using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Smo.Agent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCamp.SmoDemo._08_Jobs
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server("localhost");

            JobServer jobServer = server.JobServer;

            foreach(Job serverJob in jobServer.Jobs)
            {
                Console.WriteLine("Job: {0} - Owner: {1}", serverJob.Name, serverJob.OwnerLoginName);
            }

            Job job = new Job(jobServer, "Clean PO Table");
            job.Create();

            JobStep jobStep = new JobStep(job, "Delete old records");
            jobStep.Command = "DELETE FROM dbo.PurchaseOrders WHERE OrderDateTime < DATEADD(DAY, -30, GETDATE())";
            jobStep.DatabaseName = "SmoDemoDatabase";

            jobStep.Create();

            JobSchedule jobSchedule = new JobSchedule(job, "Nightly Run");
            jobSchedule.ActiveStartTimeOfDay = new TimeSpan(3, 0, 0);
            jobSchedule.FrequencyInterval = 1;
            jobSchedule.FrequencyTypes = FrequencyTypes.Daily;
            jobSchedule.FrequencySubDayTypes = FrequencySubDayTypes.Once;

            jobSchedule.Create();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Finished");
            Console.ReadKey();
        }
    }
}