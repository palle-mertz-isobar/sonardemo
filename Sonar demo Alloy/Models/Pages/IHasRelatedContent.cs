using EPiServer.Core;

namespace Sonar_demo_Alloy.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
