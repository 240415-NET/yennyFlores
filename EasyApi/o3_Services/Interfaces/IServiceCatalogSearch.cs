using EasyApi.o1_Models;

namespace EasyApi.o3_Services;

//Added this entire file
public interface IServiceCatalogSearch
{
    public Task<Book> CatalogSearchAsync(Book bookQuerySentFromController);
}