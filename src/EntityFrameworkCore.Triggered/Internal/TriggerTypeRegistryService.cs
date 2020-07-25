﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Triggered.Internal
{
    public sealed class TriggerTypeRegistryService : ITriggerTypeRegistryService
    {
        readonly ConcurrentDictionary<(Type, Type), TriggerTypeRegistry> _resolvedRegistries = new ConcurrentDictionary<(Type, Type), TriggerTypeRegistry>();

        public TriggerTypeRegistry ResolveRegistry(Type openTriggerType, Type entityType, Func<Type, ITriggerTypeDescriptor> triggerTypeDescriptorFactory)
            => _resolvedRegistries.GetOrAdd((openTriggerType, entityType), _ => new TriggerTypeRegistry(entityType, triggerTypeDescriptorFactory));
    }
}