using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPatterns.Contracts;
using TestPatterns.Models;

namespace TestPatterns.Factory.FactoryMethod
{
	public class HighProductFactory : BaseProductFactory
	{
		public HighProductFactory(Product product) : base(product)
		{
		}

		public override IProductManager Create()
		{
			HighTaxProductManager manager = new HighTaxProductManager();
			_product.ImportPerc = manager.GetImportPercentual();

			return manager;
		}
	}
}
