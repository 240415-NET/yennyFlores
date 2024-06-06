using EasyApi.o1_Models;

namespace EasyApi.o3_Services;

//Added this entire file
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