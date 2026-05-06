using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using сайт_курсач.Models;

namespace сайт_курсач.Pages.Clients
{
    public class IndexModel : PageModel

    {
        public List<Client> Clients { get; set; } = new();
        public void OnGet()
        {
            Clients = new List<Client>
        {
            new Client { Id = 1, FirstName = "Анна", Phone = "123456" },
            new Client { Id = 2, FirstName = "Иван", Phone = "987654" }
        };
        }
    }
}
