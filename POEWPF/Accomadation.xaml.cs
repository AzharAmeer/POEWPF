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
    /// Interaction logic for Accomadation.xaml
    /// </summary>
    public partial class Accomadation : Window
    {
        //Getters and setters made 
        public int Income { get; set; }
        public int Tax { get; set; }

        //stroing expenses in a list 
        public List<double> Expenses { get; set; } = new List<double>();

        public int Monthrep { get; set; }

        //Passing the getters and setters through as parameters
        public Accomadation(int income, int tax, List<double> expenses)
        {
            InitializeComponent();
            Income = income;
            Tax = tax;
            Expenses = expenses;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Calling the next window 
            new Renting().Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Calling the next window with the parameters
            new Buying(Income, Tax, Expenses, Monthrep).Show();
            this.Hide();
        }


    }
}
