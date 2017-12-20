using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreExamplesFactory.Example02
{
	//Concrete factory
	class Nokia : IMobilePhone
	{
		public ISmartPhone GetSmartPhone()
		{
			return new NokiaPixel();
		}

		public INormalPhone GetNormalPhone()
		{
			return new Nokia1600();
		}
	}
}
