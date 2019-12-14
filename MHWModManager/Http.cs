using System.Diagnostics;
using System.IO;
using System.Net;

namespace MHWModManager
{
    public static class Http
    {
        public static string Get(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.Headers.Add("apikey:Z1BuVWVpWmlzcWh3UWlFaE9FQzRwOGlOaWl2L0M2NnJsdEI3NjE1VGcvK1hKMlMwRzQzVlZjQzdhN1pDc1NEOC0tdkxHcXJVbjlKNGltVS82RFRvMnhIQT09--70a1b63e1a1f501b660caa377afe9c9dee409544");
            request.Headers.Add("accept:application/json");
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using Stream stream = response.GetResponseStream();
            Debug.Assert(stream != null, nameof(stream) + " != null");
            using StreamReader reader = new StreamReader(stream);
            return reader.ReadToEnd();
        }
    }
}