﻿using OOPsProblemStatement.InventoryDataManagementProblem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace OOPsProblemStatement.InventoryManagement
{
    public class InventoryList
    {
        public List<InventoryData> RiceList { get; set; }
        public List<InventoryData> WheatList { get; set; }
        public List<InventoryData> PulsesList { get; set; }
    }
}
