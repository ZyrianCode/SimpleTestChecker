using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTestChecker.Zyrian.TestChecker
{
    public class UserAnswers
    {
        private List<string> _userAnswers = new();
        public void AddQuestion(string answer) => _userAnswers.Add(answer);
        public List<string> GetAnswers() => _userAnswers;
    }
}
