using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Contracts;
using Patterns.Models;

namespace Patterns.Factory.FactoryMethod
{
	public abstract class BaseProductFactory
	{
		protected Product _product;

		public BaseProductFactory(Product product)
		{
			_product = product;
		}

		public Product ApplyBonusTax()
		{
			IProductManager manager = this.Create();
			_product.Bonus = manager.GetBonus();
			_product.Tax = manager.GetTax();
			return _product;
		}

		public abstract IProductManager Create();
	}
}
