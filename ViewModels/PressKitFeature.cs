using OrchardCore.ContentFields.Fields;
using OrchardCore.ContentManagement;

namespace Etch.OrchardCore.PressKit.ViewModels
{
    public class PressKitFeature
    {
        public string Text { get; set; }

        public PressKitFeature(ContentItem contentItem)
        {
            var part = contentItem.Get<ContentPart>("PressKitFeature");

            if (part == null)
            {
                return;
            }

            Text = part.Get<TextField>(nameof(Text))?.Text;
        }
    }
}
