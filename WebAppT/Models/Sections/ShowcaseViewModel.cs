﻿using WebApp.Models.Components;

namespace WebApp.Models.Sections
{
	public class ShowcaseViewModel
	{
		public string? Id { get; set; }
		public ImageViewModel ShowcaseImage { get; set; } = null!; 
		public string? Title { get; set; }
		public string? Text { get; set; }
		public LinkViewModel Link { get; set; } = new LinkViewModel();
		public string? BrandDescription { get; set; }
		public List<ImageViewModel>? Brands { get; set; }

	}
}
