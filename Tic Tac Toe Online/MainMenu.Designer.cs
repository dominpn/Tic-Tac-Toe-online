namespace Tic_Tac_Toe_Online
{
    partial class MainMenu
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
            this.ServerIpText = new System.Windows.Forms.TextBox();
            this.ServerIpLabel = new System.Windows.Forms.Label();
            this.CreateNewGameButton = new System.Windows.Forms.Button();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ServerIpText
            // 
            this.ServerIpText.Location = new System.Drawing.Point(94, 146);
            this.ServerIpText.Name = "ServerIpText";
            this.ServerIpText.Size = new System.Drawing.Size(152, 20);
            this.ServerIpText.TabIndex = 5;
            this.ServerIpText.Text = "192.168.0.101";
            // 
            // ServerIpLabel
            // 
            this.ServerIpLabel.AutoSize = true;
            this.ServerIpLabel.Location = new System.Drawing.Point(12, 149);
            this.ServerIpLabel.Name = "ServerIpLabel";
            this.ServerIpLabel.Size = new System.Drawing.Size(67, 13);
            this.ServerIpLabel.TabIndex = 4;
            this.ServerIpLabel.Text = "Opponent IP";
            // 
            // CreateNewGameButton
            // 
            this.CreateNewGameButton.Location = new System.Drawing.Point(171, 194);
            this.CreateNewGameButton.Name = "CreateNewGameButton";
            this.CreateNewGameButton.Size = new System.Drawing.Size(75, 43);
            this.CreateNewGameButton.TabIndex = 6;
            this.CreateNewGameButton.Text = "Create new game";
            this.CreateNewGameButton.UseVisualStyleBackColor = true;
            this.CreateNewGameButton.Click += new System.EventHandler(this.CreateNewGameButton_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(12, 194);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 43);
            this.ConnectButton.TabIndex = 7;
            this.ConnectButton.Text = "Connect to opponent";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.CreateNewGameButton);
            this.Controls.Add(this.ServerIpText);
            this.Controls.Add(this.ServerIpLabel);
            this.Name = "MainMenu";
            this.Text = "Tic Tac Toe Online";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ServerIpText;
        private System.Windows.Forms.Label ServerIpLabel;
        private System.Windows.Forms.Button CreateNewGameButton;
        private System.Windows.Forms.Button ConnectButton;
    }
}