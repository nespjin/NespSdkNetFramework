using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NespSdkNetFramework.Utils
{
    public class ObjectUtils
    {
        public static bool CopyProperties(object objFrom, object objTo)
        {
            try
            {
                Type typeFrom = objFrom.GetType();
                Type typeTo = objTo.GetType();

                foreach (PropertyInfo propertyInfoFrom in typeFrom.GetProperties())
                {
                    foreach (PropertyInfo propertyInfoTo in typeTo.GetProperties())
                    {
                        if (propertyInfoFrom.Name == propertyInfoTo.Name)
                        {
                            propertyInfoTo.SetValue(objTo, propertyInfoFrom.GetValue(objFrom));
                        }
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}
