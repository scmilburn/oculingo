using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

var api_key = 'BdQxSnT3t54Y0Ko3QnijviLFi';
var api_secret = 'h8VrVXPyqoecnM3iwhuID8n0Vx0t6Vvcnfr48906ObCWrnpTF9'
var oauth_token = '605707646-Ks1JLdnU5ID5vYMyfxCrFxjIx20DHGe13WPTGES8'
var oauth_token_secret = 'XCZwrGBnmuZSzvz9DPbqzUXFiCZyzs7f5MwISaHg93why'
owner_id = '605707646'

namespace ConsoleProgram 
{

    public class Trending 
    {
        private const string URL = "https://api.twitter.com/1.1/search/tweets.json";
        private string _query_param;
        public string Query_param
        {
        	get
        	{
        		return _query_param;
        	}
        	set{
        		_query_param = "?q=" + value;
        	}
        }


        static void Main(string[] args) 
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            HttpResponseMessage response = client.GetAsync(urlParameters).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var dataObjects = response.Content.ReadAsAsync<IEnumerable<DataObject>>().Result;
                foreach (var d in dataObjects)
                {
                    Console.WriteLine("{0}", d.Name);
                }
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }  
        }
    }
}