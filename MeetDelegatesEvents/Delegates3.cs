//using System;

//namespace MeetDelegatesEvents
//{
//    public enum WorkType
//    {
//        GoToMeetings,
//        Golf,
//        GenerateReports
//    }

//    public delegate int WorkPerformedHandler(int hours, WorkType workType);
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
            
//            int finalHours = del1(10, WorkType.Golf);  // calls all three delegates
//            Console.WriteLine(finalHours);

//            // prints 13 , takes the 10 and adds the 3 from the last delegate

//        }

//        static void DoWork(WorkPerformedHandler handler)
//        {
//            handler(5, WorkType.GoToMeetings);
//        }

//        static int WorkPerformed1(int hours, WorkType wt)
//        {
//            Console.WriteLine("WorkPerformed1 called");
//            return hours + 1;
//        }

//        static int WorkPerformed2(int hours, WorkType wt)
//        {
//            Console.WriteLine("WorkPerformed2 called");
//            return hours + 2;
//        }

//        static int WorkPerformed3(int hours, WorkType wt)
//        {
//            Console.WriteLine("WorkPerformed3 called");
//            return hours + 3;
//        }
//    }
//}