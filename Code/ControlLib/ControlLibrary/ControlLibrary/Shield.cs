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

namespace ControlLibrary
{
    [TemplatePart(Name = clickBtn, Type = typeof(Button))]
    public class Shield : Control
    {
        static Shield()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Shield), new FrameworkPropertyMetadata(typeof(Shield)));
        }
        private const string clickBtn = "clickBtn";
        private Button btn = null;

        private string gemini = "";
        public string Gemini
        {
            get
            {
                return gemini;
            }
            set
            {
                gemini = value;
            }
        }
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            btn = Template.FindName(clickBtn, this) as Button;

            btn.Click += delegate { Operate(); };
        }

        public delegate void BtnClick(string gemini);
        public event BtnClick btnClickEvent;

        private void Operate()
        {
            btnClickEvent?.Invoke(gemini);
            //MessageBox.Show(gemini);
        }
    }
}
