﻿using Microsoft.AspNetCore.Mvc.Filters;

namespace RestWithASPNET.HATEOAS.Hypermedia.Abstract
{
	public interface IResponseEnricher
	{
		bool CanEnrich(ResultExecutingContext context);
		Task Enrich(ResultExecutingContext context);
	}
}
