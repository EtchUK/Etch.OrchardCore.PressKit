using OrchardCore.ContentManagement;
using OrchardCore.Media.Fields;
using System.Linq;

namespace Etch.OrchardCore.PressKit.ViewModels
{
    public class PressKitImages
    {
        public string ArchivePath { get; set; }

        public string[] Paths { get; set; }

        public PressKitImages(ContentItem contentItem)
        {
            var part = contentItem.Get<ContentPart>("Images");

            if (part == null)
            {
                return;
            }

            ArchivePath = part.Get<MediaField>("Zip")?.Paths.FirstOrDefault();
            Paths = part.Get<MediaField>("Images")?.Paths;
        }
    }
}
