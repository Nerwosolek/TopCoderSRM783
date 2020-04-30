using System.Collections.Generic;
using System;
public class  PosNegDice 
{
     public static int[] evaluateRoll(int T, int[] positiveDice, int[] negativeDice)
     {
         if (positiveDice.Length == 0) 
         {
             return new int[] {0, negativeDice.Length};
         }
         else
         {
             Array.Sort(positiveDice);
             Array.Sort(negativeDice);
             List<int> positiveR = new List<int>(positiveDice);
             positiveR.Sort();
             List<int> negativeR = new List<int>(negativeDice);
             negativeR.Sort();
             var n_i = 0;
             var p_i = 0;
             while (n_i < negativeDice.Length && p_i < positiveDice.Length)
             {
                 if (negativeDice[n_i] == positiveDice[p_i])
                 {
                     negativeR.Remove(negativeDice[n_i]);
                     positiveR.Remove(negativeDice[n_i]);
                     n_i++;
                     p_i++;
                 }
                 else if (negativeDice[n_i] < positiveDice[p_i])
                 {
                     n_i++;
                 }
                 else
                 {
                     p_i++;
                 }
             }  
             if (positiveR.Count > 0 && positiveR[0] <= T) return new int[] {1, negativeR.Count};
             else return new int[] {0, negativeR.Count};
         }
     }
}