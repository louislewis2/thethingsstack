namespace System.Net.Http
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public static class HttpResponseMessageExtensions
    {
        public static T Deserialize<T>(this HttpResponseMessage response) where T : class
        {
            var settings = new JsonSerializerSettings();
            settings.ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor;
            settings.Converters.Add(new StringEnumConverter());

            var stream = response.Content.ReadAsStringAsync().Result;
            var item = JsonConvert.DeserializeObject<T>(stream, settings);

            return item;
        }
    }
}