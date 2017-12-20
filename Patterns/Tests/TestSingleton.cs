using Patterns.Singleton;
using NUnit.Framework;

namespace Patterns.Tests
{
	public class TestSingleton
	{
		[Test]
		public void TestSimpleSingleton()
		{
			SimpleSingleton anyClass = SimpleSingleton.GetInstance;
			anyClass.AnyMethod("My anyClass call instance of singleton");

			SimpleSingleton anyClass2 = SimpleSingleton.GetInstance;
			anyClass2.AnyMethod("My anyClass2 use the same instance of singleton");

			Assert.AreSame(anyClass, anyClass2);

		}

		[Test]
		public void TestThreadSafeSingleton()
		{

			ThreadSafeSingleton anyClass = ThreadSafeSingleton.GetInstance;
			anyClass.AnyMethod("My anyClass call instance of singleton");

			ThreadSafeSingleton anyClass2 = ThreadSafeSingleton.GetInstance;
			anyClass2.AnyMethod("My anyClass2 use the same instance of singleton");

			Assert.AreSame(anyClass, anyClass2);

		}
	}
}
