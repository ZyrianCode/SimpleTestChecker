using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTestChecker.Zyrian.TestChecker.Loadres
{
    public class CostLoader : BaseLoader
    {
        private readonly List<int> _costs = new();
        public override string Path { get; set; }

        public override void Load()
        {
            using StreamReader streamReader = new(Path);
            string line;

            while ((line = streamReader.ReadLine()) != null)
            {
                _costs.Add(int.Parse(line));
            }
        }

        public List<int> GetCosts() => _costs;

        public override List<object> GetResultList() => _costs.Cast<object>().ToList();
    }
}
