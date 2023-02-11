using System.Collections.ObjectModel;
using System.Diagnostics;
using static System.Console;

{

    //Thread.CurrentThread.Name = "Main";


    //WriteLine(Thread.CurrentThread.Name);
    //WriteLine(Thread.CurrentThread.ManagedThreadId);
    //WriteLine(Thread.CurrentThread.CurrentCulture);
    //WriteLine(Thread.CurrentThread.IsAlive);
    //WriteLine(Thread.CurrentThread.Priority);
    //WriteLine(Thread.CurrentThread.ThreadState);


    //Thread t = new Thread(() => 
    //{
    //	while (true)
    //		WriteLine("\tyyyyyyyyyyyy");
    //});


    ////t.Name = "Worker";
    //t.Start();


    //while (true)
    //    WriteLine("xxxxxxxxxxx");

}





{
    //WriteLine(Process.GetCurrentProcess().Id);
    //WriteLine(Process.GetCurrentProcess().ProcessName);
    //WriteLine(Process.GetCurrentProcess().MachineName);
    //WriteLine(Process.GetCurrentProcess().BasePriority);
    //WriteLine(Process.GetCurrentProcess().PriorityClass);
    //WriteLine(Process.GetCurrentProcess().TotalProcessorTime);
    //WriteLine(Process.GetCurrentProcess().UserProcessorTime);
}






{
    //WriteLine(Process.GetProcesses().Count());

    //foreach (var item in Process.GetProcesses())
    //    WriteLine(item.Id + " - " + item.ProcessName);
}


{
    //var list = new ObservableCollection<Process>(Process.GetProcesses());
}



{
    //Process.Start("calc");
    //Process.Start("mspaint");
    //var processName = Process.Start("notepad");

    //await processName.WaitForExitAsync(); 
    //processName.WaitForExit(2000);



    //Thread.Sleep(3000);
    //processName.Kill();
}




{
    //var processStart = new ProcessStartInfo("notepad");
    //processStart.WindowStyle = ProcessWindowStyle.Maximized;

    //var p = Process.Start(processStart);
}



//Process.Start("C:\\Program Files\\Microsoft VS Code\\Code.exe");
//Process.Start("C:\\Program Files\\Microsoft Visual Studio\\2022\\Community\\Common7\\IDE\\devenv.exe");



WriteLine("Console terminated");