using System;

public class titleCase
{
    private string inputString;

    public titleCase()
    {
        inputString = "";
    }

    public titleCase( string input )
    {
        inputString = input;
    }

    public string makeTitleCase()
    {
        string outputString = "";

        string[] inputWords = inputString.Split(" ");

        foreach (string word in inputWords)
        {
            outputString += word.Substring(0, 1).ToUpper();
            outputString += word.Substring(1).ToLower() + " ";
        }

        return outputString;
    }

    public string InputString
    {
        get
        {
            return inputString;
        }
        set
        {
            inputString = value;
        }
    }
} 