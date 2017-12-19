﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreExamplesFactory.Example01
{
	// Client Class - Create Products from Factory
	class AnimalWorld
	{
		private Herbivore _herbivore;
		private Carnivore _carnivore;

		public AnimalWorld(ContinentFactory factory)
		{
			_carnivore = factory.CreateCarnivore();
			_herbivore = factory.CreateHerbivore();
		}

		public void RunFoodChain()
		{
			_carnivore.Eat(_herbivore);
		}
	}
}
