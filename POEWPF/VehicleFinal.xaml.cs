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
    /// Interaction logic for VehicleFinal.xaml
    /// </summary>
    public partial class VehicleFinal : Window
    {

        //Gettters and setters 
        public int Income { get; set; }
        public int Tax { get; set; }
        public String Model { get; set; }
        public int PurchasePrice { get; set; }
        public int VehicleDeposit { get; set; }
        public int InterestRate { get; set; }
        public int InsureancePremium { get; set; }

        //Stroing expenses in a list 
        public List<double> Expenses { get; set; } = new List<double>();

        //Passing the getters and setters through as parameters
        public VehicleFinal(int income, int tax, List<double> expenses, string model, int purchasePrice, int vehicleDeposit, int interestRate, int insureancePremium)
        {
            InitializeComponent();
            Income = income;
            Tax = tax;
            Expenses = expenses;
            Model = model;
            PurchasePrice = purchasePrice;
            VehicleDeposit = vehicleDeposit;
            InterestRate = interestRate;
            InsureancePremium = insureancePremium;


            vehicleCalc();




        }
        //Passing the getters and setters through as parameters
        public VehicleFinal(string model, int purchasePrice, int vehicleDeposit, int interestRate, int insureancePremium)
        {
            Model = model;
            PurchasePrice = purchasePrice;
            VehicleDeposit = vehicleDeposit;
            InterestRate = interestRate;
            InsureancePremium = insureancePremium;
        }

        //Method that calculates the vehicle 
        public void vehicleCalc()
        {
            //This code below is for calculations where the code will calculate the total monthly cost of buying the car, insurance and loan repayment  is added to the calculation over 5 years

            double interest = InterestRate / 100;
            PurchasePrice = PurchasePrice - VehicleDeposit;
            int yearRepay = 5;

            InsureancePremium = InsureancePremium * yearRepay;
            double FinTot = PurchasePrice * (1 + InterestRate);
            FinTot = FinTot + InsureancePremium;
            double monthsToRepay = FinTot / (yearRepay * 12);
            monthsToRepay = Math.Round(monthsToRepay, 2);

            //The code below is the output where the program will display the monthly repayment  after the calculations
            repayMonthTxt.Text = monthsToRepay.ToString();

            double caclFinal = 0;
            //Adding up the expenses in a List where generic collection is used
            for (int i = 0; i < Expenses.Count; i++)
            {
                double sum = 0;
                sum = Expenses.Count;
                caclFinal += sum;
            }
            //Code below is adding the expenses and the monthly repayment together 
            double carsCalc = monthsToRepay + caclFinal;

            //Code below is taking the values and arranging it in decending order 
            Expenses.Sort();
            Expenses.Reverse();
            foreach (double decendingValues in Expenses)
            {

            decendingTxt.Items.Add(decendingValues.ToString());

            }
            


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Your option was not wanting to save money, have a great day further !");
            this.Hide();
            Application.Current.Shutdown();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new Savings().Show();
        }
    }
}
