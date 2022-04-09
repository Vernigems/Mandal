namespace Mandal.Models
{
    public class EmiModel
    {

        public int TransactionId { get; set; }
        public int MemberId { get; set; }
        public string Month { get; set; }
        public string NickName { get; set; }
        public string CreatedBy { get; set; }
        public int Emi { get; set; }
        public int Intrest { get; set; }
        public int Debit { get; set; }
        public int Credit { get; set; }
        public int Fine { get; set; }

    }
}
