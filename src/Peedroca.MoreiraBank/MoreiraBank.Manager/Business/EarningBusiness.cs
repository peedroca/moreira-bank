using MoreiraBank.Manager.Data;
using MoreiraBank.Manager.Data.Repositories;
using MoreiraBank.Manager.Models;

namespace MoreiraBank.Manager.Business
{
    internal class EarningBusiness
    {
        private readonly EarningRepository _earningRepository;

        public EarningBusiness()
        {
            _earningRepository = new EarningRepository();
        }

        public Response<EarningModel> Create(EarningModel model)
        {
            if (!model.IsValid)
                return new Response<EarningModel>(model.Notifications);

            Earning earning = model;

            _earningRepository.Create(earning);
            _earningRepository.SaveChanges();

            return new Response<EarningModel>(earning);
        }

        public IEnumerable<EarningModel> List(long profileId)
        {
            return _earningRepository.GetAll(profileId).Select(s => (EarningModel)s);
        }
    }
}
