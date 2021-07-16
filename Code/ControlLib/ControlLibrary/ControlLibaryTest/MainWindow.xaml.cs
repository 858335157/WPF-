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

namespace ControlLibaryTest
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnClickEvent(string gemini)
        {
            Button btn = new Button();
            switch(gemini)
            {
                case "1": btn = btn1; break;
                case "2": btn = btn2; break;
                case "3": btn = btn3; break;
                case "4": btn = btn4; break;
                case "5": btn = btn5; break;
                case "6": btn = btn6; break;
            }
            btn.Content = gemini;

        }

    }
}
