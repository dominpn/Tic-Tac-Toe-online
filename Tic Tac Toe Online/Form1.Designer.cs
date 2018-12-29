namespace Tic_Tac_Toe_Online
{
    partial class Board
    {
        private System.ComponentModel.IContainer components = null;

       
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region

       
        private void InitializeComponent()
        {
            this.X1 = new System.Windows.Forms.Button();
            this.X2 = new System.Windows.Forms.Button();
            this.X3 = new System.Windows.Forms.Button();
            this.Y3 = new System.Windows.Forms.Button();
            this.Y2 = new System.Windows.Forms.Button();
            this.Y1 = new System.Windows.Forms.Button();
            this.Z3 = new System.Windows.Forms.Button();
            this.Z2 = new System.Windows.Forms.Button();
            this.Z1 = new System.Windows.Forms.Button();
            this.IpLabel = new System.Windows.Forms.Label();
            this.receiverWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // X1
            // 
            this.X1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.X1.Location = new System.Drawing.Point(12, 43);
            this.X1.Name = "X1";
            this.X1.Size = new System.Drawing.Size(80, 80);
            this.X1.TabIndex = 0;
            this.X1.UseVisualStyleBackColor = true;
            this.X1.Click += new System.EventHandler(this.Button_Click);
            // 
            // X2
            // 
            this.X2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.X2.Location = new System.Drawing.Point(98, 43);
            this.X2.Name = "X2";
            this.X2.Size = new System.Drawing.Size(80, 80);
            this.X2.TabIndex = 1;
            this.X2.UseVisualStyleBackColor = true;
            this.X2.Click += new System.EventHandler(this.Button_Click);
            // 
            // X3
            // 
            this.X3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.X3.Location = new System.Drawing.Point(184, 43);
            this.X3.Name = "X3";
            this.X3.Size = new System.Drawing.Size(80, 80);
            this.X3.TabIndex = 2;
            this.X3.UseVisualStyleBackColor = true;
            this.X3.Click += new System.EventHandler(this.Button_Click);
            // 
            // Y3
            // 
            this.Y3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Y3.Location = new System.Drawing.Point(184, 129);
            this.Y3.Name = "Y3";
            this.Y3.Size = new System.Drawing.Size(80, 80);
            this.Y3.TabIndex = 5;
            this.Y3.UseVisualStyleBackColor = true;
            this.Y3.Click += new System.EventHandler(this.Button_Click);
            // 
            // Y2
            // 
            this.Y2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Y2.Location = new System.Drawing.Point(98, 129);
            this.Y2.Name = "Y2";
            this.Y2.Size = new System.Drawing.Size(80, 80);
            this.Y2.TabIndex = 4;
            this.Y2.UseVisualStyleBackColor = true;
            this.Y2.Click += new System.EventHandler(this.Button_Click);
            // 
            // Y1
            // 
            this.Y1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Y1.Location = new System.Drawing.Point(12, 129);
            this.Y1.Name = "Y1";
            this.Y1.Size = new System.Drawing.Size(80, 80);
            this.Y1.TabIndex = 3;
            this.Y1.UseVisualStyleBackColor = true;
            this.Y1.Click += new System.EventHandler(this.Button_Click);
            // 
            // Z3
            // 
            this.Z3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Z3.Location = new System.Drawing.Point(184, 215);
            this.Z3.Name = "Z3";
            this.Z3.Size = new System.Drawing.Size(80, 80);
            this.Z3.TabIndex = 8;
            this.Z3.UseVisualStyleBackColor = true;
            this.Z3.Click += new System.EventHandler(this.Button_Click);
            // 
            // Z2
            // 
            this.Z2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Z2.Location = new System.Drawing.Point(98, 215);
            this.Z2.Name = "Z2";
            this.Z2.Size = new System.Drawing.Size(80, 80);
            this.Z2.TabIndex = 7;
            this.Z2.UseVisualStyleBackColor = true;
            this.Z2.Click += new System.EventHandler(this.Button_Click);
            // 
            // Z1
            // 
            this.Z1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Z1.Location = new System.Drawing.Point(12, 215);
            this.Z1.Name = "Z1";
            this.Z1.Size = new System.Drawing.Size(80, 80);
            this.Z1.TabIndex = 6;
            this.Z1.UseVisualStyleBackColor = true;
            this.Z1.Click += new System.EventHandler(this.Button_Click);
            // 
            // IpLabel
            // 
            this.IpLabel.AutoSize = true;
            this.IpLabel.Location = new System.Drawing.Point(13, 13);
            this.IpLabel.Name = "IpLabel";
            this.IpLabel.Size = new System.Drawing.Size(0, 13);
            this.IpLabel.TabIndex = 9;
            // 
            // receiverWorker
            // 
            this.receiverWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.receiverWorker_DoWork);
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 305);
            this.Controls.Add(this.IpLabel);
            this.Controls.Add(this.Z3);
            this.Controls.Add(this.Z2);
            this.Controls.Add(this.Z1);
            this.Controls.Add(this.Y3);
            this.Controls.Add(this.Y2);
            this.Controls.Add(this.Y1);
            this.Controls.Add(this.X3);
            this.Controls.Add(this.X2);
            this.Controls.Add(this.X1);
            this.Name = "Board";
            this.Text = "Tic Tac Toe Online";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button X1;
        private System.Windows.Forms.Button X2;
        private System.Windows.Forms.Button X3;
        private System.Windows.Forms.Button Y3;
        private System.Windows.Forms.Button Y2;
        private System.Windows.Forms.Button Y1;
        private System.Windows.Forms.Button Z3;
        private System.Windows.Forms.Button Z2;
        private System.Windows.Forms.Button Z1;
        private System.Windows.Forms.Label IpLabel;
        private System.ComponentModel.BackgroundWorker receiverWorker;
    }
}

