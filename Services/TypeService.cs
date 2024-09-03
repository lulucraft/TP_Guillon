using Microsoft.EntityFrameworkCore;
using TP_Guillon.Context.Models;

namespace TP_Guillon.Services
{
    public class TypeService(GuillonLucasContext context) : ITypeService
    {
        public List<TP_Guillon.Context.Models.Type> GetTypes()
        {
            return [.. context.Types];
        }
    }
}
