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

namespace _7132016
{
    /// <summary>
    /// Interaction logic for LargeBackgroundWindow.xaml
    /// </summary>
    public partial class LargeBackgroundWindow : Window
    {
        public LargeBackgroundWindow()
        {
            this.Left = 0;
            this.Top = 0;
            this.Activate();
            InitializeComponent();
        }
    }
}
