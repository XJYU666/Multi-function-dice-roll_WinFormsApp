//Made by XJYU_Angel
namespace Multi_function_dice_roll_WinFormsApp
{
    internal class XJYU_Random
    {
        public int[] OutPut=new int[1000];



        public int Random_C(int rmin,int rmax,int num)                               //常规随机数
        {
            Random Ra =new Random();

            for(int i = 0; i < num; i++)
            {
                OutPut[i] = Ra.Next(rmin - 1, rmax) + 1;
            }
            return 0;
        }



        public int Random_F_NR(int rmin, int rmax, int num, int mix)                  //快速随机数（含有查重功能）
        {
            Random Ra = new Random();
            int temp, a, b;
            for (int i = 0; i < rmax; i++)
            {
                OutPut[i] = rmin + i + 1;
            }
            for(int i = 0; i < mix; i++)
            {
                a = Ra.Next(rmax);
                b = Ra.Next(rmax);
                temp = OutPut[a];
                OutPut[a] = OutPut[b];
                OutPut[b] = temp;
            }
            return 0;
        }
        public static int Check(int rmin, int rmax, int num) 
        { 
            return 0;
        }
    }
}
