﻿using NerdBlock.Engine.Backend;
using NerdBlock.Engine.Backend.Models;
using NerdBlock.Engine.Frontend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdBlock.Engine.LogicLayer.Implementation.Actions
{
    [BusinessActionContainer]
    public class Customer
    {
        [BusinessAction("goto_customer_search")]
        public void ShowSearch()
        {
            ViewManager.Show("CustomerSearch");
        }
    }
}