using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AccountOperationAppPractice1
{
    public partial class AccountOperationUi : Form
    {
        Transaction transaction = new Transaction();
        

        public AccountOperationUi()
        {
            InitializeComponent();
        }

        private void DipositButton_Click(object sender, EventArgs e)
        {
         
            transaction.account = Convert.ToInt32(amountTextBox.Text);
            transaction.Deposit();
            MessageBox.Show("Deposit complete");

        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            
            transaction.account = Convert.ToInt32(amountTextBox.Text);
            transaction.Withdraw();
            MessageBox.Show("withdraw complete");
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(transaction.Report());

        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
           
            transaction.name= customerNameTextBox.Text;
            transaction.accountNo= accountNoTextBox.Text;
            MessageBox.Show("account created");
        }
    }
}
