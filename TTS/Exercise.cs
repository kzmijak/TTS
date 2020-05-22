using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TTS
{
    public class Exercise
    {
        public static double StartExercise(double h, double b, double w)
        {
            if ( h < 0  || w <0 || b < 0 || b >= 1) // I assume that if (at least) one of these requirements are fulfilled, the parameters are not valid
                                          // - starting and window height is lower than 0 ( I assume that calculations are made on or above sea level (0 meters),
                                          //   height cannot be lower than 0, but can equal to 0, and can be infinite
                                          // - bouncing modifier ( b ) can only have values between 0 and lower than 1. ( 0 because it may not bounce whatsoever)
            {
                return -1;
            }


            short counter = 0; /// this is the counter of bounces visible by the window (w)
            while( h >= w)
            {
                counter += 1; // This is when mother sees the ball descend
                h *= b; // height is now modified by the bouncing modifier

                if(h >= w )
                {
                    counter += 1; // This is when mother sees the ball ascend
                }
            }

            return counter;
        }
    }
}
