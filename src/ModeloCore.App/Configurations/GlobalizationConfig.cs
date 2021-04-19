using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ModeloCore.App.Configurations
{
    public static class GlobalizationConfig
    {
        public static IApplicationBuilder UseGlobalizationConfiguration(this IApplicationBuilder app)
        {
            var defaultCulture = new CultureInfo("pt-BR");
            var localizationOptions = new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture(defaultCulture),
                SupportedCultures = new List<CultureInfo> { defaultCulture },
                SupportedUICultures = new List<CultureInfo> { defaultCulture }
            };
            app.UseRequestLocalization(localizationOptions);

            return app;
        }
    }
}
