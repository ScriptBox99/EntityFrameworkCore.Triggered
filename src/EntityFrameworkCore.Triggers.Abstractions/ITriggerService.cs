﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Triggers
{
    public interface ITriggerService
    {
        ITriggerSession CreateSession(DbContext context);
    }
}