using System;
using System.IO;
using System.Net;

namespace CPSMv11APINervoGrid
{
    class Program
    {
        private const string ApiUrl = "https://pp-admin.cloudforyou.fr/cortexapi/default.aspx";
        private static readonly NetworkCredential AdminCredentials = new NetworkCredential("username", "password");

        static void Main(string[] args)
        {
            WebClient client = new WebClient
            {
                Credentials = AdminCredentials
            };

            foreach (string file in Directory.GetFiles("Requests"))
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    string fileContent = reader.ReadToEnd();

                    if (!String.IsNullOrEmpty(fileContent))
                    {
                        Console.WriteLine("Sending request: {0}", file);
                        Console.WriteLine("========== Request ==========");
                        Console.WriteLine(fileContent);
                        Console.WriteLine("======== End Request ========");
                        Console.WriteLine("========== Response ==========");
                        string response = client.UploadString(ApiUrl, fileContent);
                        Console.WriteLine(response);
                        Console.WriteLine("======== End Response ========");
                        Console.WriteLine();
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
