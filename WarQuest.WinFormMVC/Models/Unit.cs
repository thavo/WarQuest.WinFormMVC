using System.Drawing;

namespace WarQuest.WinFormMVC.Models
{
    public class Unit
    {
        public Unit(int index, int speedPower, int jumpPower, int lifeLevel, int attackLevel, int cost, Bitmap image)
        {
            Index = index;
            SpeedPower = speedPower;
            JumpPower = jumpPower;
            LifeLevel = lifeLevel;
            AttackLevel = attackLevel;
            Cost = cost;
            Image = image;
        }

        public int Index { get; set; }
        public int SpeedPower { get; set; }
        public int JumpPower { get; set; }
        public int LifeLevel { get; set; }
        public int AttackLevel { get; set; }
        public int Cost { get; set; }
        public bool IsSelected { get; internal set; }
        public Bitmap Image { get; internal set; }
    }
}
