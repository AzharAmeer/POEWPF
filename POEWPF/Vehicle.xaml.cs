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
    /// Interaction logic for Vehicle.xaml
    /// </summary>
    public partial class Vehicle : Window
    {

        //Getters and setters made 
        public int Income { get; set; }
        public int Tax { get; set; }
        public int Purchase { get; set; }
        public int Deposit { get; set; }

        public double Interest { get; set; }

        public int MonthRepay { get; set; }
        public String Model { get; set; }
        public int PurchasePrice { get; set; }
        public int VehicleDeposit { get; set; }
        public int InterestRate { get; set; }
        public int InsureancePremium { get; set; }

        //Storing expenses in a list 
        public List<double> Expenses { get; set; } = new List<double>();


        //Passing the getters and setters through as parameters
        public Vehicle(int income, int tax, int purchase, int deposit, double interest, int monthRepay, List<double> expenses)
        {
            InitializeComponent();
            Income = income;
            Tax = tax;
            Expenses = expenses;
            Purchase = purchase;
            Deposit = deposit;
            Interest = interest;
            MonthRepay = monthRepay;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //try and catch  to make sure the user enters a numeric number and the question will repeat itself till the user enters the correct data type
            try
            {
                 Model = vehicleModelTxt.Text;
            }
            catch (FormatException)
            {
                //This code will let the user know if they have entered a wrong input/ data type
                MessageBox.Show("You have to enter a word or you have not filled in everything", "Error occured", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            //try and catch  to make sure the user enters a numeric number and the question will repeat itself till the user enters the correct data type
            try
            {
                
                PurchasePrice = int.Parse(vehiclePurchaseTxt.Text);
                VehicleDeposit = int.Parse(vehicleDeposit.Text);
                InterestRate = (int)double.Parse(vehicleInterestTxt.Text);
                InsureancePremium = int.Parse(vehiclePremium.Text);

                new VehicleFinal(Income, Tax, Expenses, Model, PurchasePrice, VehicleDeposit, InterestRate, InsureancePremium).Show();
                this.Hide();
            }
            catch (FormatException)
            {
                //This code will let the user know if they have entered a wrong input/ data type
                MessageBox.Show("You have to enter a whole number or you have not filled in everything", "Error occured", MessageBoxButton.OK, MessageBoxImage.Error);
            }
         

         
        }
        public void empty()
        {
            vehicleModelTxt.Text = " ";
            vehiclePurchaseTxt.Text = " ";
            vehicleDeposit.Text = " ";
            vehicleInterestTxt.Text = " ";
            vehiclePremium.Text = " ";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            empty();
        }
    }
}
