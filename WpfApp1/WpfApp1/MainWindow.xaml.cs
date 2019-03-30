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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string metin = "";
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
        }

        private void Btn_Gnd_Click(object sender, RoutedEventArgs e)
        {
            int deger=0;
            string aranan1 = "";
            metin = Txt_Text.Text;
            for (int i = 0; i < LB_aranan.Items.Count; i++)
            {
                deger = 0;
                aranan1= LB_aranan.Items[i].ToString();
                deger = metin.IndexOf(aranan1);
                if (deger == -1)
                {
                    Txt_Sonuc.Text += "Aranan metinde " + LB_aranan.Items[i].ToString() + " ifadesi yoktur \n";
                }
                else
                {
                    Txt_Sonuc.Text += "Aranan metinde " + LB_aranan.Items[i].ToString() + " ifadesi mevcut. \n";
                }

            }
        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {
        }

        private void Btn_Ekle_Click(object sender, RoutedEventArgs e)
        {
            LB_aranan.Items.Add(Txt_Aranan.Text);
        }

        private void Btn_Sil_Click(object sender, RoutedEventArgs e)
        {
            LB_aranan.Items.RemoveAt(LB_aranan.Items.IndexOf(LB_aranan.SelectedItem));
        }
    }
}
