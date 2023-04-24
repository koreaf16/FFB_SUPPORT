using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;


namespace EXTERNAL
{
    internal class GET_PLANE
    {
        string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
        [DllImport("kernel32")] static extern int GetPrivateProfileString(string Section, string Key, string Value, [MarshalAs(UnmanagedType.LPArray)] byte[] Result, int Size, string FileName);

        public byte[] get_plane_list()
        {
            byte[] bytes = new byte[32767];
            GetPrivateProfileString("DCS_PLANE", null, null, bytes, 32767, System.IO.Path.GetDirectoryName(path) + "\\Setup.ini");
            return bytes;
        }

        public byte[] get_plane_list_wt()
        {
            byte[] bytes = new byte[32767];
            GetPrivateProfileString("WARTHUNDER_PLANE", null, null, bytes, 32767, System.IO.Path.GetDirectoryName(path) + "\\Setup.ini");
            return bytes;
        }

    }
}   
