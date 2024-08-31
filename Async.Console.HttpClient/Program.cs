Console.WriteLine("Program executing...");

//this is blocking
/*
var responseTask = new HttpClient().GetAsync("http://www.fark.com");
var response = responseTask.Result;
Console.WriteLine(response.StatusCode);
*/

//using a continuation not to block
/*
var responseTask = new HttpClient().GetAsync("http://www.fark.com");
responseTask.ContinueWith(httpTask => {
  var response = httpTask.Result;
  Console.WriteLine(response.StatusCode);
});
*/

//using async/await not to block
async Task PrintStatusCodeAsync()
{
  var response = await new HttpClient().GetAsync("http://www.fark.com");
  Console.WriteLine(response.StatusCode);
}
var statusCodeTask = PrintStatusCodeAsync();


Console.WriteLine("Ready for user input!");
Console.ReadLine();