using OrchardCore.ContentManagement;
using OrchardCore.Media.Fields;
using System.Linq;

namespace Etch.OrchardCore.PressKit.ViewModels
{
    public class PressKitLogoIcon
    {
        public string ArchivePath { get; set; }

        public string Icon { get; set; }
        public string Logo { get; set; }

        public PressKitLogoIcon(ContentItem contentItem)
        {
            var part = contentItem.Get<ContentPart>("LogoIcon");

            if (part == null)
            {
                return;
            }

            ArchivePath = part.Get<MediaField>("Zip")?.Paths.FirstOrDefault();
            Icon = part.Get<MediaField>("Icon")?.Paths.FirstOrDefault();
            Logo = part.Get<MediaField>("Logo")?.Paths.FirstOrDefault();
        }
    }
}
