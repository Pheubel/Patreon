using System;

namespace Patreon.Api.V2.Core.Resources
{
    public interface ICampaign : IPatreonResource
    {
        string? Summary { get; }
        string? CreationName { get; }
        string? PayPername { get;  }
        string? OneLiner { get;  }
        string? MainVideoEmbed { get;  }
        string? MainVideoUrl { get;  }
        string ImageUrl { get;  }
        string ImageSmallUrl { get;  }
        string? ThanksVideoUrl { get;  }
        string? ThanksEmbed { get;  }
        string? ThanksMessage { get;  }
        bool IsMonthly { get;  }
        bool HasRss { get;  }
        bool HasSentRssNotification { get;  }
        string RssFeedTitle { get;  }
        string? RssArtworkUrl { get;  }
        bool IsNsfw { get;  }
        bool IsChargedImmediately { get;  }
        DateTime CreatedAt { get;  }
        DateTime? PublishedAt { get;  }
        string PledgeUrl { get;  }
    }
}
