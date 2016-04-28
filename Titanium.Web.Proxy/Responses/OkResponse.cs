﻿using System;
using Titanium.Web.Proxy.Models;
using Titanium.Web.Proxy.Network;

namespace Titanium.Web.Proxy.Responses
{
    public class OkResponse : Response
    {
        public OkResponse()
        {
            ResponseStatusCode = "200";
            ResponseStatusDescription = "Ok";
        }
    }
}