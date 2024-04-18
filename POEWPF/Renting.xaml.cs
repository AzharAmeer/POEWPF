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

namespace POEWPF
{
    /// <summary>
    /// Interaction logic for Renting.xaml
    /// </summary>
    public partial class Renting : Window
    {
        public Renting()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thank you for entering your monthly rental amount, Have a great day !");
            Application.Current.Shutdown();
        }
    }
}
