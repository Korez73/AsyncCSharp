void ProcessData()
{
  Console.WriteLine("Processing Started");
  Thread.Sleep(10000);
  Console.WriteLine("Processing Completed");
}

Console.WriteLine("Program executing...");

//this is the most simple way to run a task
//Task.Run(ProcessData);

//this is a good idea if you need to conditionally start a task
var dataTask = new Task(ProcessData);
dataTask.Start();

Console.WriteLine("Ready for user input.");
Console.ReadLine();
