using System.Security.Cryptography;

//ToDo: Po rozmowie ze Żbikiem to ja już sam nie wiem czy to powinno być tutaj właśnie jako taki model czy jednak implementacja jako technikalia do Infrastracture
//ToDo: Z jednej strony nie ma tu nic co nie byloby logika Biznesowa, Biznes decyduje ze chce miec 8 znakow, biznes decyduje ze ma to byc A-Z oraz 0-9
namespace PdfGenerator.User.Domain.Models;
internal class TagGenerator
{
    private readonly char[] _allowedLetters = "ABCDEFGHIJKLMNOPQRSTUVQXYZ".ToCharArray();
    private readonly char[] _allowedDigits = "0123456789".ToCharArray();
    private readonly char[] _allowedSigns;
    private int signsLength => _allowedSigns.Length;

    public int RequestedSize { get; set; }

    public TagGenerator(int requestedSize)
    {
        RequestedSize = requestedSize;
        _allowedSigns = [.. _allowedLetters, .. _allowedDigits];
    }

    public TagGenerator(int requestedSize, string allowedSigns)
    {
        RequestedSize = requestedSize;
        _allowedSigns = [.. allowedSigns];
    }

    private IEnumerable<char> generateTagValue()
    {
        for (int i = 0; i<RequestedSize;i++)
        {
            var index = RandomNumberGenerator.GetInt32(1, signsLength);
            yield return _allowedSigns[index];
        }
    }

    public TagModel Generate() 
        => new(string.Concat(generateTagValue()));


}
