using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    public class AppSettings
    {
        public static string ApiUrl = DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:5284/" : "http://localhost:5284/";        
    }
}
