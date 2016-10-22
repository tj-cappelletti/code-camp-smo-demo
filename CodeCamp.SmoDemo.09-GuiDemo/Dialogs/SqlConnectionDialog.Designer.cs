namespace CodeCamp.SmoDemo._09_GuiDemo.Dialogs
{
    partial class SqlConnectionDialog
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
            this.connectionDetailsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.serverNameLabel = new System.Windows.Forms.Label();
            this.authenticationTypeLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.serverNameTextBox = new System.Windows.Forms.TextBox();
            this.authenticationTypeComboBox = new System.Windows.Forms.ComboBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.buttonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.connectionDetailsTableLayoutPanel.SuspendLayout();
            this.buttonsTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectionDetailsTableLayoutPanel
            // 
            this.connectionDetailsTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.connectionDetailsTableLayoutPanel.ColumnCount = 4;
            this.connectionDetailsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.connectionDetailsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.connectionDetailsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.connectionDetailsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.connectionDetailsTableLayoutPanel.Controls.Add(this.serverNameLabel, 0, 0);
            this.connectionDetailsTableLayoutPanel.Controls.Add(this.authenticationTypeLabel, 0, 1);
            this.connectionDetailsTableLayoutPanel.Controls.Add(this.userNameLabel, 1, 2);
            this.connectionDetailsTableLayoutPanel.Controls.Add(this.passwordLabel, 1, 3);
            this.connectionDetailsTableLayoutPanel.Controls.Add(this.serverNameTextBox, 2, 0);
            this.connectionDetailsTableLayoutPanel.Controls.Add(this.authenticationTypeComboBox, 2, 1);
            this.connectionDetailsTableLayoutPanel.Controls.Add(this.userNameTextBox, 3, 2);
            this.connectionDetailsTableLayoutPanel.Controls.Add(this.passwordTextBox, 3, 3);
            this.connectionDetailsTableLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.connectionDetailsTableLayoutPanel.Name = "connectionDetailsTableLayoutPanel";
            this.connectionDetailsTableLayoutPanel.RowCount = 5;
            this.connectionDetailsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.connectionDetailsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.connectionDetailsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.connectionDetailsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.connectionDetailsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.connectionDetailsTableLayoutPanel.Size = new System.Drawing.Size(386, 152);
            this.connectionDetailsTableLayoutPanel.TabIndex = 0;
            // 
            // serverNameLabel
            // 
            this.serverNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.serverNameLabel.AutoSize = true;
            this.connectionDetailsTableLayoutPanel.SetColumnSpan(this.serverNameLabel, 2);
            this.serverNameLabel.Location = new System.Drawing.Point(3, 6);
            this.serverNameLabel.Name = "serverNameLabel";
            this.serverNameLabel.Size = new System.Drawing.Size(72, 13);
            this.serverNameLabel.TabIndex = 0;
            this.serverNameLabel.Text = "Server Name:";
            // 
            // authenticationTypeLabel
            // 
            this.authenticationTypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.authenticationTypeLabel.AutoSize = true;
            this.connectionDetailsTableLayoutPanel.SetColumnSpan(this.authenticationTypeLabel, 2);
            this.authenticationTypeLabel.Location = new System.Drawing.Point(3, 33);
            this.authenticationTypeLabel.Name = "authenticationTypeLabel";
            this.authenticationTypeLabel.Size = new System.Drawing.Size(78, 13);
            this.authenticationTypeLabel.TabIndex = 1;
            this.authenticationTypeLabel.Text = "Authentication:";
            // 
            // userNameLabel
            // 
            this.userNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(33, 59);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(63, 13);
            this.userNameLabel.TabIndex = 2;
            this.userNameLabel.Text = "User Name:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(33, 85);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password:";
            // 
            // serverNameTextBox
            // 
            this.serverNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.connectionDetailsTableLayoutPanel.SetColumnSpan(this.serverNameTextBox, 2);
            this.serverNameTextBox.Location = new System.Drawing.Point(113, 3);
            this.serverNameTextBox.Name = "serverNameTextBox";
            this.serverNameTextBox.Size = new System.Drawing.Size(270, 20);
            this.serverNameTextBox.TabIndex = 0;
            // 
            // authenticationTypeComboBox
            // 
            this.authenticationTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.connectionDetailsTableLayoutPanel.SetColumnSpan(this.authenticationTypeComboBox, 2);
            this.authenticationTypeComboBox.FormattingEnabled = true;
            this.authenticationTypeComboBox.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication"});
            this.authenticationTypeComboBox.Location = new System.Drawing.Point(113, 29);
            this.authenticationTypeComboBox.Name = "authenticationTypeComboBox";
            this.authenticationTypeComboBox.Size = new System.Drawing.Size(270, 21);
            this.authenticationTypeComboBox.TabIndex = 1;
            this.authenticationTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.authenticationTypeComboBox_SelectedIndexChanged);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameTextBox.Location = new System.Drawing.Point(143, 56);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(240, 20);
            this.userNameTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox.Location = new System.Drawing.Point(143, 82);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '●';
            this.passwordTextBox.Size = new System.Drawing.Size(240, 20);
            this.passwordTextBox.TabIndex = 3;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(308, 5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.connectButton.Location = new System.Drawing.Point(3, 5);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 4;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // buttonsTableLayoutPanel
            // 
            this.buttonsTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsTableLayoutPanel.ColumnCount = 2;
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsTableLayoutPanel.Controls.Add(this.connectButton, 0, 0);
            this.buttonsTableLayoutPanel.Controls.Add(this.cancelButton, 1, 0);
            this.buttonsTableLayoutPanel.Location = new System.Drawing.Point(12, 170);
            this.buttonsTableLayoutPanel.Name = "buttonsTableLayoutPanel";
            this.buttonsTableLayoutPanel.RowCount = 1;
            this.buttonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.buttonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.buttonsTableLayoutPanel.Size = new System.Drawing.Size(386, 31);
            this.buttonsTableLayoutPanel.TabIndex = 3;
            // 
            // SqlConnectionDialog
            // 
            this.AcceptButton = this.connectButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(410, 213);
            this.Controls.Add(this.buttonsTableLayoutPanel);
            this.Controls.Add(this.connectionDetailsTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SqlConnectionDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect to Server";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SqlConnectionForm_Load);
            this.connectionDetailsTableLayoutPanel.ResumeLayout(false);
            this.connectionDetailsTableLayoutPanel.PerformLayout();
            this.buttonsTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel connectionDetailsTableLayoutPanel;
        private System.Windows.Forms.Label serverNameLabel;
        private System.Windows.Forms.Label authenticationTypeLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox serverNameTextBox;
        private System.Windows.Forms.ComboBox authenticationTypeComboBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TableLayoutPanel buttonsTableLayoutPanel;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
    }
}