using Microsoft.EntityFrameworkCore;
using TP_Guillon.Context.Models;

namespace TP_Guillon.Services
{
    public class MeubleService(GuillonLucasContext context) : IMeubleService
    {
        public List<Meuble> GetMeubles()
        {
            return [.. context.Meubles.Include(e => e.IdMateriau).Include(e => e.IdCollection).Include(e => e.IdType)];
        }
    }
}
