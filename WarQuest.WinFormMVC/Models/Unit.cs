/// /////////////////////////////////////////////////////////////////////////////////////////////////////
/// FileName: Unit.cs
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
/// ////////////////////////////////////////////////////////////////////////////////////////////////////////s

using System.Drawing;

namespace WarQuest.WinFormMVC.Models
{
    public class Unit
    {
        public Unit(int index, int speedPower, int jumpPower, int lifeLevel, int attackLevel, int cost, Bitmap image)
        {
            this.Index = index;
            this.SpeedPower = speedPower;
            this.JumpPower = jumpPower;
            this.LifeLevel = lifeLevel;
            this.AttackLevel = attackLevel;
            this.Cost = cost;
            this.Image = image;
        }

        public int Index { get; set; }
        public int SpeedPower { get; set; }
        public int JumpPower { get; set; }
        public int LifeLevel { get; set; }
        public int AttackLevel { get; set; }
        public int Cost { get; set; }
        public bool IsSelected { get; set; }
        public Bitmap Image { get; internal set; }
        public string FileName { get; internal set; }
    }
}
