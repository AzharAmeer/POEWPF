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
    /// Interaction logic for Property.xaml
    /// </summary>
    public partial class Property : Window
    {

        //Making getters and setters
        public int Income { get; set; }
        public int Tax { get; set; }
    
        public List<double> Expenses { get; set; } = new List<double>();

        //Passing the getters and setters as parameters
        public Property(int income, int tax, List <double> expenses)
        {
            InitializeComponent();
            Income = income;
            Tax = tax;
            Expenses = expenses;
            calcExpen();
        }
        double finalSum = 0;

        //Method to calculate expenses
        public void calcExpen()
        {
            //Adding up the expenses in a List where generic collection is used
            for (int i = 0; i < Expenses.Count; i++)
            {
                double sum = 0;
                sum = Expenses[i];
                finalSum += sum;

            }

            totalExpenFinal.Text = finalSum.ToString();

            //Using my code below using my getters and setters 
            double avail = Income - Tax - finalSum;

            monthlyIncomeFinal.Text = avail.ToString();



       
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Calling the next window with the parameters
            new Accomadation(Income, Tax, Expenses).Show();
            this.Hide();
        }
    }
}
