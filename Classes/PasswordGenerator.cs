using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager.Classes
{

    internal class PasswordGenerator
    {
        // VARIABLES


        private const string alphabets = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string specialCharacters = "!@#$%^&*()-_=+[]{}|;:'\",.<>/?";
        private const string numbers = "0123456789";
        private char random_char;
        private int random_int;
        private readonly Random random = new Random();



        // METHODS


        // For generating password

        public string Generate_Password(bool alph, bool numb, bool spec, int password_length_given)
        {
            string password_generated = "";
            int password_length = password_length_given;

            int i = 0;
            while (i < password_length)
            {
                random_int = random.Next(0, 3);
                switch (random_int)
                {
                    case 0:
                        if (alph)
                        {
                            random_char = alphabets[random.Next(0, alphabets.Length)];
                            password_generated += random_char;
                        }
                        else
                            i--;
                        break;
                    case 1:
                        if (numb)
                        {
                            random_char = numbers[random.Next(0, numbers.Length)];
                            password_generated += random_char;
                        }
                        else
                            i--;
                        break;
                    case 2:

                        if (spec)
                        {
                            random_char = specialCharacters[random.Next(0, specialCharacters.Length)];
                            password_generated += random_char;
                        }
                        else
                            i--;
                        break;
                }
                i++;
            }

            // If the password doesn't contain at least one of the user's wanted characters, it loops until it meets the requirments

            while ((!password_generated.Any(c => alphabets.Contains(c)) && alph) &&
                (!password_generated.Any(c => specialCharacters.Contains(c)) && spec) &&
                (!password_generated.Any(c => specialCharacters.Contains(c)) && spec))
            {
                if (!password_generated.Any(c => alphabets.Contains(c)) && alph)
                {
                    char[] chars_in_password_generated = password_generated.ToCharArray();
                    random_char = alphabets[random.Next(0, alphabets.Length)];
                    random_int = random.Next(0, password_generated.Length);
                    for (int c = 0; c < password_generated.Length; c++)
                    {
                        if (c == random_int)
                            chars_in_password_generated[c] = random_char;
                        else
                            chars_in_password_generated[c] = password_generated[c];
                    }
                    password_generated = new string(chars_in_password_generated);
                }

                if (!password_generated.Any(c => specialCharacters.Contains(c)) && spec)
                {
                    char[] chars_in_password_generated = password_generated.ToCharArray();
                    random_char = specialCharacters[random.Next(0, specialCharacters.Length)];
                    random_int = random.Next(0, password_generated.Length);
                    for (int c = 0; c < password_generated.Length; c++)
                    {
                        if (c == random_int)
                            chars_in_password_generated[c] = random_char;
                        else
                            chars_in_password_generated[c] = password_generated[c];
                    }
                    password_generated = new string(chars_in_password_generated);
                }

                if (!password_generated.Any(c => numbers.Contains(c)) && numb)
                {
                    char[] chars_in_password_generated = password_generated.ToCharArray();
                    random_char = numbers[random.Next(0, numbers.Length)];
                    random_int = random.Next(0, password_generated.Length);
                    for (int c = 0; c < password_generated.Length; c++)
                    {
                        if (c == random_int)
                            chars_in_password_generated[c] = random_char;
                        else
                            chars_in_password_generated[c] = password_generated[c];
                    }
                    password_generated = new string(chars_in_password_generated);
                }
            }

            return password_generated;
        }
    }
}

