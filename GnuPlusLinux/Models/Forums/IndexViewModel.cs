namespace GnuPlusLinux.Models.Forums
{
    public class IndexViewModel
    {
        public string title { get; set; }
        public string message { get; set; }

        public IndexViewModel(in string pageTitle) 
        {
            title = pageTitle;
        }
    }
}
