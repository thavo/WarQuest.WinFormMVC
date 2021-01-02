namespace WarQuest.WinFormMVC.Models
{
    /// <summary>
    /// A Builder can ONLY Build and cannot destroy.
    /// </summary>
    public interface IUnitBuilder
    {
        public int BuidingType { get; set; }
        //public int FrontSize { get; set; }
        //public int LeftSize { get; set; }
        //public int RightSize { get; set; }
        //public int BackSize { get; set; }

    }
}