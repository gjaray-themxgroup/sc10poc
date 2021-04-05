using System;
using Sitecore.XConnect;

namespace SC10Poc.XConnect.Model
{
    [Serializable]
    [FacetKey(DefaultFacetKey)]
    public class DemoFacet : Sitecore.XConnect.Facet
    {
        public const string DefaultFacetKey = "DemoFacet";

        public string FavoriteAnimal { get; set; }
    }
}
