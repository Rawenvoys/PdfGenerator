namespace PdfGenerator.User.Domain.Models;
public class UserModel(Guid id, string login)
{
    public Guid Id { get; set; } = id;
    public string Login { get; set; } = login;
}
