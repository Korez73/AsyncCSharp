using System.Diagnostics.Contracts;

Console.WriteLine("Program is running");

string filename = @"data.txt";
byte[] contents;

CancellationTokenSource cts = new CancellationTokenSource();
//cts.CancelAfter(500); //this is more than enough time
cts.CancelAfter(0);


try
{
  using (FileStream dataStream = File.Open(filename, FileMode.Open))
  {
    contents = new byte[dataStream.Length];
    await dataStream.ReadAsync(contents, 0, (int)dataStream.Length, cts.Token);
    Console.WriteLine(System.Text.Encoding.ASCII.GetString(contents));
  }
}
catch (Exception ex)
{
  Console.WriteLine($"Exception type: {ex.GetType()}");
}
finally
{
  //important to note that CancellationTokenSource implements IDisposable
  //so we either need to wrap it a "using" block, or call Dispose some other way
  cts.Dispose();
}
