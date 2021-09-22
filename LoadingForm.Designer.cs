
namespace SimpleTestChecker
{
    partial class LoadingForm
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
            this.LoadProgressBar = new System.Windows.Forms.ProgressBar();
            this.DisplayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoadProgressBar
            // 
            this.LoadProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LoadProgressBar.Location = new System.Drawing.Point(73, 93);
            this.LoadProgressBar.Name = "LoadProgressBar";
            this.LoadProgressBar.Size = new System.Drawing.Size(403, 44);
            this.LoadProgressBar.TabIndex = 0;
            // 
            // DisplayLabel
            // 
            this.DisplayLabel.AutoSize = true;
            this.DisplayLabel.Font = new System.Drawing.Font("JetBrains Mono NL", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DisplayLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DisplayLabel.Location = new System.Drawing.Point(73, 37);
            this.DisplayLabel.Name = "DisplayLabel";
            this.DisplayLabel.Size = new System.Drawing.Size(117, 19);
            this.DisplayLabel.TabIndex = 1;
            this.DisplayLabel.Text = "DisplayLabel";
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(79)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(555, 179);
            this.Controls.Add(this.DisplayLabel);
            this.Controls.Add(this.LoadProgressBar);
            this.Name = "LoadingForm";
            this.ShowInTaskbar = false;
            this.Text = "LoadingForm";
            this.Load += new System.EventHandler(this.LoadingFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar LoadProgressBar;
        private System.Windows.Forms.Label DisplayLabel;
    }
}