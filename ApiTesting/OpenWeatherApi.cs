using System;


namespace ApiTesting
{
    public class OpenWeatherApi
    {
        private string openWeatherAPIKey;

        public OpenWeatherApi(string apiKey)
        {
            openWeatherAPIKey = apiKey;
        }

        public void UpdateAPIKey(string apiKey)
        {
            openWeatherAPIKey = apiKey;
        }

        //Returns null if invalid request
        public Query Query(string queryStr)
        {
            Query newQuery = new Query(openWeatherAPIKey, queryStr);
            if (newQuery.ValidRequest)
                return newQuery;
            return null;
        }
    }
}
