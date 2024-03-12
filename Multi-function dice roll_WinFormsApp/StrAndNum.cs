//Made by XJYU_Angel
namespace Multi_function_dice_roll_WinFormsApp
{
    internal static class StrAndNum
    {
        /**
         * StrAndNum.CharsForCheck[]
         * 用于与字符作比较，进而达到检测的目的
         **/
        public static readonly string CharsForCheck = "0123456789-+~ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrsthijklmnuvwxyz";



        /**
         * StrAndNum.CharIsNumC(char)
         * 用于检测字符是否为数字
         * 输入为一个字符，输出为一个bool值
         **/
        public static bool CharIsNumC(char charToCheck)
        {
            bool NotAnNum = true;
            for (int i = 0; i <= 9; i++)
            {
                if (charToCheck == CharsForCheck[i])
                {
                    NotAnNum = false;
                    break;
                }
            }
            if (NotAnNum)
                return false;
            else
            {
                return true;
            }
        }



        /**
         * StrAndNum.StrIsNumC(string)
         * 输入为一个字符串，输出为一个bool值
         * 用于检测字符串是否只含数字
         * *只接受十进制
         * 例如:“123”、“321” 
         **/
        public static bool StrIsNumC(string strToCheck)
        {
            bool NotAnNum;

            switch (strToCheck.Length)                                                  //分类检测
            {
                case 0: return false;
                case 1:
                    if (CharIsNumC(strToCheck[0]))
                        return true;
                    else
                    {
                        return false;
                    }
                default:
                    for (int i = strToCheck.Length - 1; i > 0; i--)                     //对除首位的数字进行检测
                    {
                        if (CharIsNumC(strToCheck[i]) == false) return false;           //未通过检测返回false
                    }


                    NotAnNum = true;                                                    //初始化NotAnNum
                    for (int i = 0; i <= 11; i++)                                       //对首位数字进行判断(包括+ -）
                    {
                        if (strToCheck[0] == CharsForCheck[i])
                        {
                            NotAnNum = false;
                            break;
                        }
                    }
                    if (NotAnNum) return false;                                         //未通过检测返回false

                    return true;                                                        //通过检测返回true
            }
        }



        /**
         * StrAndNum.StrIsNumRC(string)（未完成）
         * 输入为一个字符串，输出为一个bool值
         * 用于检测字符串是否符合"Num~Num""Num-Num"的格式
         * *只接受十进制
         * 例如:“1~2”、“1-2” 
         **/
        /*     public static bool StrIsNumRC(string strToCheck)
             {
                 bool outPut = true;
                 bool NotAnNum;
                 char temp;
                 for (int i = 0; i < strToCheck.Length; i++)
                 {
                     temp = strToCheck[i];
                     NotAnNum = true;
                     for (int i2 = 0; i2 <= 12; i2++)
                     {
                         if (temp == CharsForCheck[i2])
                         {
                             NotAnNum = false;
                             break;
                         }
                     }
                     if (NotAnNum)
                     {
                         outPut = false;
                     }
                 }

                 return outPut;
             }
        */



        /**
         * StrAndNum.StrToInt(string)
         * 输入为一个字符串，输出为一个int值
         * 用于将纯数字的字符串转换成int类型
         * 建议在转换前先调用StrAndNum.StrIsNumC(string)对字符串进行检测
         * *当字符串不由纯数字组成时，会抛出异常
         **/
        public static int StrToInt(string strToCheck)
        {
            if (StrIsNumC(strToCheck) == false) throw new Exception("输入的值无效");
            int outPut = 0;
            int temp = 1;
            int numInt = 0;
            for (int i = strToCheck.Length - 1; i >= 0; i--)
            {
                for (int i2 = 0; i2 <= 9; i2++)                                       //对首位数字进行判断(包括+ -）
                {
                    if (strToCheck[i] == CharsForCheck[i2])
                    {
                        numInt = i2;
                        break;
                    }
                }
                outPut += numInt * temp;
                temp *= 10;
            }
            return outPut;
        }



        /**
         * StrAndNum.IntToStr(int)
         * 输入为一个int值，输出为一个字符串
         * 用于将int类型的值转换成纯数字的字符串
         **/
        public static string IntToStr(int intToCheck)
        {
            String outPut = "0";
            switch (intToCheck % 10)
            {
                case 0:
                    outPut = "0";
                    break;
                case 1:
                    outPut = "1";
                    break;
                case 2:
                    outPut = "2";
                    break;
                case 3:
                    outPut = "3";
                    break;
                case 4:
                    outPut = "4";
                    break;
                case 5:
                    outPut = "5";
                    break;
                case 6:
                    outPut = "6";
                    break;
                case 7:
                    outPut = "7";
                    break;
                case 8:
                    outPut = "8";
                    break;
                case 9:
                    outPut = "9";
                    break;
                default:
                    break;
            }
            intToCheck /= 10;
            while (intToCheck != 0)
            {
                outPut = CharsForCheck[intToCheck % 10] + outPut;
                intToCheck /= 10;
            }
            return outPut;
        }


    }
}
