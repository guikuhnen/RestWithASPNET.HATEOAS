using RestWithASPNET.HATEOAS.Hypermedia.Abstract;

namespace RestWithASPNET.HATEOAS.Hypermedia.Filters
{
	public class HyperMediaFilterOptions
	{
		public ICollection<IResponseEnricher> ContentResponseEnricherList { get; set; } = [];
	}
}
