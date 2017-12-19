using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPatterns.Models;

namespace TestPatterns.Factory.FactoryMethod
{
	public class ProductManagerFactory
	{
		public BaseProductFactory CreateFactory(Product prod)
		{
			BaseProductFactory value = null;
			switch (prod.CategoryId)
			{
				case 1:
					value = new LowProductFactory(prod);
					break;
				case 2:
					value = new MediumProductFactory(prod);
					break;
				case 3:
					value = new HighProductFactory(prod);
					break;
				default:
					break;
			}
			return value;
		}
	}
}
