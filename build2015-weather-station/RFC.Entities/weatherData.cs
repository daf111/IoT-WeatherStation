using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;

namespace RFC.Entities
{
    public class WeatherData
    {

        public float Altitude { get; set; }
        public float BarometricPressure { get; set; }
        public float CelsiusTemperature { get; set; }
        public float FahrenheitTemperature { get; set; }
        public float Humidity { get; set; }
        public string TimeStamp { get; set; }

        public string JSON
        {
            get
            {
                var jsonSerializer = new DataContractJsonSerializer(typeof(WeatherData));
                using (MemoryStream strm = new MemoryStream())
                {
                    jsonSerializer.WriteObject(strm, this);
                    byte[] buf = strm.ToArray();
                    return Encoding.UTF8.GetString(buf, 0, buf.Length);
                }
            }
        }

    }
}
