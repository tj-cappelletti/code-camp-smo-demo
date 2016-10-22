using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCamp.SmoDemo._05_Backup
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server("localhost");

            Console.WriteLine("Backup Directory: {0}", server.BackupDirectory);

            foreach(Database database in server.Databases)
            {
                if (database.Name == "tempdb")
                    continue;

                var fileName = string.Format("{0}_{1:s}.bak", database.Name, DateTime.Now).Replace(":", string.Empty);

                BackupDeviceItem backupDeviceItem = new BackupDeviceItem(fileName, DeviceType.File);

                Backup backup = new Backup();
                backup.Action = BackupActionType.Database;
                backup.Database = database.Name;
                backup.Devices.Add(backupDeviceItem);
                backup.BackupSetDescription = "Full database backup";
                backup.BackupSetName = database.Name + " SMO Backup";
                backup.Incremental = false;
                backup.PercentComplete += Backup_PercentComplete;
                backup.PercentCompleteNotification = 10;

                if (database.RecoveryModel == RecoveryModel.Full)
                    backup.LogTruncation = BackupTruncateLogType.Truncate;

                Console.WriteLine("Backingup Database {0}", database.Name);
                backup.SqlBackup(server);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Finished");
            Console.ReadKey();
        }

        private static void Backup_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            Console.WriteLine(e.Message);
        }
    }
}