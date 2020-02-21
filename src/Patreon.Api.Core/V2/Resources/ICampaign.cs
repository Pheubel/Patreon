using System;
using System.Collections.Generic;

namespace Patreon.Api.Core.V2.Resources
{
    /// <summary> A container representing campaign data.</summary>
    public interface ICampaign : IPatreonResource<int>
    {
        /// <summary> The summary of the campaign.</summary>
        string Summary { get; }
        /// <summary> The type of content the creator is creating.</summary>
        string CreationName { get; }
        /// <summary> The thing which patrons are paying per.</summary>
        string PayPername { get; }
        /// <summary> The one-liner for this campaign.</summary>
        string OneLiner { get; }
        /// <summary> The embed for the main video of the campaign.</summary>
        string MainVideoEmbed { get; }
        /// <summary> The embed for the main video of the campaign.</summary>
        string MainVideoUrl { get; }
        /// <summary> The banner image URL for the campaign.</summary>
        string ImageUrl { get; }
        /// <summary> The URL fo the campaign's profile image.</summary>
        string ImageSmallUrl { get; }
        /// <summary> The URL for the thanks video shown after pledging to this campaign.</summary>
        string ThanksVideoUrl { get; }
        /// <summary> The embed for the thanks video shown after pledging to this campaign.</summary>
        string ThanksEmbed { get; }
        /// <summary> The thanks message shown to patrons after pledging to this campaign.</summary>
        string ThanksMessage { get; }
        /// <summary> Determines if this campaign charges on a monthly basis.</summary>
        bool IsMonthly { get; }
        /// <summary> Determines whether this user has opted-in to RSS feeds.</summary>
        bool HasRss { get; }
        /// <summary> Determines wheter or not the creator has sent a one-time RSS notification email.</summary>
        bool HasSentRssNotification { get; }
        /// <summary> The title of the RSS feed.</summary>
        string RssFeedTitle { get; }
        /// <summary> The URL for the RSS album artwork.</summary>
        string RssArtworkUrl { get; }
        /// <summary> Determines if the creator has marked this campaign as containing NSFW content.</summary>
        bool IsNsfw { get; }
        /// <summary> Determines if the campaign charges upfront.</summary>
        bool IsChargedImmediately { get; }
        /// <summary> The date that the creator created the campaign.</summary>
        DateTime CreatedAt { get; }
        /// <summary> The date the creator published the campaign.</summary>
        DateTime? PublishedAt { get; }
        /// <summary> The relative URL for the pledge checkout flow for this campaign.</summary>
        string PledgeUrl { get; }
        /// <summary> The number of patrons pledging to this creator.</summary>
        int PatronCount { get; }
        /// <summary> The ID of the external discord server that is linked to this campaign.</summary>
        ulong? DiscordServerId { get; }
        /// <summary> The id of the Google Analytics tracker that the creator wants metrics sent to.</summary>
        string GoogleAnalyticsId { get; }
        /// <summary> Determines whether the campaing's total earnings are shown publicly.</summary>
        bool ShowEarnings { get; }
        /// <summary> The campaign's vanity.</summary>
        string Vanity { get; }
        /// <summary> A URL to access this campaign.</summary>
        string Url { get; }

        /// <summary> The tiers in this campaign.</summary>
        IReadOnlyCollection<ITier> Tiers { get; }
        /// <summary> The owner of the campaign.</summary>
        IUser Creator { get; }
        /// <summary> The benefits in this campaign.</summary>
        IReadOnlyCollection<IBenefit> Benefits { get; }
        /// <summary> The goals set for this campaign.</summary>
        IReadOnlyCollection<IGoal> Goals { get; }
    }
}
