using Riok.Mapperly.Abstractions;

namespace MapperlyRepro;

public sealed class Source
{
	public int Id { get; set; }
	public string Name { get; set; }
	public DateTime? NotInTarget { get; set; }
}

public sealed record Target(int Id, string Name, DateTime? NotInSource);

[Mapper]
public static partial class Mapper
{
	public static partial IQueryable<Target> Map(IQueryable<Source> sources);
}