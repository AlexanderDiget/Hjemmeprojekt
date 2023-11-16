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

namespace TusindfrydWPF
{
    /// <summary>
    /// Interaction logic for CreateFlowerSortDialog.xaml
    /// </summary>
    public partial class CreateFlowerSortDialog : Window
    {
        public FlowerSort flower;  
        void IsButtonReady()
        {
            if (NavnBox.Text != "" &&
                BilledeBox.Text != "" &&
                ProduktionstidBox.Text != "" &&
                HalveringstidBox.Text != "" &&
                StørrelseBox.Text != "")
            {
                OKButton.IsEnabled = true;
            }
            else OKButton.IsEnabled = false;
        }
        public CreateFlowerSortDialog()
        {
            InitializeComponent();
            flower = new FlowerSort();
            OKButton.IsEnabled = false;
        }
        private void NavnBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (NavnBox.Text != "")
            {
                flower.Name = (NavnBox.Text);
            }
            else MessageBox.Show("Skriv et gydligt navn før du går videre");
            IsButtonReady();
        }

        private void BilledeBox_LostFocus(object sender, RoutedEventArgs e)
        {
            flower.PicturePath = BilledeBox.Text;
            try
            {
                imgFlowerSort.Source = new BitmapImage(new Uri(BilledeBox.Text));
            }
            catch (UriFormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            IsButtonReady();
        }
        private void ProduktionstidBox_LostFocus(object sender, RoutedEventArgs e)
        {
            try
            {
                flower.ProductionTime = int.Parse(ProduktionstidBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Input skal være et tal!");
            }
            IsButtonReady();
        }

        private void HalveringstidBox_LostFocus(object sender, RoutedEventArgs e)
        {
            try
            {
                flower.HalfLifeTime = int.Parse(HalveringstidBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Input skal være et tal!");
            }
            IsButtonReady();
        }

        private void StørrelseBox_LostFocus(object sender, RoutedEventArgs e)
        {
            try
            {
                flower.Size = int.Parse(StørrelseBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Input skal være et tal!");
            }
            IsButtonReady();
        }
        private void StørrelseBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            IsButtonReady();
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void FortrydButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
