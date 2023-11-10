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

namespace WPFSimpleGUI
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

        private void ScrollUp_Click(object sender, RoutedEventArgs e)
        {
            string template = Line4.Text;           //Event-Handler for Scroll Up kaldes ScrollUp_Button_Click
            Line4.Text = Line3.Text;                //Når dette er lavet skal man huske at tilføje sin event handler til sin knap i MainWindow.XAML.
            Line3.Text = Line2.Text;                //Det gør man helt ude til højre for sin knap i sit grid i XAML editoren
            Line2.Text = Line1.Text;                //Man kan fx ændre navnet fra ScrollUp_Click til ScrollUp_Button_Click hvilket man så gør i XAML editoren i mit MainWindow.XAML
            Line1.Text = template;
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Line1.Text = "";            //Her har jeg implementeret Clear knappen hvor man bruger ""; til at clear.
            Line2.Text = "";
            Line3.Text = "";
            Line4.Text = "";
        }

        private void ScrollDown_Click(object sender, RoutedEventArgs e)
        {
            string template1 = Line1.Text;
            Line1.Text = Line2.Text;
            Line2.Text = Line3.Text;
            Line3.Text = Line4.Text;
            Line4.Text = template1;
        }
    }
}
