using System;
using System.Collections.Generic;
using System.Text;
using WarQuest.WinFormMVC.Presenters;


namespace WarQuest.WinFormMVC.Models
{
   public class PlayerOneGame
    {
        public const int MAX_SPENDING_MONEY = 10000;
        public int MoneyInitialAmount { get; set; }
        public int MoneyCurrentAmount { get; set; }
        public UnitCollection UnitCollection { get; set; }
    }
}
