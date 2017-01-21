using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{

    public class CPacket
    {
        public string Altitude { get; set; }
        public string BarometricPressure { get; set; }
        public string CelsiusTemperature { get; set; }
        public string FahrenheitTemperature { get; set; }
        public string Humidity { get; set; }
        public string TimeStamp { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

            WebClient client = new WebClient();
            //string myJsonString = client.DownloadString("http://127.0.0.1/weather.php");
            string myJsonString = client.DownloadString("http://192.168.0.47:50001/");
            var jo = JObject.Parse(myJsonString);

            CPacket x = JsonConvert.DeserializeObject<CPacket>(jo.ToString());

            Console.WriteLine(myJsonString);
            Console.ReadKey();

        }
    }
}
