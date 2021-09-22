using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleTestChecker.Zyrian.TestChecker.Loadres;

namespace SimpleTestChecker.Zyrian.TestChecker
{
    public class Test
    {
        private List<Question> _questions = new();
        private List<BaseLoader> _loaders;
        private Question _question = new();

        public event EventHandler QuestionsRecived;

        public event EventHandler Begin;
        public event EventHandler SettingCompleted;


        public void SetQuestions()
        {
            Begin?.Invoke(this, new EventArgs());
            int numOfRows = _loaders[0].GetResultList().Count;
            for (int i = 0; i < numOfRows; i++)
            {

                for (int j = 0; j < _loaders.Count; )
                {
                    //Не менять порядок, фирменный говнокод работает на соответствие столбцов и строк, в C# массив формируется по алфавиту
                    //соответственно поставить эти строчки в произвольном порядке не получится
                    string correctAnswer = _loaders[j++].GetResultList()[i].ToString();
                    int cost = int.Parse(_loaders[j++].GetResultList()[i].ToString());
                    string name = _loaders[j++].GetResultList()[i].ToString();
                    int num = int.Parse(_loaders[j++].GetResultList()[i].ToString());
                    string text = _loaders[j++].GetResultList()[i].ToString();

                    _questions.Add(
                        _question = new QuestionBuilder()
                            .SetCorrectAnswer(correctAnswer)
                            .SetName(name)
                            .SetCost(cost)
                            .SetNumber(num)
                            .SetText(text)
                            .Build()
                    );
                }
                
                //_questions.Add(
                //        _question = new QuestionBuilder()
                //            .SetCorrectAnswer(_answersLoader.GetResultList()[i].ToString())
                //            .SetName(_nameLoader.GetResultList()[i].ToString())
                //            .SetCost(int.Parse(_costLoader.GetResultList()[i].ToString()))
                //            .SetNumber(int.Parse(_numberLoader.GetResultList()[i].ToString()))
                //            .SetText(_textLoader.GetResultList()[i].ToString())
                //            .Build()
                //    );
            }
            SettingCompleted?.Invoke(this, new EventArgs());
        }

        public void ReceiveListOfLoaders(List<BaseLoader> loaders)
        {
            _loaders = loaders;
            QuestionsRecived?.Invoke(this, new EventArgs());
        }

        public List<Question> GetQuestions() => _questions;
    }
}
