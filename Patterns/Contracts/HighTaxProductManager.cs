﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Contracts
{
	public class HighTaxProductManager : IProductManager
	{
		public decimal GetBonus()
		{
			return 1;
		}

		public decimal GetTax()
		{
			return 7;
		}

		public double GetImportPercentual()
		{
			return 0.9;
		}
	}
}
