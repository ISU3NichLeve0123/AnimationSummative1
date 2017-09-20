namespace AnimationSummative1
{
    partial class GreetingCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GreetingCard));
            this.nameLabel = new System.Windows.Forms.Label();
            this.cardLabel = new System.Windows.Forms.Label();
            this.animationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Black;
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(29, 235);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nameLabel.Size = new System.Drawing.Size(171, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Nicholas Levesque, Sept 26, 2017";
            // 
            // cardLabel
            // 
            this.cardLabel.AutoSize = true;
            this.cardLabel.BackColor = System.Drawing.Color.DimGray;
            this.cardLabel.ForeColor = System.Drawing.Color.White;
            this.cardLabel.Location = new System.Drawing.Point(26, 0);
            this.cardLabel.Name = "cardLabel";
            this.cardLabel.Size = new System.Drawing.Size(98, 13);
            this.cardLabel.TabIndex = 1;
            this.cardLabel.Text = "Libra Greeting Card";
            // 
            // animationButton
            // 
            this.animationButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.animationButton.ForeColor = System.Drawing.Color.Crimson;
            this.animationButton.Location = new System.Drawing.Point(86, 183);
            this.animationButton.Name = "animationButton";
            this.animationButton.Size = new System.Drawing.Size(95, 23);
            this.animationButton.TabIndex = 2;
            this.animationButton.Text = "Animation Start";
            this.animationButton.UseVisualStyleBackColor = false;
            this.animationButton.Visible = false;
            this.animationButton.Click += new System.EventHandler(this.AnimationButton_Click);
            // 
            // GreetingCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(240, 257);
            this.Controls.Add(this.animationButton);
            this.Controls.Add(this.cardLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "GreetingCard";
            this.Text = "Greeting Card";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GreetingCard_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label cardLabel;
        private System.Windows.Forms.Button animationButton;
    }
}

