
namespace SimpleTestChecker
{
    partial class QuestionsForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.testAnswerARadioBtn = new System.Windows.Forms.RadioButton();
            this.testAnswerBRadioBtn = new System.Windows.Forms.RadioButton();
            this.QuestionsProgressBar = new System.Windows.Forms.ProgressBar();
            this.QuestionsLeft = new System.Windows.Forms.Label();
            this.QuestionText = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testAnswerARadioBtn
            // 
            this.testAnswerARadioBtn.AutoSize = true;
            this.testAnswerARadioBtn.Font = new System.Drawing.Font("JetBrains Mono NL", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.testAnswerARadioBtn.Location = new System.Drawing.Point(81, 123);
            this.testAnswerARadioBtn.Name = "testAnswerARadioBtn";
            this.testAnswerARadioBtn.Size = new System.Drawing.Size(45, 23);
            this.testAnswerARadioBtn.TabIndex = 0;
            this.testAnswerARadioBtn.Text = "a)";
            this.testAnswerARadioBtn.UseVisualStyleBackColor = true;
            // 
            // testAnswerBRadioBtn
            // 
            this.testAnswerBRadioBtn.AutoSize = true;
            this.testAnswerBRadioBtn.Font = new System.Drawing.Font("JetBrains Mono NL", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.testAnswerBRadioBtn.Location = new System.Drawing.Point(81, 167);
            this.testAnswerBRadioBtn.Name = "testAnswerBRadioBtn";
            this.testAnswerBRadioBtn.Size = new System.Drawing.Size(45, 23);
            this.testAnswerBRadioBtn.TabIndex = 1;
            this.testAnswerBRadioBtn.TabStop = true;
            this.testAnswerBRadioBtn.Text = "б)";
            this.testAnswerBRadioBtn.UseVisualStyleBackColor = true;
            // 
            // QuestionsProgressBar
            // 
            this.QuestionsProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(152)))), ((int)(((byte)(145)))));
            this.QuestionsProgressBar.Location = new System.Drawing.Point(97, 309);
            this.QuestionsProgressBar.Name = "QuestionsProgressBar";
            this.QuestionsProgressBar.Size = new System.Drawing.Size(578, 23);
            this.QuestionsProgressBar.Step = 0;
            this.QuestionsProgressBar.TabIndex = 2;
            // 
            // QuestionsLeft
            // 
            this.QuestionsLeft.AutoSize = true;
            this.QuestionsLeft.Font = new System.Drawing.Font("JetBrains Mono NL", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QuestionsLeft.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.QuestionsLeft.Location = new System.Drawing.Point(629, 276);
            this.QuestionsLeft.Name = "QuestionsLeft";
            this.QuestionsLeft.Size = new System.Drawing.Size(126, 19);
            this.QuestionsLeft.TabIndex = 3;
            this.QuestionsLeft.Text = "QuestionsLeft";
            // 
            // QuestionText
            // 
            this.QuestionText.AutoSize = true;
            this.QuestionText.Font = new System.Drawing.Font("JetBrains Mono NL", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QuestionText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.QuestionText.Location = new System.Drawing.Point(125, 25);
            this.QuestionText.Name = "QuestionText";
            this.QuestionText.Size = new System.Drawing.Size(117, 19);
            this.QuestionText.TabIndex = 4;
            this.QuestionText.Text = "QuestionText";
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.NextButton.FlatAppearance.BorderSize = 0;
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.NextButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NextButton.Location = new System.Drawing.Point(581, 361);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(94, 56);
            this.NextButton.TabIndex = 5;
            this.NextButton.Text = "Next question";
            this.NextButton.UseVisualStyleBackColor = false;
            // 
            // QuestionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(63)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.QuestionText);
            this.Controls.Add(this.QuestionsLeft);
            this.Controls.Add(this.QuestionsProgressBar);
            this.Controls.Add(this.testAnswerBRadioBtn);
            this.Controls.Add(this.testAnswerARadioBtn);
            this.MaximumSize = new System.Drawing.Size(820, 500);
            this.MinimumSize = new System.Drawing.Size(820, 500);
            this.Name = "QuestionsForm";
            this.Text = "Questions";
            this.Load += new System.EventHandler(this.QuestionsFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton testAnswerARadioBtn;
        private System.Windows.Forms.RadioButton testAnswerBRadioBtn;
        private System.Windows.Forms.ProgressBar QuestionsProgressBar;
        private System.Windows.Forms.Label QuestionsLeft;
        private System.Windows.Forms.Label QuestionText;
        private System.Windows.Forms.Button NextButton;
    }
}

