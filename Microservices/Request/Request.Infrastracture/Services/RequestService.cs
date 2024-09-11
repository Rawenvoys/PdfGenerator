using PdfGenerator.Data.Domain.IServices;
using PdfGenerator.Data.Domain.Models;
using PdfGenerator.Request.Domain.IServices;
using PdfGenerator.Request.Infrastracture.IRepositories;
using PdfGenerator.Template.Domain.IServices;

namespace PdfGenerator.Request.Infrastracture.Services;
internal class RequestService(ITemplateService templateService, IRequestRepository requestRepository, IDataService dataService) : IRequestService
{
    private readonly ITemplateService _templateService = templateService;
    private readonly IRequestRepository _requestRepository = requestRepository;
    private readonly IDataService _dataService = dataService;

    public async Task<Guid> SaveAsync(string templateName, string json)
    {
        var templateModel = await _templateService.GetAsync(templateName);
        var requestId = await _requestRepository.SaveAsync(templateModel.Id);
        await _dataService.SaveAsync(requestId, new DataModel(json));
        return requestId;
    }
}
