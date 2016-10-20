using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Management.Smo;

namespace CodeCamp.SmoDemo._01_Connecting
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server("localhost");

            Console.WriteLine("Server Name: {0}", server.Name);
            Console.WriteLine("Server Version: {0}", server.Version);
            Console.WriteLine("Server Service Pack: {0}", server.ProductLevel);
            Console.WriteLine("Server Edition: {0}", server.Edition);
            Console.WriteLine("Server Collation: {0}", server.Collation);

            Console.WriteLine("Finished");
        }
    }
}