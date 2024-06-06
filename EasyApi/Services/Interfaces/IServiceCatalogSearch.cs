using EasyApi.Models;

namespace EasyApi.Services;
//Added this entire file
public interface IServiceCatalogSearch
{
    public Task<Book> CatalogSearchAsync(Book bookQuerySentFromController);
}