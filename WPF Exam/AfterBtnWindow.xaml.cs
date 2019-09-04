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
using System.Windows.Shapes;


namespace WPF_Exam
{
    /// <summary>
    /// Interaction logic for AfterBtnWindow.xaml
    /// </summary>
    public partial class AfterBtnWindow : Window
    {
        public double w { get; set; }
        public double h { get; set; }
        public string s { get; set; }
        public MainWindow main { get; set; }
        public AfterBtnWindow()
        {
            
            InitializeComponent();
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string x = $"text => { s} width:::{w} height:::{h}";
            this.informationShow.Text = x;
        }
    }
}
