﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utulities_Araçlar_.Results
{
    public class ErrorResult :Result
    {
        public ErrorResult( string message):base(false)
        {

        }

        public ErrorResult():base(false)
        {

        }
    }
}
