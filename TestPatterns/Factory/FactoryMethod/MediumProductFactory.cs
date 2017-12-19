using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPatterns.Contracts;
using TestPatterns.Models;

namespace TestPatterns.Factory.FactoryMethod
{
	public class MediumProductFactory : BaseProductFactory
	{
		public MediumProductFactory(Product product) : base(product)
		{
		}

		public override IProductManager Create()
		{
			MediumProductManager manager = new MediumProductManager();
			_product.ManufactoryPerc = manager.GetManufactoryPercentual();

			return manager;
		}
	}
}
