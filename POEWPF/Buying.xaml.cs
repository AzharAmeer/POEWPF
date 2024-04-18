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
    /// Interaction logic for Buying.xaml
    /// </summary>
    public partial class Buying : Window
    {

        //Getters and setters made
        public int Income { get; set; }
        public int Tax { get; set; }

        public int Purchase { get; set; }

        public int Deposit { get; set; }

        public double Interest { get; set; }
        public int Monthrep { get; set; }


        //Storing expenses in a list 
        public List<double> Expenses { get; set; } = new List<double>();

        //Passing the getters and setters through as parameters
        public Buying(int income, int tax, List<double> expenses, int monthrep)
        {
            InitializeComponent();
            Income = income;
            Tax = tax;
            Expenses = expenses;

        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //try and catch  to make sure the user enters a numeric number and the question will repeat itself till the user enters the correct data type
            try
            {
                Interest = double.Parse(interestTxt.Text);
                Purchase = int.Parse(purchaseTxt.Text);
                Deposit = int.Parse(depositTxt.Text);
                Monthrep = int.Parse(monthRepayTxt.Text);

                //Calling the next window with the parameters
                new BuyingFinal(Income, Tax, Expenses, Purchase, Deposit, Interest, Monthrep, Interest, Purchase, Deposit).Show();

                this.Hide();
            }
            catch (FormatException)
            {
                //This code will let the user know if they have entered a wrong input/ data type
                MessageBox.Show("You have to enter a whole number or you have not filled in everything", "Error occured", MessageBoxButton.OK, MessageBoxImage.Error);
            }
          
        }

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            empty();
        }
        public void empty()
        {
            //Clears the text boxes if the user makes a mistake 
            purchaseTxt.Text = " ";
            depositTxt.Text = " ";
            interestTxt.Text = " ";
            monthRepayTxt.Text = " ";
           
        }

        
    }
}
