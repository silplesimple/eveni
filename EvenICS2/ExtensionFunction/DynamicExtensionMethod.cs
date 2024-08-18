using System;

static class DynamicExtensionMethod
{
    static string PreDoNet(this string str) => $".....{str}";
    static void Main()
    {
        string s1 = "DotNet";
        Console.WriteLine(s1.PreDoNet());

        dynamic d1 = "Korea";
        Console.WriteLine(d1.PreDoNet());
    }
}