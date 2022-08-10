#region Thread class

/*
 
Advantages and disadvantages of threads

** The Thread class has the following advantages:

1 - Threads can be utilized to free up the main thread.
2 - Threads can be used to break up a task into smaller units that can be executed concurrently.

** The Thread class has the following disadvantages:

1 - With more threads, the code becomes difficult to debug and maintain.
2 - Thread creation puts a load on the system in terms of memory and CPU resources.
3 - We need to do exception handling inside the worker method as any unhandled exceptions can result in the program crashing 

*/

#endregion

#region Example 1

Console.WriteLine("Start Application ...."); // Main Tread

PrintNumber10Times(); // Main Thread

Console.WriteLine("End Application ....");  // Main Thread

static void PrintNumber10Times()
{
    for (int i = 0; i < 10; i++)
    {
        Console.Write(1);
    }

    Console.WriteLine();
}

#endregion

#region Example 2

//Console.WriteLine("Start Application ...."); // Main Tread

//CreateThreadUsingThreadClassWithParameter(); // Child Thread

//Console.WriteLine("End Application ....");  // Main Thread

//static void CreateThreadUsingThreadClassWithParameter()
//{
//    Thread thread;

//    thread = new Thread(new ParameterizedThreadStart(PrintNumberNTimes));

//    thread.Start(10);
//}

//static void PrintNumberNTimes(object? times)
//{
//    int n = Convert.ToInt32(times);

//    for (var i = 0; i < n; i++)
//    {
//        Console.Write(1);
//    };

//    Console.WriteLine();
//}

#endregion

#region Example 3

//Console.WriteLine("Start Application ...."); // Main Tread

//CreateThreadUsingThreadClassWithoutParameter(); // Child Thread

//Console.WriteLine("End Application ....");  // Main Thread

//static void CreateThreadUsingThreadClassWithoutParameter()
//{
//    Thread thread;
//    thread = new Thread(new ThreadStart(PrintNumber10Times));

//    thread.Start();
//}

//static void PrintNumber10Times()
//{
//    for (int i = 0; i < 10; i++)
//    {
//        Console.Write(1);
//    }

//    Console.WriteLine();
//}

#endregion

