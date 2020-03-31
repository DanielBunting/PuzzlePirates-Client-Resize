using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClientResizer
{
    static class WindowsInterface
    {
        /// <summary>
        /// Gets the IntPtr of a process of a specified name, else returns an empty process as it is not an nullable type. 
        /// </summary>
        /// <param name="wName"> The name of the process. </param>
        /// <returns> the IntPrt of the named process. </returns>
        public static IntPtr WinGetHandle(string wName = "Puzzle Pirates")
        {
            IntPtr hWnd = IntPtr.Zero;

            foreach (Process pList in Process.GetProcesses())
            {
                if (pList.MainWindowTitle.Contains(wName))
                {
                    hWnd = pList.MainWindowHandle;
                    return hWnd;
                }
            }
            return hWnd;
        }

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int Width, int Height, bool Repaint);

        public static void ResizeWindow(IntPtr processHandle, int width, int height)
        {
            MoveWindow(processHandle, 10, 10, width, height, true);
        }
    }
}
