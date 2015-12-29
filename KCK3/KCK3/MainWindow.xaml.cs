using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace KCK3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

      
        public MainWindow()
        {
            InitializeComponent();
            repozytorium.repozytorium.init();
            listFakturaSprzedazy.ItemsSource = repozytorium.repozytorium.listFakturaSprzedazy;
            Wydarzenia.ItemsSource = repozytorium.repozytorium.listWydarzenia;
            ListEmail.ItemsSource = repozytorium.repozytorium.listEmail;
            Pracownicy.ItemsSource = repozytorium.repozytorium.listPracownikow;
            listFakturaZakupu.ItemsSource = repozytorium.repozytorium.listFakturaZakupu;

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Data.Content = DateTime.Now.ToString();
        }
  
    }
}
