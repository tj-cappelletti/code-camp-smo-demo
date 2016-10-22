using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCamp.SmoDemo._06_Restore
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server("localhost");

            Database database = server.Databases["SmoDemoDatabase"];

            //database.Tables["PurchaseOrders"].Drop();

            ConsoleKey key = ConsoleKey.Escape;

            while(key != ConsoleKey.N && key != ConsoleKey.Y)
            {
                Console.WriteLine("The database has been damaged, do you want to restore?");
                key = Console.ReadKey().Key;
                Console.WriteLine();
            }

            if(key == ConsoleKey.Y)
            {

                Restore restore = new Restore();
                restore.Database = database.Name;
                restore.PercentComplete += Restore_PercentComplete;
                restore.PercentCompleteNotification = 10;
                restore.NoRecovery = false;
                restore.ReplaceDatabase = true;

                foreach(var file in Directory.GetFiles(server.BackupDirectory, database.Name + "*.bak"))
                {
                    BackupDeviceItem backupDeviceItem = new BackupDeviceItem(file, DeviceType.File);
                    restore.Devices.Add(backupDeviceItem);
                }

                restore.SqlRestore(server);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Finished");
            Console.ReadKey();
        }

        private static void Restore_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            Console.WriteLine(e.Message);
        }
    }
}