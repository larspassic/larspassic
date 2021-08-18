﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Microsoft.Graph;
using TimeZoneConverter;

namespace GraphTutorial.Graph
{
    public class GraphHelper
    {
        private static DeviceCodeCredential tokenCredential;
        private static GraphServiceClient graphClient;

        public static void Initialize(
            string clientId,
            string[] scopes,
            Func<DeviceCodeInfo, CancellationToken, Task> callBack)
        {
            tokenCredential = new DeviceCodeCredential(callBack, clientId);
            graphClient = new GraphServiceClient(tokenCredential, scopes);
        }

        public static async Task<string> GetAccessTokenAsync(string[] scopes)
        {
            var context = new TokenRequestContext(scopes);
            var response = await tokenCredential.GetTokenAsync(context);
            return response.Token;
        }
    }
}
