using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTestChecker.Zyrian.TestChecker;

namespace SimpleTestChecker
{
    public partial class UserAnswersCheckForm : Form
    {
        private List<string> _userAnswers;
        private List<Question> _questions;
        private int _countOfBalls = 0;

        public UserAnswersCheckForm(List<string> userAnswers, List<Question> questions)
        {
            InitializeComponent();
            _userAnswers = userAnswers;
            _questions = questions;
        }

        private void OnFormLoaded(object sender, EventArgs e)
        {
            
            ShowQuestionsInfo();
            AddBall();
            PrintMissed();
            FormClosed += (o, args) => Application.Exit();
        }

        private void ShowQuestionsInfo()
        {
            foreach (var userAnswer in _userAnswers)
            {
                UserAnswersLabel.Text += $@" {userAnswer} ";
            }
        }

        private void AddBall()
        {
            for (int i = 0; i < _userAnswers.Count; i++)
            {
                if (_questions[i].CorrectAnswer.Equals(_userAnswers[i]))
                {
                    _countOfBalls += _questions[i].Cost;
                    CountOfBallsLabel.Text += $@" {_countOfBalls} ";
                }
            }
            CountOfBallsLabel.Text += $@" {_countOfBalls} ";
        }

        private void PrintMissed()
        {
            for (int i = 0; i < _userAnswers.Count; i++)
            {
                if (_questions[i].CorrectAnswer != _userAnswers[i])
                {
                    ListOfMissedLabel.Text += $@" {_userAnswers[i]} ";
                }
            }
        }
    }
}
