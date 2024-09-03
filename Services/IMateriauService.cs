using Microsoft.EntityFrameworkCore.ChangeTracking;
using TP_Guillon.Context.Models;

namespace TP_Guillon.Services
{
    public interface IMateriauService
    {
        List<Materiau> GetMateriaux();

        EntityEntry<Materiau> UpdateMateriau(Materiau materiau);

        void RemoveMateriau(Materiau materiau);
    }
}
