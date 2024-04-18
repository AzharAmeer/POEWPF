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

namespace POEWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //Making getters and setters
        public int Income { get; set; }

        public int Tax { get; set; }

        //Storing expenses in a list 
        public List<double> Expenses { get; set; } = new List<double>();


        public MainWindow()
        {
            InitializeComponent();

        }
        public void empty()
        {

            //Clears the text boxes if the user makes a mistake 
            grossMonthlyText.Text = " ";
            monthlyTaxText.Text = " ";
            groceries.Text = " ";
            waterLights.Text = " ";
            travelCosts.Text = " ";
            cellphone.Text = " ";
            otherExpense.Text = " ";
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            //calling the method in the clear button where the user will be able to clear his mistakes 
            empty();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            //try and catch  to make sure the user enters a numeric number and the question will repeat itself till the user enters the correct data type
            try
            {
                //Storing the textbox name into a variable which i can call
                Income = int.Parse(grossMonthlyText.Text);
                Tax = int.Parse(monthlyTaxText.Text);
                Expenses.Add(int.Parse(groceries.Text));
                Expenses.Add(int.Parse(waterLights.Text));
                Expenses.Add(int.Parse(travelCosts.Text));
                Expenses.Add(int.Parse(cellphone.Text));
                Expenses.Add(int.Parse(otherExpense.Text));

                //Calling the next window with the parameters
                new Property(Income, Tax, Expenses).Show();
                this.Hide();

            }
            catch (FormatException)
            {
                //This code will let the user know if they have entered a wrong input/ data type
                MessageBox.Show("You have to enter a whole number or you have not filled in everything","Error occured",MessageBoxButton.OK,MessageBoxImage.Error);


            }


          
        }
    }
  
}
