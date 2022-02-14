using System;
using System.Collections.Generic;
using System.Text;

namespace P22514022022HomeWork1
{
    class User
    {
        string _userName;
        public string UserName 
        {
            get 
            {
                return _userName;
            }
            set
            {
                while (value.Length < 8)
                {
                    Console.WriteLine("Duzgun UserName Daxil Et");
                    value = Console.ReadLine();
                }
                _userName = value;
            } 
        }
        string _password;
        public string Password 
        {
            get
            {
                return _password;
            }
            set
            {
                bool check = true;
                while (check)
                {
                    bool checkUperCase = false;
                    bool checkLowerCase = false;
                    bool checkDigit = false;

                    if (value.Length >= 8)
                    {
                        foreach (char item in value)
                        {
                            if (char.IsDigit(item))
                            {
                                checkDigit = true;
                            }
                            else if (char.IsLower(item))
                            {
                                checkLowerCase = true;
                            }
                            else if (char.IsUpper(item))
                            {
                                checkUperCase = true;
                            }

                            if (checkDigit && checkLowerCase && checkUperCase)
                            {
                                _password = value;
                                check = false;
                                break;
                            }
                        }
                    }

                    if (!checkDigit || !checkLowerCase || !checkUperCase)
                    {
                        Console.WriteLine("Duzgun Password Daxil Et Uzunlugu 8 Simvol Olmalidir");
                        value = Console.ReadLine();
                    }
                }
            } 
        }


        public User(string username)
        {
            UserName = username;
        }
    }
}
