using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreExamplesFactory.Example02
{
	//Concrete Factory
	class Samsung : IMobilePhone
	{
		public ISmartPhone GetSmartPhone()
		{
			return new SamsungGalaxy();
		}

		public INormalPhone GetNormalPhone()
		{
			return new SamsungGuru();
		}
	}
}
