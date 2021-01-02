using System;
using System.Collections.Generic;

namespace WarQuest.WinFormMVC.Models
{
    public class UnitCollection
    {
        // Create a list of parts.
        protected List<Unit> _unitCollection = new List<Unit>();
        private int _moneyBalance;

        public int AddUnit(Unit unit)
        {
            _unitCollection.Add(unit);

            this.MoneyBalance = 22;

            return this.MoneyBalance;
        }

        public int MoneyBalance
    {
            get 
            {
                int _moneyBalance = 0;
                foreach (Unit item in _unitCollection)
                {
                    _moneyBalance += item.Cost;
                }

                return _moneyBalance; 
            }

            set => _moneyBalance = value;
        }

        public int Count()
        {
            return _unitCollection.Count;
        }
    }
}