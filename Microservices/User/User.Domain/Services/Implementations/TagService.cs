using PdfGenerator.Common.Lib.Domain.Exceptions;
using PdfGenerator.User.Domain.IFinders;
using PdfGenerator.User.Domain.Models;
using PdfGenerator.User.Domain.Services.Interfaces;

namespace PdfGenerator.User.Domain.Services.Implementations;
//ToDo: Spodobal mi sie pomysl z Services/Implementations oraz Services/Interfaces, wymysl jeszcze cos tak extra na IFinders oraz IRepository
//ToDo: Mysle tez nad tym jak rozroznic serwisy publiczne oraz te niepubliczne dla swiata zewnetrznego
public class TagService(ITagFinder tagFinder) : ITagService
{
    private readonly ITagFinder _tagFinder = tagFinder;
    private readonly TagGenerator _tagGenerator = new(8);


    //ToDo: Test jednostkowy
    public async Task<TagModel> GenerateUniqueAsync()
    {
        const int iterationLimit = 100;
        int iteration = 1;
        do
        {
            var tag = _tagGenerator.Generate();
            bool isTagUnique = await _tagFinder.UniqueAsync(tag);

            if (isTagUnique) return tag;

            iteration = iteration switch
            {
                < iterationLimit => iteration + 1,
                _ => throw new LoopIterationLimitReachedException(iterationLimit)
            };

        } while (true);
    }
}
