using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection; // 더블버퍼링 하기 위해서 이넘을 추가한다.
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ISSOFT
{
    public static class ExtensionMethods    // DoubleBuffered 메서드를 확장 시켜주자..
    {
        public static void DoubleBuffered(this DataGridView dgv, bool setting)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.SetProperty);
            pi.SetValue(dgv, setting, null);
        }

        public static string DatagridviewToString(DataGridView dgv)
        {
            string result = "";

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row != null)
                {
                    for (int i = 0; i < dgv.ColumnCount; i++)
                    {
                        string cellValue = "";
                        if (row.Cells[i] != null)
                        {
                            if (row.Cells[i].Value != null)
                            {
                                cellValue = row.Cells[i].Value.ToString();
                            }
                        }
                        result += cellValue;
                        if (i == dgv.ColumnCount - 1)
                        {
                            result += "\r\n";
                        }
                        else
                        {
                            result += "\t";
                        }
                    }
                }
            }

            return result;
        }

        public static List<string[]> DatagridviewToListString(DataGridView dgv)
        {
            List<string[]> result = new List<string[]>();

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row != null)
                {
                    string[] temp = new string[dgv.ColumnCount];
                    for (int i = 0; i < dgv.ColumnCount; i++)
                    {
                        string cellValue = "";
                        if (row.Cells[i] != null)
                        {
                            if (row.Cells[i].Value != null)
                            {
                                cellValue = row.Cells[i].Value.ToString();
                            }
                        }
                        temp[i] += cellValue;
                    }
                    result.Add(temp);
                }
            }

            return result;
        }

        public static void ProcessKill(string filename)
        {
            try
            {
                System.Diagnostics.ProcessStartInfo start = new System.Diagnostics.ProcessStartInfo();
                start.FileName = "taskkill";
                start.UseShellExecute = false;
                start.RedirectStandardOutput = true;
                start.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                start.CreateNoWindow = true;
                start.Arguments = "/F /IM " + filename;

                using (System.Diagnostics.Process process = System.Diagnostics.Process.Start(start))
                {
                    using (StreamReader reader = process.StandardOutput)
                    {
                        while (!reader.EndOfStream)
                        {
                            Console.WriteLine(reader.ReadLine());
                        }
                    }
                }
            }
            catch
            {

            }
        }

        public static byte[] Combine(byte[] first, byte[] second)
        {
            byte[] ret = new byte[first.Length + second.Length];
            Buffer.BlockCopy(first, 0, ret, 0, first.Length);
            Buffer.BlockCopy(second, 0, ret, first.Length, second.Length);
            return ret;
        }

        public static byte[] Combine(byte[] first, byte[] second, byte[] third)
        {
            byte[] ret = new byte[first.Length + second.Length + third.Length];
            Buffer.BlockCopy(first, 0, ret, 0, first.Length);
            Buffer.BlockCopy(second, 0, ret, first.Length, second.Length);
            Buffer.BlockCopy(third, 0, ret, first.Length + second.Length,
                             third.Length);
            return ret;
        }

        public static byte[] Combine(params byte[][] arrays)
        {
            byte[] ret = new byte[arrays.Sum(x => x.Length)];
            int offset = 0;
            foreach (byte[] data in arrays)
            {
                Buffer.BlockCopy(data, 0, ret, offset, data.Length);
                offset += data.Length;
            }
            return ret;
        }

        public static DateTime ConvertFromUnixTimestamp(double timestamp)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return origin.AddSeconds(timestamp);
        }

        public static DateTime ConvertFromTimestamp(double timestamp)
        {
            DateTime origin = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            return origin.AddSeconds(timestamp * 86400 - 86400 * 2);
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        struct SHFILEOPSTRUCT
        {
            public IntPtr hwnd;
            [MarshalAs(UnmanagedType.U4)]
            public int wFunc;
            public string pFrom;
            public string pTo;
            public short fFlags;
            [MarshalAs(UnmanagedType.Bool)]
            public bool fAnyOperationsAborted;
            public IntPtr hNameMappings;
            public string lpszProgressTitle;
        }
        private const int FO_DELETE = 0x0003;
        private const int FOF_ALLOWUNDO = 0x0040;           // Preserve undo information, if possible. 
        private const int FOF_NOCONFIRMATION = 0x0010;      // Show no confirmation dialog box to the user      


        [DllImport("shell32.dll", CharSet = CharSet.Auto)]
        static extern int SHFileOperation(ref SHFILEOPSTRUCT FileOp);

        static bool DeleteFileOrFolder(string path)
        {


            SHFILEOPSTRUCT fileop = new SHFILEOPSTRUCT();
            fileop.wFunc = FO_DELETE;
            fileop.pFrom = path + '\0' + '\0';
            fileop.fFlags = FOF_ALLOWUNDO | FOF_NOCONFIRMATION;


            var rc = SHFileOperation(ref fileop);
            return rc == 0;
        }

        public static bool ToRecycleBin(this DirectoryInfo dir)
        {
            dir?.Refresh();
            if (dir == null || !dir.Exists)
            {
                return false;
            }
            else
            {
                return DeleteFileOrFolder(dir.FullName);
            }
        }
        public static bool ToRecycleBin(this FileInfo file)
        {
            file?.Refresh();

            if (file == null || !file.Exists)
            {
                return false;
            }
            return DeleteFileOrFolder(file.FullName);
        }
    }
}
