using System;
using System.Runtime.InteropServices;
using Pelly.Enums.Windows;

namespace Pelly.Common
{
    [StructLayout(LayoutKind.Sequential)]
    public struct POINT
    {
        public int x;
        public int y;
    }
}