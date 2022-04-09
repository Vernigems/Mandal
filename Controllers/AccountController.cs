using Mandal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;

namespace Mandal.Controllers
{
    public class AccountController : BaseClass
    {
        public AccountController(IConfiguration configuration) : base(configuration)
        {

        }

        public IActionResult AccountOverView()
        {
            return View();
        }

        public IActionResult AccountDetail(int MemberID)
        {
            List<EmiModel> EmiModel = ExecuteNonQuery<EmiModel>(CommandType.StoredProcedure, "GetMemberEmi", ("@MemberId", MemberID));
            return View(EmiModel);
        }

        [HttpPost]
        public int AddEmi(EmiModel EmiModel)
        {
            var isRecordExists = false;

            if (EmiModel.TransactionId == 0)
            {
                isRecordExists = ExecuteScalar<bool>(CommandType.StoredProcedure, "MothEmiCheck",
                                                     ("@MemberId", EmiModel.MemberId, false),
                                                     ("@Month", EmiModel.Month, false),
                                                     ("@Year", "2022", false)
                                                     );
            }

            if (!isRecordExists)
            {
                ExecuteNonQuery<UserwModel>(CommandType.StoredProcedure, "AddEditEmi",
                                                 ("@MemberId", EmiModel.MemberId),
                                                 ("@Month", EmiModel.Month),
                                                 ("@Emi", EmiModel.Emi),
                                                 ("@Intrest", EmiModel.Intrest),
                                                 ("@Debit", EmiModel.Debit),
                                                 ("@Credit", EmiModel.Credit),
                                                 ("@Fine", EmiModel.Fine),
                                                 ("@TransactionId", EmiModel.TransactionId)
                                                 );
                return 1;// "Record Add/Edit Successfully";
            }
            else
            {
                return 0;// "Something Wrong Please contact Admin";
            }
        }

        [HttpPost]
        public List<EmiModel> GetEmiById(int TransactionId)
        {
            List<EmiModel> EmiModel = ExecuteNonQuery<EmiModel>(CommandType.StoredProcedure, "GetEmiById", ("@TransactionId", TransactionId));
            return EmiModel;
        }

        [HttpPost]
        public bool DeleteEmi(int TransactionId)
        {
            ExecuteNonQuery(CommandType.StoredProcedure, "DeleteEmi", ("@TransactionId", TransactionId));
            return true;
        }
    }
}
