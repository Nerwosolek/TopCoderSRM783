using System;
public class BouncingBall
{
    public static double getPosition(int g, int h, int p, int t)
    {
        /* co to? */
        double G = g / 100.0;
        double T = t;
        double h_res = h;
        while (T > 0)
        {
            double fallTime = Math.Sqrt(2.0 * h_res / G);
            Console.WriteLine($"fallTime: {fallTime}");
            double fallVelocity = G * fallTime;
            double bouncedVelocity = fallVelocity * Math.Sqrt(1 - p / 100.0);
            double riseTime = bouncedVelocity / G;
            if (T < fallTime)
            {
                h_res -= G * T * T / 2;
                return h_res;
            }
            else
            {
                T -= fallTime;
                
                Console.WriteLine($"bouncedVelocity: {bouncedVelocity}");
                if (T < riseTime)
                {
                    h_res = bouncedVelocity * T - G * T * T / 2;
                }
                else
                {
                    h_res = bouncedVelocity * riseTime - G * riseTime * riseTime / 2;
                }
            }
            T -= Math.Min(riseTime, T);
        }
        return h_res;
    }
}   