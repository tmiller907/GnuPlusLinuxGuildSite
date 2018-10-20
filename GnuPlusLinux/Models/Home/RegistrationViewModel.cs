namespace GnuPlusLinux.Models.Home
{
    public class RegistrationViewModel
    {
        public string title { get; set; }

        public RegistrationViewModel(in string pageTitle) 
        {
            title = pageTitle; 
        }
    }
}
