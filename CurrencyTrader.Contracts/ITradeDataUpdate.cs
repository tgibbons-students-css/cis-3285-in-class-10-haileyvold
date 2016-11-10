using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyTrade.Contracts
{
    interface ITradeDataUpdate
    {
        void UpdateTradeData(IEnumerable lines);

    }
}
