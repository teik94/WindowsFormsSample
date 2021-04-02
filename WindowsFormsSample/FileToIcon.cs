using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
//using System.Windows.Media;
//using System.Windows.Media.Imaging;
//using System.Windows.Data;
//using System.Windows.Interop;
using System.Windows;
using System.Runtime.InteropServices;
//using vbAccelerator.Components.ImageList;
using System.Diagnostics;
using System.Threading;
//using System.Windows.Threading;

namespace WindowsFormsApp2
{

    public static class FileToIconConverter
    {
        private static string imageFilter = ".jpg,.jpeg,.png,.gif";
        private static string exeFilter = ".exe,.lnk";
        //private int defaultsize;

        //public int DefaultSize { get { return defaultsize; } set { defaultsize = value; } }

        public enum IconSize
        {
            small, large, extraLarge, jumbo, thumbnail
        }

        //private class thumbnailInfo
        //{
        //    public IconSize iconsize;
        //    public WriteableBitmap bitmap;
        //    public string fullPath;
        //    public thumbnailInfo(WriteableBitmap b, string path, IconSize size)
        //    {
        //        bitmap = b;
        //        fullPath = path;
        //        iconsize = size;
        //    }
        //}


        #region Win32api
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern bool DeleteObject(IntPtr hObject);

        [StructLayout(LayoutKind.Sequential)]
        internal struct SHFILEINFO
        {
            public IntPtr hIcon;
            public IntPtr iIcon;
            public uint dwAttributes;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szDisplayName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
        };

        internal const uint SHGFI_ICON = 0x100;
        internal const uint SHGFI_TYPENAME = 0x400;
        internal const uint SHGFI_LARGEICON = 0x0; // 'Large icon
        internal const uint SHGFI_SMALLICON = 0x1; // 'Small icon
        internal const uint SHGFI_SYSICONINDEX = 16384;
        internal const uint SHGFI_USEFILEATTRIBUTES = 16;

        // <summary>
        /// Get Icons that are associated with files.
        /// To use it, use (System.Drawing.Icon myIcon = System.Drawing.Icon.FromHandle(shinfo.hIcon));
        /// hImgSmall = SHGetFileInfo(fName, 0, ref shinfo,(uint)Marshal.SizeOf(shinfo),Win32.SHGFI_ICON |Win32.SHGFI_SMALLICON);
        /// </summary>
        [DllImport("shell32.dll")]
        internal static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes,
                                                  ref SHFILEINFO psfi, uint cbSizeFileInfo, uint uFlags);

        // <summary>
        /// Return large file icon of the specified file.
        /// </summary>
        internal static Icon GetFileIcon(string fileName, IconSize size)
        {
            SHFILEINFO shinfo = new SHFILEINFO();

            uint flags = SHGFI_SYSICONINDEX;
            if (fileName.IndexOf(":") == -1)
                flags = flags | SHGFI_USEFILEATTRIBUTES;
            if (size == IconSize.small)
                flags = flags | SHGFI_ICON | SHGFI_SMALLICON;
            else flags = flags | SHGFI_ICON;

            SHGetFileInfo(fileName, 0, ref shinfo, (uint)Marshal.SizeOf(shinfo), flags);
            return Icon.FromHandle(shinfo.hIcon);
        }
        #endregion


        //public FileToIconConverter()
        //{
        //    this.defaultsize = 48;
        //}


    }
}
