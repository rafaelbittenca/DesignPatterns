using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreExamplesFactory.Example01
{
	// Abstract Factory
    abstract class ContinentFactory
    {
		public abstract Herbivore CreateHerbivore();
		public abstract Carnivore CreateCarnivore();
	}
}
