
var result = indexesFound(new [] {9,2,5,3}, 5); //expect 1,3
Console.WriteLine(string.Join(" ", result));

result = indexesFound(new [] {9, 1, 2, 6, 7, 9, 5, 9, 11}, 13); //expect 2,8
Console.WriteLine(string.Join(" ", result));

result = indexesFound(new [] {8, 6, 4, 9, 11}, 1); //expect empty
Console.WriteLine(string.Join(" ", result));

int[] indexesFound(int[] inputArray, int valueToMatch)
{
  var length = inputArray.Length;
  for(int x = 0; x < length; x++)
  {
    for(int y = x+1; y < length; y++)
    {
      if(inputArray[x] + inputArray[y] == valueToMatch)
        return new[] { x, y };
    }
  }
  return new int[0];
}