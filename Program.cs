using System;
using System.IO;
using System.Net;

namespace Complyle
{

    //This is very pointless lol
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Complyle! a useless compiler - made by nick.#1666 - for the Compliant texture pack!\n");
            if (args.Length == 0)
            {
                Console.WriteLine("Please specify flags like so: <64x|32x> <-b|-j> -v [version]");
                return;
            }
            var resolution = args[0];

            switch (resolution)
            {
                case "--usage":
                    Console.WriteLine("<64x|32x> <-b|-j> -v [version]");
                    break;

                //no -v handleing

                case "32"  when args.Length == 4 && args[2] == "-v":
                case "x32" when args.Length == 4 && args[2] == "-v":
                case "32x" when args.Length == 4 && args[2] == "-v":
                    download("32x", args);
                    break;

                case "64" when args.Length == 4 && args[2] == "-v":
                case "x64" when args.Length == 4 && args[2] == "-v":
                case "64x" when args.Length == 4 && args[2] == "-v":
                    download("32x", args);
                    break;
                default:
                    Console.WriteLine("Invalid command!");
                    break;
            }

            static void download(string res, string[] args)
            {
                if (args[1] == "-b")
                {
                    var url = "https://github.com/Compliance-Resource-Pack/Compliance-Bedrock-" + res + "/archive/refs/heads/Jappa-bedrock-latest.zip";

                    using (var client = new WebClient())
                    {
                        try
                        {
                            client.DownloadFile(url, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\resourcepacks\\ComplianceBedrock" + res + ".zip");
                            Console.WriteLine("Sucsessfully downloaded from: " + url);
                            Console.WriteLine("Sucsessfully downloaded to: " + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\resourcepacks\\ComplianceBedrock" + res + "x.zip");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Unable to retrieve github repository.");
                        }
                        return;
                        
                    }
                }

                if (args[1] == "-j")
                {
                    var url = "https://github.com/Compliance-Resource-Pack/Compliance-Java-" + res + "/archive/refs/heads/Jappa-" + args[3] + ".zip";

                    using (var client = new WebClient())
                    {
                        try
                        {
                            client.DownloadFile(url, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\resourcepacks\\ComplianceJava" + res + ".zip");
                            Console.WriteLine("Sucsessfully downloaded from: " + url);
                            Console.WriteLine("Sucsessfully downloaded to: " + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\resourcepacks\\ComplianceJava" + res + "x.zip");
                        }
                        catch
                        {
                            Console.WriteLine("Branch not found on github! please use a valid version (e.g -v 1.18 | -v 1.12.2)");
                        }
                        return;
                    }
                }


                Console.WriteLine("Invalid MC type! Chose -b for Bedrock or -j for Kava like so: <64x|32x> <-b|-j> -v [version]");
                return;
            }
        }
    }
}
