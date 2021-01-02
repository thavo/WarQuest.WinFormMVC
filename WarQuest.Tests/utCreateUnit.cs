using NUnit.Framework;
using System;

namespace WarQuest.Tests
{
    public class utCreateUnit
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GIVEN_a_collectionOfSameUnit_WHEN_I_add_2_different_unit_types_THEN_addition_fails()
        {
            WarQuest.WinFormMVC.Models.SameUnitCollection myUnitCollection = new WinFormMVC.Models.SameUnitCollection();
            myUnitCollection.AddSameUnit(new WinFormMVC.Models.UnitBuilder());
            
            // Adding Same Unit type should be OK and count == 2
            myUnitCollection.AddSameUnit(new WinFormMVC.Models.UnitBuilder());

            Assert.AreEqual(myUnitCollection.Count(), 2);
   
            // Adding a different Unit Type should crash, because should be the same type
            Assert.Throws<System.InvalidOperationException>(() => myUnitCollection.AddSameUnit(new WinFormMVC.Models.UnitHuman()) );

        }

        [Test]
        public void GIVEN_a_collectionOfUnit_WHEN_I_add_2_units_THEN_the_total_count_is_2()
        {
            const int NUMBER_OF_UNITS = 2;

            WarQuest.WinFormMVC.Models.UnitCollection myUnitCollection = new WinFormMVC.Models.UnitCollection();
            myUnitCollection.AddUnit(new WinFormMVC.Models.UnitBuilder());
            myUnitCollection.AddUnit(new WinFormMVC.Models.UnitHuman());

            int countUnits = myUnitCollection.Count();
            Assert.AreEqual(countUnits, NUMBER_OF_UNITS);
        }

        [Test]
        public void GIVEN_a_collectionOfUnit_WHEN_I_add_5_different_unit_types_THEN_the_total_count_is_5()
        {
            const int NUMBER_OF_UNITS = 5;

            WarQuest.WinFormMVC.Models.UnitCollection myUnitCollection = new WinFormMVC.Models.UnitCollection();
            myUnitCollection.AddUnit(new WinFormMVC.Models.UnitBuilder());
            myUnitCollection.AddUnit(new WinFormMVC.Models.UnitDestroyer());
            myUnitCollection.AddUnit(new WinFormMVC.Models.UnitHuman());
            myUnitCollection.AddUnit(new WinFormMVC.Models.UnitMonster());
            myUnitCollection.AddUnit(new WinFormMVC.Models.UnitVehicle());

            int countUnits = myUnitCollection.Count();
            Assert.AreEqual(countUnits, NUMBER_OF_UNITS);
        }

        [Test]
        public void GIVEN_Units_To_Add_WHEN_I_add_units_of_cost_500_and_257_THEN_the_total_is_757()
        {
            // WarQuest.WinFormMVC.Models.PlayerOneGame test = new WinFormMVC.Models.PlayerOneGame();
            //test.MoneyInitialAmount = 55;
            //Assert.AreEqual(test.MoneyInitialAmount, 55);

            //WarQuest.WinFormMVC.Models.

        }
    }
}