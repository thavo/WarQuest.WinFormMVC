﻿using System;
using System.Collections.Generic;

namespace WarQuest.WinFormMVC.Models
{
    public class SameUnitCollection: UnitCollection
    {
        /// <summary>
        /// Returns the number of units added.
        /// </summary>
        /// <param name="unit"></param>
        /// <returns></returns>
        public int AddSameUnit(Unit unit)
        {
            // If first Add, then no check
            if (this._unitCollection.Count == 0)
            {
                this._unitCollection.Add(unit);
            }
            else if (this._unitCollection[0].GetType() == unit.GetType())
            {
                // Can add because same type
                this._unitCollection.Add(unit);
            }
            else 
            { 
                // Cannot Add. 
                // Also, this Exception is catched by Unit Test.
                throw new System.InvalidOperationException();
            }

            return this.Count();
        }
    }
}