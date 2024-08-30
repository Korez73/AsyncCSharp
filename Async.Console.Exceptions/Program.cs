using System.Net;

async Task PrintStatusCodeAsync()
{
  try
  {

    //fire and forget.  returns a task that we don't await.  will silently error.  
		//new HttpClient().GetAsync("http://expired.badssl.com");

    //now we effectively 'await' it by asking for the result
    //and we get an AggregateException in the catch, and would have to iterate thru to find our HTTP
    //also seems to block more than the ideal solution below
		//var responseTask = new HttpClient().GetAsync("http://expired.badssl.com");
    //var response = responseTask.Result;

    //here, because we're using the 'await' keyword, the exception in the catch is the HTTPRequestException we want
    var response = await new HttpClient().GetAsync("http://expired.badssl.com");
    Console.WriteLine(response.StatusCode);
  }
  catch(Exception e)
  {
    Console.WriteLine($"Something bad of this type happened:{e.GetType()}");
  }
}


Console.WriteLine("Program Executing...");

var statusCodeTask = PrintStatusCodeAsync();

Console.WriteLine("Ready for user input!");
Console.ReadLine();