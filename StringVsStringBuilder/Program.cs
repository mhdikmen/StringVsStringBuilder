//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/

using System.Diagnostics;
using System.Text;

Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();
string s1 = string.Empty;

for (int i = 0; i < 100000; i++)
{
    s1 += "a";
}
stopwatch.Stop();
Console.WriteLine($"String: {stopwatch.ElapsedMilliseconds} ms");
stopwatch.Restart();
StringBuilder s2 = new StringBuilder();
for (int i = 0; i < 100000; i++)
{
    s2.Append("a");
}
stopwatch.Stop();
Console.WriteLine($"StringBuilder: {stopwatch.ElapsedMilliseconds} ms");