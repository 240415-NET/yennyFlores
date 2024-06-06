using EasyApi.Models;

namespace EasyApi.DTOs;

public class DTOCatalog
{
    public List<Book>? catalog {get; set;}

    public DTOCatalog()
    {
        this.catalog = new List<Book>();
    }

}