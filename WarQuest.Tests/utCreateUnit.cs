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
        public void GIVEN_a_collectionOfSameUnit_WHEN_add_2_different_unit_types_THEN_addition_fails()
        {
            WarQuest.WinFormMVC.Models.SameUnitCollection myUnitCollection = new WinFormMVC.Models.SameUnitCollection();
            myUnitCollection.AddSameUnit(new WinFormMVC.Models.UnitBuilder(0, 0, 0, 0, 0));
            
            // Adding Same Unit type should be OK and count == 2
            myUnitCollection.AddSameUnit(new WinFormMVC.Models.UnitBuilder(0, 0, 0, 0, 0));

            Assert.AreEqual(myUnitCollection.Count(), 2);
   
            // Adding a different Unit Type should crash, because should be the same type
            Assert.Throws<System.InvalidOperationException>(() => myUnitCollection.AddSameUnit(new WinFormMVC.Models.UnitHuman(0, 0, 0, 0, 0)) );

        }

        [Test]
        public void GIVEN_a_collectionOfUnit_WHEN_I_add_2_units_THEN_the_total_count_is_2()
        {
            const int NUMBER_OF_UNITS = 2;

            WarQuest.WinFormMVC.Models.UnitCollection myUnitCollection = new WinFormMVC.Models.UnitCollection();
            myUnitCollection.AddUnit(new WinFormMVC.Models.UnitBuilder(0, 0, 0, 0, 0));
            myUnitCollection.AddUnit(new WinFormMVC.Models.UnitHuman(0, 0, 0, 0, 0));

            int countUnits = myUnitCollection.Count();
            Assert.AreEqual(countUnits, NUMBER_OF_UNITS);
        }

        [Test]
        public void GIVEN_a_collectionOfUnit_WHEN_I_add_5_different_unit_types_THEN_the_total_count_is_5()
        {
            const int NUMBER_OF_UNITS = 5;

            WarQuest.WinFormMVC.Models.UnitCollection myUnitCollection = new WinFormMVC.Models.UnitCollection();
            myUnitCollection.AddUnit(new WinFormMVC.Models.UnitBuilder(0, 0, 0, 0, 0));
            myUnitCollection.AddUnit(new WinFormMVC.Models.UnitDestroyer(0, 0, 0, 0, 0));
            myUnitCollection.AddUnit(new WinFormMVC.Models.UnitHuman(0, 0, 0, 0, 0));
            myUnitCollection.AddUnit(new WinFormMVC.Models.UnitMonster(0, 0, 0, 0, 0));
            myUnitCollection.AddUnit(new WinFormMVC.Models.UnitVehicle(0, 0, 0, 0, 0));

            int countUnits = myUnitCollection.Count();
            Assert.AreEqual(countUnits, NUMBER_OF_UNITS);
        }

        [Test]
        public void GIVEN_Units_To_Add_WHEN_I_add_units_of_cost_500_and_257_THEN_the_total_is_757()
        {
            WarQuest.WinFormMVC.Models.UnitCollection myUnitCollection = new WinFormMVC.Models.UnitCollection();

            myUnitCollection.AddUnit(new WinFormMVC.Models.UnitBuilder(0, 0, 0, 0, 500));
            myUnitCollection.AddUnit(new WinFormMVC.Models.UnitBuilder(0, 0, 0, 0, 257));

            int cost = myUnitCollection.TotalCost();
            Assert.AreEqual(cost, 757);

        }

        [Test]
        public void GIVEN_Units_WHEN_Generate_Random_20_Units_of_1000_Cost_THEN_TotalCost_is_20000()
        {
            WarQuest.WinFormMVC.Models.UnitCollection myUnitCollection = new WinFormMVC.Models.UnitCollection();

            myUnitCollection.AddRandomUnit(20, 1000);

            int cost = myUnitCollection.TotalCost();
            Assert.AreEqual(cost, 20000);

        }
    }
}