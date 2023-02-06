using IGapi.Dtos;
using IGapi.Models;
using IGapi.Repositories;

namespace IGapi.Services
{
    public class Offer_ApplicationService
    {
        private readonly Offer_ApplicationRepository offer_applicationRepo;

        public Offer_ApplicationService(Offer_ApplicationRepository offer_applicationRepo)
        {
            this.offer_applicationRepo = offer_applicationRepo;
        }

        public bool Insert(Offer_ApplicationDto offer_Application)
        {
            if(offer_Application != null)
            {
                var aux = new Offer_ApplicationModel()
                {
                    Assignment_Date =   offer_Application.Assignment_Date,
                    Description =       offer_Application.Description,
                    Entry_Date =        offer_Application.Entry_Date,
                    Id_Candidate =      offer_Application.Id_Candidate,
                    Id_Oferta =         offer_Application.Id_Oferta,
                    IsAccepted =        offer_Application.IsAccepted
                };
                if(offer_Application.Technical_Test != null ) 
                {
                    var ms = new MemoryStream();
                    offer_Application.Technical_Test.CopyTo(ms);
                    var fileBytes = ms.ToArray();
                    aux.Technical_Test = fileBytes;
                }
                return offer_applicationRepo.Insert(aux);
            }
            return false;
            
        }
    }
}
