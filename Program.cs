using System;
using System.Text.RegularExpressions;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
	// \s [:space:]
	var regex = new Regex("^[A-Z][a-z]*$");
	var values = new []
	    {
		"string",
		"String",
		"Str1ng",
		" String "
	    };
	foreach (var s in values)
	{
	    var m = regex.IsMatch(s);
	    Console.WriteLine($"{s} matches? {m}");
	}

	regex = new Regex("i");
	foreach (var s in values)
	{
	    var m = regex.Match(s);
	    Console.WriteLine($"{s} matches? {m.Success}");
	    if (m.Success)
	    {
		Console.WriteLine($"\tMatched at: {m.Index}");
	    }
	}	
    }
}
