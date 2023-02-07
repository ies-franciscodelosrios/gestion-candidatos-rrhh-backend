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
                    return false;
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

        public bool Delete(int id)
        {
            if (db.Offers.FirstOrDefault(c => c.Id == id) != null)
            {
                try
                {
                    db.Offers.Remove(db.Offers.FirstOrDefault(c => c.Id == id));
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }

        public OfferModel GetById(int id)
        {
            var aux = new OfferModel();
            if (db.Offers.FirstOrDefault(c => c.Id == id) != null)
            {
                aux = db.Offers.FirstOrDefault(c => c.Id == id);
            }
            return aux;

        }
    }
}
