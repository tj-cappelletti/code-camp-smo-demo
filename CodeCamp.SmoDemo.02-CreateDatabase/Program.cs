using System;
using System.Collections.Generic;
using System.IO;
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
            var primaryDataFileName = Path.Combine(server.DefaultFile, "SmoDemoDatabase_Primary.mdf");
            var secondaryDataFileName = Path.Combine(server.DefaultFile, "SmoDemoDatabase_Secondary.ndf");
            var logFileName = Path.Combine(server.DefaultLog, "SmoDemoDatabase_Log.ldf");

            Database database = new Database(server, "SmoDemoDatabase");

            FileGroup primaryFileGroup = new FileGroup(database, "PRIMARY", FileGroupType.RowsFileGroup);

            database.FileGroups.Add(primaryFileGroup);

            DataFile primaryDataFile = new DataFile(primaryFileGroup, "PrimaryDataFile")
            {
                FileName = primaryDataFileName,
                Growth = 4096,
                GrowthType = FileGrowthType.KB,
                IsPrimaryFile = true,
                Size = 10240
            };

            DataFile secondaryDataFile = new DataFile(primaryFileGroup, "SecondaryDataFile")
            {
                FileName = secondaryDataFileName,
                Growth = 4096,
                GrowthType = FileGrowthType.KB,
                Name = "SecondaryDataFile",
                Size = 10240
            };

            LogFile logFile = new LogFile(database, "LogFile", logFileName)
            {
                Growth = 2048,
                GrowthType = FileGrowthType.KB,
                Size = 20480
            };

            database.LogFiles.Add(logFile);

            primaryFileGroup.Files.Add(primaryDataFile);
            primaryFileGroup.Files.Add(secondaryDataFile);

            server.Databases.Add(database);

            database.Create();
        }
    }
}