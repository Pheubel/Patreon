using System;
using System.Collections.Generic;
using System.Text;

namespace Patreon.Api.V2.Core.Resources
{
    public interface ITier
    {
        int AmountCents { get; }
        int UserLimit { get; }
        int? Remaining { get; }
        string Description { get; }
        bool RequiresShipping { get; }
        DateTime CreatedAt { get; }
        string Url { get; }
        int PatronCount { get; }
        int PostCount { get; }
        string Title { get; }
        string ImageUrl { get; }
        DateTime EditedAt { get; }
        bool Published { get; }
        DateTime? PublishedAt { get; }
        DateTime? UnpublishedAt { get; }
    }
}
