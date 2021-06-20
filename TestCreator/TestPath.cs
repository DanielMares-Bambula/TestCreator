using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace TestCreator
{
    class TestPath : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPathChanged(string property)
        {
            if (PropertyChanged != null) 
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
               
        }
        private string testPathS;
        public string TestPathS
        {
            get => testPathS;
            set { testPathS = value; OnPathChanged("TestPath"); }
        }
    }
}
