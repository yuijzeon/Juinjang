using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oval_Measure
{
    class EillpseRes
    {
        public static double[] EllipticRegressionAnalysis(double[] FX, double[] FY)//X,Y,長軸,短軸,角度
        {
            double[,] Sol = new double[5, 6];
            Sol = ELLIPREG(FX, FY);
            Sol = YENBOB(5, 5, Sol);

            double a = Sol[2, 5];
            double b = Sol[3, 5];
            double c = Sol[4, 5];
            double D = Sol[1, 5];
            double E = -1;
            double F = Sol[0, 5];

            double TT = Math.Atan(b / (a - c)) / 2;
            double SinTT = Math.Sin(TT);
            double CosTT = Math.Cos(TT);
            double AP = a * Math.Pow(CosTT, 2) + b * SinTT * CosTT + c * Math.Pow(SinTT, 2);
            double CP = a * Math.Pow(SinTT, 2) - b * SinTT * CosTT + c * Math.Pow(CosTT, 2);
            double DP = (D * CosTT + E * SinTT) / 2;
            double EP = (-D * SinTT + E * CosTT) / 2;
            double FP = F;
            double RXM = -DP / AP; //中心X
            double RYM = -EP / CP;  //中心Y
            double RSA = Math.Sqrt((CP * DP * DP + AP * EP * EP - AP * CP * FP) / (AP * AP * CP));//長軸
            double RSB = Math.Sqrt((CP * DP * DP + AP * EP * EP - AP * CP * FP) / (AP * CP * CP));//短軸
            Console.WriteLine(TT); 
            double[] R_Sol = { RXM, RYM, RSA, RSB,TT};
            return R_Sol;
        }

        public static double[,] ELLIPREG(double[] FX, double[] FY)
        {
            double[,] RK = new double[5,6];
            double X1, X2, X3, X4, Y1, Y2, Y3, Y4;
            //初始 RK  [5 X 6]
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    RK[i, j] = 0;
                }
            }
            int IPOINT = FX.Length;
            RK[0, 0] = IPOINT;
            for (int i = 0; i < IPOINT; i++)
            {
                X1 = FX[i];
                X2 = X1 * X1;
                X3 = X1 * X2;
                X4 = X2 * X2;

                Y1 = FY[i];
                Y2 = Y1 * Y1;
                Y3 = Y1 * Y2;
                Y4 = Y2 * Y2;
                RK[0, 1] = RK[0, 1] + X1;
                RK[0, 2] = RK[0, 2] + X2;
                RK[0, 3] = RK[0, 3] + X1 * Y1;
                RK[0, 4] = RK[0, 4] + Y2;
                RK[0, 5] = RK[0, 5] + Y1;
                RK[1, 1] = RK[1, 1] + X2;
                RK[1, 2] = RK[1, 2] + X3;
                RK[1, 3] = RK[1, 3] + X2 * Y1;
                RK[1, 4] = RK[1, 4] + X1 * Y2;
                RK[1, 5] = RK[1, 5] + X1 * Y1;
                RK[2, 2] = RK[2, 2] + X4;
                RK[2, 3] = RK[2, 3] + X3 * Y1;
                RK[2, 4] = RK[2, 4] + X2 * Y2;
                RK[2, 5] = RK[2, 5] + X2 * Y1;
                RK[3, 3] = RK[3, 3] + X2 * Y2;
                RK[3, 4] = RK[3, 4] + X1 * Y3;
                RK[3, 5] = RK[3, 5] + X1 * Y2;
                RK[4, 4] = RK[4, 4] + Y4;
                RK[4, 5] = RK[4, 5] + Y3;
            }
            RK[1, 0] = RK[0, 1];
            RK[2, 0] = RK[0, 2];
            RK[2, 1] = RK[1, 2];
            RK[3, 0] = RK[0, 3];
            RK[3, 1] = RK[1, 3];
            RK[3, 2] = RK[2, 3];
            RK[4, 0] = RK[0, 4];
            RK[4, 1] = RK[1, 4];
            RK[4, 2] = RK[2, 4];
            RK[4, 3] = RK[3, 4];

            return RK;
        }
        public static double[,] YENBOB(int IROW, int ICOL, double[,] RK)   //解聯立方程式   'the same
        {
            int ICOL1, INDEX1, INDEX2, INDEX3, INDEX4, I, K, J;
            int NDIN;
            ICOL1 = ICOL + 1;
            NDIN = IROW * ICOL1;
            double[] a = new double[NDIN + 100];

            K = 0;
            for (J = 1; J <= ICOL1; J++)
            {
                for (I = 1; I <= IROW; I++)
                {
                    K = K + 1;
                    a[K] = RK[I-1, J-1];
                }
            }

            for (K = 1; K <= ICOL; K++)
            {
                INDEX1 = (K - 1) * IROW + K;
                a[INDEX1] = 1 / a[INDEX1];

                for (J = 1; J <= ICOL1; J++)
                {
                    if ((J - K) != 0)
                    {
                        INDEX2 = (J - 1) * IROW + K;
                        a[INDEX2] = a[INDEX2] * a[INDEX1];
                    }
                }
                for (I = 1; I <= ICOL; I++)
                {
                    if ((I - K) != 0)
                    {
                        INDEX3 = (K - 1) * IROW + I;
                        for (J = 1; J <= ICOL1; J++)
                        {
                            if ((J - K) != 0)
                            {
                                INDEX2 = (J - 1) * IROW + I;
                                INDEX4 = (J - 1) * IROW + K;
                                a[INDEX2] = a[INDEX2] - a[INDEX4] * a[INDEX3];
                            }
                        }
                    }
                }
                for (I = 1; I <= ICOL; I++)
                {
                    if ((I - K) != 0)
                    {
                        INDEX2 = (K - 1) * IROW + I;
                        a[INDEX2] = -a[INDEX2] * a[INDEX1];
                    }
                }
            }
            K = 0;
            for (J = 1; J <= ICOL1; J++)
            {
                for (I = 1; I <= IROW; I++)
                {
                    K = K + 1;
                    RK[I-1, J-1] = a[K];
                }
            }


            return RK;
        }

    }
}
