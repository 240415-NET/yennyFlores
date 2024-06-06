using EasyApi.Models;

namespace EasyApi.Services;

public class ServiceCatalogSearch : IServiceCatalogSearch
{
 
    public ServiceCatalogSearch()
    {

    }

    public async Task<Book> CatalogSearchAsync(Book bookQuerySentFromController)
    {
        
        return bookQuerySentFromController;
    }

   
}