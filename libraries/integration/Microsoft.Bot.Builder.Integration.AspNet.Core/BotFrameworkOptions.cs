﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using BotMiddleware = Microsoft.Bot.Builder.Middleware;
using Microsoft.Bot.Connector.Authentication;

namespace Microsoft.Bot.Builder.Integration.AspNet.Core
{
    public class BotFrameworkOptions
    {
        private readonly List<BotMiddleware.IMiddleware> _middleware;

        public BotFrameworkOptions()
        {
            _middleware = new List<BotMiddleware.IMiddleware>();
        }

        public ICredentialProvider CredentialProvider { get; set; }
        public IList<BotMiddleware.IMiddleware> Middleware { get => _middleware; }
        public bool EnableProactiveMessages { get; set; }
    }
}
