﻿using Game.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Game.Web
{
    public partial class Monster : System.Web.UI.Page
    {
        ItemService itemService;
        protected void Page_Load(object sender, EventArgs e)
        {
            itemService = new ItemService();
            List<Common.Entities.Item> list = itemService.GetAll().ToList();
            GridView1.DataSource = list;
            GridView1.DataBind();
        }
    }
}