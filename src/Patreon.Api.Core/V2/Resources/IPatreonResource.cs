namespace Patreon.Api.Core.V2.Resources
{
    /// <summary> A resource available from the patreon API.</summary>
    public interface IPatreonResource
    {
        /// <summary> The string representation of the resource identifier.</summary>
        string Id { get; }
    }

    /// <inheritdoc/>
    /// <typeparam name="TIdentifier"> The type to reresent the resource identifier.</typeparam>
    public interface IPatreonResource<TIdentifier> : IPatreonResource
    {
        /// <summary> The resource identifier.</summary>
        new TIdentifier Id { get; }
    }
}
