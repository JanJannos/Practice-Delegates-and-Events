//using System;
//using MeetDelegatesEvents.Delegates4;

//namespace MeetDelegatesEvents
//{
  
    
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var worker = new Worker();
//            worker.WorkPerformed += new EventHandler<WorkPerformedEventArgs>(worker_WorkPerformed);
//            worker.WorkCompleted += WorkerOnWorkCompleted;
//            worker.DoWork(10 , WorkType.GenerateReports);
//        }

//        private static void WorkerOnWorkCompleted(object sender, EventArgs e)
//        {
//            Console.WriteLine("Woker is done working!");
//        }

//        static void worker_WorkPerformed(object sender, WorkPerformedEventArgs e)
//        {
//            Console.WriteLine($"Total Work Hours : {e.Hours} in {e.WorkType}");
//        }
//    }
//}