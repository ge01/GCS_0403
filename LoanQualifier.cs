using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_0403
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////////////////////////////////////
            //                      Loan Qualifier Program                      //
            // This program determines whether a person qualifies for a loan.   //
            // To qualify for the loan, the perso must earn a salary of at      //
            // least $40,000 and must have been employed at his or her current  //
            // job for at least 2 years.                                        //
            //////////////////////////////////////////////////////////////////////

            try
            {
                // Named constants
                const decimal MINIMUM_SALARY = 40000m;
                const int MINIMUM_YEARS_ON_JOB = 2;

                // Local variables
                decimal salary;
                int yearsOnJob;

                // Get the salary and years on the job.
                Console.Write("Annual salary: ");
                salary = decimal.Parse(Console.ReadLine());

                Console.Write("Years at current job: ");
                yearsOnJob = int.Parse(Console.ReadLine());

                // Determine whether the user qualifies
                if (salary >= MINIMUM_SALARY)
                {
                    if (yearsOnJob >= MINIMUM_YEARS_ON_JOB)
                    {
                        // The user qualifies.
                        Console.Write("You qualify for the loan.");
                    }
                    else
                    {
                        // The user does not qualify.
                        Console.Write("Minimum years at current " +
                            "job not met.");
                    }
                }
                else
                {
                    // The user does not qualify.
                    Console.Write("Minimum salary requiremnt " +
                        "not met.");
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                // Display an error message.
                Console.Write(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
