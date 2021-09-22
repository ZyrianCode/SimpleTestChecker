
namespace SimpleTestChecker
{
    partial class UserAnswersCheckForm
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
            this.UserAnswersLabel = new System.Windows.Forms.Label();
            this.CountOfBallsLabel = new System.Windows.Forms.Label();
            this.ListOfMissedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserAnswersLabel
            // 
            this.UserAnswersLabel.AutoSize = true;
            this.UserAnswersLabel.Font = new System.Drawing.Font("JetBrains Mono NL", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserAnswersLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UserAnswersLabel.Location = new System.Drawing.Point(256, 139);
            this.UserAnswersLabel.Name = "UserAnswersLabel";
            this.UserAnswersLabel.Size = new System.Drawing.Size(126, 19);
            this.UserAnswersLabel.TabIndex = 0;
            this.UserAnswersLabel.Text = "User answers:";
            // 
            // CountOfBallsLabel
            // 
            this.CountOfBallsLabel.AutoSize = true;
            this.CountOfBallsLabel.Font = new System.Drawing.Font("JetBrains Mono NL", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CountOfBallsLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CountOfBallsLabel.Location = new System.Drawing.Point(256, 88);
            this.CountOfBallsLabel.Name = "CountOfBallsLabel";
            this.CountOfBallsLabel.Size = new System.Drawing.Size(144, 19);
            this.CountOfBallsLabel.TabIndex = 1;
            this.CountOfBallsLabel.Text = "Count Of Balls:";
            // 
            // ListOfMissedLabel
            // 
            this.ListOfMissedLabel.AutoSize = true;
            this.ListOfMissedLabel.Font = new System.Drawing.Font("JetBrains Mono NL", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListOfMissedLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ListOfMissedLabel.Location = new System.Drawing.Point(256, 196);
            this.ListOfMissedLabel.Name = "ListOfMissedLabel";
            this.ListOfMissedLabel.Size = new System.Drawing.Size(72, 19);
            this.ListOfMissedLabel.TabIndex = 2;
            this.ListOfMissedLabel.Text = "Missed:";
            // 
            // UserAnswersCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(63)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.ListOfMissedLabel);
            this.Controls.Add(this.CountOfBallsLabel);
            this.Controls.Add(this.UserAnswersLabel);
            this.MaximumSize = new System.Drawing.Size(820, 500);
            this.MinimumSize = new System.Drawing.Size(820, 500);
            this.Name = "UserAnswersCheckForm";
            this.Text = "UserAnswersCheckForm";
            this.Load += new System.EventHandler(this.OnFormLoaded);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserAnswersLabel;
        private System.Windows.Forms.Label CountOfBallsLabel;
        private System.Windows.Forms.Label ListOfMissedLabel;
    }
}