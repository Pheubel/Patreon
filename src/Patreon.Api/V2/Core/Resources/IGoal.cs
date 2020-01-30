﻿using Patreon.Api.V2.Resources;
using System;

namespace Patreon.Api.V2.Core.Resources
{
    public interface IGoal : IPatreonResource
    {
        /// <summary> The goal amount in USD cents.</summary>
        int AmountCents { get; }
        /// <summary> The title of the goal.</summary>
        string Title { get; }
        /// <summary> The goal description.</summary>
        string Description { get; }
        /// <summary> When the goal was created for the campaign.</summary>
        DateTime CreatedAt { get; }
        /// <summary> When the campaign reached the goal.</summary>
        DateTime? ReachedAt { get; }
        /// <summary> The whole-number representation of the pledge sum compared to the pledge goal.</summary>
        int CompletedPercentage { get; }

        /// <summary> The campaign the goal is set for.</summary>
        Campaign Campaign { get; }
    }
}
