using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishSpiderPluginEngineWPF.Utils
{
    public class UnitUtils
    {
        public static string GetStorageUnitString(float size)
        {
            return GetStorageUnitString(size, new string[0]);
        }

        /// <summary>
        /// Bytes unit convert to string.
        /// </summary>
        /// <param name="size">The size to format, bytes</param>
        /// <param name="units">Units GB to KB</param>
        /// <returns></returns>
        public static string GetStorageUnitString(float size,string[] units)
        {
            if (units == null) units = new string[0];

            float GB = 1024 * 1024 * 1024.000F;
            float MB = 1024 * 1024.000F;
            float KB = 1024.000F;

            if (size / GB >= 1)
            {
                string unit = "GB";
                if (units.Length > 0) unit = units[0];
                return String.Format("{0:N3} ", size / GB) + unit;
            }
            else if (size / MB >= 1)
            {
                string unit = "MB";
                if (units.Length > 1) unit = units[1];
                return String.Format("{0:N3} ", size / MB) + unit;
            } 
            else if (size / KB >= 1)
            {
                string unit = "KB";
                if (units.Length > 2) unit = units[2];
                return String.Format("{0:N3} ", size / KB) + unit;
            }
            else
            {
                string unit = "B";
                return String.Format("{0:N3} ", size / KB) + unit;
            }
        }
    }
}
