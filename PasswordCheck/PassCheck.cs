using System.Text.RegularExpressions;

namespace PasswordCheck
{
    public class PassCheck
    {
        public int Pass(string password)
        {
            var passBall = 0;
            if (password.Length > 10) {
                passBall++;
            }
            if (Regex.IsMatch(password, "[A-Z]")) {
                passBall++;
            }
            if (Regex.IsMatch(password, "[a-z]")) 
            
            {
                passBall++;
            }
            if (Regex.IsMatch(password, "\\d"))
            {
                passBall++;
            }
            if(Regex.IsMatch(password, "[!@#$%^&*(),.?\":{}|<>]"))
            {
                passBall++;
            }
            return passBall;
        }
    }
}
