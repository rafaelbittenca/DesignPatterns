using System;

namespace MoreExamplesFactory.Example01
{
	class Wolf : Carnivore
	{
		public override void Eat(Herbivore h)
		{
			// Eat Bison

			Console.WriteLine(this.GetType().Name +
			  " eats " + h.GetType().Name);
		}
	}
}