using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreExamplesFactory.Example02
{
	interface IMobilePhone
	{
		ISmartPhone GetSmartPhone();
		INormalPhone GetNormalPhone();
	}
}
