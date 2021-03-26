using System;
using System.Collections.Generic;
using System.Text;

namespace NespSdkNetFramework.Utils
{
    using Newtonsoft.Json;
    class NewtonsoftJsonFormatter : IJsonFormatter
    {

        public string ToJson(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public T FromJson<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
