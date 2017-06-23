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

using TravelApp.DOMAIN;
using TravelApp.SERVICE;
using TravelApp.BUSINESS;

namespace TravelApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AccountMgr am = new AccountMgr();
            Account a = am.GenerateAccount();

            MessageBox.Show(a.Print());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AccountMgr am = new AccountMgr();
            IList<Transaction> tt = am.GenerateTList();
            IList<string> ss = new List<string>();

            int i = 0;

            string str = "Transactions: @ ";
            foreach (Transaction t in tt)
            {

                str = str + t.ToString() + " @ ";
                str = str.Replace("@", System.Environment.NewLine);
                ss.Add(str);
                i++;
                if (i == 10)
                {
                    ss.Add(str);
                    MessageBox.Show(str);
                    i = 0;
                    str = null;

                }

            }

            MessageBox.Show(str);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string amt_s = AmountBox.Text;
            double amt = Convert.ToDouble(amt_s);
            string currency = CurrencyBox.Text;
            string date = DateBox.Text;




            Deposit d = new DOMAIN.Deposit(amt, currency, date);

            AccountMgr am = new AccountMgr();
            Account a = am.GenerateAccount();
            IList<Transaction> tt = am.GenerateTList();

            DepositMgr dm = new DepositMgr();
            dm.ProcessDeposit(d, a, tt);
        }
    }
}
