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

namespace KCK3.UserControl
{
    /// <summary>
    /// Interaction logic for EditButton.xaml
    /// </summary>
    public partial class EditButton 
    {
        public EditButton()
        {
            InitializeComponent();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            EditWindows.AddEditPracownik window = new EditWindows.AddEditPracownik();

            window.Show();
        }
    }
}
