using System.Runtime.InteropServices;

namespace DofusFlashGenerator.Utils;

public static partial class Screenshot
{
    /// <summary>
    /// Creates an Image object containing a screen shot of the entire desktop
    /// </summary>
    /// <returns></returns>
    public static Image Screen()
    {
        return Window(User32.GetDesktopWindow());
    }

    /// <summary>
    /// Creates an Image object containing a screen shot of a specific window
    /// </summary>
    /// <param name="handle">The handle to the window. (In windows forms, this is obtained by the Handle property)</param>
    /// <returns></returns>
    public static Image Window(nint handle)
    {
        // get te hDC of the target window
        var hdcSrc = User32.GetWindowDC(handle);

        // get the size
        User32.RECT windowRect = new();
        User32.GetWindowRect(handle, ref windowRect);
        var width = windowRect.right - windowRect.left;
        var height = windowRect.bottom - windowRect.top;

        // create a device context we can copy to
        var hdcDest = GDI32.CreateCompatibleDC(hdcSrc);

        // create a bitmap we can copy it to,
        // using GetDeviceCaps to get the width/height
        var hBitmap = GDI32.CreateCompatibleBitmap(hdcSrc, width, height);

        // select the bitmap object
        var hOld = GDI32.SelectObject(hdcDest, hBitmap);

        // bitblt over
        GDI32.BitBlt(hdcDest, 0, 0, width, height, hdcSrc, 0, 0, GDI32.SRCCOPY);

        // restore selection
        GDI32.SelectObject(hdcDest, hOld);

        // clean up
        GDI32.DeleteDC(hdcDest);
        User32.ReleaseDC(handle, hdcSrc);

        // get a .NET image object for it
        Image img = Image.FromHbitmap(hBitmap);

        // free up the Bitmap object
        GDI32.DeleteObject(hBitmap);

        return img;
    }

    /// <summary>
    /// Helper class containing GDI32 API functions
    /// </summary>
    private static partial class GDI32
    {
        public const int SRCCOPY = 0x00CC0020; // BitBlt dwRop parameter

        [LibraryImport("gdi32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static partial bool BitBlt(nint hObject, int nXDest, int nYDest,
            int nWidth, int nHeight, nint hObjectSource,
            int nXSrc, int nYSrc, int dwRop);

        [LibraryImport("gdi32.dll")]
        public static partial nint CreateCompatibleBitmap(nint hDC, int nWidth,
            int nHeight);

        [LibraryImport("gdi32.dll")]
        public static partial nint CreateCompatibleDC(nint hDC);

        [LibraryImport("gdi32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static partial bool DeleteDC(nint hDC);

        [LibraryImport("gdi32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static partial bool DeleteObject(nint hObject);

        [LibraryImport("gdi32.dll")]
        public static partial nint SelectObject(nint hDC, nint hObject);
    }

    /// <summary>
    /// Helper class containing User32 API functions
    /// </summary>
    private static partial class User32
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        [LibraryImport("user32.dll")]
        public static partial nint GetDesktopWindow();

        [LibraryImport("user32.dll")]
        public static partial nint GetWindowDC(nint hWnd);

        [LibraryImport("user32.dll")]
        public static partial nint ReleaseDC(nint hWnd, nint hDC);

        [LibraryImport("user32.dll")]
        public static partial nint GetWindowRect(nint hWnd, ref RECT rect);
    }
}
