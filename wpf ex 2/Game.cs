using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace wpf_ex_2
{
    public class Game
    {
        public string Formula { get; private set; }
        public double Answer { get; private set; }
        public double Wrong1 { get; private set; }
        public double Worng2 { get; private set; }
        public double Wrong3 { get; private set; }
        public int TimerProp { get; set; }
        public MainWindow main { get; set; }

        public Game()
        {

            Random r = new Random();
            double a, b;
            a = r.Next(1, 25);
            b = r.Next(1, 25);
            this.Formula = $"{a} * {b} = ?";
            this.Answer = a * b;
            this.Wrong1 = r.Next(int.Parse((Answer * 3).ToString()));
            this.Worng2 = r.Next(int.Parse((Answer * 3).ToString()));
            this.Wrong3 = r.Next(int.Parse((Answer * 3).ToString()));
          
        }
        
    }
}
