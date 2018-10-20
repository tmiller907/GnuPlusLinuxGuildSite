namespace GnuPlusLinux.Models.Home
{
    public class LoginViewModel
    {
        public string title { get; set; }

        public LoginViewModel(in string pageTitle) 
        {
            title = pageTitle;
        }
    }
}
