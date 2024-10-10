using PdfGenerator.User.Domain.Models;

namespace PdfGenerator.User.Domain.Exceptions;
public class EmptyTagException() : ArgumentNullException(nameof(TagModel), "Tag must have a value") { }
