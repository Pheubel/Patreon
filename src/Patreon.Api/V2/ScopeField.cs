using System;
using System.Collections.Generic;
using System.Text;

namespace Patreon.Api.V2
{
    [Flags]
    public enum ScopeField
    {
        Identity = 1 << 0,
        IdentityEmail = Identity | (1 << 1),
        IdentityMemberships = Identity | (1 << 2),
        Campaigns = 1 << 3,
        CampaignMembers = Campaigns | (1 << 4),
        CampaignMemberEmails = CampaignMembers | (1 << 5),
        CampaignMemberAdresses = CampaignMembers | (1 << 6),
        CampaignPosts = Campaigns | (1 << 7),
        CampaignWebhooks = 1 << 8
    }

    public static class ScopeUtility
    {
        private static Dictionary<string, ScopeField> _mapping = new Dictionary<string, ScopeField>(capacity: 9)
        {
            ["identity"] = ScopeField.Identity,
            ["identity[email]"] = ScopeField.IdentityEmail,
            ["identity.memberships"] = ScopeField.IdentityMemberships,
            ["campaigns"] = ScopeField.Campaigns,
            ["campaigns.members"] = ScopeField.CampaignMembers,
            ["campaigns.members[email]"] = ScopeField.CampaignMemberEmails,
            ["campaigns.members.address"] = ScopeField.CampaignMemberAdresses,
            ["campaigns.posts"] = ScopeField.CampaignPosts,
            ["w:campaigns.webhook"] = ScopeField.CampaignWebhooks
        };

        public static string ToScopeString(ScopeField scope)
        {
            return string.Concat(
                    scope.HasFlag(ScopeField.Identity) ? "identity " : string.Empty,
                    scope.HasFlag(ScopeField.IdentityEmail) ? "identity[email] " : string.Empty,
                    scope.HasFlag(ScopeField.IdentityMemberships) ? "identity.memberships " : string.Empty,
                    scope.HasFlag(ScopeField.Campaigns) ? "campaigns " : string.Empty,
                    scope.HasFlag(ScopeField.CampaignMembers) ? "campaigns.members" : string.Empty,
                    scope.HasFlag(ScopeField.CampaignMemberEmails) ? "campaigns.members[email] " : string.Empty,
                    scope.HasFlag(ScopeField.CampaignMemberAdresses) ? "campaigns.members.address " : string.Empty,
                    scope.HasFlag(ScopeField.CampaignPosts) ? "campaigns.posts " : string.Empty,
                    scope.HasFlag(ScopeField.CampaignWebhooks) ? "w:campaigns.webhook " : string.Empty
                );
        }

        public static ScopeField ParseScopeString(string scopeString)
        {
            var scopeValueStrings = scopeString.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            ScopeField scopeValue = 0;

            for (int i = 0; i < scopeValueStrings.Length; i++)
            {
                scopeValue |= _mapping[scopeValueStrings[i]];
            }

            return scopeValue;
        }
    }
}
