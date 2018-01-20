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

namespace hw22_WPF_Elements3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1Click(object sender, RoutedEventArgs e)
        {
            if (button1.HorizontalAlignment == HorizontalAlignment.Right)
            {
                button1.HorizontalAlignment = HorizontalAlignment.Left;
                button1.VerticalAlignment = VerticalAlignment.Bottom;
            }
            else if (button1.HorizontalAlignment == HorizontalAlignment.Left && button1.VerticalAlignment == VerticalAlignment.Bottom)
            {
                button1.HorizontalAlignment = HorizontalAlignment.Left;
                button1.VerticalAlignment = VerticalAlignment.Top;
            }
            else if (button1.HorizontalAlignment == HorizontalAlignment.Left && button1.VerticalAlignment == VerticalAlignment.Top)
            {
                button1.HorizontalAlignment = HorizontalAlignment.Right;
                button1.VerticalAlignment = VerticalAlignment.Top;
            }
        }
    }
}
