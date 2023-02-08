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
            if(db.OfertasdeTrabajo.Add(offer) != null)
            {
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public List<OfferModel> GetAll()
        {
            var list = new List<OfferModel>();
            list = db.OfertasdeTrabajo.ToList();
            return list;
        }

        public bool Delete(int id)
        {
            if (db.OfertasdeTrabajo.FirstOrDefault(c => c.Id == id) != null)
            {
                try
                {
                    db.OfertasdeTrabajo.Remove(db.OfertasdeTrabajo.FirstOrDefault(c => c.Id == id));
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
            if (db.OfertasdeTrabajo.FirstOrDefault(c => c.Id == id) != null)
            {
                aux = db.OfertasdeTrabajo.FirstOrDefault(c => c.Id == id);
            }
            return aux;

        }
    }
}
