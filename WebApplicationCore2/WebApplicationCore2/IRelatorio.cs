using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace WebApplicationCore2
{
    public interface IRelatorio
    {
        Task Imprimir(HttpContext context);
    }
}