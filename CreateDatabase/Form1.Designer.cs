namespace CreateDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.ipBazyDanychTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.hasłoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.insertToDatabaseTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(484, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Wykonaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ipBazyDanychTextBox
            // 
            this.ipBazyDanychTextBox.Location = new System.Drawing.Point(75, 38);
            this.ipBazyDanychTextBox.Name = "ipBazyDanychTextBox";
            this.ipBazyDanychTextBox.Size = new System.Drawing.Size(100, 20);
            this.ipBazyDanychTextBox.TabIndex = 1;
            this.ipBazyDanychTextBox.Text = "127.0.0.1";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(219, 38);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(100, 20);
            this.loginTextBox.TabIndex = 3;
            this.loginTextBox.Text = "root";
            // 
            // hasłoTextBox
            // 
            this.hasłoTextBox.Location = new System.Drawing.Point(369, 38);
            this.hasłoTextBox.Name = "hasłoTextBox";
            this.hasłoTextBox.PasswordChar = '*';
            this.hasłoTextBox.Size = new System.Drawing.Size(100, 20);
            this.hasłoTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Adres IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hasło";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Dane do połączenia do bazy danych MySql";
            // 
            // insertToDatabaseTextBox
            // 
            this.insertToDatabaseTextBox.Location = new System.Drawing.Point(25, 64);
            this.insertToDatabaseTextBox.Multiline = true;
            this.insertToDatabaseTextBox.Name = "insertToDatabaseTextBox";
            this.insertToDatabaseTextBox.Size = new System.Drawing.Size(534, 348);
            this.insertToDatabaseTextBox.TabIndex = 10;
            this.insertToDatabaseTextBox.Text = resources.GetString("insertToDatabaseTextBox.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 433);
            this.Controls.Add(this.insertToDatabaseTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hasłoTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.ipBazyDanychTextBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Tworzenie bazy danych";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ipBazyDanychTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox hasłoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox insertToDatabaseTextBox;
    }
}

