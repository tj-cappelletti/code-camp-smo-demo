using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Management.Smo;

namespace CodeCamp.SmoDemo._02_CreateDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server("localhost");

            //TODO: Add files, extended properites, etc. to show a more complex example
            Database database = new Database(server, "SmoDemoDatabase");
            database.Create();
        }
    }
}
