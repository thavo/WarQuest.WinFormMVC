/// /////////////////////////////////////////////////////////////////////////////////////////////////////
/// FileName: UnitVehicle.cs
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

using System.Drawing;

namespace WarQuest.WinFormMVC.Models
{
    public class UnitVehicle : Unit
    {
        public UnitVehicle(int index, int speedPower, int jumpPower, int lifeLevel, int attackLevel, int cost, Bitmap myImage)
            : base(index, speedPower, jumpPower, lifeLevel, attackLevel, cost, myImage)
        {
        }
    }
}