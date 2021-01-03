﻿using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;

namespace WarQuest.WinFormMVC.Models
{
    public class Unit
    {
      // public enum UnitType = new (UnitHuman, UnitBuilder);

        public Unit()
        {
        }

        public Unit(int index, int speedPower, int jumpPower, int lifeLevel, int attackLevel, int cost, Bitmap myImage)
        {
            Index = index;
            SpeedPower = speedPower;
            JumpPower = jumpPower;
            LifeLevel = lifeLevel;
            AttackLevel = attackLevel;
            Cost = cost;
            // MyImage = myImage;
        }

        public int Index { get ; set; }
        public int SpeedPower { get ; set; }
        public int JumpPower { get; set; }
        public int LifeLevel { get; set; }
        public int AttackLevel { get; set; }
        public int Cost { get; set; }
        public bool IsSelected { get; internal set; }
        // public Bitmap MyImage { get; set; }
    }
}
