namespace RestWithASPNET.HATEOAS.Hypermedia.Abstract
{
	public interface ISupportsHyperMedia
	{
		ICollection<HyperMediaLink> Links { get; set; }
	}
}
