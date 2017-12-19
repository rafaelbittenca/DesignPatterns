using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Composite
{
	// Leafe
	public class Contractor : IEmployed
	{
		public int EmpID { get; set; }
		public string Name { get; set; }
	}
}
