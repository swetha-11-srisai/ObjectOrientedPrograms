using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ObjectOrientedProgram
{
    class StockMain
    {
        public void StockData(string filepath)
        {
            try
            {
                using (StreamReader r = new StreamReader(filepath))
                {
                    var json = r.ReadToEnd();
                    var items = JsonConvert.DeserializeObject<List<StockModel>>(json);
                    Console.WriteLine("StockName \t NumberofShares \t SharePrice");
                    foreach (var item in items)
                    {
                        Console.WriteLine("{0}" + "\t" + "{1}" + "\t" + "{2}", item.StockName, item.NumberofShares, item.SharePrice);
                        Console.WriteLine("Result:"+ item.NumberofShares * item.SharePrice);
                    }

                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
