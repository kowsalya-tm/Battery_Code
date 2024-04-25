using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DWI
{
    class Global
    {
        public static string OperatorId="";
        public static string LoginUserId;
        public static string UserRole;
        public static int skip=0;
        public static string shift="";
        public static int skiptiming = 0;
        public static int logofftiming = 0;
        public static string csvfilename;
        public static string path;
        public static string plant = ConfigurationManager.AppSettings["Plant"];
        public static string assemblyLine = ConfigurationManager.AppSettings["AssemblyLine"];
        public static string deviceId;
        public static string reworkReason="";
        public static int plantId;
        public static int assemblylineId;
        public static int stationSequence;
        public static string LocationValue;
        public static string stationId;
    }
}
