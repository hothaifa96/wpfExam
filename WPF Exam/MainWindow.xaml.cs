using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WPF_Exam
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
     public string ToUse { get; set; }   
        public MainWindow()
        {
            InitializeComponent();
        }

        
        public void DyBtn_Click(object sender, RoutedEventArgs e)
        {
            AfterBtnWindow afterBtnWindow = new AfterBtnWindow();
            afterBtnWindow.main = this;
            afterBtnWindow.w = DyBtn.Width;
            afterBtnWindow.h = DyBtn.Height;
            afterBtnWindow.s = DyBtn.Content.ToString();
            afterBtnWindow.Show();
            this.Close();
            
        }

    }
}
