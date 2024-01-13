using Mandal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;

namespace Mandal.Controllers
{
    public class User : BaseClass
    {
        public User(IConfiguration configuration) : base(configuration)
        {

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UserList()
        {
            List<UserDetailModel> userwModel = ExecuteNonQuery<UserDetailModel>(CommandType.StoredProcedure, "GetAllMember", null);

            foreach (var userwModel1 in  userwModel)
            {
                userwModel1.Intrest = (Convert.ToInt64(userwModel1.TotalDebit) * 1.5 / 100);
                userwModel1.NextPay = userwModel1.Intrest + 1000; 
                userwModel.Where(w => w.MemberId == userwModel1.MemberId).Select(s => { s.Intrest = userwModel1.Intrest; return s; }).ToList();
                userwModel.Where(w => w.MemberId == userwModel1.MemberId).Select(s => { s.NextPay = userwModel1.NextPay; return s; }).ToList();
            }

            return View(userwModel);
        }

        [HttpPost]
        public ActionResult SaveUser(UserwModel UserModel)
        {
           ExecuteNonQuery<UserwModel>(CommandType.StoredProcedure, "AddMember", 
                                                ("@NickName", UserModel.NickName),
                                                ("@FName", UserModel.FName),
                                                ("@MName", UserModel.MName),
                                                ("@LName", UserModel.LName),
                                                ("@Address", UserModel.address),
                                                ("@Mobile", UserModel.mobile),
                                                ("@RefName", UserModel.refName),
                                                ("@RefMobile", UserModel.refMobile),
                                                ("@CreatedBy", "Admin")
                                                );
            return Redirect("/Index");
        }
    }
}
