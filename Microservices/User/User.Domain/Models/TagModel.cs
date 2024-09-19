using PdfGenerator.Common.Lib.Domain.Models;
using PdfGenerator.User.Domain.Exceptions;

namespace PdfGenerator.User.Domain.Models;
public class TagModel : ValueObject
{
    private readonly int _expectedSize = 8;

    public TagModel(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new EmptyTagException();

        if (value.Length != _expectedSize)
            throw new InvalidTagLengthException(value, _expectedSize);

        Value = value;
    }

    public string Value { get; set; }
}
