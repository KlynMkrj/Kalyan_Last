using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

using FileService;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)  
        {
            string strArg1, strArg2;

            try
            {
                if (args.Length >= 2)
                {
                    strArg1 = args[0];
                    strArg2 = args[1];

                    ServiceFile objServiceFile = new ServiceFile(strArg1, strArg2);

                    string strResult = objServiceFile.BringFileInformation();

                    Console.WriteLine(strResult);
                    Console.Read();
                }
            }

            catch (Exception e)
            {
                Console.WriteLine("Some exception happened : " + e.ToString());
                Console.Read();
            }
        }
    }
}
