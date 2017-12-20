using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern.Subject;

namespace ObserverPattern.ConcreteSubject
{
    class IBM : Stock
    {
		public IBM(string symbol, double price) : base(symbol, price)
		{
		}
	}
}
