using System;
using System.Text.RegularExpressions;

public class Program
{
	public static void Main()
	{
		string input = "Kittens!!!!!!!!!!!";
		string output = Test(input);
		Console.WriteLine("Match Found: " + output);
	}

	///"\{(.*?);(.*?);(.*?)\}"
	private static readonly Regex Pattern = new Regex("{Kittens?!*}", RegexOptions.Compiled);
	public static string Test(string input)
	{
		return Pattern.Replace(input, match =>
		{
			string newMatch = match.Groups[1].Value;
			return ">> " + newMatch + " <<";
		});
	}
}
