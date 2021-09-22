using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTestChecker.Zyrian.TestChecker.Loadres
{
    public class NumberLoader : BaseLoader
    {
        private readonly List<int> _numbers = new();
        public override string Path { get; set; }
        public override List<object> GetResultList() => _numbers.Cast<object>().ToList();

        public override void Load()
        {
            using (StreamReader streamReader = new(Path))
            {
                string line;

                while ((line = streamReader.ReadLine()) != null)
                {
                    _numbers.Add(int.Parse(line));
                }
            }
        }

        public List<int> GetNumbers() => _numbers;
        
    }
}
