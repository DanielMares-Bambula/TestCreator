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
using System.IO;

namespace TestCreator
{
    //public StreamReader reader = new StreamReader();
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddPath_Click(object sender, RoutedEventArgs e)
        {
            BindingExpression expression = TestPath.GetBindingExpression(TextBox.TextProperty);
            expr?.UpdateSource(); ;
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
