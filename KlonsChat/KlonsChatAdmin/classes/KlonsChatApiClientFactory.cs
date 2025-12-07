using Refit;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace KlonsChatAdmin.classes
{
    public static class KlonsChatApiClientFactory
    {
        public static IklonsqApi Create(string serverurl)
        {
            var refitsettings = new RefitSettings();
            var serializeroptions = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true,
                PropertyNamingPolicy = null
            };
            serializeroptions.Converters.Add(new ObjectToInferredTypesConverter());
            var customserializer = new SystemTextJsonContentSerializer(serializeroptions);
            refitsettings.ContentSerializer = customserializer;
            var httpClient = new HttpClient(new SafeHttpHandler(new HttpClientHandler()))
            {
                BaseAddress = new Uri(serverurl)
            };
            var ret = RestService.For<IklonsqApi>(httpClient, refitsettings);
            return ret;
        }
    }
}
