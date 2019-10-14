using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountOperationAppPractice1
{
  public  class Transaction
    {
        public int balance;
        public int account;
        public string name;
        public string accountNo;

      
       public  int Withdraw()
        {
         
            balance = balance - account;
         
            return balance;
        }
       public  int Deposit()
        {
           
            balance = balance + account;
           
            return balance;
        }
        public string  Report()
        {
        
            string report= ""+name+ ","+" your account number is  "+accountNo+"  and your balance is  " +balance.ToString();
            return report;
        }
        
    }
}
