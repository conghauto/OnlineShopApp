using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.API.Helpers
{   //use to get parametter from clients
	public class ProductParams
	{
		private const int MaxPageSize = 20;
		public int PageNumber { get; set; } = 1;	
		private int pageSize = 5;

		public int PageSize
		{
			get { return pageSize; }
			set { pageSize = (value > MaxPageSize) ? MaxPageSize : value; }
		}
	}
}