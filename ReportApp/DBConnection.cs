﻿using ReportApp.ADOApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportApp
{
    public static class DBConnection
    {
        public static ReportEntities Connection = new ReportEntities();
    }
}
