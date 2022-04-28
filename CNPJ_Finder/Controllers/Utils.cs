using CNPJ_Finder.Entities;
using Newtonsoft.Json;

namespace CNPJ_Finder.Controllers
{
    internal class Utils
    {
        #region Convert Json to Object

        public static Enterprise JsonToObject(string jsonString)
        {
            return JsonConvert.DeserializeObject<Enterprise>(jsonString);
        }
        #endregion
    }
}