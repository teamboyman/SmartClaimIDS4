﻿using System.Collections.Generic;
using SmartClaim.Admin.Configuration.Identity;

namespace SmartClaim.Admin.Configuration.IdentityServer
{
    public class Client : global::IdentityServer4.Models.Client
    {
        public List<Claim> ClientClaims { get; set; } = new List<Claim>();
    }
}






