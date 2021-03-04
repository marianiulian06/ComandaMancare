using comandamancare.RegisterSettings;
using Umbraco.Core;
using Umbraco.Core.Composing;

namespace comandamancare.EnableRouting
{
    public class myComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.Components().Append<ResterSettingsComponent>();
        }
    }
}