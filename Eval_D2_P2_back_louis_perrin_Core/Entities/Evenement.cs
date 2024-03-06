using Eval_D2_P2_back_louis_perrin_Core.Common;

namespace Eval_D2_P2_back_louis_perrin_Core.Entities;

public class Evenement
{
    public Guid id;
    public string nomEvenement;
    public ETypeEvenement typeEvenement;
    public DateTime Date;

    public Evenement(Guid id, string nomEvenement, ETypeEvenement typeEvenement, DateTime date)
    {
        this.id = id;
        this.nomEvenement = nomEvenement;
        this.typeEvenement = typeEvenement;
        Date = date;
    }
}
