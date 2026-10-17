using System;
using System.Collections.Generic;
using System.Text;

namespace Gem.Helpers
{
    public static class Utilites
    {
        //1- You can't create an instance of a static class.
        //2- You can't declare a variabe of it
        //3- Cannot contain non-static/instance members
        //4- Cannot inherit or be inherited from

        public static string language { get; set; }
        public static string HeadOfficeAddress { get; set; } 
        
        public static string GreetVisitor()
        {
            return "Welcome to Static Class Utility!";
        }

    }
}
