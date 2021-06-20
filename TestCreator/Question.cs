using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace TestCreator
{
    class Question : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string q = "";
        private string a = "";
        private string b = "";
        private string c = "";
        public string Q
        {
            get => q;
            set { q = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Q")); }
        }
        public string AnswerA
        {
            get => a;
            set { a = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("A")); }
        }
        public string AnswerB
        {
            get => b;
            set { b = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("B")); }
        }
        public string AnswerC
        {
            get => c;
            set { c = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("C")); }
        }
    }
}
