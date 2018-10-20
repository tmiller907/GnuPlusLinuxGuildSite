namespace GnuPlusLinux.Models.Home
{
    public class InformationViewModel
    {
        // Page Fields
        public string title       { get; set; }
        public string welcome     { get; set; }
        public string charter     { get; set; }
        public string rules       { get; set; }
        public string loot        { get; set; }
        public string addons      { get; set; }
        public string recruitment { get; set; }

        public InformationViewModel(in string pageTitle) 
        {
            title = pageTitle;
        }
    }
}
