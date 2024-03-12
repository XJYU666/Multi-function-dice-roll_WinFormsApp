//Made by XJYU_Angel
using System;

namespace Multi_function_dice_roll_WinFormsApp
{
    internal class Run
    {
        public string? Output;
        public int Main(string inPutMode, bool fastmode, bool NR, bool allString, string mix, string tB1_1, string tB1_2, string tB2_1, string tB2_12, string tB2_2, string space)
        {
            int rmin, rmax, rmix, rnum;
            string insideMode;
            switch (inPutMode)
            {
                case "Ra":                                                          //Random数据格式
                    if (StrAndNum.StrIsNumC(tB2_1) == false) return -4;             //Error:输入的参数非数字
                    if (StrAndNum.StrIsNumC(tB2_12) == false) return -4;            //Error:输入的参数非数字
                    if (StrAndNum.StrIsNumC(tB2_2) == false) return -4;             //Error:输入的参数非数字

                    rmin = StrAndNum.StrToInt(tB2_1);
                    rmax = StrAndNum.StrToInt(tB2_12);
                    rnum = StrAndNum.StrToInt(tB2_2);

                    if (rmin > rmax)                                                //起始值与终止值大小问题
                    {
                        rmix = rmax;
                        rmax = rmin;
                        rmin = rmix;
                    }

                    break;
                case "Ro":                                                          //Roll数据格式
                    if (StrAndNum.StrIsNumC(tB1_1) == false) return -4;             //Error:输入的参数非数字
                    if (StrAndNum.StrIsNumC(tB1_2) == false) return -4;             //Error:输入的参数非数字

                    rmin = 0;
                    rmax = StrAndNum.StrToInt(tB1_1);
                    rnum = StrAndNum.StrToInt(tB1_2);

                    break;
                default:
                    return -2;                                                      //Error:模式无效
            }
            if (NR && (rmax - rmin) < rnum - 1) 
                throw new Exception("Error:输入逻辑错误");                          //Error:输入逻辑错误

            if (fastmode)                                                           //判断快速模式
            {                                                                       //快速模式
                if (NR)                                                             //判断查重模式
                {                                                                   //快速+查重
                    insideMode = "FANR";
                }
                else
                {                                                                   //快速不查重
                    insideMode = "FAUR";
                }
            }
            else
            {                                                                       //普通模式
                if (NR)
                {                                                                   //普通+查重
                    insideMode = "CONR";
                }
                else
                {                                                                   //普通不查重
                    insideMode = "COUR";
                }
            }

            XJYU_Random xRandom1 = new();                                           //实例化
            switch (insideMode)
            {
                case "FANR":                                                        //快速+查重
                    if (StrAndNum.StrIsNumC(mix) == false) return -5;               //Error;输入的随机程度非数字
                    rmix = StrAndNum.StrToInt(mix);
                    xRandom1.Random_F_NR(rmin, rmax, rnum, rmix);
                    break;
                // case "CONR":                                                     //普通+查重
                // break;

                case "FAUR":                                                        //快速不查重
                case "COUR":                                                        //普通不查重
                    xRandom1.Random_C(rmin, rmax, rnum);
                    break;
                default:
                    return -6;                                                      //Error;内部模式错误
            }

            for (int i = 0; i < rnum; i++)
            {
                Output += StrAndNum.IntToStr(xRandom1.OutPut[i]);
                if (i < rnum - 1) Output += space;
            }

            return 0;
        }
    }
}
