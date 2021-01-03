using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using WarQuest.WinFormMVC.Models;
using WarQuest.WinFormMVC.Views;


namespace WarQuest.WinFormMVC.Presenters
{
    public class UnitCollection
    {
        // Create Objects from Models.
        // Here Create a list of parts.
        protected List<Unit> _unitCollection = new List<Unit>();

        public object myUnit { get; private set; }

        public List<Unit> Units()
        {
            return _unitCollection;
        }

        public int AddUnit(Unit unit)
        {
            _unitCollection.Add(unit);

            return this.Count();
        }


        public int Count()
        {
            return _unitCollection.Count;
        }

        public int TotalCost()
        {
            int _moneyBalance = 0;
            foreach (Unit item in _unitCollection)
            {
                _moneyBalance += item.Cost;
            }

            return _moneyBalance;
        }

        public int AddRandomUnit(int numberOfUnits, int costPerUnit)
        {
            for (int i=0; i<numberOfUnits; i++)
            {
                this.AddUnit(new Unit(i, 20*i, 30*i, 40*i, 50*i, costPerUnit, null));
            }
            return this.Count();
        }

        public int AddRandomDifferentUnitTypes(int orderOfMagnitude, int costPerUnit)
        {
            for (int i = 0; i < orderOfMagnitude*2; i++)
            {
                this.AddUnit(new UnitBuilder(i, 20 * i, 320 * i, 40 * i, 50 * i, costPerUnit + i*2, null));
                this.AddUnit(new UnitBuilder(i, 30 * i, 390 * i, 40 * i, 50 * i, costPerUnit + i*3, null));
                this.AddUnit(new UnitBuilder(i, 40 * i, 360 * i, 40 * i, 50 * i, costPerUnit + i*4, null));
                this.AddUnit(new UnitMonster(i, 50 * i, 410 * i, 40 * i, 50 * i, costPerUnit + i*6, null));
                this.AddUnit(new UnitMonster(i, 60 * i, 520 * i, 40 * i, 50 * i, costPerUnit + i*7, null));
                this.AddUnit(new UnitVehicle(i, 70 * i, 600 * i, 40 * i, 50 * i, costPerUnit + i*9, null));
                this.AddUnit(new UnitVehicle(i, 80 * i, 400 * i, 40 * i, 50 * i, costPerUnit + i*10, null));
                this.AddUnit(new UnitHuman(i, 90 * i, 500 * i, 40 * i, 50 * i, costPerUnit + i * 20, null));
                this.AddUnit(new UnitHuman(i, 100 * i, 120 * i, 40 * i, 50 * i, costPerUnit + i * 30, null));
            }

            return this.Count();
        }

        internal void CreateRandomUnits(ImageList imageListUnits)
        {
            int i = 0;
            Random rnd = new Random();

            foreach (Bitmap img in imageListUnits.Images)
            {
                int myRnd = rnd.Next(120 * i, 200 * (i + 2*i));

                this.AddUnit(new UnitBuilder(i, 20 + myRnd, 320 + myRnd, 40 + myRnd, 50 + myRnd, myRnd + i * 2, img));
                i++;
            }
        }

        internal int ClearAllSelectedUnits()
        {
            int totalCleared = 0;

            for (int i = 0; i < _unitCollection.Count; i++)
            {
                var myUnit = _unitCollection[i];
                if (myUnit.IsSelected)
                {
                    myUnit.IsSelected = false;
                    totalCleared += 1;
                }
            }

            return totalCleared;
        }

        internal int GetTotalMoneySelected()
        {
            int CountTotalMoney = 0;

            for (int i=0; i< _unitCollection.Count; i++)
            {
                var myUnit = _unitCollection[i];
                if (myUnit.IsSelected)
                {
                    CountTotalMoney += myUnit.Cost;
                }
            }

            return CountTotalMoney;
        }
    }
}