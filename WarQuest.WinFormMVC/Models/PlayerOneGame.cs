using System;
using System.Collections.Generic;
using System.Text;

namespace WarQuest.WinFormMVC.Models
{
   public class PlayerOneGame
    {
        public int MoneyInitialAmount { get; set; }
        public int MoneyCurrentAmount { get; set; }

        public UnitCollection UnitCollection { get; set; }
    }
}
