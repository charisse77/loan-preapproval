namespace LoanPreapproval
{
    public class Customer
    {
        public string? Name //property
        {
            get;
            set;

        }
        public int CreditScore
        {
            get; 
            set; 
        }
        public int MonthlyIncome = 3100;
        public int HousingPayment = 800;
        public string? LoanStatus
        {
            get; 
            set; 
        }

    
    }
}