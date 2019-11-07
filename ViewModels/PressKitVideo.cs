using OrchardCore.ContentFields.Fields;
using OrchardCore.ContentManagement;

namespace Etch.OrchardCore.PressKit.ViewModels
{
    public class PressKitVideo
    {
        public string Platform { get; set; }
        public string Title { get; set; }
        public string VideoLinkUrl { get; set; }
        public string VideoEmbedUrl { get; set; }

        public PressKitVideo(ContentItem contentItem)
        {
            var part = contentItem.Get<ContentPart>("PressKitVideo");

            if (part == null)
            {
                return;
            }

            Platform = part.Get<TextField>(nameof(Platform))?.Text;
            Title = contentItem.DisplayText;
            VideoLinkUrl = part.Get<TextField>(nameof(VideoLinkUrl))?.Text;
            VideoEmbedUrl = part.Get<TextField>(nameof(VideoEmbedUrl))?.Text;
        }
    }
}
