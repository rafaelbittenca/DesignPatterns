using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreExamplesFactory.Example02
{
	// Client class 
	class MobileClient
	{
		ISmartPhone smartPhone;
		INormalPhone normalPhone;

		public MobileClient(IMobilePhone factory)
		{
			smartPhone = factory.GetSmartPhone();
			normalPhone = factory.GetNormalPhone();
		}

		public string GetSmartPhoneModelDetails()
		{
			return smartPhone.GetModelDetails();
		}

		public string GetNormalPhoneModelDetails()
		{
			return normalPhone.GetModelDetails();
		}
	}
}
