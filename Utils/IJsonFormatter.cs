namespace FishSpiderPluginEngineWPF.Utils
{
    interface IJsonFormatter
    {
        string ToJson(object obj);

        T FromJson<T>(string json);
    }
}
