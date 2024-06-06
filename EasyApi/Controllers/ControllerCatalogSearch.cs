using Microsoft.AspNetCore.Mvc;
using EasyApi.Models;
using EasyApi.Services;
//Added this file, created folders as well
namespace EasyApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ControllerCatalogSearch : ControllerBase
{

 private readonly IServiceCatalogSearch _catalogService;

   public ControllerCatalogSearch(IServiceCatalogSearch builderCatalogService) {

    _catalogService = builderCatalogService;
   }


 [HttpGet(Name = "/Catalog/booksList")]
public async Task<Book> ListOfBooks()
    {
      
      var oneBook = new Book( 1, 15623, "Twilight", "Stephanie Meyer", "young adult");
       return oneBook;
      
      
      
    }



}
