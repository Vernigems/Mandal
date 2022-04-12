using System;

namespace Mandal.Models
{
    public class UserwModel
    {
        public int MemberId { get; set; }
        public string NickName { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string MName { get; set; }
        public string address { get; set; }
        public double mobile { get; set; }
        public string refName { get; set; }
        public double refMobile { get; set; }
        public bool Status { get; set; }
       
    }

    public class UserDetailModel
    {
        public int MemberId { get; set; }
        public string NickName { get; set; }
        public string TotalEMI { get; set; }
        public string TotalDebit { get; set; }
        public string TotalCredit { get; set; }
        public double NextPay { get; set; }
        public string address { get; set; }
        public string LastMonth { get; set; }
        public double Intrest { get; set; }        
        public bool Status { get; set; }


    }
}
