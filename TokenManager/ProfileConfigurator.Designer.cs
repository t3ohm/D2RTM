
namespace TokenManager
{
    partial class AccountConfiguration
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountConfiguration));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.useDefaultGame = new System.Windows.Forms.CheckBox();
            this.gameExecutableName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.browseForInstallationButton = new System.Windows.Forms.Button();
            this.installationPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grabWindowXYButton = new System.Windows.Forms.Button();
            this.muteWhenMinimized = new System.Windows.Forms.CheckBox();
            this.separateJsonSettings = new System.Windows.Forms.CheckBox();
            this.separateTaskbarItems = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.windowYposition = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.windowXposition = new System.Windows.Forms.TextBox();
            this.gameLaunchArgs = new System.Windows.Forms.TextBox();
            this.postLaunchCmd = new System.Windows.Forms.TextBox();
            this.preLaunchCmd = new System.Windows.Forms.TextBox();
            this.selectedRegion = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.modifyWindowTitles = new System.Windows.Forms.CheckBox();
            this.skipIntroVideos = new System.Windows.Forms.CheckBox();
            this.arguments = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.selectAccount = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.currentHotKey = new System.Windows.Forms.TextBox();
            this.hotKeyKey = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.enableHotkeys = new System.Windows.Forms.CheckBox();
            this.saveConfig = new System.Windows.Forms.Button();
            this.grabXYTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.useDefaultGame);
            this.groupBox1.Controls.Add(this.gameExecutableName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.browseForInstallationButton);
            this.groupBox1.Controls.Add(this.installationPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Details";
            // 
            // useDefaultGame
            // 
            this.useDefaultGame.AutoSize = true;
            this.useDefaultGame.Location = new System.Drawing.Point(3, 75);
            this.useDefaultGame.Name = "useDefaultGame";
            this.useDefaultGame.Size = new System.Drawing.Size(87, 17);
            this.useDefaultGame.TabIndex = 5;
            this.useDefaultGame.Text = "Use Defaults";
            this.useDefaultGame.UseVisualStyleBackColor = true;
            this.useDefaultGame.CheckedChanged += new System.EventHandler(this.useDefaultGame_CheckedChanged);
            // 
            // gameExecutableName
            // 
            this.gameExecutableName.Location = new System.Drawing.Point(100, 72);
            this.gameExecutableName.Name = "gameExecutableName";
            this.gameExecutableName.Size = new System.Drawing.Size(122, 20);
            this.gameExecutableName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Custom Exe name (ie: Default is D2R)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // browseForInstallationButton
            // 
            this.browseForInstallationButton.Location = new System.Drawing.Point(3, 17);
            this.browseForInstallationButton.Name = "browseForInstallationButton";
            this.browseForInstallationButton.Size = new System.Drawing.Size(59, 36);
            this.browseForInstallationButton.TabIndex = 2;
            this.browseForInstallationButton.Text = "browse";
            this.browseForInstallationButton.UseVisualStyleBackColor = true;
            // 
            // installationPath
            // 
            this.installationPath.Location = new System.Drawing.Point(67, 33);
            this.installationPath.Name = "installationPath";
            this.installationPath.Size = new System.Drawing.Size(155, 20);
            this.installationPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 16);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Installation Folder";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.muteWhenMinimized);
            this.groupBox2.Controls.Add(this.separateJsonSettings);
            this.groupBox2.Controls.Add(this.separateTaskbarItems);
            this.groupBox2.Controls.Add(this.gameLaunchArgs);
            this.groupBox2.Controls.Add(this.postLaunchCmd);
            this.groupBox2.Controls.Add(this.preLaunchCmd);
            this.groupBox2.Controls.Add(this.selectedRegion);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.modifyWindowTitles);
            this.groupBox2.Controls.Add(this.skipIntroVideos);
            this.groupBox2.Controls.Add(this.arguments);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(6, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(231, 171);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Launch Settings";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // grabWindowXYButton
            // 
            this.grabWindowXYButton.Location = new System.Drawing.Point(67, 19);
            this.grabWindowXYButton.Name = "grabWindowXYButton";
            this.grabWindowXYButton.Size = new System.Drawing.Size(41, 40);
            this.grabWindowXYButton.TabIndex = 18;
            this.grabWindowXYButton.Text = " Get";
            this.grabWindowXYButton.UseVisualStyleBackColor = true;
            this.grabWindowXYButton.Click += new System.EventHandler(this.grabWindowXYButton_Click_1);
            // 
            // muteWhenMinimized
            // 
            this.muteWhenMinimized.AutoSize = true;
            this.muteWhenMinimized.Location = new System.Drawing.Point(109, 129);
            this.muteWhenMinimized.Name = "muteWhenMinimized";
            this.muteWhenMinimized.Size = new System.Drawing.Size(113, 17);
            this.muteWhenMinimized.TabIndex = 17;
            this.muteWhenMinimized.Text = "Mute on minimized";
            this.muteWhenMinimized.UseVisualStyleBackColor = true;
            this.muteWhenMinimized.CheckedChanged += new System.EventHandler(this.muteWhenMinimized_CheckedChanged);
            // 
            // separateJsonSettings
            // 
            this.separateJsonSettings.AutoSize = true;
            this.separateJsonSettings.Location = new System.Drawing.Point(3, 148);
            this.separateJsonSettings.Name = "separateJsonSettings";
            this.separateJsonSettings.Size = new System.Drawing.Size(105, 17);
            this.separateJsonSettings.TabIndex = 16;
            this.separateJsonSettings.Text = "Self settings.json";
            this.separateJsonSettings.UseVisualStyleBackColor = true;
            this.separateJsonSettings.CheckedChanged += new System.EventHandler(this.separateJsonSettings_CheckedChanged);
            // 
            // separateTaskbarItems
            // 
            this.separateTaskbarItems.AutoSize = true;
            this.separateTaskbarItems.Location = new System.Drawing.Point(113, 110);
            this.separateTaskbarItems.Name = "separateTaskbarItems";
            this.separateTaskbarItems.Size = new System.Drawing.Size(110, 17);
            this.separateTaskbarItems.TabIndex = 15;
            this.separateTaskbarItems.Text = "Self Taskbar Icon";
            this.separateTaskbarItems.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(0, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Y";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // windowYposition
            // 
            this.windowYposition.Location = new System.Drawing.Point(15, 39);
            this.windowYposition.Name = "windowYposition";
            this.windowYposition.Size = new System.Drawing.Size(46, 20);
            this.windowYposition.TabIndex = 13;
            this.windowYposition.TextChanged += new System.EventHandler(this.windowYposition_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(0, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "X";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // windowXposition
            // 
            this.windowXposition.Location = new System.Drawing.Point(15, 16);
            this.windowXposition.Name = "windowXposition";
            this.windowXposition.Size = new System.Drawing.Size(46, 20);
            this.windowXposition.TabIndex = 11;
            this.windowXposition.TextChanged += new System.EventHandler(this.windowXposition_TextChanged);
            // 
            // gameLaunchArgs
            // 
            this.gameLaunchArgs.Location = new System.Drawing.Point(89, 80);
            this.gameLaunchArgs.Name = "gameLaunchArgs";
            this.gameLaunchArgs.Size = new System.Drawing.Size(133, 20);
            this.gameLaunchArgs.TabIndex = 10;
            this.gameLaunchArgs.TextChanged += new System.EventHandler(this.gameLaunchArgs_TextChanged);
            // 
            // postLaunchCmd
            // 
            this.postLaunchCmd.Location = new System.Drawing.Point(67, 56);
            this.postLaunchCmd.Name = "postLaunchCmd";
            this.postLaunchCmd.Size = new System.Drawing.Size(155, 20);
            this.postLaunchCmd.TabIndex = 9;
            this.postLaunchCmd.TextChanged += new System.EventHandler(this.postLaunchCmd_TextChanged);
            // 
            // preLaunchCmd
            // 
            this.preLaunchCmd.Location = new System.Drawing.Point(67, 30);
            this.preLaunchCmd.Name = "preLaunchCmd";
            this.preLaunchCmd.Size = new System.Drawing.Size(155, 20);
            this.preLaunchCmd.TabIndex = 8;
            this.preLaunchCmd.TextChanged += new System.EventHandler(this.preLaunchCmd_TextChanged);
            // 
            // selectedRegion
            // 
            this.selectedRegion.FormattingEnabled = true;
            this.selectedRegion.Location = new System.Drawing.Point(2, 5);
            this.selectedRegion.Name = "selectedRegion";
            this.selectedRegion.Size = new System.Drawing.Size(58, 21);
            this.selectedRegion.TabIndex = 7;
            this.selectedRegion.SelectedIndexChanged += new System.EventHandler(this.selectedRegion_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Region:";
            // 
            // modifyWindowTitles
            // 
            this.modifyWindowTitles.AutoSize = true;
            this.modifyWindowTitles.Location = new System.Drawing.Point(33, 129);
            this.modifyWindowTitles.Name = "modifyWindowTitles";
            this.modifyWindowTitles.Size = new System.Drawing.Size(75, 17);
            this.modifyWindowTitles.TabIndex = 5;
            this.modifyWindowTitles.Text = "ProfileTitle";
            this.modifyWindowTitles.UseVisualStyleBackColor = true;
            // 
            // skipIntroVideos
            // 
            this.skipIntroVideos.AutoSize = true;
            this.skipIntroVideos.Location = new System.Drawing.Point(11, 110);
            this.skipIntroVideos.Name = "skipIntroVideos";
            this.skipIntroVideos.Size = new System.Drawing.Size(97, 17);
            this.skipIntroVideos.TabIndex = 4;
            this.skipIntroVideos.Text = "Click Skip Intro";
            this.skipIntroVideos.UseVisualStyleBackColor = true;
            this.skipIntroVideos.CheckedChanged += new System.EventHandler(this.skipIntroVideos_CheckedChanged);
            // 
            // arguments
            // 
            this.arguments.AutoSize = true;
            this.arguments.Location = new System.Drawing.Point(8, 83);
            this.arguments.Name = "arguments";
            this.arguments.Size = new System.Drawing.Size(80, 13);
            this.arguments.TabIndex = 2;
            this.arguments.Text = "EXE arguments";
            this.arguments.Click += new System.EventHandler(this.arguments_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Post cmd";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pre cmd";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Profile";
            // 
            // selectAccount
            // 
            this.selectAccount.FormattingEnabled = true;
            this.selectAccount.Location = new System.Drawing.Point(45, 4);
            this.selectAccount.Name = "selectAccount";
            this.selectAccount.Size = new System.Drawing.Size(144, 21);
            this.selectAccount.TabIndex = 3;
            this.selectAccount.SelectedIndexChanged += new System.EventHandler(this.selectAccount_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.currentHotKey);
            this.groupBox3.Controls.Add(this.hotKeyKey);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.enableHotkeys);
            this.groupBox3.Location = new System.Drawing.Point(123, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(114, 70);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hot Key";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // currentHotKey
            // 
            this.currentHotKey.Enabled = false;
            this.currentHotKey.Location = new System.Drawing.Point(58, 17);
            this.currentHotKey.Name = "currentHotKey";
            this.currentHotKey.Size = new System.Drawing.Size(47, 20);
            this.currentHotKey.TabIndex = 5;
            // 
            // hotKeyKey
            // 
            this.hotKeyKey.Location = new System.Drawing.Point(57, 43);
            this.hotKeyKey.MaxLength = 40;
            this.hotKeyKey.Name = "hotKeyKey";
            this.hotKeyKey.Size = new System.Drawing.Size(48, 20);
            this.hotKeyKey.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "New";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Current";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // enableHotkeys
            // 
            this.enableHotkeys.AutoSize = true;
            this.enableHotkeys.Location = new System.Drawing.Point(0, 0);
            this.enableHotkeys.Name = "enableHotkeys";
            this.enableHotkeys.Size = new System.Drawing.Size(59, 17);
            this.enableHotkeys.TabIndex = 0;
            this.enableHotkeys.Text = "Enable";
            this.enableHotkeys.UseVisualStyleBackColor = true;
            // 
            // saveConfig
            // 
            this.saveConfig.Location = new System.Drawing.Point(197, 4);
            this.saveConfig.Name = "saveConfig";
            this.saveConfig.Size = new System.Drawing.Size(40, 23);
            this.saveConfig.TabIndex = 5;
            this.saveConfig.Text = "Save";
            this.saveConfig.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.windowXposition);
            this.groupBox4.Controls.Add(this.grabWindowXYButton);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.windowYposition);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(6, 33);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(114, 70);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Window Position";
            // 
            // AccountConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 374);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.saveConfig);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.selectAccount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AccountConfiguration";
            this.Text = "Profile Configuration";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox gameExecutableName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button browseForInstallationButton;
        private System.Windows.Forms.TextBox installationPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox selectedRegion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox modifyWindowTitles;
        private System.Windows.Forms.CheckBox skipIntroVideos;
        private System.Windows.Forms.Label arguments;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox gameLaunchArgs;
        private System.Windows.Forms.TextBox postLaunchCmd;
        private System.Windows.Forms.TextBox preLaunchCmd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox selectAccount;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox enableHotkeys;
        private System.Windows.Forms.TextBox hotKeyKey;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button saveConfig;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox windowXposition;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox windowYposition;
        private System.Windows.Forms.CheckBox useDefaultGame;
        private System.Windows.Forms.TextBox currentHotKey;
        private System.Windows.Forms.CheckBox separateTaskbarItems;
        private System.Windows.Forms.CheckBox separateJsonSettings;
        private System.Windows.Forms.CheckBox muteWhenMinimized;
        private System.Windows.Forms.Button grabWindowXYButton;
        private System.Windows.Forms.ToolTip grabXYTooltip;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}