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
    /// Interaction logic for BuyingFinal.xaml
    /// </summary>
    public partial class BuyingFinal : Window
    {

        //Getters and setters made
        public int Income { get; set; }
        public int Tax { get; set; }

        public int Purchase { get; set; }

        public int Deposit { get; set; }

        public double Interest { get; set; }

        public int Monthrep { get; set; }

        //Storing the expenses in a list
        public List<double> Expenses { get; set; } = new List<double>();

        //Passing the getters and setters through as parameters
        public BuyingFinal(int income, int tax, List<double> expenses, int purchase, int deposit, double interest, int monthrep, double interest1, int purchase1, int deposit1)
        {
            InitializeComponent();
            Income = income;
            Tax = tax;
            Purchase = purchase;
            Deposit = deposit;
            Interest = interest;
            Expenses = expenses;
            Monthrep = monthrep;
            buying();

    }
        //Method for buying a house 
        public void buying()
        {
            
            //if statment to see if the user enters between 240 and 360 months
            if (Monthrep >= 240 && Monthrep <= 360)
            {
                //Calculating the users monthly repayment 
                double depo = (Interest / 100) * Purchase;
                double amount = Purchase - depo;
                double yearPay = Monthrep / 12;
                double monthlyTot = Math.Round(amount * (1 + (Interest * yearPay)) / Monthrep);
                payMonth.Text = monthlyTot.ToString();
                
            }
            else
            {
                //Will let the user know if he/she never entered the months required
                MessageBox.Show("You have not entered the number of months between 240 and 360, please try again");
                this.Hide();

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Calling the next form with parameters
            new Vehicle(Income,Tax,Purchase,Deposit,Interest, Monthrep, Expenses).Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Your option was not to purchase a vehicle, have a great day further !");
            Application.Current.Shutdown();
        }

       
    }
}
