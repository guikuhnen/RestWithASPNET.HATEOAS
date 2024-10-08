﻿using System.Text;

namespace RestWithASPNET.HATEOAS.Hypermedia
{
	public class HyperMediaLink
	{
		public string Rel { get; set; }

		private string _href;
		public string Href
		{
			get
			{
				object _lock = new();
				lock (_lock)
				{
					StringBuilder sb = new(_href);
					return sb.Replace("%2F", "/").ToString();
				}
			}
			set { _href = value; }
		}

		public string Type { get; set; }
		public string Action { get; set; }
	}
}
