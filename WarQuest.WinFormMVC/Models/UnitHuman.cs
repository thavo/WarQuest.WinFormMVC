using System.Drawing;

namespace WarQuest.WinFormMVC.Models
{
    public class UnitHuman : Unit
    {
        public UnitHuman(int speedPower, int jumpPower, int lifeLevel, int attackLevel, int cost, Bitmap myImage) 
            : base(speedPower, jumpPower, lifeLevel, attackLevel, cost, myImage)
        {
        }
    }
}