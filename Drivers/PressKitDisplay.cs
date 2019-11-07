using Etch.OrchardCore.PressKit.Models;
using Etch.OrchardCore.PressKit.ViewModels;
using Microsoft.AspNetCore.Http;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.ContentManagement.Display.Models;
using OrchardCore.DisplayManagement.ModelBinding;
using OrchardCore.DisplayManagement.Views;
using System.Threading.Tasks;

namespace Etch.OrchardCore.PressKit.Drivers
{
    public class PressKitDisplay : ContentPartDisplayDriver<Models.PressKit>
    {
        #region Dependencies

        private readonly IHttpContextAccessor _httpContextAccessor;

        #endregion

        #region Constructor

        public PressKitDisplay(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        #endregion 

        #region Driver Overrides

        public override IDisplayResult Display(Models.PressKit part, BuildPartDisplayContext context)
        {
            if (context.DisplayType == "Detail" && part.UsePressKitDisplay)
            {
                var httpContext = _httpContextAccessor.HttpContext;
                httpContext.Response.Redirect($"{httpContext.Request.PathBase}/press-kit/{part.ContentItem.ContentItemId}", false);
            }

            return null;
        }

        public override IDisplayResult Edit(Models.PressKit part)
        {
            return Initialize<PressKitEditViewModel>("PressKit_Edit", model =>
            {
                model.UsePressKitDisplay = part.UsePressKitDisplay;
            });
        }

        public override async Task<IDisplayResult> UpdateAsync(Models.PressKit part, IUpdateModel updater)
        {
            var model = new PressKitEditViewModel();

            await updater.TryUpdateModelAsync(model, Prefix, m => m.UsePressKitDisplay);

            part.UsePressKitDisplay = model.UsePressKitDisplay;

            return Edit(part);
        }

        #endregion
    }
}
