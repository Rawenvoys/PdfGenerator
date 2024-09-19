namespace PdfGenerator.User.Domain.Exceptions;
public class InvalidTagLengthException(string value, int expectedSize) 
    : Exception($"Invalid Tag Length for value: {value}. Expected size is {expectedSize} instead of {value.Length}") { }
