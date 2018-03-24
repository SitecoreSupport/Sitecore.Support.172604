using Sitecore.Modules.EmailCampaign.Messages;
using Sitecore.Modules.EmailCampaign.Core.Services;

namespace Sitecore.Support.Modules.EmailCampaign.Core.Services
{
  public class DedicatedServersService : Sitecore.Modules.EmailCampaign.Core.Services.DedicatedServersService
  {
    public override int Status(MessageItem message, out int totalNumServers)
    {
      return base.Status(message, out totalNumServers);
    }
  }
}