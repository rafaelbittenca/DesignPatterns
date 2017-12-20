using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Singleton
{
    public sealed class SingletonTest
    {
		private static SingletonTest _instance = null;
		private static readonly object _plock = new object();

		public static SingletonTest GetInstance
		{
			get
			{
				lock (_plock)
				{
					if (_instance == null)
						_instance = new SingletonTest();
				}
				return _instance;
			}
		}

		private SingletonTest()
		{

		}

		public void AnyMethod()
		{
			Console.WriteLine("Any method");
		}
    }
}
