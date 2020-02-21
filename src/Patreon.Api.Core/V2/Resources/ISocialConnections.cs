namespace Patreon.Api.Core.V2.Resources
{
    public interface ISocialConnections
    {
        IAuhorizedApp DeviantArt { get; }
        IAuhorizedApp Discord { get; }
        IAuhorizedApp Facebook { get; }
        IAuhorizedApp Google { get; }
        IAuhorizedApp Instagram { get; }
        IAuhorizedApp Spotify { get; }
        IAuhorizedApp Twitch { get; }
        IAuhorizedApp Twitter { get; }
        IAuhorizedApp Youtube { get; }
    }
}