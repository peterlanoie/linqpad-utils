<Query Kind="Program" />

void Main()
{
	
}

public class LinqPadUtils
{

	public static object MakeHyperlink(string url, string text)
	{
		return Util.RawHtml($"<a href=\"{url}\">{text}</a>");
	}

}

// You can define other methods, fields, classes and namespaces here