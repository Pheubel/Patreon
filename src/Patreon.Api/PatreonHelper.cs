using Patreon.Api.V2.Builders;
using Patreon.Api.V2.Resources;
using System;
using System.Text;

namespace Patreon.Api.V2
{
    internal static class PatreonHelper
    {
        public static readonly ReadOnlyMemory<byte> DataToken = Encoding.UTF8.GetBytes("data");
        public static readonly ReadOnlyMemory<byte> AttributeToken = Encoding.UTF8.GetBytes("attributes");
        public static readonly ReadOnlyMemory<byte> IdToken = Encoding.UTF8.GetBytes("id");
        public static readonly ReadOnlyMemory<byte> IncludeToken = Encoding.UTF8.GetBytes("included");
        public static readonly ReadOnlyMemory<byte> RelationshipToken = Encoding.UTF8.GetBytes("relationships");
        public static readonly ReadOnlyMemory<byte> TypeToken = Encoding.UTF8.GetBytes("type");

        public static StringBuilder AppendIncludeString(StringBuilder sb, IdentityBuilder.IncludeRelation relation)
        {
            int startLength = sb.Length;

            if (relation.HasFlag(IdentityBuilder.IncludeRelation.Campaign))
            {
                sb.Append("campaign,");

                if (relation.HasFlag(IdentityBuilder.IncludeRelation.CampaignTiers))
                    sb.Append("campaign.tiers,");
                if (relation.HasFlag(IdentityBuilder.IncludeRelation.CampaignGoals))
                    sb.Append("campaign.goals,");
                if (relation.HasFlag(IdentityBuilder.IncludeRelation.CampaignBenefits))
                    sb.Append("campaign.benefits,");
                if (relation.HasFlag(IdentityBuilder.IncludeRelation.CampaignTierMedia))
                    sb.Append("campaign.tiers.tier_media,");
                if (relation.HasFlag(IdentityBuilder.IncludeRelation.CampaignDeliverables))
                    sb.Append("campaign.benefits.deliverables,");
            }

            if (relation.HasFlag(IdentityBuilder.IncludeRelation.Memberships))
            {
                sb.Append("memberships,");

                if (relation.HasFlag(IdentityBuilder.IncludeRelation.MembershipCampaigns))
                    sb.Append("memberships.campaign,");
                if (relation.HasFlag(IdentityBuilder.IncludeRelation.MembershipCampaignCreator))
                    sb.Append("memberhip.campaign.creator,");
                if (relation.HasFlag(IdentityBuilder.IncludeRelation.MembershipPledgeHistory))
                    sb.Append("memberhips.pledge_history,");
                if (relation.HasFlag(IdentityBuilder.IncludeRelation.MembershipCurrentlyEntitledTiers))
                    sb.Append("memberships.currently_entitled_tiers,");
                if (relation.HasFlag(IdentityBuilder.IncludeRelation.MembershipCurrentBenefits))
                    sb.Append("memberships.currently_entitled_tiers.benefits,");
                if (relation.HasFlag(IdentityBuilder.IncludeRelation.MembershipCurrentlyEntitledDeliverables))
                    sb.Append("memberships.currently_entitled_tiers.benefits.deliverables,");
                if (relation.HasFlag(IdentityBuilder.IncludeRelation.MembershipAddresses))
                    sb.Append("memberships.address,");
                if (relation.HasFlag(IdentityBuilder.IncludeRelation.MembershipCampaignBenefits))
                    sb.Append("memberships.campaign.benefits,");
                if (relation.HasFlag(IdentityBuilder.IncludeRelation.MembershipCampaignTiers))
                    sb.Append("memberships.campaign.tiers,");
                if (relation.HasFlag(IdentityBuilder.IncludeRelation.MembershipCampaignGoals))
                    sb.Append("memberships.campaign.goals,");
                if (relation.HasFlag(IdentityBuilder.IncludeRelation.MembershipCampaignBenefits))
                    sb.Append("memberships.campaign.benefits,");
                if (relation.HasFlag(IdentityBuilder.IncludeRelation.MembershipCampaignTierMedia))
                    sb.Append("memberships.campaign.tiers.tier_media,");
                if (relation.HasFlag(IdentityBuilder.IncludeRelation.MembershipCampaignDeliverables))
                    sb.Append("memberships.campaign.benefits.deliverables,");
            }

            if (sb.Length != startLength)
                sb.Remove(sb.Length - 2, 1);

            return sb;
        }

        internal static StringBuilder AppendMemberIncludeString(StringBuilder sb, Member.IncludeField memberInclude)
        {
            int startLength = sb.Length;

            if (memberInclude.HasFlag(Member.IncludeField.IncludesPatronStatus))
                sb.Append(",");
            if (memberInclude.HasFlag(Member.IncludeField.IncludesIsFollower))
                sb.Append(",");
            if (memberInclude.HasFlag(Member.IncludeField.IncludesFullName))
                sb.Append(",");
            if (memberInclude.HasFlag(Member.IncludeField.IncludesEmail))
                sb.Append(",");
            if (memberInclude.HasFlag(Member.IncludeField.IncludesPledgeRelationshipStart))
                sb.Append(",");
            if (memberInclude.HasFlag(Member.IncludeField.IncludesLifetimeSupportCents))
                sb.Append(",");
            if (memberInclude.HasFlag(Member.IncludeField.IncludesCurrentlyEntitledAmountCents))
                sb.Append(",");
            if (memberInclude.HasFlag(Member.IncludeField.IncludesLastChargeDate))
                sb.Append(",");
            if (memberInclude.HasFlag(Member.IncludeField.IncludesLastChargeStatus))
                sb.Append(",");
            if (memberInclude.HasFlag(Member.IncludeField.IncludesNote))
                sb.Append(",");
            if (memberInclude.HasFlag(Member.IncludeField.IncludesWillPayAmountCents))
                sb.Append(",");

            if (sb.Length != startLength)
                sb.Remove(sb.Length - 2, 1);

            return sb;
        }

        internal static string AppendAdressIncludeString(StringBuilder sb, Address.IncludeFlag addressInclude)
        {
            throw new NotImplementedException();
        }

        public static StringBuilder AppendUserIncludeString(StringBuilder sb, User.IncludeFlag userInclude)
        {
            int startLength = sb.Length;

            if (userInclude.HasFlag(User.IncludeFlag.IncludesEmail))
                sb.Append("email,");
            if (userInclude.HasFlag(User.IncludeFlag.IncludesFirstName))
                sb.Append("first_name,");
            if (userInclude.HasFlag(User.IncludeFlag.IncludesLastName))
                sb.Append("last_name,");
            if (userInclude.HasFlag(User.IncludeFlag.IncludesFullName))
                sb.Append("full_name,");
            if (userInclude.HasFlag(User.IncludeFlag.IncludesIsEmailVerified))
                sb.Append("is_email_verified,");
            if (userInclude.HasFlag(User.IncludeFlag.IncludesVanity))
                sb.Append("vanity,");
            if (userInclude.HasFlag(User.IncludeFlag.IncludesAbout))
                sb.Append("about,");
            if (userInclude.HasFlag(User.IncludeFlag.IncludesAvatar))
                sb.Append("image_url,");
            if (userInclude.HasFlag(User.IncludeFlag.IncludesAvatarThumbnail))
                sb.Append("thumb_url,");
            if (userInclude.HasFlag(User.IncludeFlag.IncludesCanSeeNsfw))
                sb.Append("can_see_nsfw,");
            if (userInclude.HasFlag(User.IncludeFlag.IncludesCreatedAt))
                sb.Append("created,");
            if (userInclude.HasFlag(User.IncludeFlag.IncludesLikeCount))
                sb.Append("like_count,");
            if (userInclude.HasFlag(User.IncludeFlag.IncludesHidePledges))
                sb.Append("hide_pledges,");
            if (userInclude.HasFlag(User.IncludeFlag.IncludesSocialConnections))
                sb.Append("social_connections,");
            if (userInclude.HasFlag(User.IncludeFlag.IncludesUrl))
                sb.Append("url,");

            if (sb.Length != startLength)
                sb.Remove(sb.Length - 2, 1);

            return sb;
        }

        public static StringBuilder AppendCampaignIncludeString(StringBuilder sb, Campaign.IncludeField campaignInclude)
        {
            int startLength = sb.Length;

            if (campaignInclude.HasFlag(Campaign.IncludeField.IncludesSummary))
                sb.Append("summary,");
            if (campaignInclude.HasFlag(Campaign.IncludeField.IncludesCreationName))
                sb.Append("creation_name,");
            if (campaignInclude.HasFlag(Campaign.IncludeField.IncludesPayPername))
                sb.Append("pay_per_name,");
            if (campaignInclude.HasFlag(Campaign.IncludeField.IncludesOneLiner))
                sb.Append("one_liner,");
            if (campaignInclude.HasFlag(Campaign.IncludeField.IncludesMainVideoEmbed))
                sb.Append("main_video_embed,");
            if (campaignInclude.HasFlag(Campaign.IncludeField.IncludesMainVideoUrl))
                sb.Append("main_video_url,");
            if (campaignInclude.HasFlag(Campaign.IncludeField.IncludesImageUrl))
                sb.Append("image_url,");
            if (campaignInclude.HasFlag(Campaign.IncludeField.IncludesImageSmallUrl))
                sb.Append("image_small_url,");
            if (campaignInclude.HasFlag(Campaign.IncludeField.IncludesThanksVideoUrl))
                sb.Append("thanks_video_url,");
            if (campaignInclude.HasFlag(Campaign.IncludeField.IncludesThanksEmbed))
                sb.Append("thanks_embed,");
            if (campaignInclude.HasFlag(Campaign.IncludeField.IncludesThanksMessage))
                sb.Append("thanks_msg,");
            if (campaignInclude.HasFlag(Campaign.IncludeField.IncludesIsMonthly))
                sb.Append("is_monthly,");
            if (campaignInclude.HasFlag(Campaign.IncludeField.IncludesHasRss))
                sb.Append("has_rss,");
            if (campaignInclude.HasFlag(Campaign.IncludeField.IncludesHasSentRssNotification))
                sb.Append("has_sent_rss_notify,");
            if (campaignInclude.HasFlag(Campaign.IncludeField.IncludesRssFeedTitle))
                sb.Append("rss_feed_title,");
            if (campaignInclude.HasFlag(Campaign.IncludeField.IncludesRssArtworkUrl))
                sb.Append("rss_artwork_url,");
            if (campaignInclude.HasFlag(Campaign.IncludeField.IncludesIsNsfw))
                sb.Append("is_nsfw,");
            if (campaignInclude.HasFlag(Campaign.IncludeField.IncludesIsChargedImmediately))
                sb.Append("is_charged_immediately,");
            if (campaignInclude.HasFlag(Campaign.IncludeField.IncludesCreatedAt))
                sb.Append("created_at,");
            if (campaignInclude.HasFlag(Campaign.IncludeField.IncludesPublishedAt))
                sb.Append("published_at,");
            if (campaignInclude.HasFlag(Campaign.IncludeField.IncludesPledgeUrl))
                sb.Append("pledge_url,");
            if (campaignInclude.HasFlag(Campaign.IncludeField.IncludesPatronCount))
                sb.Append("patron_count,");
            if (campaignInclude.HasFlag(Campaign.IncludeField.IncludesDiscordServerId))
                sb.Append("discord_server_id,");
            if (campaignInclude.HasFlag(Campaign.IncludeField.IncludesGoogleAnalyticsId))
                sb.Append("google_analytics_id,");
            if (campaignInclude.HasFlag(Campaign.IncludeField.IncludesShowEarings))
                sb.Append("show_earnings,");
            if (campaignInclude.HasFlag(Campaign.IncludeField.IncludesVanity))
                sb.Append("vanity,");
            if (campaignInclude.HasFlag(Campaign.IncludeField.IncludesUrl))
                sb.Append("url,");

            if (sb.Length != startLength)
                sb.Remove(sb.Length - 2, 1);

            return sb;
        }
    }
}
