using System;
using System.Collections.Concurrent;
using System.Threading;

namespace EncompassRest
{
    /// <summary>
    /// A common cache object that is meant to be shared between multiple clients. This can be done through the <see cref="ClientParameters.CommonCache"/> property when creating a client.
    /// </summary>
    public sealed class CommonCache
    {
        private ConcurrentDictionary<string, object>? _extensionData;

        internal ConcurrentDictionary<string, object> ExtensionData
        {
            get
            {
                var extensionData = _extensionData;
                return extensionData ?? Interlocked.CompareExchange(ref _extensionData, (extensionData = new ConcurrentDictionary<string, object>(StringComparer.OrdinalIgnoreCase)), null) ?? extensionData;
            }
        }
    }
}