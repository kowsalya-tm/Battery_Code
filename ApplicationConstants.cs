using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DWI
{
    class ApplicationConstants
    {
        
        public static string APPLICATION_NAME = "DWI App";
        public static string LOGIN_SELECT_QUERY = "usp_ValidateLogin";
        public static string GET_PLANT_NAME = "[dwi].[usp_GetPlantName]";
        public static string GET_AssemblyLine = "[dwi].[usp_GetAssemblyLine]";
        public static string Get_LookUpValues = "[dwi].[usp_GetLookUpValues]";
        public static string Get_Station = "[dwi].[usp_GetStation]";
        public static string GetEmployeeId = "[dwi].[usp_GetEmployeeId]";
        public static string GetVehicleDetails = "[dwi].[usp_GetVehicleDetails]";
        public static string CheckIsVinNoExists = "[dwi].[usp_CheckIsVinNoExists]";
        public static string CheckIsVinNoExistsBattery = "select a.VinNumber,a.Status,a.StationNumber	 from dwi.wi_MainLine a join dwi.wi_Station b on (a.StationId=b.stationId and stationtype='BATTERY') where vinnumber=@vinnumber";
        public static string CheckIsVinNoExistsBattery1 = "dwi.usp_CheckIsVinNoExists_Battery";
        public static string GetShiftDetails = "[dbo].[usp_GetShiftDetails]";
        public static string AddMainLineVehicle = "[dwi].[usp_AddMainLineVehicle]";
        public static string ValidateVinnumber = "[dwi].[usp_ValidateVinnumber]";
        public static string UpdateReworkBattery = "[dwi].[usp_UpdateReworkBattery]";
        public static string Report = "[dwi].[usp_Report]";
        public static string GetMlPartUniqueNo = "[dwi].[usp_GetMlPartUniqueNo]";
        public static string GetBatteryVehicleDetails = "[dwi].[usp_ GetBatteryVehicleDetails]";
        public static string GetStationIDForBattery = "[dwi].[usp_GetStationIDForBattery]";

    }
    

}

