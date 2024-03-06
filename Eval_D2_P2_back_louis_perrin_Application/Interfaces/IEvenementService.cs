using Eval_D2_P2_back_louis_perrin_Core.Entities;

namespace Eval_D2_P2_back_louis_perrin_Application.Interfaces;

public interface IEvenementService
{
    Task<Evenement> AddEvent(Evenement evenement);
    Task<IEnumerable<Evenement>> ListEvents();
    Task<Evenement> UpdateEvent(string title, Evenement evenement);
    Task DeleteEvent(string title);
}
