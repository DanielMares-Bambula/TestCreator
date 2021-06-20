using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Text.RegularExpressions;

namespace TestCreator
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int questionNumber = 0;
        public MainWindow()
        {
            TestPath path = new TestPath();
            DataContext = path;
            InitializeComponent();
    }

        private void AddPath_Click(object sender, RoutedEventArgs e)
        {
            BindingExpression expr = TestPathB.GetBindingExpression(TextBox.TextProperty);
            expr?.UpdateSource();
            questionNumber = 0;
            QuestionBuilder(questionNumber);
        }
        private void Next_Click(object sender, RoutedEventArgs e)
        {

             QuestionBuilder(questionNumber);
        }
        private void QuestionBuilder(int question)
        {
            Question q = new Question();
            for (int x = 0; x < 3; x++)
            {
                string txt = System.IO.File.ReadAllLines(@"C:\Users\Daniel Mareš\Desktop\Test1.txt")[question];
                if (Regex.IsMatch(txt, @"[?*]{1}.+ [*]{1}[?]{1}")) 
                {
                    txt = txt.Replace("?*", "");
                    txt = txt.Replace("*?", "");
                    q.Q = txt;
                    questionNumber = questionNumber + 1;
                }
                if (Regex.IsMatch(txt, @"[O]{1}[*]{1}.+[*]{1}[O]{1}")) 
                {
                    txt = txt.Replace("O*","");
                    txt = txt.Replace("*O", "");
                    if(x==1)
                    {
                        q.AnswerA = txt;
                        q.A = true;
                    }
                    if (x == 2)
                    {
                        q.AnswerB = txt;
                        q.B = true;
                    }
                    if (x == 3)
                    {
                        q.AnswerC = txt;
                        q.C = true;
                    }
                }
                if (Regex.IsMatch(txt, @"[X]{1}[*]{1}.+[*]{1}[X]{1}"))
                {
                    txt = txt.Replace("X*", "");
                    txt = txt.Replace("*X", "");
                    if (x == 1)
                    {
                        q.AnswerA = txt;
                        q.A = false;
                    }
                    if (x == 2)
                    {
                        q.AnswerB = txt;
                        q.B = false;
                    }
                    if (x == 3)
                    {
                        q.AnswerC = txt;
                        q.C = false;
                    }
                }
            }           
        }
        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            if (q.A) 
            {
                AnswerA.Background = Brushes.Green;
            }
            else
            {
                AnswerA.Background = Brushes.Red;
            }
            if (q.B)
            {
                AnswerB.Background = Brushes.Green;
            }
            else
            {
                AnswerB.Background = Brushes.Red;
            }
            if (q.C)
            {
                AnswerC.Background = Brushes.Green;
            }
            else
            {
                AnswerC.Background = Brushes.Red;
            }
        }
    }
}
