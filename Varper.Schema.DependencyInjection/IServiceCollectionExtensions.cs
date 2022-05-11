using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varper.Schema.DependencyInjection
{
    public static class IServiceCollectionExtensions
    {
        public static void AddXmlSchemaValidation(this IServiceCollection services, Action<StorageProviderOptions> getConfigOptions)
        {
            getConfigOptions(new StorageProviderOptions());
        }
    }
}
