//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/
//https://www.geeksforgeeks.org/garbage-collection-in-c-sharp-dot-net-framework/
using System.Diagnostics;
using System.Text;
using static System.Console;

Stopwatch stopwatch = new();
stopwatch.Start();
string s1 = string.Empty;
WriteLine($"s1 : {GC.GetGeneration(s1)}");
for (int i = 0; i < 100000; i++)
{
    s1 += "a";
}
stopwatch.Stop();
WriteLine($"String: {stopwatch.ElapsedMilliseconds} ms");
WriteLine($"s1 : {GC.GetGeneration(s1)}");
stopwatch.Restart();
StringBuilder s2 = new();

for (int i = 0; i < 100000; i++)
{
    s2.Append("a");
}
stopwatch.Stop();
WriteLine($"StringBuilder: {stopwatch.ElapsedMilliseconds} ms");
WriteLine($"s2 : {GC.GetGeneration(s2)}");

// String: 1000 ms
// StringBuilder: 0 ms

