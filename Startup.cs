using Etch.OrchardCore.PressKit.Drivers;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.Data.Migration;
using OrchardCore.Modules;

namespace Etch.OrchardCore.PressKit
{
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddContentPart<Models.PressKit>()
                .UseDisplayDriver<PressKitDisplay>();

            services.AddScoped<IDataMigration, Migrations>();
        }
    }
}
