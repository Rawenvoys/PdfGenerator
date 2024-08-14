using PdfTemplate.Domain.Models;
using System;
using System.Threading.Tasks;

namespace PdfTemplate.Domain.IServices
{
    public interface IPdfTemplateService
    {
        Task<PdfTemplateModel> Get(Guid id);
    }
}
