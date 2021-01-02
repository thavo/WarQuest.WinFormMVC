namespace WarQuest.WinFormMVC.Models
{
    public class UnitDestroyer : Unit, IUnitDestroyer
    {
        public UnitDestroyer(int speedPower, int jumpPower, int lifeLevel, int attackLevel, int cost) : base(speedPower, jumpPower, lifeLevel, attackLevel, cost)
        {
        }

        public int DestroyType { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}