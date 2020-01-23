using Patreon.Api.V2.Resources;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patreon.Api.V2.Core.Resources
{
    public interface IWebhook<TTrigger>
        where TTrigger : struct, Enum
    {
        TTrigger Triggers { get; }
        Uri Uri { get; }
        bool Paused { get; }
        DateTime LastAttemptedAt { get; }
        int NumConsecutiveTimesFailed { get; }
        string Secret { get; }
    }
}
