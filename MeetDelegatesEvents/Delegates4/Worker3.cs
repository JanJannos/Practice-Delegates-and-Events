//using System;
//using System.Collections.Generic;
//using System.Text;


//// Same thing as Worker1 , with one difference that here we have
//// WorkPerformedEventArgs that inherits from EventArgs

//namespace MeetDelegatesEvents.Delegates4
//{
//    public enum WorkType
//    {
//        GoToMeetings,
//        Golf,
//        GenerateReports
//    }

   
//    // public delegate int WorkPerformedHandler(object sender, WorkPerformedEventArgs e);


//    public class Worker
//    {

//        // public event WorkPerformedHandler WorkPerformed;
//        public event EventHandler<WorkPerformedEventArgs> WorkPerformed;
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
//                System.Threading.Thread.Sleep(1000);
//                OnWorkPerformed(i + 1, wt);
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

//            // var del = WorkPerformed as WorkPerformedHandler;
//            var del = WorkPerformed as EventHandler<WorkPerformedEventArgs>;
//            if (del != null)
//            {
//                del(this, new WorkPerformedEventArgs(hours, wt));
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