using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTestChecker.Zyrian.TestChecker.Loadres
{
    public class CorrectAnswerLoader : BaseLoader
    {
        private List<string> _correctAnswers = new();
        public override string Path { get; set; }
        public override List<object> GetResultList() => _correctAnswers.Cast<object>().ToList();

        public override void Load()
        {
            using StreamReader streamReader = new(Path);
            string line;

            while ((line = streamReader.ReadLine()) != null)
            {
                _correctAnswers.Add(line);
            }
        }

        public List<string> GetCorrectAnswers() => _correctAnswers;
        
    }
}
