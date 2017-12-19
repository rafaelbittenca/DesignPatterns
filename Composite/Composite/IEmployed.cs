using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Composite
{
	//Component class
	public interface IEmployed
    {
		int EmpID { get; set; }
		string Name { get; set; }
	}
}
