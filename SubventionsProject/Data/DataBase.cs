using System.Net.Http;

namespace SubventionsProject
{
    static class DataBase
    {
        public static readonly HttpClient client = new HttpClient();

        public const string Uri = "http://83.142.167.198";
    }
}
