
namespace CardsAgainstSoftwareDevelopment
{
    partial class CASD
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
            this.cardSelector = new System.Windows.Forms.GroupBox();
            this.card1 = new System.Windows.Forms.Button();
            this.card2 = new System.Windows.Forms.Button();
            this.card3 = new System.Windows.Forms.Button();
            this.card4 = new System.Windows.Forms.Button();
            this.card5 = new System.Windows.Forms.Button();
            this.card6 = new System.Windows.Forms.Button();
            this.cardSelector.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardSelector
            // 
            this.cardSelector.Controls.Add(this.card6);
            this.cardSelector.Controls.Add(this.card5);
            this.cardSelector.Controls.Add(this.card4);
            this.cardSelector.Controls.Add(this.card3);
            this.cardSelector.Controls.Add(this.card2);
            this.cardSelector.Controls.Add(this.card1);
            this.cardSelector.Location = new System.Drawing.Point(12, 209);
            this.cardSelector.Name = "cardSelector";
            this.cardSelector.Size = new System.Drawing.Size(626, 229);
            this.cardSelector.TabIndex = 0;
            this.cardSelector.TabStop = false;
            this.cardSelector.Text = "Select cards";
            // 
            // card1
            // 
            this.card1.Location = new System.Drawing.Point(6, 19);
            this.card1.Name = "card1";
            this.card1.Size = new System.Drawing.Size(201, 96);
            this.card1.TabIndex = 0;
            this.card1.Text = "card1";
            this.card1.UseVisualStyleBackColor = true;
            // 
            // card2
            // 
            this.card2.Location = new System.Drawing.Point(6, 121);
            this.card2.Name = "card2";
            this.card2.Size = new System.Drawing.Size(201, 96);
            this.card2.TabIndex = 1;
            this.card2.Text = "card2";
            this.card2.UseVisualStyleBackColor = true;
            // 
            // card3
            // 
            this.card3.Location = new System.Drawing.Point(213, 19);
            this.card3.Name = "card3";
            this.card3.Size = new System.Drawing.Size(201, 96);
            this.card3.TabIndex = 2;
            this.card3.Text = "card3";
            this.card3.UseVisualStyleBackColor = true;
            // 
            // card4
            // 
            this.card4.Location = new System.Drawing.Point(213, 121);
            this.card4.Name = "card4";
            this.card4.Size = new System.Drawing.Size(201, 96);
            this.card4.TabIndex = 3;
            this.card4.Text = "card4";
            this.card4.UseVisualStyleBackColor = true;
            // 
            // card5
            // 
            this.card5.Location = new System.Drawing.Point(420, 19);
            this.card5.Name = "card5";
            this.card5.Size = new System.Drawing.Size(201, 96);
            this.card5.TabIndex = 4;
            this.card5.Text = "card5";
            this.card5.UseVisualStyleBackColor = true;
            // 
            // card6
            // 
            this.card6.Location = new System.Drawing.Point(420, 121);
            this.card6.Name = "card6";
            this.card6.Size = new System.Drawing.Size(201, 96);
            this.card6.TabIndex = 5;
            this.card6.Text = "card6";
            this.card6.UseVisualStyleBackColor = true;
            // 
            // CASD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cardSelector);
            this.Name = "CASD";
            this.Text = "Cards Against Software Development";
            this.cardSelector.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox cardSelector;
        private System.Windows.Forms.Button card6;
        private System.Windows.Forms.Button card5;
        private System.Windows.Forms.Button card4;
        private System.Windows.Forms.Button card3;
        private System.Windows.Forms.Button card2;
        private System.Windows.Forms.Button card1;
    }
}

