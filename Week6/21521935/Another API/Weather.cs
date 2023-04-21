using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Another_API
{
    public partial class Weather : Form
    {
        public Weather()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://weatherapi-com.p.rapidapi.com/current.json?q={querry.Text}"),
                Headers =
    {
        { "X-RapidAPI-Key", "23bef34f7emshb79a95e739f4a1ep1e36cdjsnab3db44eb3eb" },
        { "X-RapidAPI-Host", "weatherapi-com.p.rapidapi.com" },
    },
            };
                WeatherData weatherData;
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                weatherData = JsonConvert.DeserializeObject<WeatherData>(body);
            }
            view_data_weather.Items.Add("Khu vực: " + weatherData.Location.Name);
            view_data_weather.Items.Add("Nước: " + weatherData.Location.Country);
            view_data_weather.Items.Add("Nhiệt độ: " + weatherData.Current.Temp_c);
            view_data_weather.Items.Add("Hướng gió " + weatherData.Current.Wind_dir);
            view_data_weather.Items.Add("Feel like:  " + weatherData.Current.Feelslike_c);
        }

        private void querry_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
