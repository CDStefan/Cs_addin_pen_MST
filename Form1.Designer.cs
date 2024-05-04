namespace Cs_addin_pen_MST
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpenWorkbook1 = new System.Windows.Forms.Button();
            this.btnOpenWorkbook2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenWorkbook1
            // 
            this.btnOpenWorkbook1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenWorkbook1.Location = new System.Drawing.Point(12, 12);
            this.btnOpenWorkbook1.Name = "btnOpenWorkbook1";
            this.btnOpenWorkbook1.Size = new System.Drawing.Size(556, 70);
            this.btnOpenWorkbook1.TabIndex = 0;
            this.btnOpenWorkbook1.Text = "Registre_evidenta_asesizarilor_confirmarea_autorizarea_interceptarilor";
            this.btnOpenWorkbook1.UseVisualStyleBackColor = true;
            this.btnOpenWorkbook1.Click += new System.EventHandler(this.btnOpenWorkbook1_Click);
            // 
            // btnOpenWorkbook2
            // 
            this.btnOpenWorkbook2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenWorkbook2.Location = new System.Drawing.Point(12, 125);
            this.btnOpenWorkbook2.Name = "btnOpenWorkbook2";
            this.btnOpenWorkbook2.Size = new System.Drawing.Size(556, 70);
            this.btnOpenWorkbook2.TabIndex = 1;
            this.btnOpenWorkbook2.Text = "Registre_evidenta_autorizatiilor_perchezitie_domiciliara_UP";
            this.btnOpenWorkbook2.UseVisualStyleBackColor = true;
            this.btnOpenWorkbook2.Click += new System.EventHandler(this.btnOpenWorkbook2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 251);
            this.Controls.Add(this.btnOpenWorkbook2);
            this.Controls.Add(this.btnOpenWorkbook1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenWorkbook1;
        private System.Windows.Forms.Button btnOpenWorkbook2;
    }
}