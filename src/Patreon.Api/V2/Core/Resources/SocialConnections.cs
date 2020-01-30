using Patreon.Api.V2.Core.Resources.Socials;

namespace Patreon.Api.V2.Core.Resources
{
    public class SocialConnections
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

        internal SocialConnections() { }
    }
}