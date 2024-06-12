namespace lab15
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tbHost = new TextBox();
            tbUser = new TextBox();
            label2 = new Label();
            label3 = new Label();
            tbPass = new TextBox();
            btnConnect = new Button();
            btnUpload = new Button();
            btnCreateDirectory = new Button();
            openFileDialog1 = new OpenFileDialog();
            lstFiles = new ListBox();
            lblStatus = new Label();
            tbNewDir = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 28);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "Host:";
            // 
            // tbHost
            // 
            tbHost.Location = new Point(74, 25);
            tbHost.Name = "tbHost";
            tbHost.Size = new Size(362, 23);
            tbHost.TabIndex = 1;
            // 
            // tbUser
            // 
            tbUser.Location = new Point(74, 54);
            tbUser.Name = "tbUser";
            tbUser.Size = new Size(362, 23);
            tbUser.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 57);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 3;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 86);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 5;
            label3.Text = "Password:";
            // 
            // tbPass
            // 
            tbPass.Location = new Point(74, 83);
            tbPass.Name = "tbPass";
            tbPass.Size = new Size(362, 23);
            tbPass.TabIndex = 4;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(521, 6);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(143, 117);
            btnConnect.TabIndex = 6;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(33, 331);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(140, 23);
            btnUpload.TabIndex = 7;
            btnUpload.Text = "Upload file to server";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // btnCreateDirectory
            // 
            btnCreateDirectory.Location = new Point(33, 302);
            btnCreateDirectory.Name = "btnCreateDirectory";
            btnCreateDirectory.Size = new Size(140, 23);
            btnCreateDirectory.TabIndex = 8;
            btnCreateDirectory.Text = "Create Directory";
            btnCreateDirectory.UseVisualStyleBackColor = true;
            btnCreateDirectory.Click += btnCreateDirectory_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "All Files|.";
            // 
            // lstFiles
            // 
            lstFiles.FormattingEnabled = true;
            lstFiles.ItemHeight = 15;
            lstFiles.Location = new Point(450, 149);
            lstFiles.Name = "lstFiles";
            lstFiles.Size = new Size(319, 274);
            lstFiles.TabIndex = 9;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(348, 408);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(38, 15);
            lblStatus.TabIndex = 10;
            lblStatus.Text = "label4";
            // 
            // tbNewDir
            // 
            tbNewDir.Location = new Point(179, 302);
            tbNewDir.Name = "tbNewDir";
            tbNewDir.Size = new Size(241, 23);
            tbNewDir.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbNewDir);
            Controls.Add(lblStatus);
            Controls.Add(lstFiles);
            Controls.Add(btnCreateDirectory);
            Controls.Add(btnUpload);
            Controls.Add(btnConnect);
            Controls.Add(label3);
            Controls.Add(tbPass);
            Controls.Add(label2);
            Controls.Add(tbUser);
            Controls.Add(tbHost);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbHost;
        private TextBox tbUser;
        private Label label2;
        private Label label3;
        private TextBox tbPass;
        private Button btnConnect;
        private Button btnUpload;
        private Button btnCreateDirectory;
        private OpenFileDialog openFileDialog1;
        private ListBox lstFiles;
        private Label lblStatus;
        private TextBox tbNewDir;
    }
}
