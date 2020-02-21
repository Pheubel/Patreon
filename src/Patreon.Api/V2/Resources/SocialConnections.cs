using Patreon.Api.Core.V2.Resources;
using Patreon.Api.V2.Resources.Socials;

namespace Patreon.Api.V2.Resources
{
    public class SocialConnections : ISocialConnections
    {
        public DeviantArt DeviantArt { get; internal set; }
        public Discord Discord { get; internal set; }
        public Facebook Facebook { get; internal set; }
        public Google Google { get; internal set; }
        public Instagram Instagram { get; internal set; }
        public Spotify Spotify { get; internal set; }
        public Twitch Twitch { get; internal set; }
        public Twitter Twitter { get; internal set; }
        public Youtube Youtube { get; internal set; }

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
