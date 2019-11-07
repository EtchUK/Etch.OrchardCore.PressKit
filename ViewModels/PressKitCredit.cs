using OrchardCore.ContentFields.Fields;
using OrchardCore.ContentManagement;

namespace Etch.OrchardCore.PressKit.ViewModels
{
    public class PressKitCredit
    {
        public string Fullname { get; set; }
        public string LinkUrl { get; set; }
        public string Role { get; set; }

        public PressKitCredit(ContentItem contentItem)
        {
            var part = contentItem.Get<ContentPart>("PressKitCredit");

            if (part == null)
            {
                return;
            }

            Fullname = part.Get<TextField>(nameof(Fullname))?.Text;
            LinkUrl = part.Get<TextField>(nameof(LinkUrl))?.Text;
            Role = part.Get<TextField>(nameof(Role))?.Text;
        }
    }
}
