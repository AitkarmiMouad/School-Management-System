using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System
{
    public class Invoker
        {
            public CommonDialog InvokeDialog;
            private Thread InvokeThread;
            private DialogResult InvokeResult;

            public Invoker(CommonDialog dialog)
            {
                InvokeDialog = dialog;
                InvokeThread = new Thread(new ThreadStart(InvokeMethod));
                InvokeThread.SetApartmentState(ApartmentState.STA);
                InvokeResult = DialogResult.None;
            }

            public DialogResult Invoke()
            {
                InvokeThread.Start();
                InvokeThread.Join();
                return InvokeResult;
            }

            private void InvokeMethod()
            {
                InvokeResult = InvokeDialog.ShowDialog();

            }
        }
    }
