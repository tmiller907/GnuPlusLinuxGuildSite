namespace GnuPlusLinux.Models.Home
{
    public class ApplicationViewModel
    {
        public string title   { get; set; }
        public string message { get; set; }

        public ApplicationViewModel(in string pageTitle) 
        {
            title = pageTitle;
        }
    }
}
