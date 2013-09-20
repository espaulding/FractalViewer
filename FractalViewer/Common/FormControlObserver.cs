using System.Windows.Forms;

namespace FractalViewer
{
    public class FormControlObserver
    {
        //controls to be updated by worker thread
        private volatile ProgressBar status;
        private volatile Button stop;
        private volatile Button btnPortal;

        //delegates required for invoking
        protected delegate void percentDel(int percent);
        protected delegate void toggleDel(bool toggle);

        //Constructor
        public FormControlObserver(ProgressBar p, Button b, Button portal)
        {
            status = p;
            stop = b;
            btnPortal = portal;
        }

        public void updateStatusbar(int completion)
        {
            //Every control has a handle which is the id related to the thread that created the control
            //when any property of a control is updated or changed that handle is checked against the
            //current thread's id. If it does not match InvokeRequired will be true because ONLY the 
            //control's parent thread is allowed to make changes to the control
            if (status.InvokeRequired == false)
            {
                status.Visible = true;
                status.Value = completion;
            }
            else
            {
                //This thread did not have permission to update the statusbar so we need to make an invoke
                //which is basically a request to the thread that owns this control to run the callback that
                //we create the delegate with
                //The callback is just a pointer to a function so that the parent thread knows what code to run.
                percentDel d = new percentDel(updateStatusbar);
                //Invoke is a synchronous call to the parent thread. That means that this thread will block
                //until the parent thread responds and completes running the requested code
                status.Invoke(d, new object[] { completion });
            }
        }

        public void toggleStatusbar(bool visible)
        {
            if (status.InvokeRequired == false)
            {
                status.Visible = visible;
            }
            else
            {
                toggleDel d = new toggleDel(toggleStatusbar);
                status.Invoke(d, new object[] { visible });
            }
        }

        public void togglePortalButton(bool enabled)
        {
            if (status.InvokeRequired == false)
            {
                btnPortal.Enabled = enabled;
            }
            else
            {
                toggleDel d = new toggleDel(togglePortalButton);
                status.Invoke(d, new object[] { enabled });
            }
        }

        public void toggleStopButton(bool visible)
        {
            if (stop.InvokeRequired == false)
            {
                stop.Visible = visible;
            }
            else
            {
                toggleDel d = new toggleDel(toggleStopButton);
                stop.Invoke(d, new object[] { visible });
            }
        }
    }
}
