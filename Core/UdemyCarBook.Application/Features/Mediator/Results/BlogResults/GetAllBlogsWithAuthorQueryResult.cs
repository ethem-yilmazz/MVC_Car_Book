﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Results.BlogResults
{
	public class GetAllBlogsWithAuthorQueryResult
	{
		public int BlogID { get; set; }
		public string Title { get; set; }
		public string AuthorName { get; set; }
		public string AuthorDescriptrion { get; set; }
		public string AuthorImageUrl { get; set; }
		public string CategoryName { get; set; }
		public int AuthorId { get; set; }
		public string CoverImageUrl { get; set; }
		public DateTime CreatedDate { get; set; }
		public int CategoryId { get; set; }
		public string Description { get; set; }
	}
}
