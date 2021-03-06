﻿using System;

namespace Patreon.Api.Core.V2.Resources
{
    /// <summary> A container of  webhoook's data.</summary>
    public interface IWebhook : IPatreonResource<int>
    {
        /// <summary> The events that will trigger the webhook.</summary>
        Enum Triggers { get; }
        /// <summary> The fully qualifier URI where the webhook will be sent.</summary>
        Uri Uri { get; }
        /// <summary> Determined if the webhook is paused by repeated failed attempts.</summary>
        bool Paused { get; }
        /// <summary> When the last attempt of triggering the webhook occured.</summary>
        DateTime LastAttemptedAt { get; }
        /// <summary> The number of time sthe webhook has failed onecutively.</summary>
        int NumConsecutiveTimesFailed { get; }
        /// <summary> The secret used to sign the webhook mesage body for verifying authenticity.</summary>
        string Secret { get; }

        /// <summary> The oauth client which created the webhook.</summary>
        IOAuthClient Client { get; }
        /// <summary> The campaign whose events trigger the webhook.</summary>
        ICampaign Campaign { get; }
    }

    /// <inheritdoc/>
    /// <typeparam name="TTrigger"> The type to use for managing the triggers the webhook uses.</typeparam>
    public interface IWebhook<TTrigger> : IWebhook
        where TTrigger : struct, Enum
    {
        /// <summary> The events that will trigger the webhook.</summary>
        new TTrigger Triggers { get; }
    }
}
