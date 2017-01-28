namespace EncryptDecryptAppConfigFile
{
    partial class EncryptDecrypt
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEncryption = new System.Windows.Forms.TextBox();
            this.cmdOpen = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmdDecrypt = new System.Windows.Forms.Button();
            this.cmdEncrypt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDilog";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtEncryption);
            this.panel1.Controls.Add(this.cmdOpen);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 70);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Open .NET Executable File";
            // 
            // txtEncryption
            // 
            this.txtEncryption.Location = new System.Drawing.Point(15, 38);
            this.txtEncryption.Name = "txtEncryption";
            this.txtEncryption.Size = new System.Drawing.Size(214, 20);
            this.txtEncryption.TabIndex = 6;
            // 
            // cmdOpen
            // 
            this.cmdOpen.Location = new System.Drawing.Point(235, 38);
            this.cmdOpen.Name = "cmdOpen";
            this.cmdOpen.Size = new System.Drawing.Size(22, 20);
            this.cmdOpen.TabIndex = 5;
            this.cmdOpen.Text = "&..";
            this.cmdOpen.UseVisualStyleBackColor = true;
            this.cmdOpen.Click += new System.EventHandler(this.cmdOpen_Click_1);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cmdDecrypt);
            this.panel2.Controls.Add(this.cmdEncrypt);
            this.panel2.Location = new System.Drawing.Point(12, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 49);
            this.panel2.TabIndex = 6;
            // 
            // cmdDecrypt
            // 
            this.cmdDecrypt.Location = new System.Drawing.Point(137, 13);
            this.cmdDecrypt.Name = "cmdDecrypt";
            this.cmdDecrypt.Size = new System.Drawing.Size(104, 23);
            this.cmdDecrypt.TabIndex = 3;
            this.cmdDecrypt.Text = "&Decrypt Config";
            this.cmdDecrypt.UseVisualStyleBackColor = true;
            this.cmdDecrypt.Click += new System.EventHandler(this.cmdDecrypt_Click_1);
            // 
            // cmdEncrypt
            // 
            this.cmdEncrypt.Location = new System.Drawing.Point(27, 13);
            this.cmdEncrypt.Name = "cmdEncrypt";
            this.cmdEncrypt.Size = new System.Drawing.Size(104, 23);
            this.cmdEncrypt.TabIndex = 2;
            this.cmdEncrypt.Text = "&Encrypt Config";
            this.cmdEncrypt.UseVisualStyleBackColor = true;
            this.cmdEncrypt.Click += new System.EventHandler(this.cmdEncrypt_Click_1);
            // 
            // EncryptDecrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 141);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EncryptDecrypt";
            this.Text = "Encrypt Decrypt Connection String";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEncryption;
        private System.Windows.Forms.Button cmdOpen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cmdDecrypt;
        private System.Windows.Forms.Button cmdEncrypt;
    }
}

