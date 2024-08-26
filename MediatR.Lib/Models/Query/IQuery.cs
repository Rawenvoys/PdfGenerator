using MediatR;

namespace PdfGenerator.MediatR.Lib.Models.Query;
public interface IQuery : IRequest { }
public interface IQuery<out TQueryResponse> : IRequest<TQueryResponse> { }
