using NUnit.Framework;
using WarQuest.WinFormMVC.Presenters;

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
            myUnitCollection.AddSameUnit(new WinFormMVC.Models.UnitBuilder(0, 0, 0, 0, 0, 0, null));

            // Adding Same Unit type should be OK and count == 2
            myUnitCollection.AddSameUnit(new WinFormMVC.Models.UnitBuilder(1, 0, 0, 0, 0, 0, null));

            Assert.AreEqual(2, myUnitCollection.Count());

            // Adding a different Unit Type should crash, because should be the same type
            Assert.Throws<System.InvalidOperationException>(
                () => myUnitCollection.AddSameUnit(new WinFormMVC.Models.UnitHuman(2, 0, 0, 0, 0, 0, null)));

        }

        [Test]
        public void GIVEN_a_collectionOfUnit_WHEN_I_add_2_units_THEN_the_total_count_is_2()
        {
            const int NUMBER_OF_UNITS = 2;

            WarQuest.WinFormMVC.Presenters.UnitCollection myUnitCollection = new WinFormMVC.Presenters.UnitCollection();
            myUnitCollection.AddUnit(new WinFormMVC.Models.UnitBuilder(0, 0, 0, 0, 0, 0, null));
            myUnitCollection.AddUnit(new WinFormMVC.Models.UnitHuman(1, 0, 0, 0, 0, 0, null));

            int countUnits = myUnitCollection.Count();
            Assert.AreEqual(NUMBER_OF_UNITS, countUnits);
        }

        [Test]
        public void GIVEN_I_create_45_Units_WHEN_I_count_THEN_I_have_45_items()
        {
            const int NUMBER_OF_UNITS = 21;
            const int DUMMY_INDEX = 0;

            UnitCollection myUnitCollection = CreateUnitCollection(NUMBER_OF_UNITS, DUMMY_INDEX, DUMMY_INDEX, DUMMY_INDEX);

            Assert.AreEqual(NUMBER_OF_UNITS, myUnitCollection.Count());
        }

        [Test]
        public void GIVEN_a_collection_of_159_units_with_3_Selected_Units_WHEN_Extract_selected_ones_THEN_I_have_a_collection_of_3_Units()
        {
            const int NUMBER_OF_UNITS = 159;

            const int NUMBER_OF_SELECTED_ITEMS = 3;
            const int INDEX_OF_SELECTED_ITEM_1 = 3;
            const int INDEX_OF_SELECTED_ITEM_2 = 12;
            const int INDEX_OF_SELECTED_ITEM_3 = 18;

            UnitCollection myUnitCollection = CreateUnitCollection(NUMBER_OF_UNITS, INDEX_OF_SELECTED_ITEM_1, INDEX_OF_SELECTED_ITEM_2, INDEX_OF_SELECTED_ITEM_3);

            // Check #selected Items on original list
            int countSelected = myUnitCollection.GetTotalUnitSelected();
            Assert.AreEqual(NUMBER_OF_SELECTED_ITEMS, countSelected);

            UnitCollection myUnitCollectionWithOnlySelectedUnits = new UnitCollection();
            myUnitCollectionWithOnlySelectedUnits = myUnitCollection.GetSelectedUnits();

            // Check #selected Items on NEW list
            int countAllItems = myUnitCollectionWithOnlySelectedUnits.Count();
            Assert.AreEqual(NUMBER_OF_SELECTED_ITEMS, countAllItems);
        }

        [Test]
        public void GIVEN_3_selected_units_out_of_21_WHEN_I_deleted_all_unselected_THEN_only_3_selection_remains()
        {
            const int NUMBER_OF_UNITS = 21;

            const int NUMBER_OF_SELECTED_ITEMS = 3;
            const int INDEX_OF_SELECTED_ITEM_1 = 2;
            const int INDEX_OF_SELECTED_ITEM_2 = 11;
            const int INDEX_OF_SELECTED_ITEM_3 = 15;

            UnitCollection myUnitCollection = CreateUnitCollection(NUMBER_OF_UNITS, INDEX_OF_SELECTED_ITEM_1, INDEX_OF_SELECTED_ITEM_2, INDEX_OF_SELECTED_ITEM_3);

            int countSelected = myUnitCollection.GetTotalUnitSelected();
            Assert.AreEqual(NUMBER_OF_SELECTED_ITEMS, countSelected);

            // Delete All UNSelected. Should leave with NUMBER_OF_SELECTED_ITEMS remaining items
            myUnitCollection.DeleteUnselectedUnits();
            int countRemainingUnits = myUnitCollection.Count();

            Assert.AreEqual(NUMBER_OF_SELECTED_ITEMS, countRemainingUnits);
        }

        private static UnitCollection CreateUnitCollection(int NUMBER_OF_UNITS, int INDEX_OF_SELECTED_ITEM_1, int INDEX_OF_SELECTED_ITEM_2, int INDEX_OF_SELECTED_ITEM_3)
        {
            WinFormMVC.Presenters.UnitCollection myUnitCollection = new WinFormMVC.Presenters.UnitCollection();
            WinFormMVC.Models.Unit myUnit = null;

            for (int i = 0; i < NUMBER_OF_UNITS; i++)
            {
                myUnit = new WinFormMVC.Models.UnitBuilder(0, 0, 0, 0, 0, 0, null);

                // Choose Units that are marked as selected items
                if (i == INDEX_OF_SELECTED_ITEM_1 || i == INDEX_OF_SELECTED_ITEM_2 || i == INDEX_OF_SELECTED_ITEM_3)
                {
                    myUnit.IsSelected = true;
                }
                myUnitCollection.AddUnit(myUnit);
            }

            return myUnitCollection;
        }

        [Test]
        public void GIVEN_a_collectionOfUnit_WHEN_I_add_5_different_unit_types_THEN_the_total_count_is_5()
        {
            const int NUMBER_OF_UNITS = 5;

            WarQuest.WinFormMVC.Presenters.UnitCollection myUnitCollection = new WinFormMVC.Presenters.UnitCollection();
            myUnitCollection.AddUnit(new WinFormMVC.Models.UnitBuilder(0, 0, 0, 0, 0, 0, null));
            myUnitCollection.AddUnit(new WinFormMVC.Models.UnitDestroyer(1, 0, 0, 0, 0, 0, null));
            myUnitCollection.AddUnit(new WinFormMVC.Models.UnitHuman(2, 0, 0, 0, 0, 0, null));
            myUnitCollection.AddUnit(new WinFormMVC.Models.UnitMonster(3, 0, 0, 0, 0, 0, null));
            myUnitCollection.AddUnit(new WinFormMVC.Models.UnitVehicle(4, 0, 0, 0, 0, 0, null));

            int countUnits = myUnitCollection.Count();
            Assert.AreEqual(NUMBER_OF_UNITS, countUnits);
        }

        [Test]
        public void GIVEN_Units_To_Add_WHEN_I_add_units_of_cost_500_and_257_THEN_the_total_is_757()
        {
            WarQuest.WinFormMVC.Presenters.UnitCollection myUnitCollection = new WinFormMVC.Presenters.UnitCollection();

            myUnitCollection.AddUnit(new WinFormMVC.Models.UnitBuilder(0, 0, 0, 0, 0, 500, null));
            myUnitCollection.AddUnit(new WinFormMVC.Models.UnitBuilder(1, 0, 0, 0, 0, 257, null));

            int cost = myUnitCollection.TotalCost();
            Assert.AreEqual(757, cost);

        }

        [Test]
        public void GIVEN_Units_WHEN_Generate_Random_20_Units_of_1000_Cost_THEN_TotalCost_is_20000()
        {
            WarQuest.WinFormMVC.Presenters.UnitCollection myUnitCollection = new WinFormMVC.Presenters.UnitCollection();

            myUnitCollection.AddRandomUnit(20, 1000);

            int cost = myUnitCollection.TotalCost();
            Assert.AreEqual(20000, cost);

        }
    }
}