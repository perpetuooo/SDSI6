namespace XML_Validator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnSelectXsd;
        private System.Windows.Forms.Button btnSelectXml;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

        private void InitializeComponent()
        {
            this.btnSelectXsd = new System.Windows.Forms.Button();
            this.btnSelectXml = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();

            this.btnSelectXsd.Location = new System.Drawing.Point(12, 12);
            this.btnSelectXsd.Name = "btnSelectXsd";
            this.btnSelectXsd.Size = new System.Drawing.Size(75, 23);
            this.btnSelectXsd.TabIndex = 0;
            this.btnSelectXsd.Text = "Carregar XSD";
            this.btnSelectXsd.UseVisualStyleBackColor = true;
            this.btnSelectXsd.Click += new System.EventHandler(this.btnSelectXsd_Click);

            this.btnSelectXml.Location = new System.Drawing.Point(12, 41);
            this.btnSelectXml.Name = "btnSelectXml";
            this.btnSelectXml.Size = new System.Drawing.Size(75, 23);
            this.btnSelectXml.TabIndex = 1;
            this.btnSelectXml.Text = "Carregar XML";
            this.btnSelectXml.UseVisualStyleBackColor = true;
            this.btnSelectXml.Click += new System.EventHandler(this.btnSelectXml_Click);

            this.txtResult.Location = new System.Drawing.Point(12, 70);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(360, 208);
            this.txtResult.TabIndex = 2;

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnSelectXml);
            this.Controls.Add(this.btnSelectXsd);
            this.Name = "Form1";
            this.Text = "Validador de XML";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
