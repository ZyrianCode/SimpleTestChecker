using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTestChecker.Zyrian.TestChecker;
using SimpleTestChecker.Zyrian.TestChecker.Loadres;

namespace SimpleTestChecker
{
    public partial class QuestionsForm : Form
    {
        private Test _test;
        private readonly List<Question> _questions = new();

        private bool _isPressed = false;
        private readonly UserAnswers _userAnswers = new();

        public QuestionsForm(Test test)
        {
            InitializeComponent();
            _test = test;
            _questions = _test.GetQuestions();
        }


        private void QuestionsFormLoad(object sender, EventArgs e)
        {
            ShowTests();
        }

        private async void ShowTests()
        {
            for (int line = 0; line != _questions.Count;)
            {
                if (line.Equals(_questions.Count - 1))
                {
                    NextButton.Text = "Check Answers";
                }

                UpdateProgress(_questions[line]);
                ShowQuestion(_questions[line]);
                await Task.Run((() => Clicking()));
                _isPressed = false;
                
                ++line;
            }
            LoadAnswersCheckForm();
        }

        private void LoadAnswersCheckForm()
        {
            UserAnswersCheckForm userAnswersCheckForm = new(_userAnswers.GetAnswers(), _questions);
            Hide();
            userAnswersCheckForm.ShowDialog();
        }

        private void ShowQuestion(Question question)
        {
            QuestionText.Text = question.Text;
            QuestionsLeft.Text = $"{question.Number} / {_questions.Count}";

        }

        private void UpdateProgress(Question question)
        {
            QuestionsProgressBar.Maximum = _questions.Count;
            QuestionsProgressBar.Value = question.Number;
        }

        private  void Clicking()
        {
            NextButton.Click += OnNextQuestionClicked;
            while (_isPressed != true)
            {
            }
        }

        private void OnNextQuestionClicked(object sender, EventArgs e)
        {
            _isPressed = true;
  
                if (testAnswerARadioBtn.Checked)
                {
                    _userAnswers.AddQuestion(testAnswerARadioBtn.Text);
                }
                else
                {
                    _userAnswers.AddQuestion(testAnswerBRadioBtn.Text);
                }
                NextButton.Click -= OnNextQuestionClicked;
        }
    }
}
