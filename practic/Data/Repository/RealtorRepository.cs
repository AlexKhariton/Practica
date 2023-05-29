using Microsoft.EntityFrameworkCore;
using practic.Data.Interfaces;
using practic.Data.Models;
using System.Linq;

namespace practic.Data.Repository
{
    public class RealtorRepository : IAllRealtors
    {
        private readonly AppDBContent appDBContent;
        public RealtorRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Realtor> Realtors => appDBContent.Realtor.Include(c => c.Category);

        public Realtor getObjRealtor(int id) => appDBContent.Realtor.FirstOrDefault(p => p.id == id);
    }
}
