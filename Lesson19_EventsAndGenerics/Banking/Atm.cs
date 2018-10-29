using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson19_EventsAndGenerics.Banking
{
    public class Atm
    {
        private int _operationCount;
        private decimal _cashCount = 500;
        public event EventHandler<TransferEventArgs> TransferRequested;

        public void Witdraw(string accountNumber, decimal ammount)
        {
            if (ammount > _cashCount)
            {
                throw new Exception("Not enought cash in ATM");
            }

            _operationCount++;
            OnTransfer(accountNumber, ammount, TransferTipe.Witdraw);
        }

        public void Deposit(string accountNumber, decimal ammount)
        {
            _operationCount++;
            _cashCount += ammount;
            OnTransfer(accountNumber, ammount, TransferTipe.Deposit);
        }

        protected virtual void OnTransfer(string accountNumber, decimal ammount, TransferTipe trasferTipe)
        {
            if (TransferRequested != null)
            {
                TransferRequested(this, new TransferEventArgs(accountNumber, ammount, trasferTipe));
            }
        }
    }
}
