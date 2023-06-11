using Emby.ApiClient;
using Emby.ApiClient.Cryptography;
using Emby.ApiClient.Model;
using JellyFinAPI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft;
using Newtonsoft.Json;

namespace JellyFinAPI

{
    public class Jellyfin
    {
        public Jellyfin()
        {
        }
        HttpClient client = new HttpClient();
        static string api_key = JellyFinAPI.Properties.Resources.api_key;
        static string ParentId = "f137a2dd21bbc1b99aa5c0f6bf02a805";
        static public Dictionary<string, string> requestStreamItems = new Dictionary<string, string>();

        ResponseJsonStructure responseJsonStructure = new ResponseJsonStructure();
        public async void GetList()
        {
            WebRequest webRequest = WebRequest.Create($"http://localhost:8096/Items?Item=&api_key={api_key}&ParentId=f137a2dd21bbc1b99aa5c0f6bf02a805");
            WebResponse response = webRequest.GetResponse();
            Stream stream = response.GetResponseStream();

            StreamReader reader = new StreamReader(stream);
            string data = reader.ReadToEnd();
            responseJsonStructure = JsonConvert.DeserializeObject<ResponseJsonStructure>(data);
            foreach (var index in responseJsonStructure.items)
            {
                string request = $"http://localhost:8096/Items/{index.id}/Download?api_key={api_key}";
                requestStreamItems[index.name] = request;
            }

        }


    }
}
