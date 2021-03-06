﻿using System;
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

namespace KCK3.EditWindows
{
    /// <summary>
    /// Interaction logic for SendingEmail.xaml
    /// </summary>
    public partial class SendingEmail : Window
    {
        public SendingEmail()
        {
            InitializeComponent();
            adresyEmail.ItemsSource = repozytorium.repozytorium.listPracownikow;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Czy chcesz wysłać maila?", " Potwierdzenie", MessageBoxButton.YesNo);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog 
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();



            // Set filter for file extension and default file extension 
            dlg.DefaultExt = ".png";
           /// dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";


            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();


            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                zalacznik.Content = filename;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        
        {
            bool IsVisibleAdresy = Adresy.Visibility == System.Windows.Visibility.Visible ? true : false;
            if (IsVisibleAdresy)
            Adresy.Visibility = System.Windows.Visibility.Collapsed;
            else
            Adresy.Visibility = System.Windows.Visibility.Visible;
        }
    }
}
