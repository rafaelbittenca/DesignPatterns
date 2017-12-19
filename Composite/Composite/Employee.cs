using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Composite
{
	//Composite Class

	//	Composite pattern is used to separate an abstraction from its implementation 
	//so that both can be modified independently.

	//Composite pattern is used when we need to treat a group of objects and a single 
	//object in the same way.Composite pattern composes objects in term of a tree 
	//structure to represent part as well as whole hierarchies.

	//This pattern creates a class contains group of its own objects.This class 
	//provides ways to modify its group of same objects.

	public class Employee : IEmployed, IEnumerable<IEmployed>
	{
		private List<IEmployed> _subordinates = new List<IEmployed>();

		public int EmpID { get; set; }
		public string Name { get; set; }

		public void AddSubordinate(IEmployed subordinate)
		{
			_subordinates.Add(subordinate);
		}

		public void RemoveSubordinate(IEmployed subordinate)
		{
			_subordinates.Remove(subordinate);
		}

		public IEmployed GetSubordinate(int index)
		{
			return _subordinates[index];
		}

		public IEnumerator<IEmployed> GetEnumerator()
		{
			foreach (IEmployed subordinate in _subordinates)
			{
				yield return subordinate;
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator(); throw new NotImplementedException();
		}
	}
}
