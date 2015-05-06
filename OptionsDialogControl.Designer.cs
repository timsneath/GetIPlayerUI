namespace GetIPlayerUI
{
    partial class OptionsDialogControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.proxyPanel = new System.Windows.Forms.Panel();
            this.portValidationLabel = new System.Windows.Forms.Label();
            this.proxySettingsLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.serverNameTextBox = new System.Windows.Forms.TextBox();
            this.serverNameLabel = new System.Windows.Forms.Label();
            this.applyButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.executablePathPanel = new System.Windows.Forms.Panel();
            this.pathSettingsPanel = new System.Windows.Forms.Label();
            this.pathLocationTextBox = new System.Windows.Forms.TextBox();
            this.pathLabel = new System.Windows.Forms.Label();
            this.pathLocationButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.proxyPanel.SuspendLayout();
            this.executablePathPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // proxyPanel
            // 
            this.proxyPanel.BackColor = System.Drawing.Color.Transparent;
            this.proxyPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.proxyPanel.Controls.Add(this.portValidationLabel);
            this.proxyPanel.Controls.Add(this.proxySettingsLabel);
            this.proxyPanel.Controls.Add(this.passwordTextBox);
            this.proxyPanel.Controls.Add(this.passwordLabel);
            this.proxyPanel.Controls.Add(this.usernameTextBox);
            this.proxyPanel.Controls.Add(this.usernameLabel);
            this.proxyPanel.Controls.Add(this.portTextBox);
            this.proxyPanel.Controls.Add(this.portLabel);
            this.proxyPanel.Controls.Add(this.serverNameTextBox);
            this.proxyPanel.Controls.Add(this.serverNameLabel);
            this.proxyPanel.Location = new System.Drawing.Point(24, 19);
            this.proxyPanel.Name = "proxyPanel";
            this.proxyPanel.Size = new System.Drawing.Size(644, 291);
            this.proxyPanel.TabIndex = 0;
            // 
            // portValidationLabel
            // 
            this.portValidationLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portValidationLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.portValidationLabel.Location = new System.Drawing.Point(481, 118);
            this.portValidationLabel.Name = "portValidationLabel";
            this.portValidationLabel.Size = new System.Drawing.Size(145, 41);
            this.portValidationLabel.TabIndex = 9;
            this.portValidationLabel.Text = "Should be a number from 1 to 65535.";
            this.portValidationLabel.Visible = false;
            // 
            // proxySettingsLabel
            // 
            this.proxySettingsLabel.AutoSize = true;
            this.proxySettingsLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proxySettingsLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.proxySettingsLabel.Location = new System.Drawing.Point(21, 16);
            this.proxySettingsLabel.Name = "proxySettingsLabel";
            this.proxySettingsLabel.Size = new System.Drawing.Size(234, 32);
            this.proxySettingsLabel.TabIndex = 8;
            this.proxySettingsLabel.Text = "Proxy server settings";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GetIPlayerUI.Properties.Settings.Default, "ProxyPassword", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.passwordTextBox.Location = new System.Drawing.Point(157, 230);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(318, 30);
            this.passwordTextBox.TabIndex = 7;
            this.passwordTextBox.Text = global::GetIPlayerUI.Properties.Settings.Default.ProxyPassword;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(44, 233);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(84, 23);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Pa&ssword:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GetIPlayerUI.Properties.Settings.Default, "ProxyUsername", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.usernameTextBox.Location = new System.Drawing.Point(157, 177);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(318, 30);
            this.usernameTextBox.TabIndex = 5;
            this.usernameTextBox.Text = global::GetIPlayerUI.Properties.Settings.Default.ProxyUsername;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(44, 180);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(91, 23);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "&Username:";
            // 
            // portTextBox
            // 
            this.portTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GetIPlayerUI.Properties.Settings.Default, "ProxyPort", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.portTextBox.Location = new System.Drawing.Point(157, 124);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(318, 30);
            this.portTextBox.TabIndex = 3;
            this.portTextBox.Text = global::GetIPlayerUI.Properties.Settings.Default.ProxyPort;
            this.portTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.portTextBox_Validating);
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(44, 127);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(45, 23);
            this.portLabel.TabIndex = 2;
            this.portLabel.Text = "&Port:";
            // 
            // serverNameTextBox
            // 
            this.serverNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GetIPlayerUI.Properties.Settings.Default, "ProxyServerName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.serverNameTextBox.Location = new System.Drawing.Point(157, 71);
            this.serverNameTextBox.Name = "serverNameTextBox";
            this.serverNameTextBox.Size = new System.Drawing.Size(318, 30);
            this.serverNameTextBox.TabIndex = 1;
            this.serverNameTextBox.Text = global::GetIPlayerUI.Properties.Settings.Default.ProxyServerName;
            // 
            // serverNameLabel
            // 
            this.serverNameLabel.AutoSize = true;
            this.serverNameLabel.Location = new System.Drawing.Point(44, 74);
            this.serverNameLabel.Name = "serverNameLabel";
            this.serverNameLabel.Size = new System.Drawing.Size(109, 23);
            this.serverNameLabel.TabIndex = 0;
            this.serverNameLabel.Text = "&Server name:";
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(422, 490);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(119, 45);
            this.applyButton.TabIndex = 9;
            this.applyButton.Text = "&Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(549, 490);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(119, 45);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // executablePathPanel
            // 
            this.executablePathPanel.BackColor = System.Drawing.Color.Transparent;
            this.executablePathPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.executablePathPanel.Controls.Add(this.pathLocationButton);
            this.executablePathPanel.Controls.Add(this.pathSettingsPanel);
            this.executablePathPanel.Controls.Add(this.pathLocationTextBox);
            this.executablePathPanel.Controls.Add(this.pathLabel);
            this.executablePathPanel.Location = new System.Drawing.Point(24, 331);
            this.executablePathPanel.Name = "executablePathPanel";
            this.executablePathPanel.Size = new System.Drawing.Size(644, 138);
            this.executablePathPanel.TabIndex = 11;
            // 
            // pathSettingsPanel
            // 
            this.pathSettingsPanel.AutoSize = true;
            this.pathSettingsPanel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathSettingsPanel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.pathSettingsPanel.Location = new System.Drawing.Point(21, 16);
            this.pathSettingsPanel.Name = "pathSettingsPanel";
            this.pathSettingsPanel.Size = new System.Drawing.Size(213, 32);
            this.pathSettingsPanel.TabIndex = 8;
            this.pathSettingsPanel.Text = "Path to get_iplayer";
            // 
            // pathLocationTextBox
            // 
            this.pathLocationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GetIPlayerUI.Properties.Settings.Default, "GetIPlayerPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pathLocationTextBox.Location = new System.Drawing.Point(157, 71);
            this.pathLocationTextBox.Name = "pathLocationTextBox";
            this.pathLocationTextBox.Size = new System.Drawing.Size(318, 30);
            this.pathLocationTextBox.TabIndex = 1;
            this.pathLocationTextBox.Text = global::GetIPlayerUI.Properties.Settings.Default.GetIPlayerPath;
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(44, 74);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(48, 23);
            this.pathLabel.TabIndex = 0;
            this.pathLabel.Text = "Pa&th:";
            // 
            // pathLocationButton
            // 
            this.pathLocationButton.Location = new System.Drawing.Point(475, 71);
            this.pathLocationButton.Name = "pathLocationButton";
            this.pathLocationButton.Size = new System.Drawing.Size(47, 30);
            this.pathLocationButton.TabIndex = 9;
            this.pathLocationButton.Text = "&...";
            this.pathLocationButton.UseVisualStyleBackColor = true;
            this.pathLocationButton.Click += new System.EventHandler(this.pathLocationButton_Click);
            // 
            // OptionsDialogControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.executablePathPanel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.proxyPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "OptionsDialogControl";
            this.Size = new System.Drawing.Size(689, 555);
            this.proxyPanel.ResumeLayout(false);
            this.proxyPanel.PerformLayout();
            this.executablePathPanel.ResumeLayout(false);
            this.executablePathPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel proxyPanel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.TextBox serverNameTextBox;
        private System.Windows.Forms.Label serverNameLabel;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Label proxySettingsLabel;
        private System.Windows.Forms.Label portValidationLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Panel executablePathPanel;
        private System.Windows.Forms.Label pathSettingsPanel;
        private System.Windows.Forms.TextBox pathLocationTextBox;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Button pathLocationButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}
