using Patreon.Api.V2.Resources;
using System;
using System.Collections.Generic;

namespace Patreon.Api.V2.Core.Resources
{
    public interface ITier : IPatreonResource<int>
    {
        /// <summary> Monetary amount associeted with this tier.</summary>
        int AmountCents { get; }
        /// <summary> The maximum number of patrons this tier is limited to, if applicable.</summary>
        int? UserLimit { get; }
        /// <summary> The remaining number of patrons who may subscribe to this tier if thre is a user limit.</summary>
        int? Remaining { get; }
        /// <summary> The tier diplay description.</summary>
        string Description { get; }
        /// <summary> Determines if te tier requires a shipping address from patrons.</summary>
        bool RequiresShipping { get; }
        /// <summary> When thist tier was created.</summary>
        DateTime CreatedAt { get; }
        /// <summary> The fully quaified URL associated with this tier.</summary>
        string Url { get; }
        /// <summary> The number of patrons currently registered for this tier.</summary>
        int PatronCount { get; }
        /// <summary> The number of posts published to this tier.</summary>
        int PostCount { get; }
        /// <summary> The discord role ID's granted by this tier.</summary>
        IReadOnlyCollection<ulong> DiscordRoleIds { get; }
        /// <summary> The tier display title.</summary>
        string Title { get; }
        /// <summary> The full qualified image URL associated with this tier.</summary>
        string ImageUrl { get; }
        /// <summary> When the tier was last modified.</summary>
        DateTime EditedAt { get; }
        /// <summary> Determines if the tier is currently published.</summary>
        bool Published { get; }
        /// <summary> When the tier was published.</summary>
        DateTime? PublishedAt { get; }
        /// <summary> When the tier was published.</summary>
        DateTime? UnpublishedAt { get; }

        /// <summary> The campaign the tier belongs to.</summary>
        Campaign Campaign { get; }
        /// <summary> The image file associated with the tier.</summary>
        Media Media { get; }
        /// <summary> The benefits attached to the tier.</summary>
        IReadOnlyCollection<Benefit> Benefits { get; }
       
    }
}
