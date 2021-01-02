
using System.Drawing;

namespace WarQuest.WinFormMVC.Models
{
    public class UnitMonster : Unit
    {
        public UnitMonster(int speedPower, int jumpPower, int lifeLevel, int attackLevel, int cost, Bitmap myImage) : 
            base(speedPower, jumpPower, lifeLevel, attackLevel, cost, myImage)
        {
        }
    }
}