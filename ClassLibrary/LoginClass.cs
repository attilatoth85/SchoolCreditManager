using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public static class LoginClass
    {
        public static string UserName { get; set; }
        public static string Psw { get; set; }
        public static string FilePath { get; set; }= @"C:\Users\totha\Source\Repos\LibrarySchoolCreditManager\login.dat";
        public static bool Check { get; set; }
    }
}
