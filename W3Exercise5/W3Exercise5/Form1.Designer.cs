namespace W3Exercise5
{
    partial class ApproximatePI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApproximatePI));
            this.termsLabel = new System.Windows.Forms.Label();
            this.termsBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.resultValueLabel = new System.Windows.Forms.Label();
            this.resultL = new System.Windows.Forms.Label();
            this.equalsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // termsLabel
            // 
            this.termsLabel.AutoSize = true;
            this.termsLabel.Location = new System.Drawing.Point(21, 24);
            this.termsLabel.Name = "termsLabel";
            this.termsLabel.Size = new System.Drawing.Size(89, 13);
            this.termsLabel.TabIndex = 0;
            this.termsLabel.Text = "Enter # of Terms:";
            // 
            // termsBox
            // 
            this.termsBox.Location = new System.Drawing.Point(116, 21);
            this.termsBox.Name = "termsBox";
            this.termsBox.Size = new System.Drawing.Size(100, 20);
            this.termsBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultValueLabel
            // 
            this.resultValueLabel.AutoSize = true;
            this.resultValueLabel.Location = new System.Drawing.Point(21, 115);
            this.resultValueLabel.Name = "resultValueLabel";
            this.resultValueLabel.Size = new System.Drawing.Size(178, 13);
            this.resultValueLabel.TabIndex = 3;
            this.resultValueLabel.Text = "Approximate value of pi after 0 terms";
            // 
            // resultL
            // 
            this.resultL.AutoSize = true;
            this.resultL.Location = new System.Drawing.Point(31, 149);
            this.resultL.Name = "resultL";
            this.resultL.Size = new System.Drawing.Size(13, 13);
            this.resultL.TabIndex = 4;
            this.resultL.Text = "0";
            // 
            // equalsLabel
            // 
            this.equalsLabel.AutoSize = true;
            this.equalsLabel.Location = new System.Drawing.Point(21, 149);
            this.equalsLabel.Name = "equalsLabel";
            this.equalsLabel.Size = new System.Drawing.Size(13, 13);
            this.equalsLabel.TabIndex = 5;
            this.equalsLabel.Text = "=";
            // 
            // ApproximatePI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.equalsLabel);
            this.Controls.Add(this.resultL);
            this.Controls.Add(this.resultValueLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.termsBox);
            this.Controls.Add(this.termsLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ApproximatePI";
            this.Text = "Approximate pi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label termsLabel;
        private System.Windows.Forms.TextBox termsBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label resultValueLabel;
        private System.Windows.Forms.Label resultL;
        private System.Windows.Forms.Label equalsLabel;
    }
}

