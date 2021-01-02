namespace WarQuest.WinFormMVC.Models
{
    /// <summary>
    /// A Destroyer can ONLY destroy, and cannot Build.
    /// </summary>
    public interface IUnitDestroyer
    {
        public int DestroyType { get; set; }

        //// Number of bricks to destroy
        //public int FrontSize { get; set; }
        //// Number of bricks to destroy
        //public int LeftSize { get; set; }
        //// Number of bricks to destroy
        //public int RightSize { get; set; }
        //// Number of bricks to destroy
        //public int BackSize { get; set; }

    }
}