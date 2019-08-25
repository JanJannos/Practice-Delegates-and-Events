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
//            WorkPerformedHandler del3 = new WorkPerformedHandler(WorkPerformed3);


//            // adding delegates
//            //del1 += del2;
//            //del1 += del3;

//            // same thing as saying ...
//            del1 += del2 + del3;
//            del1(10, WorkType.Golf);  // calls all three delegates



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

//        static void WorkPerformed3(int hours, WorkType wt)
//        {
//            Console.WriteLine("WorkPerformed3 called");
//        }
//    }
//}