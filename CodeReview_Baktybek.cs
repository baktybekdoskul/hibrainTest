using System;
public class CodeReview

{
/// <summary>

/// This method returns integer parsed from the source.

/// If parsing fails it should return zero.

/// </summary>

/// <param name="o">Object with data to parse.</param>

/// <returns>Parsed value</returns>

	public static int Parse(object o)
	
	{
		try{
			return int.Parse(o.ToString());
		}
		catch{
			return 0;
		}
	}

/// <summary>

/// This method returns concatenated string from the array of the strings.

/// </summary>

/// <param name="lines">Array of strings with lines.</param>

/// <returns>Concatenated string.</returns>

	public static string Concat(string[] lines)
	
	{
	
		string result="";
		
		for(int i = 0; i < lines.Length; i++)
		
		{
		
			result += lines[i];
		
		}
		
		return result;
	
	}

}