using Moq;
using PdfGenerator.Common.Lib.Domain.Exceptions;
using PdfGenerator.User.Domain.IFinders;
using PdfGenerator.User.Domain.Models;
using PdfGenerator.User.Domain.Services.Implementations;

namespace PdfGenerator.User.Domain.Tests.Services.Implementations;
public class TagServiceTests
{
    private readonly Mock<ITagFinder> _tagFinderMock;

    public TagServiceTests()
    {
        _tagFinderMock = new Mock<ITagFinder>();
    }

    [Fact]
    public async Task GenerateUniqueAsync_IteratorLimitReached()
    {
        //Arrange
        _tagFinderMock.Setup(t => t.UniqueAsync(It.IsAny<TagModel>())).ReturnsAsync(false);
        var tagService = new TagService(_tagFinderMock.Object);

        //Act
        
        //Assert
        await Assert.ThrowsAsync<LoopIterationLimitReachedException>(tagService.GenerateUniqueAsync);
    }
}
