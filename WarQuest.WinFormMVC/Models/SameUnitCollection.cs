
using System.Collections.Generic;
/// /////////////////////////////////////////////////////////////////////////////////////////////////////
/// FileName: SameUnitCollection.cs
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
namespace WarQuest.WinFormMVC.Models
{
    public class SameUnitCollection : UnitCollection
    {
        public SameUnitCollection() : base()
        {
        }

        public SameUnitCollection(List<Unit> unitCollection) : base(unitCollection)
        {
        }

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
                // Cannot Add. Note : this Exception is catched OK by Unit Test.
                throw new System.InvalidOperationException();
            }

            return this.Count();
        }
    }
}