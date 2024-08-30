async Task ProcessData(string[] departments, IProgress<int> progress)
{
  for(int i = 1; i <= departments.Count(); i++)
  {
    progress.Report(i);
    //simulate data processing
    await Task.Delay(2000);
  }
  Console.WriteLine("Done processing data.");
}

Console.WriteLine("Program is running.");

string[] departments = { "Engineering", "Sales", "Marketing", "Support"};
IProgress<int> progressReporter = new Progress<int>(i => Console.WriteLine($"Processing department {i}"));
var dataTask = ProcessData(departments, progressReporter);
Console.WriteLine("Ready for user input.");
await dataTask;
