using OrchardCore.ContentFields.Fields;
using OrchardCore.ContentManagement;
using OrchardCore.Flows.Models;
using System.Linq;

namespace Etch.OrchardCore.PressKit.ViewModels
{
    public class PressKitFactsheet
    {
        public string Developer { get; set; }
        public string DeveloperLocation { get; set; }
        public string DeveloperWebsite { get; set; }
        public string Game { get; set; }
        public PressKitPlatform[] Platforms { get; set; } = new PressKitPlatform[0];
        public string ReleaseDate { get; set; }
        public string RegularPrice { get; set; }
        public string Website { get; set; }

        public PressKitFactsheet(ContentItem contentItem)
        {
            var part = contentItem.Get<ContentPart>("Factsheet");

            if (part == null)
            {
                return;
            }

            Developer = part.Get<TextField>(nameof(Developer))?.Text;
            DeveloperLocation = part.Get<TextField>(nameof(DeveloperLocation))?.Text;
            DeveloperWebsite = part.Get<TextField>(nameof(DeveloperWebsite))?.Text;
            ReleaseDate = part.Get<TextField>(nameof(ReleaseDate))?.Text;
            RegularPrice = part.Get<TextField>(nameof(RegularPrice))?.Text;
            Website = part.Get<TextField>(nameof(Website))?.Text;

            part = contentItem.Get<ContentPart>("PressKit");

            if (part == null)
            {
                return;
            }

            Game = part.Get<TextField>(nameof(Game))?.Text;

            var platforms = contentItem.Get<BagPart>("Platforms");

            if (platforms == null)
            {
                return;
            }

            Platforms = platforms.ContentItems.Select(x => new PressKitPlatform(x)).ToArray();
        }
    }
}
