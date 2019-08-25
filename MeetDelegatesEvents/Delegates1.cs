//using System;

//namespace MeetDelegatesEvents
//{
//    public enum WorkType
//    {
//        GoToMeetings,
//        Golf,
//        GenerateReports
//    }

//    public delegate void WorkPerformedHandler(int hours, WorkType workType);
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            WorkPerformedHandler del1 = new WorkPerformedHandler(WorkPerformed1);
//            WorkPerformedHandler del2 = new WorkPerformedHandler(WorkPerformed2);

//            // version 1
//            del1(5, WorkType.GenerateReports);
//            del2(10, WorkType.Golf);

//            // version 2
//            DoWork(del1);
//            DoWork(del2);
//        }

//        static void DoWork(WorkPerformedHandler handler)
//        {
//            handler(5, WorkType.GoToMeetings);
//        }

//        static void WorkPerformed1(int hours, WorkType wt)
//        {
//            Console.WriteLine("WorkPerformed1 called");
//        }   

//        static void WorkPerformed2(int hours, WorkType wt)
//        {
//            Console.WriteLine("WorkPerformed2 called");
//        }
//    }
//}
