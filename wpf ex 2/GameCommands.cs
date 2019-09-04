using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace wpf_ex_2
{
    class GameCommands
    {
        public ICommand RightClickCommand { get; set; }
        public ICommand WrongClickCommand { get; set; }
        public GameCommands()
        {
            
            //RightClickCommand = new RCommand((o) => { return true; }, (o) => {});
            //WrongClickCommand = new RCommand((o) => { return true; }, (o) => {; });
        }
        
    }
}
