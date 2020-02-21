using Patreon.Api.Core.V2.Resources;
using Patreon.Api.V2.Resources.Socials;

namespace Patreon.Api.V2.Resources
{
    public class SocialConnections : ISocialConnections
    {
        public DeviantArtApp DeviantArt { get; internal set; }
        public DiscordApp Discord { get; internal set; }
        public FacebookApp Facebook { get; internal set; }
        public GoogleApp Google { get; internal set; }
        public InstagramApp Instagram { get; internal set; }
        public SpotifyApp Spotify { get; internal set; }
        public TwitchApp Twitch { get; internal set; }
        public TwitterApp Twitter { get; internal set; }
        public YoutubeApp Youtube { get; internal set; }

        IAuhorizedApp ISocialConnections.DeviantArt => DeviantArt;
        IAuhorizedApp ISocialConnections.Discord => Discord;
        IAuhorizedApp ISocialConnections.Facebook => Facebook;
        IAuhorizedApp ISocialConnections.Google => Google;
        IAuhorizedApp ISocialConnections.Instagram => Instagram;
        IAuhorizedApp ISocialConnections.Spotify => Spotify;
        IAuhorizedApp ISocialConnections.Twitch => Twitch;
        IAuhorizedApp ISocialConnections.Twitter => Twitter;
        IAuhorizedApp ISocialConnections.Youtube => Youtube;
    }
}
