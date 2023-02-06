using IGapi.Context;
using IGapi.Models;

namespace IGapi.Repositories
{
    public class Offer_ApplicationRepository
    {
        private readonly ApplicationDBContext db;

        public Offer_ApplicationRepository(ApplicationDBContext db)
        {
            this.db = db;
        }

        public bool Insert(Offer_ApplicationModel offer_aplicattion)
        {
            if (offer_aplicattion != null) 
            {
                try
                {
                    db.Orders.Add(offer_aplicattion);
                    db.SaveChanges();
                    return true;
                }catch(Exception ex)
                {
                    throw;
                }
            }
            return false;
        }
    }
}
