using EasyApi.Models;

namespace EasyApi.Services;

public interface IServiceCatalogSearch
{
    public Task<Book> CatalogSearchAsync(Book bookQuerySentFromController);
}