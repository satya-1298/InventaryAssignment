using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace InventaryMangement
{
    public class Reads
    {
        public Details Read(string path)
        {
            try
            {
                using (StreamReader file = new StreamReader(path))
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<Details>(json);
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
