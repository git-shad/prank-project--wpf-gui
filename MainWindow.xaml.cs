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
using System.Threading;

namespace PracticeWPF_GUI
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

        private void freemove(object sender, MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);

            // Begin dragging the window
            this.DragMove();
        }

        static Random rand = new Random();
        int num = rand.Next(1,10);
        private void NONONO(object sender, MouseEventArgs e)
        {
            num = rand.Next(1, 10);
            switch(num){
                case 1:
                    no.Margin = new Thickness(254,199,290,100);
                    break;
                case 2:
                    no.Margin = new Thickness(514,150,30,149);
                    break;
                case 3:
                    no.Margin = new Thickness(68,278,276,21);
                    break;
                case 4:
                    no.Margin = new Thickness(235, 142, 309, 157);
                    break;
                case 5:
                    no.Margin = new Thickness(162, 237, 382, 62);
                    break;
                case 6:
                    no.Margin = new Thickness(116, 218, 428, 81);
                    break;
                case 7:
                    no.Margin = new Thickness(68, 114, 476, 185);
                    break;
                case 8:
                    no.Margin = new Thickness(-10, 308, 554, -9);
                    break;
                case 9:
                    no.Margin = new Thickness(521, 0, 23, 299);
                    break;
                case 10:
                    no.Margin = new Thickness(565, 312, -21, -13);
                    break;
            }
            num = rand.Next(1, 10);

        }

        private void YES(object sender, RoutedEventArgs e)
        {
            t.Text = "i knew it HAHAHA";
                        
        }

        

    }
}
