﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Models;

namespace TestPatterns.ViewModels
{
	public class ProductViewModel
	{
		public IEnumerable<ProductCategory> Categories { get; set; }

		[Required]
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		public string Description { get; set; }

		public decimal Bonus { get; set; }
		public decimal Tax { get; set; }

		public double InternalPerc { get; set; }
		public double ImportPerc { get; set; }
		public double ManufactoryPerc { get; set; }

		[Required]
		public int CategoryId { get; set; }

		public ProductViewModel()
		{
			Id = 0;
		}

		public ProductViewModel(Product product)
		{
			Id = product.Id;
			Name = product.Name;
			Description = product.Description;
			Tax = product.Tax;
			CategoryId = product.CategoryId;
		}
	}
}
