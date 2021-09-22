using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTestChecker.Zyrian.TestChecker.Loadres
{
    public class NameLoader : BaseLoader
    {
        private readonly List<string> _names = new();
        public override string Path { get; set; }
        public override List<object> GetResultList() => _names.Cast<object>().ToList();

        public override void Load()
        {
            using StreamReader streamReader = new(Path);
            string line;

            while ((line = streamReader.ReadLine())!= null)
            {
                _names.Add(line);
            }
        }

        public List<string> GetNames() => _names;
    }
}
