#region Advantages and disadvantages of using BackgroundWorker

/*

The advantages of using BackgroundWorker are as follows:

1 - Threads can be utilized to free up the main thread
2 - Threads are created and maintained in an optimal way by the ThreadPool class's CLR
3 - Graceful and automatic exception handling.
4 - Supports progress reporting, cancellation, and completion logic using events.

The disadvantage of using BackgroundWorker is that, with more threads, the code becomes difficult to debug and maintain

*/

#endregion

using System.ComponentModel;
using System.Text;

var backgroundWorker = new BackgroundWorker();

backgroundWorker.WorkerReportsProgress = true;  
backgroundWorker.WorkerSupportsCancellation = true;
backgroundWorker.DoWork += SimulateServiceCall;
backgroundWorker.ProgressChanged += ProgressChanged;
backgroundWorker.RunWorkerCompleted += RunWorkerCompleted;
backgroundWorker.RunWorkerAsync();

Console.WriteLine("To Cancel Worker Thread Press C.");

while (backgroundWorker.IsBusy)
{
    if (Console.ReadKey(true).KeyChar == 'C')
    {
        backgroundWorker.CancelAsync();
    }
}


static void SimulateServiceCall(object sender, DoWorkEventArgs e)
{
    var worker = sender as BackgroundWorker;

    StringBuilder data = new StringBuilder();

    for (int i = 1; i <= 100; i++)
    {
        if (!worker.CancellationPending)
        {
            data.Append(i);
            worker.ReportProgress(i);
            Thread.Sleep(100);
        }
        else
        {
            worker.CancelAsync();
        }
    }

    e.Result = data;
}

static void ProgressChanged(object sender , ProgressChangedEventArgs args)
{
    Console.WriteLine($"{args.ProgressPercentage}% completed");
}

static void RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
{
    if (e.Error != null)
    {
        Console.WriteLine(e.Error.Message);
    }
    else
    {
        Console.WriteLine($"Result from service call is { e.Result }");
    }
}






