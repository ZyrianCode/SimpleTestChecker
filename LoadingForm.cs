using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTestChecker.Zyrian.TestChecker;
using SimpleTestChecker.Zyrian.TestChecker.Loadres;

namespace SimpleTestChecker
{
    public partial class LoadingForm : Form
    {
        private Test _test;
        private Loader _loader;
        public LoadingForm()
        {
            InitializeComponent();
        }

        private async void LoadingFormLoad(object sender, EventArgs e)
        {

            //string path = "D:\\Users\\RyzenPC\\Program\\VisualStudio IDE\\СSharp\\WinForms\\SimpleTestChecker\\Tests";
            string path = Directory.GetCurrentDirectory() + "\\Tests";
            _loader = new Loader();
            _test = new Test();

            
            InitializePaths(path);
            ResetDisplayedInfo();

            
            InjectLoaders();
            ResetDisplayedInfo();

            
            LoaderLoad();
            ResetDisplayedInfo();

            GetLoaders(); 
            ResetDisplayedInfo();

            SetQuestions();

            await Task.Delay(1000);
            LoadQuestionsForm();

        }

        private void LoadQuestionsForm()
        {
            QuestionsForm questionsForm = new QuestionsForm(_test);
            questionsForm.FormClosed += (o, args) => Close();
            Hide();
            questionsForm.ShowDialog();
        }

        private void DisplayCurrentState(int newValue, string whatThingLoading)
        {
            DisplayLabel.Text = whatThingLoading;
            LoadProgressBar.Value = newValue;
        }

        private void ResetDisplayedInfo()
        {
            LoadProgressBar.Text = "";
            LoadProgressBar.Value = 0;
        }


        private void InitializePaths(string path)
        {
            _loader.PathsIntialized += (sender, args) => DisplayCurrentState(100, "Paths successfully initialized");
            _loader.InitializePaths(path);
        }

        private void InjectLoaders()
        {
            _loader.Injected += (sender, args) => DisplayCurrentState(100, "Loaders successfully injected");
            _loader.InjectLoaders();
        }

        private void LoaderLoad()
        {
            _loader.Loaded += (sender, args) => DisplayCurrentState(100, "Loaders successfully initialized");
            _loader.Load();
        }

        private void GetLoaders()
        {
            _test.QuestionsRecived += (sender, args) => DisplayCurrentState(100, "Question successfully recieved");
            _test.ReceiveListOfLoaders(_loader.GetLoaders());
        }

        private void SetQuestions()
        {
            _test.Begin += (sender, args) => DisplayCurrentState(100, "Start setting questions for test");
            _test.SettingCompleted += async (sender, args) =>
            {
                DisplayCurrentState(100, "Setting completed");
            };
            _test.SetQuestions();
        }

    }
}
