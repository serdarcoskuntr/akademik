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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for giris.xaml
    /// </summary>
    public partial class giris : Window
    {
        MainWindow win1 = new MainWindow();
        public giris()
        {
            
            InitializeComponent();
            peopleListBox.Items.Add("Serdar");
            peopleListBox.Items.Add("Ozan");
            peopleListBox.Items.Add("Bekir");
            peopleListBox.Items.Add("Serkan");
            Lbl_pword.Visibility = Visibility.Collapsed;
            txt_pword.Visibility = Visibility.Collapsed;
            

        }

        private void PeopleListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (peopleListBox.Items.IndexOf(peopleListBox.SelectedItem) != -1)
            {
                Lbl_pword.Visibility = Visibility.Visible;
                txt_pword.Visibility = Visibility.Visible;
            }

        }

        private void Btn_giris_Click(object sender, RoutedEventArgs e)
        {

            if (peopleListBox.Items.IndexOf(peopleListBox.SelectedItem) == 0)
            {
                
                if (txt_pword.Password == "serdar123")
                {
                    tx_snc.Text = "Giriş Başarılı";
                    win1.Show();
                    this.Close();
                }
                else
                {
                    tx_snc.Text = "Tekrar Deneyiniz ";
                }
            }
            else
            {
                tx_snc.Text = "Admin olmayan kullanıcı.";
            }


        }
    }
}
