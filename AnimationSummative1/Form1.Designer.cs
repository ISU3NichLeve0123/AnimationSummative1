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
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(-3, 258);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nameLabel.Size = new System.Drawing.Size(341, 25);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Nicholas Levesque, Sept 26, 2017";
            // 
            // cardLabel
            // 
            this.cardLabel.BackColor = System.Drawing.Color.DimGray;
            this.cardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardLabel.ForeColor = System.Drawing.Color.White;
            this.cardLabel.Location = new System.Drawing.Point(54, 9);
            this.cardLabel.Name = "cardLabel";
            this.cardLabel.Size = new System.Drawing.Size(212, 30);
            this.cardLabel.TabIndex = 1;
            this.cardLabel.Text = "Libra Greeting Card";
            // 
            // animationButton
            // 
            this.animationButton.BackColor = System.Drawing.Color.White;
            this.animationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animationButton.ForeColor = System.Drawing.Color.Crimson;
            this.animationButton.Location = new System.Drawing.Point(63, 167);
            this.animationButton.Name = "animationButton";
            this.animationButton.Size = new System.Drawing.Size(203, 42);
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
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(334, 292);
            this.Controls.Add(this.animationButton);
            this.Controls.Add(this.cardLabel);
            this.Controls.Add(this.nameLabel);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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

