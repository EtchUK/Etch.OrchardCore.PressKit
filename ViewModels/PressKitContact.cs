using OrchardCore.ContentFields.Fields;
using OrchardCore.ContentManagement;

namespace Etch.OrchardCore.PressKit.ViewModels
{
    public class PressKitContact
    {
        public string LinkText { get; set; }
        public string LinkUrl { get; set; }
        public string Platform { get; set; }

        public PressKitContact(ContentItem contentItem)
        {
            var part = contentItem.Get<ContentPart>("PressKitContact");

            if (part == null)
            {
                return;
            }

            LinkText = part.Get<LinkField>("Link")?.Text;
            LinkUrl = part.Get<LinkField>("Link")?.Url;
            Platform = part.Get<TextField>(nameof(Platform))?.Text;
        }
    }
}
