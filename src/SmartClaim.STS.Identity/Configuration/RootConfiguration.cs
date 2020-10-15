using SmartClaim.Shared.Configuration.Identity;
using SmartClaim.STS.Identity.Configuration.Interfaces;

namespace SmartClaim.STS.Identity.Configuration
{
    public class RootConfiguration : IRootConfiguration
    {      
        public AdminConfiguration AdminConfiguration { get; } = new AdminConfiguration();
        public RegisterConfiguration RegisterConfiguration { get; } = new RegisterConfiguration();
    }
}





