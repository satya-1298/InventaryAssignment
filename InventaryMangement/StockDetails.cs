using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventaryMangement
{
    public  class StockDetails
    {
        public List<StockReport> stockReport;
        
    }
    public class StockReport
    {
        public string name;
        public int Stocks;
        public int price;
    }
}
