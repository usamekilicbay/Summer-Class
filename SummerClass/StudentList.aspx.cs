﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using BusinessLogicLayer;
using DataAccessLayer;
using EntityLayer;

namespace SummerClass
{
    public partial class StudentList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = StudentBusinessLogic.GetStudentList();
            Repeater1.DataBind();
        }
    }
}