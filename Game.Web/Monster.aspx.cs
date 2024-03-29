﻿using Game.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Game.Web
{
    public partial class Monster : System.Web.UI.Page
    {
        MonsterService monsterService;
        protected void Page_Load(object sender, EventArgs e)
        {
            monsterService = new MonsterService();
            List<Common.Entities.Monster> list = monsterService.GetAll().ToList();
            GridView1.DataSource = list;
            GridView1.DataBind();
        }
    }
}