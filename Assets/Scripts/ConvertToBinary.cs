using System.Collections.Generic;

public static class ConvertToBinary 
{
    private static List<int> _binaryNumber = new List<int>();

    //Recursive algorithm to convert integer input into binary digits
    //Output will be stored in reverse order
    private static int ConvertInteger(int value)
    {
        int _valueToAdd = value % 2;
        _binaryNumber.Add(_valueToAdd);
        if (value > 1)
        {
            ConvertInteger(value / 2);
        }
        return value;
    }

    //Builds a string out of the elements of List binaryNumber
    private static string SetToString()
    {
        string _binaryString = "";
        _binaryNumber.Reverse();

        for (int i = 0; i < _binaryNumber.Count; i++)
        {
            _binaryString += _binaryNumber[i];
        }
        
        return _binaryString;
    }

    //Public method for converting an int into a string of equal binary value
    public static int GetConversion(int value)
    {
        ConvertInteger(value);
        string _conversionString = SetToString();
        int _convertedInt = int.Parse(_conversionString);
        _binaryNumber.Clear();
        return _convertedInt;
    }
}
