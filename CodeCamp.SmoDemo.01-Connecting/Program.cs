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

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Database database = server.Databases["PointOfSalesCloudDatabase"];

            Console.WriteLine("Database: {0}", database.Name);
            Console.WriteLine("Database Size: {0}", database.Size);
            Console.WriteLine("Database Last Backup: {0:D}", database.LastBackupDate);
            Console.WriteLine("Extended Properties:");

            foreach (ExtendedProperty extendedProperty in database.ExtendedProperties)
            {
                Console.WriteLine("\tProperty: {0} - Value: {1}", extendedProperty.Name, extendedProperty.Value);
            }

            Console.WriteLine("Finished");
            Console.ReadKey();
        }
    }
}