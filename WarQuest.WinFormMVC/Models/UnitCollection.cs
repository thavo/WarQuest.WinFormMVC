/// /////////////////////////////////////////////////////////////////////////////////////////////////////
/// FileName: UnitCollection.cs
/// FileType: Visual C# Source file
/// Author : Sanouche
/// Application codename : WarQuest
/// Audience : Dev by Kids, for Kids !
/// Created On : 01/01/2021
/// Copy Rights : MIT License
/// Description : Class for defining database related functions
/// License : MIT License, https://opensource.org/licenses/MIT
/// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
/// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR 
/// PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, 
/// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, 
/// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
/// ////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WarQuest.WinFormMVC.Models
{
    public class UnitCollection
    {
        // Create Objects from Models.
        // Here Create a list of parts.
        protected List<Unit> _unitCollection = new List<Unit>();

        public UnitCollection()
        {
        }

        public UnitCollection(List<Unit> unitCollection)
        {
            this._unitCollection = unitCollection;
        }

        public object myUnit { get; private set; }

        public List<Unit> Units()
        {
            return this._unitCollection;
        }

        public int AddUnit(Unit unit)
        {
            this._unitCollection.Add(unit);

            return this.Count();
        }


        public int Count()
        {
            return this._unitCollection.Count;
        }

        public int TotalCost()
        {
            int moneyBalance = 0;
            foreach (Unit item in this._unitCollection)
            {
                moneyBalance += item.Cost;
            }

            return moneyBalance;
        }

        public int AddRandomUnit(int numberOfUnits, int costPerUnit)
        {
            for (int i = 0; i < numberOfUnits; i++)
            {
                this.AddUnit(new Unit(i, 20 * i, 30 * i, 40 * i, 50 * i, costPerUnit, null));
            }
            return this.Count();
        }

        public int AddRandomDifferentUnitTypes(int orderOfMagnitude, int costPerUnit)
        {
            for (int i = 0; i < orderOfMagnitude * 2; i++)
            {
                this.AddUnit(new UnitBuilder(i, 20 * i, 320 * i, 40 * i, 50 * i, costPerUnit + i * 2, null));
                this.AddUnit(new UnitBuilder(i, 30 * i, 390 * i, 40 * i, 50 * i, costPerUnit + i * 3, null));
                this.AddUnit(new UnitBuilder(i, 40 * i, 360 * i, 40 * i, 50 * i, costPerUnit + i * 4, null));
                this.AddUnit(new UnitMonster(i, 50 * i, 410 * i, 40 * i, 50 * i, costPerUnit + i * 6, null));
                this.AddUnit(new UnitMonster(i, 60 * i, 520 * i, 40 * i, 50 * i, costPerUnit + i * 7, null));
                this.AddUnit(new UnitVehicle(i, 70 * i, 600 * i, 40 * i, 50 * i, costPerUnit + i * 9, null));
                this.AddUnit(new UnitVehicle(i, 80 * i, 400 * i, 40 * i, 50 * i, costPerUnit + i * 10, null));
                this.AddUnit(new UnitHuman(i, 90 * i, 500 * i, 40 * i, 50 * i, costPerUnit + i * 20, null));
                this.AddUnit(new UnitHuman(i, 100 * i, 120 * i, 40 * i, 50 * i, costPerUnit + i * 30, null));
            }

            return this.Count();
        }

        /// <summary>
        /// Creates random units of many types
        /// </summary>
        /// <param name="imageListUnits"></param>
        internal void CreateRandomUnits(ImageList imageListUnits)
        {

            string fileName = string.Empty;

            int i = 0;
            Random rnd = new Random();

            foreach (Bitmap img in imageListUnits.Images)
            {
                // Retrieves the FileName, via Keys[]
                fileName = imageListUnits.Images.Keys[i];
                
                int myRnd = rnd.Next(120 * i, 200 * (i + 2 * i));

                // fileName
                switch (fileName.Substring(0, 4))
                {
                    case ("Buil"): this.AddUnit(new UnitBuilder(i, 20 + myRnd, 320 + myRnd, 40 + myRnd, 50 + myRnd, myRnd + i * 2, img)); 
                        break;
                    case ("Dest"): this.AddUnit(new UnitDestroyer(i, 20 + myRnd, 320 + myRnd, 40 + myRnd, 50 + myRnd, myRnd + i * 2, img)); 
                        break;
                    case ("Hum-"): this.AddUnit(new UnitHuman(i, 20 + myRnd, 320 + myRnd, 40 + myRnd, 50 + myRnd, myRnd + i * 2, img)); 
                        break;
                    case ("Mon-"): this.AddUnit(new UnitMonster(i, 20 + myRnd, 320 + myRnd, 40 + myRnd, 50 + myRnd, myRnd + i * 2, img)); 
                        break;
                    case ("Veh-"): this.AddUnit(new UnitVehicle(i, 20 + myRnd, 320 + myRnd, 40 + myRnd, 50 + myRnd, myRnd + i * 2, img)); 
                        break;
                }

                i++;
            }
        }

        internal int ClearAllSelectedUnits()
        {
            int totalCleared = 0;

            for (int i = 0; i < this._unitCollection.Count; i++)
            {
                var myUnit = this._unitCollection[i];
                if (myUnit.IsSelected)
                {
                    myUnit.IsSelected = false;
                    totalCleared += 1;
                }
            }

            return totalCleared;
        }

        public UnitCollection GetSelectedUnits()
        {
            UnitCollection myCollection = new UnitCollection();
            foreach (var item in this._unitCollection)
            {
                if (item.IsSelected)
                {
                    myCollection.AddUnit(item);
                }
            }
            return myCollection;
        }

        public void DeleteUnselectedUnits()
        {
            int i = 0;
            // Delete ALL UnSelected until no more
            while (i < this._unitCollection.Count)
            {
                var myUnit = this._unitCollection[i];

                // Check if Unselected, so we can remove them
                if (!myUnit.IsSelected)
                {
                   this._unitCollection.RemoveAt(i);
                }
                else
                {   
                    // Only if NOT removed, then iterate to the next item
                    i++; 
                }
            }
        }

        internal int GetTotalMoneySelected()
        {
            int CountTotalMoney = 0;

            for (int i = 0; i < this._unitCollection.Count; i++)
            {
                var myUnit = this._unitCollection[i];
                if (myUnit.IsSelected)
                {
                    CountTotalMoney += myUnit.Cost;
                }
            }

            return CountTotalMoney;
        }

        public int GetTotalUnitSelected()
        {
            int CountTotal = 0;

            for (int i = 0; i < this._unitCollection.Count; i++)
            {
                var myUnit = this._unitCollection[i];
                if (myUnit.IsSelected)
                {
                    CountTotal++;
                }
            }

            return CountTotal;
        }
    }
}