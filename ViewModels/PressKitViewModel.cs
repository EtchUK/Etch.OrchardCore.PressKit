using OrchardCore.ContentManagement;
using OrchardCore.Flows.Models;
using OrchardCore.Media.Fields;
using System.Collections.Generic;
using System.Linq;

namespace Etch.OrchardCore.PressKit.ViewModels
{
    public class PressKitViewModel
    {
        #region Properties

        public ContentItem ContentItem { get; set; }

        public string HeaderImagePath { get; set; }

        public PressKitArticle[] Articles { get; set; } = new PressKitArticle[0];
        public PressKitContact[] Contacts { get; set; } = new PressKitContact[0];
        public PressKitCredit[] Credits { get; set; } = new PressKitCredit[0];
        public IList<dynamic> Description { get; set; }
        public PressKitFactsheet Factsheet { get; set; }
        public PressKitFeature[] Features { get; set; } = new PressKitFeature[0];
        public IList<dynamic> History { get; set; }
        public PressKitImages Images { get; set; }
        public PressKitLink[] Links { get; set; } = new PressKitLink[0];
        public PressKitLogoIcon LogoIcon { get; set; }
        public PressKitStudio Studio { get; set; }
        public PressKitVideo[] Videos { get; set; } = new PressKitVideo[0];

        #endregion

        #region Constructor

        public PressKitViewModel(ContentItem contentItem)
        {
            ContentItem = contentItem;

            Factsheet = new PressKitFactsheet(contentItem);
            Images = new PressKitImages(contentItem);
            LogoIcon = new PressKitLogoIcon(contentItem);
            Studio = new PressKitStudio(contentItem);

            #region Header Image

            var pressKitPart = contentItem.Get<ContentPart>("PressKit");

            if (pressKitPart != null)
            {
                HeaderImagePath = pressKitPart.Get<MediaField>("HeaderImage")?.Paths.FirstOrDefault();
            }

            #endregion

            #region Articles

            var bagPart = contentItem.Get<BagPart>("SelectedArticles");

            if (bagPart != null)
            {
                Articles = bagPart.ContentItems.Select(x => new PressKitArticle(x)).ToArray();
            }

            #endregion

            #region Contacts

            bagPart = contentItem.Get<BagPart>("Contact");

            if (bagPart != null)
            {
                Contacts = bagPart.ContentItems.Select(x => new PressKitContact(x)).ToArray();
            }

            #endregion

            #region Credits

            bagPart = contentItem.Get<BagPart>("Credits");

            if (bagPart != null)
            {
                Credits = bagPart.ContentItems.Select(x => new PressKitCredit(x)).ToArray();
            }

            #endregion

            #region Features

            bagPart = contentItem.Get<BagPart>("Features");

            if (bagPart != null)
            {
                Features = bagPart.ContentItems.Select(x => new PressKitFeature(x)).ToArray();
            }

            #endregion

            #region Videos

            bagPart = contentItem.Get<BagPart>("Videos");

            if (bagPart != null)
            {
                Videos = bagPart.ContentItems.Select(x => new PressKitVideo(x)).ToArray();
            }

            #endregion
        }

        #endregion
    }
}
