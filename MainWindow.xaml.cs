using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace WPF_PR10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonToFind_Click(object sender, RoutedEventArgs e)
        {
            Regex regex = new Regex("a[^d,x]b|eb");
            string s = "ahb acb aeb aeeb adcb axeb";
            Match match = regex.Match(s);
            MatchCollection mathes = regex.Matches(s);
            if (mathes.Count>0)
            {
                object[] mas = new object[mathes.Count];
                mathes.CopyTo(mas, 0);
                //textBoxResult.ItemsSource = mas;
            }
        }
    }
}
