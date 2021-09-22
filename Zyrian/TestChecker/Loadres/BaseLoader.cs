using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTestChecker.Zyrian.TestChecker.Loadres
{
    public abstract class BaseLoader
    {
        public abstract void Load();
        public abstract string Path { get; set; }
        public abstract List<object> GetResultList();
    }
}
