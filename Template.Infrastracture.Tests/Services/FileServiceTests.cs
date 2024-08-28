using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Routing;
using Moq;
using PdfGenerator.Template.Infrastracture.Services;

namespace Template.Infrastracture.Tests.Services;
public class FileServiceTests
{
    private readonly Mock<IWebHostEnvironment> _webHostEnviroment;
    public FileServiceTests()
    {
        _webHostEnviroment = new Mock<IWebHostEnvironment>();
    }


    [Theory]
    [InlineData("0810246B-FE37-40C5-8756-D1BF94157E89", "6E4146B8-6DFE-47FA-A2E8-9EBB167DC1BC", "wwwroot\\0810246B-FE37-40C5-8756-D1BF94157E89\\6E4146B8-6DFE-47FA-A2E8-9EBB167DC1BC")]
    public void GetFilePath_Ok(Guid userId, Guid templateId, string expected)
    {
        //Arrange
        _webHostEnviroment.Setup(x => x.WebRootPath).Returns("wwwroot");
        var fileService = new FileService(_webHostEnviroment.Object);

        //Act
        var actual = fileService.GetFilePath(userId, templateId);

        //Assert
        Assert.Equal(actual, expected);
    }
}
