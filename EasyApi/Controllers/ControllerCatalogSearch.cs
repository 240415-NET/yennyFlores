//For a controller, we always want to bring in Microsoft.AspNetCore.Mvc
//This is where we get things like the ApiController annotation, and the ControllerBase class
using Microsoft.AspNetCore.Mvc;
using EasyApi.Models;
using EasyApi.DTOs;
using EasyApi.Services;

namespace EasyApi.Controllers;

//We are going to break our business logic into a Service layer outside of our controllers, to keep them
//relatively small/lightweight. Since the controllers in an ASP.NET application ideally only handle
//receiving and returning HTTP requests. 

[ApiController]
[Route("[controller]")]
public class ControllerCatalogSearch : ControllerBase
{

    //I know that im going to need at minimum a place to hold my UserService object, that will be
    //given to me by the builder when the app is dotnet run. We are NOT going to instantiate this object
    //within the controller with the usual Object myObject = new Object() style syntax. We are going to 
    //allow the builder to handle creating and then passing in that UserService object through the controller's Constructor.
    private readonly IServiceCatalogSearch _catalogService;

     //Here is my constructor where we will take in our dependencies (that are automatically passed in by the builder.)
   public ControllerCatalogSearch(IServiceCatalogSearch builderCatalogService) {

    _catalogService = builderCatalogService;
   }




 [HttpGet(Name = "/Catalog/booksList")]
public async Task<Book> ListOfBooks()
    {
      //try{ 
      var oneBook = new Book( 1, 15623, "Twilight", "Stephanie Meyer", "young adult");
       return oneBook;
       //return book;
      //}
      // catch(Exception e)
      //  {

      //      return BadRequest(e.Message);
      //  }
    }



}
