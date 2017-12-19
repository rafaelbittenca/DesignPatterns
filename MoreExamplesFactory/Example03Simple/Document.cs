using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreExamplesFactory.Example03Simple
{
	// Creator
    abstract class Document
    {
		private List<Page> _pages = new List<Page>();

		public Document()
		{
			this.CreatePages();
		}

		public List<Page> Pages
		{
			get { return _pages; }
		}

		// Factory Method
		public abstract void CreatePages();
	}
}
