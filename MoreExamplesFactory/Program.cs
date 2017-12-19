using MoreExamplesFactory.Example01;
using MoreExamplesFactory.Example02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreExamplesFactory
{
	class Program
	{
		static void Main(string[] args)
		{
			#region Example01
			Console.WriteLine("********* Example01 **********");
			ContinentFactory africa = new AfricaFactory();
			AnimalWorld world = new AnimalWorld(africa);
			world.RunFoodChain();


			ContinentFactory america = new AmericaFactory();
			world = new AnimalWorld(america);
			world.RunFoodChain();

			#endregion

			Console.WriteLine("");

			#region Example02
			Console.WriteLine("********* Example02 **********");
			IMobilePhone nokiaMobilePhone = new Nokia();
			MobileClient nokiaClient = new MobileClient(nokiaMobilePhone);

			Console.WriteLine("********* NOKIA **********");
			Console.WriteLine(nokiaClient.GetSmartPhoneModelDetails());
			Console.WriteLine(nokiaClient.GetNormalPhoneModelDetails());

			IMobilePhone samsungMobilePhone = new Samsung();
			MobileClient samsungClient = new MobileClient(samsungMobilePhone);

			Console.WriteLine("******* SAMSUNG **********");
			Console.WriteLine(samsungClient.GetSmartPhoneModelDetails());
			Console.WriteLine(samsungClient.GetNormalPhoneModelDetails());

			#endregion

			Console.ReadKey();
		}
	}
}
