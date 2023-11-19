using Microsoft.Extensions.Localization;
using SimPlastik.Controllers;
using System.Reflection;

namespace SimPlastik.Services
{


    class SharedResource
    {

    }
    public class LanguageService
    {
        private readonly IStringLocalizer _localizer;
        public LanguageService(IStringLocalizerFactory factory)
        {
            var type = typeof(SharedResource);
            var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
            _localizer = factory.Create(nameof(SharedResource), assemblyName.Name);
        }
        public LocalizedString Getkey(string key)
        {
            return _localizer[key];
        }
    }
}
