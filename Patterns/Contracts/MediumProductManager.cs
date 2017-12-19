using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Contracts
{
	public class MediumProductManager : IProductManager
	{
		public decimal GetBonus()
		{
			return 2;
		}

		public decimal GetTax()
		{
			return 5;
		}

		public double GetManufactoryPercentual()
		{
			return 0.7;
		}
	}
}
