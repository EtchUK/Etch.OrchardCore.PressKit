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
        static Startup()
        {

        }

        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ContentPart, Models.PressKit>();
            services.AddScoped<IContentPartDisplayDriver, PressKitDisplay>();
            services.AddScoped<IDataMigration, Migrations>();
        }
    }
}
