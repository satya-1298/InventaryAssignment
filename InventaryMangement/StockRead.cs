using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventaryMangement
{
    public class StockRead
    {
        public StockDetails Reads(string path2)
        {
            try
            {
                using (StreamReader file = new StreamReader(path2))
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<StockDetails>(json);
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
