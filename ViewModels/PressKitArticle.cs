using OrchardCore.ContentFields.Fields;
using OrchardCore.ContentManagement;

namespace Etch.OrchardCore.PressKit.ViewModels
{
    public class PressKitArticle
    {
        public string Author { get; set; }
        public string PlatformUrl { get; set; }
        public string PlatformText { get; set; }
        public string Quote { get; set; }

        public PressKitArticle(ContentItem contentItem)
        {
            var part = contentItem.Get<ContentPart>("PressKitSelectedArticle");

            if (part == null)
            {
                return;
            }

            Author = part.Get<TextField>(nameof(Author))?.Text;
            PlatformUrl = part.Get<TextField>(nameof(PlatformUrl))?.Text;
            PlatformText = part.Get<TextField>(nameof(PlatformText))?.Text;
            Quote = part.Get<TextField>(nameof(Quote))?.Text;
        }
    }
}
