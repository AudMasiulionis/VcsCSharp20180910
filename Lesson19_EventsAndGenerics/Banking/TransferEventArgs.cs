using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson19_EventsAndGenerics.Banking
{
    public class TransferEventArgs
    {
        public TransferEventArgs(string accountNumber, decimal ammount, TransferTipe transferType)
        {
            AccountNumber = accountNumber;
            Ammount = ammount;
            TrasferTipe = transferType;
        }

        public string AccountNumber { get; }
        public decimal Ammount { get; }
        public TransferTipe TrasferTipe { get; }
    }
}
