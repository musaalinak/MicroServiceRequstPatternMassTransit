﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging.CustomerCredit
{
    public record GetCreditScoreRequest(string accountNumber, decimal requestAmount);

}