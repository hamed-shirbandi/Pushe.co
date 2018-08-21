using Newtonsoft.Json.Serialization;


namespace Pushe.co.Helpers
{
    internal class LowercaseContractResolver : DefaultContractResolver
    {
        protected override string ResolvePropertyName(string propertyName)
        {
            return propertyName.ToLower();
        }
    }
}
