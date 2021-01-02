namespace WarQuest.WinFormMVC.Models
{
    public class UnitBuilder : Unit, IUnitBuilder
    {
        public UnitBuilder(int speedPower, int jumpPower, int lifeLevel, int attackLevel, int cost)  : base(speedPower, jumpPower, lifeLevel, attackLevel, cost)
        {
        }

        public int BuidingType { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}