using System;
using MeetDelegatesEvents.Delegates4;

namespace MeetDelegatesEvents
{


    class Program
    {
        static void Main(string[] args)
        {
            var worker = new Worker();
            //worker.WorkPerformed += worker_WorkPerformed;
            //worker.WorkCompleted += worker_WorkCompleted;

            worker.WorkPerformed += worker_WorkPerformed;
            worker.WorkCompleted += (sender, eventArgs) => { Console.WriteLine("Worker is done working!"); };


            worker.DoWork(10, WorkType.GenerateReports);
        }

        //private static void worker_WorkCompleted(object sender, EventArgs e)
        //{
        //    Console.WriteLine("Worker is done working!");
        //}

        static void worker_WorkPerformed(object sender, WorkPerformedEventArgs e)
        {
            Console.WriteLine($"Total Work Hours : {e.Hours} in {e.WorkType}");
        }
    }
}