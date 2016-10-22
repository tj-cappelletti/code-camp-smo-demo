using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCamp.SmoDemo._09_GuiDemo.Information
{
    public class DatabaseInformation
    {
        private DateTime dateCreated;
        [Browsable(true)]
        [Category("Database")]
        [Description("The date the database was created.")]
        [DisplayName("Date Created")]
        [ReadOnly(true)]
        public DateTime DateCreated { get { return dateCreated; } }

        private String lastDatabaseBackup;
        [Browsable(true)]
        [Category("Backup")]
        [Description("The date of the last database backup.")]
        [DisplayName("Last Database Backup")]
        [ReadOnly(true)]
        public String LastDatabaseBackup { get { return lastDatabaseBackup; } }

        private String lastLogBackup;
        [Browsable(true)]
        [Category("Backup")]
        [Description("The date of the last database backup.")]
        [DisplayName("Last Database Backup")]
        [ReadOnly(true)]
        public String LastLogBackup { get { return lastLogBackup; } }

        private String name;
        [Browsable(true)]
        [Category("Database")]
        [Description("The name of the database.")]
        [DisplayName("Name")]
        [ReadOnly(true)]
        public String Name { get { return name; } }

        private String size;
        [Browsable(true)]
        [Category("Database")]
        [Description("The size of the database.")]
        [DisplayName("Size")]
        [ReadOnly(true)]
        public String Size { get { return size; } }

        private String status;
        [Browsable(true)]
        [Category("Database")]
        [Description("The status of the database per the DB engine.")]
        [DisplayName("Status")]
        [ReadOnly(true)]
        public String Status { get { return status; } }

        public DatabaseInformation(Database database)
        {
            dateCreated = database.CreateDate;
            lastDatabaseBackup = database.LastBackupDate == DateTime.MinValue ? String.Empty : database.LastBackupDate.ToLongDateString();
            lastLogBackup = database.LastLogBackupDate == DateTime.MinValue ? String.Empty : database.LastLogBackupDate.ToLongDateString();
            name = database.Name;
            size = database.Size.ToString("#0.0#") + " MB";

            switch (database.Status)
            {
                case DatabaseStatus.AutoClosed:
                    status = "Auto Closed";
                    break;
                case DatabaseStatus.EmergencyMode:
                    status = "Emergency Mode";
                    break;
                case DatabaseStatus.Inaccessible:
                    status = "Inaccessible";
                    break;
                case DatabaseStatus.Normal:
                    status = "Normal";
                    break;
                case DatabaseStatus.Offline:
                    status = "Offline";
                    break;
                case DatabaseStatus.Recovering:
                    status = "Recovering";
                    break;
                case DatabaseStatus.RecoveryPending:
                    status = "Recovery Pending";
                    break;
                case DatabaseStatus.Restoring:
                    status = "Restoring";
                    break;
                case DatabaseStatus.Shutdown:
                    status = "Shutdown";
                    break;
                case DatabaseStatus.Standby:
                    status = "Standby";
                    break;
                case DatabaseStatus.Suspect:
                    status = "Suspect";
                    break;

            }
        }
    }
}
