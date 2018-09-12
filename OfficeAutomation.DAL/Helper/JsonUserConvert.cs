using Newtonsoft.Json;
using OfficeAutomation.Models;

namespace OfficeAutomation.DAL.Helper
{
    public class JsonUserConvert
    {
        public users StringToObject(string str)
        {
            var item = JsonConvert.DeserializeObject<users>(str);
            return item;
        }
    }
}
