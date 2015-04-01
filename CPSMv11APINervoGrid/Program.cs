using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace CPSMv11APINervoGrid
{
    class Program
    {
        private const string ApiUrl = "https://pp-admin.cloudforyou.fr/cortexapi/default.aspx";
        private static readonly NetworkCredential AdminCredentials = new NetworkCredential("", "");
        private static readonly List<String> FileNames = new List<string>
        {
            "CustomerFindAll",
            "CustomerFind",
            "CustomerGet",
            "CustomerGetProperties",
            "CustomerCreate",
            "CustomerModify",
            "CustomerServicesFindAll",
            "CustomerProvisionExchange",
            "CustomerServiceGet",
            "CustomerModifyExchange",
            "UserCreate",
            "UserGet",
            "UserGetProperties",
            "UserServicesFindAll",
            "UserServiceGet",
            "UserProvisionExchange",
            "CustomerServiceGet",
            "CustomerDistributionGroupsGet",
            "DistributionGroupAddMember",
            "UserDeprovisionExchange",
            "UserDeprovision",
            "UserDelete",
            "CustomerDeprovisionExchange",
            "CustomerDeprovision"
            //"CustomerDelete"
        };

        static void Main(string[] args)
        {
            WebClient client = new WebClient
            {
                Credentials = AdminCredentials
            };

            if (!Directory.Exists("Requests"))
            {
                Console.WriteLine("Requests folder not found.");
                return;
            }
            foreach (string filename in FileNames)
            {
                string path = String.Format("Requests/{0}.xml", filename);

                if (File.Exists(path))
                {
                    using (StreamReader reader = new StreamReader(path))
                    {
                        string fileContent = reader.ReadToEnd();

                        if (!String.IsNullOrEmpty(fileContent))
                        {
                            Console.WriteLine("Sending request: {0}", filename);
                            Console.WriteLine("========== Request ==========");
                            Console.WriteLine(fileContent);
                            Console.WriteLine("======== End Request ========");
                            Console.WriteLine("========== Response ==========");
                            try
                            {
                                WriteResponse(client.UploadString(ApiUrl, fileContent), filename);
                            }
                            catch (WebException e)
                            {
                                if (e.Response != null)
                                {
                                    Stream responseStream = e.Response.GetResponseStream();
                                    if (responseStream != null)
                                    {
                                        WriteResponse(new StreamReader(responseStream).ReadToEnd(), filename);
                                    }
                                }
                            }
                            Console.WriteLine("======== End Response ========");
                            Console.WriteLine();
                        }
                    }
                }
            }

            Console.ReadLine();
        }

        private static void WriteResponse(string response, string filename)
        {
            Console.WriteLine(response);
            
            if (!Directory.Exists("Responses"))
                return;

            using (StreamWriter writer = new StreamWriter(String.Format("Responses/{0}.xml", filename), false))
            {
                writer.Write(response);
            }
        }
    }
}
