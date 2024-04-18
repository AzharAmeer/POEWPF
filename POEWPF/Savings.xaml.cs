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
    /// Interaction logic for Savings.xaml
    /// </summary>
    public partial class Savings : Window
    {
        //Getters and setters made 
        public int Save { get; set; }
        public int Years { get; set; }
        public String Reason { get; set; }
        public double InterestSave { get; set; }
        public Savings()
        {
            InitializeComponent();
          

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //try and catch  to make sure the user enters a numeric number and the question will repeat itself till the user enters the correct data type
            try
            {
                //Storing the textbox name into a variable which i can call
                Save = int.Parse(saveAmountTxt.Text);
                Years = int.Parse(yearsSaveTxt.Text);
                Reason = reasonTxt.Text;
                InterestSave = double.Parse(interestRateTxt.Text);

                //Calling the next form with parameters 
                new SavingsFinal(Save, Years, InterestSave).Show();
                this.Hide();
            }
            catch (FormatException)
            {
                //This code will let the user know if they have entered a wrong input/ data type
                MessageBox.Show("You have to enter a whole number or you have not filled in everything", "Error occured", MessageBoxButton.OK, MessageBoxImage.Error);
            }
          

        }
    }
}
