using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTestChecker.Zyrian.TestChecker
{
    public class QuestionBuilder
    {
        private Question _question;

        public QuestionBuilder()
        {
            _question = new();
        }

        public QuestionBuilder SetName(string name)
        {
            _question.Name = name;
            return this;
        }

        public QuestionBuilder SetCost(int cost)
        {
            _question.Cost = cost;
            return this;
        }

        public QuestionBuilder SetNumber(int number)
        {
            _question.Number = number;
            return this;
        }

        public QuestionBuilder SetCorrectAnswer(string correctAnswer)
        {
            _question.CorrectAnswer = correctAnswer;
            return this;
        }

        public QuestionBuilder SetText(string text)
        {
            _question.Text = text;
            return this;
        }

        public Question Build() => _question;

    }
}
