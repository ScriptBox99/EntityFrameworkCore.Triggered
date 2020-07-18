﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EntityFrameworkCore.Triggered.Infrastructure.Internal;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EntityFrameworkCore.Triggered.Internal
{
    public sealed class AfterSaveTriggerAdapter : TriggerAdapterBase
    {
        public AfterSaveTriggerAdapter(object trigger) : base(trigger)
        {
        }

        public override Task Execute(object triggerContext, CancellationToken cancellationToken)
            => Execute(nameof(IAfterSaveTrigger<object>.AfterSave), triggerContext, cancellationToken);
    }
}