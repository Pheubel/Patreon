namespace Patreon.Api.V2.Core.Resources
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
