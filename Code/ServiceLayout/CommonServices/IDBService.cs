﻿using ServiceLayer.CommonServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayout.CommonServices
{
    public interface IDbService
    {
        public DBDataSource DB { get; set; }
    }
}
