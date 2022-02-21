using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTest
{
    public class Class1
    {
        public bool GetPassword (string password)
        {
            bool isdigit = false;
            bool isletter = false;
            bool isupper = false;
            bool isspecial = false;
            try
            {
                foreach(var item in password)
                {
                    if(char.IsDigit(item))
                    {
                        isdigit = true;
                        break;
                    }
                }
                foreach(var item in password)
                {
                    if(char.IsLetter(item))
                    {
                        isletter = true;
                        break;
                    }
                }
                foreach(var item in password)
                {
                    if(char.IsUpper(item))
                    {
                        isupper = true;
                        break;
                    }
                }
                foreach(var item in password)
                {
                    if (item == '!' || item == '@' || item == '#' || item == '%')
                    {
                        isspecial = true;
                        break;
                    }
                }

                return password.Length >= 8 && isdigit && isletter && isupper && isspecial;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool GetEmail(string email)
        {
            try
            {
                var email_invailed = new MailAddress(email);
                return email_invailed.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
