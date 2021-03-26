using NespSdkNetFramework.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NespSdkNetFramework.Lang
{
    /// <summary>
    /// This class is extension C Sharp language standard library.
    /// </summary>
    public static class StandardExtensions
    {
        /// <summary>
        /// Convert the <paramref name="obj"/> to json string.
        /// </summary>
        /// <param name="obj"> The object to convert json string </param>
        /// <returns>The Json string convert from <paramref name="obj"/></returns>
        public static string ToJson(this object obj)
        {
            return JsonFormatter.GetInstance.ToJson(obj);
        }

        /// <summary>
        /// Copy <paramref name="obj"/> properties to <paramref name="copyTo"/>
        /// </summary>
        /// <param name="obj">Copy from</param>
        /// <param name="copyTo">Copy to</param>
        /// <returns>True if copy success otherwise False</returns>
        public static bool CopyPropertiesTo(this object obj, object copyTo)
        {
            return ObjectUtils.CopyProperties(obj, copyTo);
        }
    }
}
