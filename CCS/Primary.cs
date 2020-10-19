using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace CCS
{
    public class Primary
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern int AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern int FreeConsole();
        private void Call()
        {
            AllocConsole();
        }
        private void End()
        {
            FreeConsole();
        }
        private void Resize(int width, int height)
        {
            Console.WindowHeight = height;
            Console.BufferHeight = height;
            Console.WindowWidth = width;
            Console.BufferWidth = width;
        }
    }
}
