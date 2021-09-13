//------------------------------------------------------------
// Starpelly (the unity library)
// Homepage: https://starpelly.starpelly.com
// Do What The F*ck You Want To Public License (© 2004 Sam Hocevar <sam@hocevar.net>)
//------------------------------------------------------------

using System.Runtime.InteropServices;

namespace Starpelly.Common
{
    [StructLayout(LayoutKind.Sequential)]
    public struct POINT
    {
        public int x;
        public int y;
    }
}