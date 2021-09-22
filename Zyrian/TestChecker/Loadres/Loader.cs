using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTestChecker.Zyrian.TestChecker.Loadres
{
    public class Loader
    {
        public event EventHandler PathsIntialized;
        public event EventHandler Injected;
        public event EventHandler Loaded;

        private List<BaseLoader> _loaders = new();
        private BaseLoader _correctAnswerLoader = new CorrectAnswerLoader();
        private BaseLoader _costLoader = new CostLoader();
        private BaseLoader _nameLoader = new NameLoader();
        private BaseLoader _numberLoader = new NumberLoader();
        private BaseLoader _textLoader = new TextLoader();

        public void Load()
        {
            foreach (var loader in _loaders)
            {
                loader.Load();
            }
            Loaded?.Invoke(this, new EventArgs());
        }

        public void InitializePaths(string path)
        {
            _correctAnswerLoader.Path = path + "\\CorrectAnswers.txt";
            _costLoader.Path = path + "\\Costs.txt";
            _nameLoader.Path = path + "\\Names.txt";
            _numberLoader.Path = path + "\\Numbers.txt";
            _textLoader.Path = path + "\\Texts.txt";

            PathsIntialized?.Invoke(this, new EventArgs());
        }

        public void InjectLoaders()
        {
            _loaders.Add(_correctAnswerLoader);
            _loaders.Add(_costLoader);
            _loaders.Add(_nameLoader);
            _loaders.Add(_numberLoader);
            _loaders.Add(_textLoader);

            Injected?.Invoke(this, new EventArgs());
        }

        public List<BaseLoader> GetLoaders() => _loaders;
    }
}
