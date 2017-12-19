﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPatterns.Contracts;
using TestPatterns.Models;

namespace TestPatterns.Factory.FactoryMethod
{
	public class LowProductFactory : BaseProductFactory
	{
		public LowProductFactory(Product product) : base(product)
		{
		}

		public override IProductManager Create()
		{
			LowProductManager manager = new LowProductManager();
			_product.InternalPerc = manager.GetInternalPercentual();
			return manager;
		}
	}
}
