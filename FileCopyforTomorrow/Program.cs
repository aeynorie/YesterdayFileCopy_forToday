using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCopyforTomorrow
{
    class Program
    {
        static void Main(string[] args)
        {
            string TargetFile;
            string TomorrowFileName;
            string TargetFileName;

            TargetFile =  YesterdayFileName(DateTime.Now);
            TomorrowFileName = AfterCopyName(DateTime.Now);

            TargetFileName = @"C:\Data\TestFileReps\" + TargetFile;
            
            FileCopy_ChangeFileName(TomorrowFileName, TargetFileName);
        }

        static string YesterdayFileName(DateTime dt)
        {
            string targetFile;

            targetFile = dt.ToString("yyyyMMdd");
            StringBuilder sb = new StringBuilder(targetFile);
            sb.Append(".txt");
            targetFile = sb.ToString();

            return targetFile;
        }



        static string AfterCopyName(DateTime yesterday)
        {
            string todayFileName;
            DateTime temp = yesterday.AddDays(1);

            todayFileName = temp.ToString("yyyyMMdd");
            StringBuilder sb = new StringBuilder(todayFileName);
            sb.Append(".txt");
            todayFileName = sb.ToString();

            return todayFileName;
        }

        static void FileCopy_ChangeFileName(string todayFile, string yesterdayFile)
        {
            string todayFileName;
            string Path = @"C:\Data\TestFileReps\";
            todayFileName = Path + todayFile;
            FileInfo f = new FileInfo(yesterdayFile);
            f.CopyTo(todayFileName);
        }




    }
}
