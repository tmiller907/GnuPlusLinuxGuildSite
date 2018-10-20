namespace GnuPlusLinux.Models.Home
{
    public class IndexViewModel
    {
        public string title {get; set;}

        public IndexViewModel(in string pageTitle) 
        {
            title = pageTitle;
        }
    }
}
