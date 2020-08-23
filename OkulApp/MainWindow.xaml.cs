
using OkulApp.DLL;
using OkulApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace OkulApp
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

        private void Btnkaydet_Click(object sender, RoutedEventArgs e)
        {
            Ogrenci og = new Ogrenci();
            OgrenciBL ogrenciBL = new OgrenciBL();
            og.Ad = txtad.Text.Trim();
            og.Soyad = txtsoyad.Text.Trim();
            og.Numara = Convert.ToInt32((txtnumara.Text.Trim()));
            ogrenciBL.Kaydet(og);
        }

    }
}


