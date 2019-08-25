//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace MeetDelegatesEvents.Delegates4
//{
//    public enum WorkType
//    {
//        GoToMeetings,
//        Golf,
//        GenerateReports
//    }


//    public delegate int WorkPerformedHandler(int hours, WorkType workType);


//    public class Worker
//    {
        

//        public event WorkPerformedHandler WorkPerformed;
//        public event EventHandler WorkCompleted;

//        public void DoWork(int hours, WorkType wt)
//        {
//            // Not a good approach

//            //for (int i = 0; i < hours; i++)
//            //{
//            //    WorkPerformed(i + 1, wt);
//            //    // there is a flaw here : if nobody is attached to WorkPerformed
//            //    // we'll get an exception 
//            //}

//            for (int i = 0; i < hours; i++)
//            {
//                OnWorkPerformed(i+1 , wt);
//            }

//            OnWorkCompleted();
//        }

//        protected virtual void OnWorkPerformed(int hours, WorkType wt)
//        {
//            // 1 way

//            //if (WorkPerformed != null)
//            //{
//            //    WorkPerformed(hours, wt);
//            //}


//            // way 2

//            var del = WorkPerformed as WorkPerformedHandler;
//            if (del != null)
//            {
//                del(hours, wt);
//            }
//        }


//        protected virtual void OnWorkCompleted()
//        {
//            var del = WorkCompleted as EventHandler;
//            if (del != null)
//            {
//                del(this, EventArgs.Empty);
//            }
//        }
//    }
//}
