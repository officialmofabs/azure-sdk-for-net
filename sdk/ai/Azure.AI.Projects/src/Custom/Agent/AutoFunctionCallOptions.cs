// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azure.AI.Projects
{
    public class AutoFunctionCallOptions
    {
        private Dictionary<string, Delegate> _autoFunctionCallDelegates = new();
        private int _maxRetry;
        /// <summary> The size of the client cache. </summary>

        /// <summary>
        /// Enables auto tool calls to be executed automatically during streaming.  If this is not set, function must be called manually.
        /// </summary>
        /// <param name="delegates">Dictionary in name and delegate in pair</param>
        /// <param name="maxRetry">Maximum number of errors allowed and retry per stream. Default value is 10.</param>
        public AutoFunctionCallOptions(Dictionary<string, Delegate> delegates, int maxRetry) {
            ValidateAutoFunctions(delegates);
            _autoFunctionCallDelegates.Clear();

            foreach (var kvp in delegates)
            {
                _autoFunctionCallDelegates[kvp.Key] = kvp.Value;
            }
            _maxRetry = maxRetry;
        }

        private void ValidateAutoFunctions(Dictionary<string, Delegate> delegates)
        {
            if (delegates == null || delegates.Count == 0)
            {
                throw new InvalidOperationException("The delegate dictionary must have at least one delegate.");
            }
            foreach (var kvp in delegates)
            {
                if (kvp.Value.Method.ReturnType != typeof(string))
                {
                    throw new InvalidOperationException($"The Delegates must have string as return type.");
                }
            }
        }

        internal Dictionary<string, Delegate> AutoFunctionCallDelegates => _autoFunctionCallDelegates;

        internal int MaxRetry => _maxRetry;
    }
}
