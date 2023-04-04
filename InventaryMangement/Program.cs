namespace InventaryMangement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("These are object oriented program");
            string path2 = "D:\\assignments\\InventaryRepo\\InventaryAssignment\\InventaryMangement\\Stock.json";
            StockRead r=new StockRead();
            StockDetails data = r.Reads(path2);
            Console.WriteLine("Stockes of different companies ");
            Console.WriteLine("***************");
            for (int i = 0; i < data.stockReport.Count; i++)
            {
                Console.WriteLine(data.stockReport[i].name);
                Console.WriteLine(data.stockReport[i].Stocks);
                Console.WriteLine(data.stockReport[i].price);
                int val = data.stockReport[i].price * data.stockReport[i].Stocks;
                Console.WriteLine("The price of stock in {0} is {1} ", data.stockReport[i].name, val);
            }


                //string path = "D:\\assignments\\InventaryRepo\\InventaryAssignment\\InventaryMangement\\Data.json";
                //Reads obj = new Reads();
                //Details data = obj.Read(path);


                //Console.WriteLine("Types of Rice are:");
                //Console.WriteLine("*********************");
                //for (int i = 0; i < data.typesOfRices.Count; i++)
                //{
                //    Console.WriteLine(data.typesOfRices[i].name);
                //    Console.WriteLine(data.typesOfRices[i].weight);
                //    Console.WriteLine(data.typesOfRices[i].price);
                //    int val = data.typesOfRices[i].price * data.typesOfRices[i].weight;
                //    Console.WriteLine("The price of {0} is {1} ", data.typesOfRices[i].name, val);

                //}
                //Console.WriteLine("\n");
                //Console.WriteLine("Types of Wheats Are");
                //Console.WriteLine("**********");
                //for (int i = 0; i < data.typesOfWheats.Count; i++)
                //{
                //    Console.WriteLine(data.typesOfWheats[i].name);
                //    Console.WriteLine(data.typesOfWheats[i].weight);
                //    Console.WriteLine(data.typesOfWheats[i].price);
                //    int val = data.typesOfWheats[i].price * data.typesOfWheats[i].weight;
                //    Console.WriteLine("The price of {0} is {1} ", data.typesOfWheats[i].name, val);


                //}
                //Console.WriteLine("\n");
                //Console.WriteLine("Types of pulses Are");
                //Console.WriteLine("*************");
                //for (int i = 0; i < data.typesOfPulses.Count; i++)
                //{
                //    Console.WriteLine(data.typesOfPulses[i].name);
                //    Console.WriteLine(data.typesOfPulses[i].weight);
                //    Console.WriteLine(data.typesOfPulses[i].price);
                //    int val = data.typesOfPulses[i].price * data.typesOfPulses[i].weight;
                //    Console.WriteLine("The price of {0} is {1} ", data.typesOfPulses[i].name, val);


                //}
            }
    }
}