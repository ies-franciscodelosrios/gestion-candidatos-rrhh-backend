using IGapi.Context;
using IGapi.Models;

namespace IGapi.Repositories
{
    public class OfferRepository
    {
        private readonly ApplicationDBContext db;

        public OfferRepository(ApplicationDBContext db)
        {
            this.db = db;
        }

        public bool Insert(OfferModel offer)
        {
            if (offer != null) 
            {
                try
                {
                    db.Offers.Add(offer);
                    db.SaveChanges();
                    return true;
                }catch(Exception ex)
                {
                    throw;
                }
            }
            return false;
        }

        public List<OfferModel> GetAll()
        {
            var list = new List<OfferModel>();
            list = db.Offers.ToList();
            return list;
        }
    }
}
