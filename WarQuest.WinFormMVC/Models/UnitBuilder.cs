﻿using WarQuest.WinFormMVC.Views;
using System.Drawing;

    namespace WarQuest.WinFormMVC.Models
{
    public class UnitBuilder : Unit, IUnitBuilder
    {
        public UnitBuilder(int speedPower, int jumpPower, int lifeLevel, int attackLevel, int cost, Bitmap myImage)  : base(speedPower, jumpPower, lifeLevel, attackLevel, cost, myImage)
        {
        }

        public int BuidingType { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}