using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson19_EventsAndGenerics.Banking
{
    public class Bank
    {
        private Dictionary<string, decimal> _accountLookup = new Dictionary<string, decimal>
        {
            {"1", 100 },
            {"2", 250 },
            {"3", 450 },
        };

        public void OnTransaction(object sender, TransferEventArgs e)
        {
            switch (e.TrasferTipe)
            {
                case TransferTipe.Deposit:
                    DepositMoney(e.AccountNumber, e.Ammount);
                    break;
                case TransferTipe.Witdraw:
                    WithdrawMoney(e.AccountNumber, e.Ammount);
                    break;
            }
        }

        private void DepositMoney(string accountNumber, decimal ammount)
        {
            if (!_accountLookup.ContainsKey(accountNumber))
            {
                throw new Exception("Account not found");
            }

            _accountLookup[accountNumber] += ammount;
        }

        private void WithdrawMoney(string accountNumber, decimal ammount)
        {
            if (!_accountLookup.ContainsKey(accountNumber))
            {
                throw new Exception("Account not found");
            }

            if (ammount > _accountLookup[accountNumber])
            {
                throw new Exception("Not enougf funds");
            }

            _accountLookup[accountNumber] -= ammount;
        }
    }
}
