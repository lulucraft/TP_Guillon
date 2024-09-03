using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using TP_Guillon.Context.Models;

namespace TP_Guillon.Services
{
    public class MateriauService(GuillonLucasContext context) : IMateriauService
    {
        public List<Materiau> GetMateriaux()
        {
            return [..context.Materiaux.Include(e => e.Meubles)];
        }

        public EntityEntry<Materiau> UpdateMateriau(Materiau materiau)
        {
            return context.Update(materiau);
        }

        public void RemoveMateriau(Materiau materiau)
        {
            context.Remove(materiau);
        }
    }
}
