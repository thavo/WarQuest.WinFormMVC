using System.Drawing;

namespace WarQuest.WinFormMVC.Models
{
    public class UnitHuman : Unit
    {
        public UnitHuman(int index, int speedPower, int jumpPower, int lifeLevel, int attackLevel, int cost, Bitmap myImage) 
            : base(index, speedPower, jumpPower, lifeLevel, attackLevel, cost, myImage)
        {
        }
    }
}