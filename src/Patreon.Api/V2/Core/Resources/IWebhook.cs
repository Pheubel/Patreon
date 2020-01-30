﻿using Patreon.Api.V2.Resources;
using System;

namespace Patreon.Api.V2.Core.Resources
{
    public interface IWebhook<TTrigger>
        where TTrigger : struct, Enum
    {
        /// <summary> The events that will trigger the webhook.</summary>
        TTrigger Triggers { get; }
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
        OAuthClient Client { get; }
        /// <summary> The campaign whose events trigger the webhook.</summary>
        Campaign Campaign { get; }
    }
}
