using GnuPlusLinuxDAL;

namespace GnuPlusLinux.Models.Member
{
    public class RegistrationViewModel
    {
        public string  title   { get; set; }
        public Account account { get; set; }

        public RegistrationViewModel(in string pageTitle) 
        {
            title = pageTitle;
        }
    }
}
