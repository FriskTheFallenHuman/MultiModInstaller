namespace MultiModInstaller
{
    partial class MainWindows
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindows));
            this.quitButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.finalDoodle = new System.Windows.Forms.PictureBox();
            this.alphyDoodle = new System.Windows.Forms.PictureBox();
            this.thankyouLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.finalDoodle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphyDoodle)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(502, 327);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 23);
            this.quitButton.TabIndex = 1;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(410, 327);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = "Next >";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(329, 327);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(75, 23);
            this.prevButton.TabIndex = 3;
            this.prevButton.Text = "< Back";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(12, 53);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(370, 170);
            this.instructionLabel.TabIndex = 5;
            this.instructionLabel.Text = resources.GetString("instructionLabel.Text");
            this.instructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // finalDoodle
            // 
            this.finalDoodle.Image = global::MultiModInstaller.Properties.Resources.finalDoodle;
            this.finalDoodle.Location = new System.Drawing.Point(281, 65);
            this.finalDoodle.Name = "finalDoodle";
            this.finalDoodle.Size = new System.Drawing.Size(231, 130);
            this.finalDoodle.TabIndex = 6;
            this.finalDoodle.TabStop = false;
            this.finalDoodle.Visible = false;
            // 
            // alphyDoodle
            // 
            this.alphyDoodle.Image = global::MultiModInstaller.Properties.Resources.alphyDoodle;
            this.alphyDoodle.InitialImage = global::MultiModInstaller.Properties.Resources.alphyDoodle;
            this.alphyDoodle.Location = new System.Drawing.Point(12, 12);
            this.alphyDoodle.Name = "alphyDoodle";
            this.alphyDoodle.Size = new System.Drawing.Size(166, 308);
            this.alphyDoodle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alphyDoodle.TabIndex = 0;
            this.alphyDoodle.TabStop = false;
            // 
            // thankyouLabel
            // 
            this.thankyouLabel.AutoSize = true;
            this.thankyouLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.thankyouLabel.Location = new System.Drawing.Point(70, 193);
            this.thankyouLabel.Name = "thankyouLabel";
            this.thankyouLabel.Size = new System.Drawing.Size(211, 91);
            this.thankyouLabel.TabIndex = 7;
            this.thankyouLabel.Text = "Success! Now, launch your game.\r\n\r\n$REPLACETEXT$\r\n\r\nMod by: Depa the Dog\r\nSpaghet" +
    "tiInstaller by: Nik the Cat\r\nArrivederci! (that\'s \"Goodbye!\" in Italian)";
            this.thankyouLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.thankyouLabel.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.thankyouLabel);
            this.panel1.Controls.Add(this.instructionLabel);
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Location = new System.Drawing.Point(184, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 307);
            this.panel1.TabIndex = 4;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(66, 13);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(252, 25);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "MultiModInstaller Example";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // MainWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 367);
            this.Controls.Add(this.finalDoodle);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.alphyDoodle);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(605, 398);
            this.MinimumSize = new System.Drawing.Size(605, 398);
            this.Name = "MainWindows";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MultiModManager Example Installer";
            ((System.ComponentModel.ISupportInitialize)(this.finalDoodle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphyDoodle)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox alphyDoodle;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.PictureBox finalDoodle;
        private System.Windows.Forms.Label thankyouLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label titleLabel;
    }
}

