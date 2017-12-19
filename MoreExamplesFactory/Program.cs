using MoreExamplesFactory.Example01;
using MoreExamplesFactory.Example02;
using MoreExamplesFactory.Example03Simple;
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

			Console.WriteLine("");

			#region Example03
			Console.WriteLine("********* Example03 **********");
			Document[] documents = new Document[2];

			documents[0] = new Resume();
			documents[1] = new Report();

			// Display document pages

			foreach (Document document in documents)
			{
				Console.WriteLine("\n" + document.GetType().Name + "--");
				foreach (Page page in document.Pages)
				{
					Console.WriteLine(" " + page.GetType().Name);
				}
			}
			#endregion

			Console.ReadKey();
		}
	}
}
