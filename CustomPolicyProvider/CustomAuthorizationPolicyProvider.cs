using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthBasics.CustomPolicyProvider
{
    public static class DynamicPolicies
    {
        public const string SecurityLevel = "SecurityLevel";
        public const string Rank = "Rank";
    }
    public class CustomAuthorizationPolicyProvider : DefaultAuthorizationPolicyProvider
    {
        public CustomAuthorizationPolicyProvider(IOptions<AuthorizationOptions> options) : base(options)
        {

        }
        public override Task<AuthorizationPolicy> GetPolicyAsync(string policyName)
        {
            return base.GetPolicyAsync(policyName);
        }
    }
}
