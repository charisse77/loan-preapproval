using System;
using System.Collections.Generic;

namespace LoanPreapproval
{
    class Program 
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Loan Approval Software"); 

           Customer loanApplicant = new Customer(); 
           EnterApplicantData(); 
        }


   private static void EnterApplicantData()
        {
            while (true)
            {
                Console.WriteLine("Press any key to continue or 'q' to quit");
                var input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }

                try
                {
                    
                Customer loanApplicant = new Customer(); 
                loanApplicant.Name = GetUserInput("Enter applicant's name: ");
                loanApplicant.CreditScore = Convert.ToInt32(GetUserInput("Enter applicant's credit score: "));
                loanApplicant.MonthlyIncome = Convert.ToInt32(GetUserInput("Enter applicant's monthly income: "));
                loanApplicant.HousingPayment = Convert.ToInt32(GetUserInput("Enter applicant's montly housing payment: "));

                Console.WriteLine($"Name: {loanApplicant.Name}"); 
                Console.WriteLine($"Credit Score: {loanApplicant.CreditScore}");
                Console.WriteLine($"Monthly Income: {loanApplicant.MonthlyIncome}"); 
                Console.WriteLine($"Housing Payment: {loanApplicant.HousingPayment}"); 
                Console.WriteLine($"Loan Status: "); 

                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("**");
                }
            }
        }
        static string GetUserInput(string prompt)
        {
            Console.Write(prompt); 
            return Console.ReadLine(); 

        }

  





    }
}