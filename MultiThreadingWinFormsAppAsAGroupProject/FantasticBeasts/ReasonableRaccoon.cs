/*
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 */
using System;

namespace MultiThreadingWinFormsAppAsAGroupProject
{
    /// <summary>
    /// A Fantastic Beast that will help us maintain a secure world
    /// </summary>
    class ReasonableRaccoon : FantasticBeast
    {
        public override void SayHello() {
            Console.WriteLine($"Hello from {this.GetType().Name}");
        }
        public override void RunThread() {

            long num = Convert.ToInt64(request);
            // get the largest prime factor of num and store it in response
            response = Convert.ToString(LargestPrimeFactor(num));
        }

        // I got this method from https://stackoverflow.com/a/2535285/12442137
        /// <summary>
        /// Returns the greatest prime factor of a number.
        /// </summary>
        /// <param name="num">The long number to get the greatest prime factor of</param>
        /// <returns>the greatest long prime factor of num</returns>
        private static long LargestPrimeFactor(long num) {
            long k = 2;
            while (k * k <= num) {
                if (num % k == 0) {
                    num /= k;
                }
                else {
                    ++k;
                }
            }

            return num;
        }

    }
}
