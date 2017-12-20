using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern.Subject;

namespace ObserverPattern.Observer
{
    interface IInvestor
    {
		void Update(Stock stock);
    }
}
