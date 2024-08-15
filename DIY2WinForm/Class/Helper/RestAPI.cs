using System.Net;

namespace DIY2WinForm.Class.Helper
{
    public static class RestAPI
    {
        public static List<CountryAPI> GetCountries()
        {
            List<CountryAPI> countries = new List<CountryAPI>();

#pragma warning disable SYSLIB0014 // Type or member is obsolete
            using (WebClient webClient = new WebClient())
            {
                string json = webClient.DownloadString("https://restcountries.com/v3.1/all?fields=name");
                countries = Newtonsoft.Json.JsonConvert.DeserializeObject<List<CountryAPI>>(json);
            }
#pragma warning restore SYSLIB0014 // Type or member is obsolete

            countries = countries.OrderBy(x => x.name.common).ToList();

            return countries;
        }
    }
}