namespace Patreon.Api.Core.V2.Resources
{
    public interface IPatreonResource
    {
        string IdString { get; }
    }

    public interface IPatreonResource<TIdentifier> : IPatreonResource
    {
        TIdentifier Id { get; }
    }
}
