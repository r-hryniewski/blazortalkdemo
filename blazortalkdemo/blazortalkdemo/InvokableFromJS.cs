using System;
using Microsoft.JSInterop;

namespace blazortalkdemo
{
    public static class InvokableFromJS
    {
        [JSInvokable(nameof(ReturnRandomGuid))]
        public static string ReturnRandomGuid()
        {
            return Guid.NewGuid().ToString();
        }
    }
}