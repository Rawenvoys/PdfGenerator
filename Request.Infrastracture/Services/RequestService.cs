using PdfGenerator.Request.Domain.IServices;
using PdfGenerator.Request.Domain.Models;
using PdfGenerator.Request.Infrastracture.IRepositories;
using PdfGenerator.Template.Domain.IServices;

namespace PdfGenerator.Request.Infrastracture.Services;
internal class RequestService(ITemplateService templateService, IRequestRepository requestRepository) : IRequestService
{
    private readonly ITemplateService _templateService = templateService;
    private readonly IRequestRepository _requestRepository = requestRepository;
    //private readonly IDataService _dataService = dataService;

    public async Task<Guid> Save(string templateName, string xmlData)
    {
        var templateModel = await _templateService.GetAsync(templateName);
        var requestId = await _requestRepository.SaveAsync(templateModel.Id);
        //await _dataService.SaveAsync(xmlData);

        return requestId;
    }
}
