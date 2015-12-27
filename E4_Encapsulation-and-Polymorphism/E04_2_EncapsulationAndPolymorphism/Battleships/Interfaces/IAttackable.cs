namespace Battleships.Interfaces
{
    using Ships;

    public interface IAttackable
    {
        string Attack(Ship targetShip);
    }
}
