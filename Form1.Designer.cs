namespace Flags
{
    partial class flagsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(flagsForm));
            this.flagInfoLabel = new System.Windows.Forms.Label();
            this.finlandBtn = new System.Windows.Forms.Button();
            this.frenchBtn = new System.Windows.Forms.Button();
            this.germanBtn = new System.Windows.Forms.Button();
            this.countryNameDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // flagInfoLabel
            // 
            this.flagInfoLabel.AutoSize = true;
            this.flagInfoLabel.Location = new System.Drawing.Point(113, 9);
            this.flagInfoLabel.Name = "flagInfoLabel";
            this.flagInfoLabel.Size = new System.Drawing.Size(209, 13);
            this.flagInfoLabel.TabIndex = 0;
            this.flagInfoLabel.Text = "Click a flag to see the name of the country.";
            // 
            // finlandBtn
            // 
            this.finlandBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("finlandBtn.BackgroundImage")));
            this.finlandBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.finlandBtn.Location = new System.Drawing.Point(12, 36);
            this.finlandBtn.Name = "finlandBtn";
            this.finlandBtn.Size = new System.Drawing.Size(134, 86);
            this.finlandBtn.TabIndex = 1;
            this.finlandBtn.UseVisualStyleBackColor = true;
            this.finlandBtn.Click += new System.EventHandler(this.finlandBtn_Click);
            // 
            // frenchBtn
            // 
            this.frenchBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("frenchBtn.BackgroundImage")));
            this.frenchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.frenchBtn.Location = new System.Drawing.Point(152, 36);
            this.frenchBtn.Name = "frenchBtn";
            this.frenchBtn.Size = new System.Drawing.Size(131, 86);
            this.frenchBtn.TabIndex = 2;
            this.frenchBtn.UseVisualStyleBackColor = true;
            this.frenchBtn.Click += new System.EventHandler(this.frenchBtn_Click);
            // 
            // germanBtn
            // 
            this.germanBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("germanBtn.BackgroundImage")));
            this.germanBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.germanBtn.Location = new System.Drawing.Point(289, 36);
            this.germanBtn.Name = "germanBtn";
            this.germanBtn.Size = new System.Drawing.Size(134, 86);
            this.germanBtn.TabIndex = 3;
            this.germanBtn.UseVisualStyleBackColor = true;
            this.germanBtn.Click += new System.EventHandler(this.germanBtn_Click);
            // 
            // countryNameDisplay
            // 
            this.countryNameDisplay.Location = new System.Drawing.Point(152, 141);
            this.countryNameDisplay.Name = "countryNameDisplay";
            this.countryNameDisplay.Size = new System.Drawing.Size(131, 20);
            this.countryNameDisplay.TabIndex = 4;
            this.countryNameDisplay.TextChanged += new System.EventHandler(this.countryNameDisplay_TextChanged);
            // 
            // flagsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 176);
            this.Controls.Add(this.countryNameDisplay);
            this.Controls.Add(this.germanBtn);
            this.Controls.Add(this.frenchBtn);
            this.Controls.Add(this.finlandBtn);
            this.Controls.Add(this.flagInfoLabel);
            this.Name = "flagsForm";
            this.Text = "Flags";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label flagInfoLabel;
        private System.Windows.Forms.Button finlandBtn;
        private System.Windows.Forms.Button frenchBtn;
        private System.Windows.Forms.Button germanBtn;
        private System.Windows.Forms.TextBox countryNameDisplay;
    }
}

