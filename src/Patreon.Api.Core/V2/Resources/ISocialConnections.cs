namespace Patreon.Api.Core.V2.Resources
{
    /// <summary> A representation of the applications that can be authorized on the patreon app.</summary>
    public interface ISocialConnections
    {
        /// <summary> The application authorization data of DeviantArt.</summary>
        IAuhorizedApp DeviantArt { get; }
        /// <summary> The application authorization data of Discord.</summary>
        IAuhorizedApp Discord { get; }
        /// <summary> The application authorization data of Facebook.</summary>
        IAuhorizedApp Facebook { get; }
        /// <summary> The application authorization data of Google.</summary>
        IAuhorizedApp Google { get; }
        /// <summary> The application authorization data of Instagram.</summary>
        IAuhorizedApp Instagram { get; }
        /// <summary> The application authorization data of Spotify.</summary>
        IAuhorizedApp Spotify { get; }
        /// <summary> The application authorization data of Twitch.</summary>
        IAuhorizedApp Twitch { get; }
        /// <summary> The application authorization data of Twitter.</summary>
        IAuhorizedApp Twitter { get; }
        /// <summary> The application authorization data of Youtube.</summary>
        IAuhorizedApp Youtube { get; }
    }
}