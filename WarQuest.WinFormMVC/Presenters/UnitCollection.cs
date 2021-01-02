using System;
using System.Collections.Generic;
using WarQuest.WinFormMVC.Models;
using WarQuest.WinFormMVC.Views;


namespace WarQuest.WinFormMVC.Presenters
{
    public class UnitCollection
    {
        // Create Objects from Models.
        // Here Create a list of parts.
        protected List<Unit> _unitCollection = new List<Unit>();

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
                this.AddUnit(new Unit(20*i, 30*i, 40*i, 50*i, costPerUnit));
            }
            return this.Count();
        }

        public int AddRandomDifferentUnitTypes(int orderOfMagnitude, int costPerUnit)
        {
            for (int i = 0; i < orderOfMagnitude*2; i++)
            {
                this.AddUnit(new UnitBuilder(20 * i, 320 * i, 40 * i, 50 * i, costPerUnit + i*2));
                this.AddUnit(new UnitBuilder(30 * i, 390 * i, 40 * i, 50 * i, costPerUnit + i*3));
                this.AddUnit(new UnitBuilder(40 * i, 360 * i, 40 * i, 50 * i, costPerUnit + i*4));
                this.AddUnit(new UnitMonster(50 * i, 410 * i, 40 * i, 50 * i, costPerUnit + i*6));
                this.AddUnit(new UnitMonster(60 * i, 520 * i, 40 * i, 50 * i, costPerUnit + i*7));
                this.AddUnit(new UnitVehicle(70 * i, 600 * i, 40 * i, 50 * i, costPerUnit + i*9));
                this.AddUnit(new UnitVehicle(80 * i, 400 * i, 40 * i, 50 * i, costPerUnit + i*10));
                this.AddUnit(new UnitHuman(90 * i, 500 * i, 40 * i, 50 * i, costPerUnit + i * 20));
                this.AddUnit(new UnitHuman(100 * i, 120 * i, 40 * i, 50 * i, costPerUnit + i * 30));

            }
            return this.Count();
        }
    }
}