using Newtonsoft.Json.Linq;

namespace ApiTesting
{
    public class Query
    {
        private string apiKey;
        private string queryStr;
        private bool validRequest;
        private Main main;

        public bool ValidRequest { get => validRequest; set => validRequest = value; }
        public Main Main { get => main; set => main = value; }
        
        public Query(string apiKey, string quaryStr)
        {
            this.apiKey = apiKey;
            this.queryStr = quaryStr;
            JObject jsonData = JObject.Parse(new System.Net.WebClient().DownloadString(
                string.Format("http://api.openweathermap.org/data/2.5/weather?appid={0}&q={1}",
                    this.apiKey, this.queryStr)));

            // A valid requst have a cod of 200
            // every other cod is a error
            // token main is where the temperature is stored
            if(jsonData.SelectToken("cod").ToString() == "200")
            {
                validRequest = true;
                main = new Main(jsonData.SelectToken("main"));
            }
            else
            {
                validRequest = false;
            }

        }

    }
}
