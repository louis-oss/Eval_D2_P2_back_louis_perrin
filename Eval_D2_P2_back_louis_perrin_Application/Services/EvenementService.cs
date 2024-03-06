using Eval_D2_P2_back_louis_perrin_Application.Interfaces;
using Eval_D2_P2_back_louis_perrin_Core.Entities;

namespace Eval_D2_P2_back_louis_perrin_Application.Services;

public class EvenementService : IEvenementService
{
    public Task<Evenement> AddEvent(Evenement evenement)
    {
        throw new NotImplementedException();
    }

    public Task DeleteEvent(string title)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Evenement>> ListEvents()
    {
        throw new NotImplementedException();
    }

    public Task<Evenement> UpdateEvent(string title, Evenement evenement)
    {
        throw new NotImplementedException();
    }
}
