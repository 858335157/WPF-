using MVVMLearn.ViewModel;
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

namespace MVVMLearn.View
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

        private void Grid_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            MainWindowVM vm = DataContext as MainWindowVM;
            int index = vm.IndexValue;
            index -= e.Delta / 120;
            if(index > vm.MaxValue)
            {
                index = vm.MaxValue;
            }
            if(index < 0)
            {
                index = 0;
            }
            vm.IndexValue = index;
        }
    }
}
