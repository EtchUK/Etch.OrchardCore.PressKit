using OrchardCore.ContentFields.Fields;
using OrchardCore.ContentManagement;

namespace Etch.OrchardCore.PressKit.ViewModels
{
    public class PressKitPlatform
    {
        public string Name { get; set; }
        public string Url { get; set; }

        public PressKitPlatform(ContentItem contentItem)
        {
            var part = contentItem.Get<ContentPart>("PressKitPlatform");

            if (part == null)
            {
                return;
            }

            Name = part.Get<TextField>(nameof(Name))?.Text;
            Url = part.Get<TextField>(nameof(Url))?.Text;
        }
    }
}
