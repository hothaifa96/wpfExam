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
using System.Windows.Threading;

namespace wpf_ex_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Game game = new Game();

        public MainWindow()
        {
            
            DispatcherTimer TimerDis;
            TimerDis = new DispatcherTimer();
            TimerDis.Interval = TimeSpan.FromSeconds(1);
            TimerDis.Tick += TimerDis_Tick;
            TimerDis.Start();
            game.main = this;
            DataContext = game;
            InitializeComponent();
        }


        public int timer = 30;
        int stop = 0;
        private void TimerDis_Tick(object sender, EventArgs e)
        {
            if (timer == stop)
            {
                {
                    if(this.Background!=Brushes.LightGreen)
                        this.Background = Brushes.Red;
                    firstBtn.IsEnabled = false;
                    secondBtn.IsEnabled = false;
                    thirdBtn.IsEnabled = false;
                    furthBtn.IsEnabled = false;
                }

            }
            else
            {
                if (timer < 16)
                this.TimerBlock.Foreground = Brushes.Red; 
            
                timer--;
                TimerBlock.Content = timer.ToString();
                game.TimerProp = timer;
            }
        }

        private void ThirdBtn_Click(object sender, RoutedEventArgs e)
        {
            stop = timer;
            this.Background = Brushes.LightGreen;
            TimerDis_Tick(sender, e);


        }

        private void FurthBtn_Click(object sender, RoutedEventArgs e)
        {
            WrongClick();
        }

        private void FirstBtn_Click(object sender, RoutedEventArgs e)
        {
            WrongClick();
        }

        private void SecondBtn_Click(object sender, RoutedEventArgs e)
        {
            WrongClick();
        }

        private void WrongClick()
        {
            
            this.Background = Brushes.Red;
            firstBtn.IsEnabled = false;
            secondBtn.IsEnabled = false;
            thirdBtn.IsEnabled = false;
            furthBtn.IsEnabled = false;
        }
    }
}
