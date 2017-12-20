﻿using ObserverPattern.ConcreteObserver;
using ObserverPattern.ConcreteSubject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			// Create Stock and attach investors
			IBM ibm = new IBM("IBM", 120.00);
			ibm.Attach(new Investor("Sorros"));
			ibm.Attach(new Investor("Berkshire"));
			ibm.Attach(new Investor("Me"));

			// Notify
			ibm.Price = 120.10;
			ibm.Price = 121.00;
			ibm.Price = 120.50;
			ibm.Price = 120.75;

			Console.ReadKey();
		}
	}
}
