

namespace FishSpiderPluginEngineWPF.Utils
{
    using System;
    public class JsonFormatter : IJsonFormatter
    {
        private readonly IJsonFormatter jsonFormatter;

        private static readonly Lazy<JsonFormatter> INSTANCE_LOCK = new Lazy<JsonFormatter>(() => new JsonFormatter(), true);

        public static JsonFormatter GetInstance
        {
            get
            {
                return INSTANCE_LOCK.Value;
            }
        }

        private JsonFormatter()
        {
            jsonFormatter = new NewtonsoftJsonFormatter();
        }

        public string ToJson(object obj)
        {
            return jsonFormatter.ToJson(obj);
        }

        public T FromJson<T>(string json)
        {
            return jsonFormatter.FromJson<T>(json);
        }
    }
}
