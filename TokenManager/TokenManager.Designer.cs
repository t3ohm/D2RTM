
namespace TokenManager
{
    partial class TokenManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TokenManager));
            this.accountList = new System.Windows.Forms.CheckedListBox();
            this.launchButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.addAccountButton = new System.Windows.Forms.Button();
            this.forceExit = new System.Windows.Forms.CheckBox();
            this.forceExitToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.configureAccountsButton = new System.Windows.Forms.Button();
            this.saveAccounInfo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // accountList
            // 
            this.accountList.FormattingEnabled = true;
            this.accountList.Location = new System.Drawing.Point(0, 1);
            this.accountList.Name = "accountList";
            this.accountList.Size = new System.Drawing.Size(241, 139);
            this.accountList.TabIndex = 1;
            // 
            // launchButton
            // 
            this.launchButton.Location = new System.Drawing.Point(247, 48);
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(92, 22);
            this.launchButton.TabIndex = 2;
            this.launchButton.Text = "Launch";
            this.launchButton.UseVisualStyleBackColor = true;
            this.launchButton.Click += new System.EventHandler(this.launchButton_Click_1);
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(247, 76);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(92, 20);
            this.refreshButton.TabIndex = 19;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click_1);
            // 
            // removeButton
            // 
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.Location = new System.Drawing.Point(303, 23);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(36, 19);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "Del";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click_1);
            // 
            // addAccountButton
            // 
            this.addAccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAccountButton.Location = new System.Drawing.Point(303, 3);
            this.addAccountButton.Name = "addAccountButton";
            this.addAccountButton.Size = new System.Drawing.Size(36, 18);
            this.addAccountButton.TabIndex = 10;
            this.addAccountButton.Text = "Add";
            this.addAccountButton.UseVisualStyleBackColor = true;
            this.addAccountButton.Click += new System.EventHandler(this.addAccountButton_Click_1);
            // 
            // forceExit
            // 
            this.forceExit.AutoSize = true;
            this.forceExit.Location = new System.Drawing.Point(247, 102);
            this.forceExit.Name = "forceExit";
            this.forceExit.Size = new System.Drawing.Size(73, 17);
            this.forceExit.TabIndex = 16;
            this.forceExit.Text = "Force Exit";
            this.forceExit.UseVisualStyleBackColor = true;
            // 
            // configureAccountsButton
            // 
            this.configureAccountsButton.Location = new System.Drawing.Point(247, 3);
            this.configureAccountsButton.Name = "configureAccountsButton";
            this.configureAccountsButton.Size = new System.Drawing.Size(50, 39);
            this.configureAccountsButton.TabIndex = 19;
            this.configureAccountsButton.Text = "Config";
            this.configureAccountsButton.UseVisualStyleBackColor = true;
            this.configureAccountsButton.Click += new System.EventHandler(this.configureAccountsButton_Click_1);
            // 
            // saveAccounInfo
            // 
            this.saveAccounInfo.AutoSize = true;
            this.saveAccounInfo.Location = new System.Drawing.Point(247, 123);
            this.saveAccounInfo.Name = "saveAccounInfo";
            this.saveAccounInfo.Size = new System.Drawing.Size(80, 17);
            this.saveAccounInfo.TabIndex = 13;
            this.saveAccounInfo.Text = "Save Login";
            this.saveAccounInfo.UseVisualStyleBackColor = true;
            this.saveAccounInfo.CheckedChanged += new System.EventHandler(this.saveAccounInfo_CheckedChanged);
            // 
            // TokenManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 152);
            this.Controls.Add(this.configureAccountsButton);
            this.Controls.Add(this.saveAccounInfo);
            this.Controls.Add(this.forceExit);
            this.Controls.Add(this.addAccountButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.launchButton);
            this.Controls.Add(this.accountList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TokenManager";
            this.Text = "TokenManager";
            this.Load += new System.EventHandler(this.TokenManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox accountList;
        private System.Windows.Forms.Button launchButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addAccountButton;
        private System.Windows.Forms.CheckBox forceExit;
        private System.Windows.Forms.ToolTip forceExitToolTip;
        private System.Windows.Forms.Button configureAccountsButton;
        private System.Windows.Forms.CheckBox saveAccounInfo;
    }
}

