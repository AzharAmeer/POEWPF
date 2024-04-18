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
    /// Interaction logic for SavingsFinal.xaml
    /// </summary>
    public partial class SavingsFinal : Window
    {
        //Getters and setters made 
        public int Save { get; set; }
        public int Years { get; set; }
        public double InterestSave { get; set; }

        //Passing the getters and setters as parameters
        public SavingsFinal(int save, int years, double interestSave)
        {
            InitializeComponent();
            Save = save;
            Years = years;
            InterestSave = interestSave;
            saveCalc();
        }
        //Method that caluclates savings 
        public void saveCalc()
        {
            double saveAmount =(Save / Years) * InterestSave;
            saveAmount = Math.Round(saveAmount, 2);

            finalTxt.Text = saveAmount.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Ending the program 
            MessageBox.Show("Thank you have a great day further !");
            this.Hide();
            Application.Current.Shutdown();
        }
    }
}
