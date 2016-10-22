using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCamp.SmoDemo._04_ScriptingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server("localhost");

            Database database = server.Databases["SmoDemoDatabase"];

            Table table = database.Tables["Customers"];

            ScriptingOptions tableScriptingOptions = new ScriptingOptions();
            tableScriptingOptions.Add(ScriptOption.DriNonClustered);

            StringCollection tableScript = table.Script(tableScriptingOptions);

            foreach(var scriptString in tableScript)
            {
                Console.WriteLine(scriptString);
            }

            Console.WriteLine();
            Console.WriteLine();

            StringCollection databaseScript = database.Script();

            foreach(var scriptString in databaseScript)
            {
                Console.Write(scriptString);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Finished");
            Console.ReadKey();
        }
    }
}