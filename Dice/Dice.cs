using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LuisBot.Dice
{
    public class Dice
    {
        public static int ConvertTypeToInt(String Type)
        {
            switch (Type)
            {
                case "d2":
                    return 2;
                case "d3":
                    return 3;
                case "d4":
                    return 4;
                case "d5":
                    return 5;
                case "d6":
                    return 6;
                case "d8":
                    return 8;
                case "d10":
                    return 10;
                case "d12":
                    return 12;
                case "d20":
                    return 20;

                default:
                    return 20;
            }
        }
    }
}