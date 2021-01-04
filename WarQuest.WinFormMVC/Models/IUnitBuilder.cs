/// /////////////////////////////////////////////////////////////////////////////////////////////////////
/// FileName: IUnitBuilder.cs
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
    /// <summary>
    /// A Builder can ONLY Build and cannot destroy.
    /// </summary>
    public interface IUnitBuilder
    {
        public int BuidingType { get; set; }
        // public int FrontSize { get; set; }
        // public int LeftSize { get; set; }
        // public int RightSize { get; set; }
        // public int BackSize { get; set; }

    }
}