using OrchardCore.ContentFields.Fields;
using OrchardCore.ContentManagement;

namespace Etch.OrchardCore.PressKit.ViewModels
{
    public class PressKitStudio
    {
        public string Boilerplate { get; set; }
        public string MoreInformation { get; set; }

        public PressKitStudio(ContentItem contentItem)
        {
            var part = contentItem.Get<ContentPart>("Studio");

            if (part == null)
            {
                return;
            }

            Boilerplate = part.Get<TextField>(nameof(Boilerplate))?.Text;
            MoreInformation = part.Get<TextField>(nameof(MoreInformation))?.Text;
        }
    }
}
