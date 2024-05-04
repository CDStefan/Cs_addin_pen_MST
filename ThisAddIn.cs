using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using System.Windows.Forms;
using System.IO;

namespace Cs_addin_pen_MST
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            //this.Application.WorkbookOpen += new Excel.AppEvents_WorkbookOpenEventHandler(WorkBookOpen);
            this.Application.WorkbookBeforeSave += new Excel.AppEvents_WorkbookBeforeSaveEventHandler(Application_WorkbookBeforeSave);
            this.Application.WorkbookAfterSave += new Excel.AppEvents_WorkbookAfterSaveEventHandler(Application_WorkbookAfterSave);


            Form1 openForm = new Form1();
            openForm.TopMost = true;
            openForm.Show();


        }

        // Prevent the user from savind to a different file without password
        void Application_WorkbookBeforeSave(Excel.Workbook Wb, bool SaveAsUI, ref bool Cancel)
        {
            Cancel = true; // Prevent the normal save process
            Wb.Application.EnableEvents = false;
            Wb.SaveAs(Wb.FullName, Password: "Timis-1864"); // Save with the original password
            Wb.Application.EnableEvents = true;
        }

        // Try to make a backup after saving the changes
        void Application_WorkbookAfterSave(Excel.Workbook Wb, bool Success)
        {
            string backupPath = "";
            try
            {
                Excel.Worksheet settingsSheet = Wb.Sheets["Settings"];
                Excel.Range backupPathCell = settingsSheet.Range["B1"];
                backupPath = backupPathCell.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not fined value of path: {ex.Message}");
                
            }

            if (!Directory.Exists(backupPath))
            {
                MessageBox.Show("Folderul de backup nu a fost gasit. Contactati compartimentul informatica");
            }
            else
            {
                string backupFileName = $"{DateTime.Now.ToString("dd-MM")}-{Wb.Name}-backup";
                string backupFilePath = Path.Combine(backupPath, backupFileName);
                Wb.SaveCopyAs(backupFilePath);
            }
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            this.Application.WorkbookBeforeSave -= new Excel.AppEvents_WorkbookBeforeSaveEventHandler(Application_WorkbookBeforeSave);
            this.Application.WorkbookAfterSave -= new Excel.AppEvents_WorkbookAfterSaveEventHandler(Application_WorkbookAfterSave);
            

        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
