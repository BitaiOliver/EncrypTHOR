namespace EncrypTHOR
{
    partial class EncrypTHOR
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.EncryptSaveFileBtn = new System.Windows.Forms.Button();
            this.FileEncrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.EncryptPlainTextBox = new System.Windows.Forms.TextBox();
            this.DecryptPassTextBox = new System.Windows.Forms.TextBox();
            this.DecryptPlainTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DecryptSaveFileBtn = new System.Windows.Forms.Button();
            this.FileDecrypt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.EncryptPassTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.EncryptSaveFileBtn);
            this.panel1.Controls.Add(this.FileEncrypt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DecryptButton);
            this.panel1.Controls.Add(this.EncryptPlainTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 377);
            this.panel1.TabIndex = 0;
            // 
            // EncryptSaveFileBtn
            // 
            this.EncryptSaveFileBtn.Location = new System.Drawing.Point(180, 58);
            this.EncryptSaveFileBtn.Name = "EncryptSaveFileBtn";
            this.EncryptSaveFileBtn.Size = new System.Drawing.Size(117, 23);
            this.EncryptSaveFileBtn.TabIndex = 5;
            this.EncryptSaveFileBtn.Text = "Save to File";
            this.EncryptSaveFileBtn.UseVisualStyleBackColor = true;
            this.EncryptSaveFileBtn.Click += new System.EventHandler(this.EncryptSaveFileBtn_Click);
            // 
            // FileEncrypt
            // 
            this.FileEncrypt.Location = new System.Drawing.Point(180, 29);
            this.FileEncrypt.Name = "FileEncrypt";
            this.FileEncrypt.Size = new System.Drawing.Size(117, 23);
            this.FileEncrypt.TabIndex = 4;
            this.FileEncrypt.Text = "Open File for Encrypt";
            this.FileEncrypt.UseVisualStyleBackColor = true;
            this.FileEncrypt.Click += new System.EventHandler(this.FileEncrypt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Encrypted Side";
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(17, 29);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(75, 23);
            this.DecryptButton.TabIndex = 2;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // EncryptPlainTextBox
            // 
            this.EncryptPlainTextBox.Location = new System.Drawing.Point(17, 86);
            this.EncryptPlainTextBox.Multiline = true;
            this.EncryptPlainTextBox.Name = "EncryptPlainTextBox";
            this.EncryptPlainTextBox.Size = new System.Drawing.Size(280, 283);
            this.EncryptPlainTextBox.TabIndex = 0;
            // 
            // DecryptPassTextBox
            // 
            this.DecryptPassTextBox.Location = new System.Drawing.Point(425, 23);
            this.DecryptPassTextBox.Name = "DecryptPassTextBox";
            this.DecryptPassTextBox.Size = new System.Drawing.Size(236, 20);
            this.DecryptPassTextBox.TabIndex = 1;
            // 
            // DecryptPlainTextBox
            // 
            this.DecryptPlainTextBox.Location = new System.Drawing.Point(14, 86);
            this.DecryptPlainTextBox.Multiline = true;
            this.DecryptPlainTextBox.Name = "DecryptPlainTextBox";
            this.DecryptPlainTextBox.Size = new System.Drawing.Size(295, 283);
            this.DecryptPlainTextBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.DecryptSaveFileBtn);
            this.panel2.Controls.Add(this.FileDecrypt);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.EncryptButton);
            this.panel2.Controls.Add(this.DecryptPlainTextBox);
            this.panel2.Location = new System.Drawing.Point(338, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 377);
            this.panel2.TabIndex = 1;
            // 
            // DecryptSaveFileBtn
            // 
            this.DecryptSaveFileBtn.Location = new System.Drawing.Point(191, 58);
            this.DecryptSaveFileBtn.Name = "DecryptSaveFileBtn";
            this.DecryptSaveFileBtn.Size = new System.Drawing.Size(118, 22);
            this.DecryptSaveFileBtn.TabIndex = 5;
            this.DecryptSaveFileBtn.Text = "Save to File";
            this.DecryptSaveFileBtn.UseVisualStyleBackColor = true;
            this.DecryptSaveFileBtn.Click += new System.EventHandler(this.DecryptSaveFileBtn_Click);
            // 
            // FileDecrypt
            // 
            this.FileDecrypt.Location = new System.Drawing.Point(191, 29);
            this.FileDecrypt.Name = "FileDecrypt";
            this.FileDecrypt.Size = new System.Drawing.Size(118, 23);
            this.FileDecrypt.TabIndex = 4;
            this.FileDecrypt.Text = "Open File for Decrypt";
            this.FileDecrypt.UseVisualStyleBackColor = true;
            this.FileDecrypt.Click += new System.EventHandler(this.FileDecrypt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Decrypted Side";
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(14, 29);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(75, 23);
            this.EncryptButton.TabIndex = 2;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // EncryptPassTextBox
            // 
            this.EncryptPassTextBox.Location = new System.Drawing.Point(96, 23);
            this.EncryptPassTextBox.Name = "EncryptPassTextBox";
            this.EncryptPassTextBox.Size = new System.Drawing.Size(227, 20);
            this.EncryptPassTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Encypting PW:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Decrypting PW:";
            // 
            // EncrypTHOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 449);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EncryptPassTextBox);
            this.Controls.Add(this.DecryptPassTextBox);
            this.Name = "EncrypTHOR";
            this.Text = "EncrypTHOR";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.TextBox DecryptPassTextBox;
        private System.Windows.Forms.TextBox DecryptPlainTextBox;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.TextBox EncryptPassTextBox;
        private System.Windows.Forms.TextBox EncryptPlainTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button FileEncrypt;
        private System.Windows.Forms.Button FileDecrypt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button EncryptSaveFileBtn;
        private System.Windows.Forms.Button DecryptSaveFileBtn;
    }
}

