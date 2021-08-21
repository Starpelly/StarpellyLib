using System;
using System.Runtime.InteropServices;
using System.Text;

using UnityEngine;
using Pelly.Enums;

namespace Pelly.OS
{
    public class Universal : MonoBehaviour
    {
        [DllImport("user32.dll", EntryPoint = "SetWindowText")]
        public static extern bool SetWindowText(IntPtr hwnd, String lpString);
        [DllImport("user32.dll", EntryPoint = "FindWindow")]
        public static extern IntPtr FindWindow(String className, String windowName);
        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        /// <summary>
        /// Gets the current title of the game window.
        /// </summary>
        /// <returns>The current title the window is, will probably only be used for changing the window in ChangeWindowTitle()</returns>
        private static string GetActiveWindowTitle()
        {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            IntPtr handle = GetForegroundWindow();

            if (GetWindowText(handle, Buff, nChars) > 0)
            {
                return Buff.ToString();
            }
            return null;
        }

        /// <summary>
        /// Changes the game's window title.
        /// </summary>
        /// <param name="newTitle">The title the window will be changed to.</param>
        public static void ChangeWindowTitle(string newTitle)
        {
            if (Application.platform == RuntimePlatform.WindowsPlayer)
            {
                var windowPtr = FindWindow(null, GetActiveWindowTitle());
                SetWindowText(windowPtr, newTitle);
            }
        }
    }

    public class Windows : MonoBehaviour
    {
        public static void ChangeCursor(WindowsCursor cursor)
        {
            #if UNITY_STANDALONE_WIN
            if (Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.WindowsEditor)
            {
                SetCursor(LoadCursor(IntPtr.Zero, (int)cursor));
            }
            else
                Debug.LogWarning("Not on Windows");
            #endif
        }

        [DllImport("user32.dll", EntryPoint = "SetCursor")]
        public static extern IntPtr SetCursor(IntPtr hCursor);

        [DllImport("user32.dll", EntryPoint = "LoadCursor")]
        public static extern IntPtr LoadCursor(IntPtr hInstance, int lpCursorName);
    }
}