using Game.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Game.Web
{
    public partial class Member : System.Web.UI.Page
    {
        MemberService memberservice;
        protected void Page_Load(object sender, EventArgs e)
        {
            memberservice = new MemberService();
            List<Common.Entities.Member> list = memberservice.GetAll().ToList();
            GridView1.DataSource = list;
            GridView1.DataBind();
        }
    }
}