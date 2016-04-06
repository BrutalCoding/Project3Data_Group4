using Project3Data_Group4.WinPhone;
using Xamarin.Forms;

[assembly: Dependency(typeof(PhoneDialer))]

namespace Project3Data_Group4.WinPhone
{
    public class PhoneDialer : IDialer
    {
        public bool Dial(string number)
        {
            
            return true;
        }
    }
}