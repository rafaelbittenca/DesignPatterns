﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Contracts
{
	public class LowProductManager : IProductManager
	{
		public decimal GetBonus()
		{
			return 5;
		}

		public decimal GetTax()
		{
			return 2;
		}

		public double GetInternalPercentual()
		{
			return 0.3;
		}
	}
}
