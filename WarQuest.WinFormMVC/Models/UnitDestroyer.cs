using System.Drawing;

namespace WarQuest.WinFormMVC.Models
{
    public class UnitDestroyer : Unit, IUnitDestroyer
    {
        public UnitDestroyer(int speedPower, int jumpPower, int lifeLevel, int attackLevel, int cost, Bitmap myImage) 
            : base(speedPower, jumpPower, lifeLevel, attackLevel, cost, myImage)
        {
        }

        public int DestroyType { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}