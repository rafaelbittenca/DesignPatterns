using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreExamplesFactory.Example01
{
	// Concrete Factory
	class AfricaFactory : ContinentFactory
	{
		public override Herbivore CreateHerbivore()
		{
			return new Gnu();
		}
		public override Carnivore CreateCarnivore()
		{
			return new Lion();
		}
	}
}
