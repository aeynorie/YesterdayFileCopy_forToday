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
            string TargetFileName;
            string TomorrowFileName;
            string AfterFileName;

            TargetFileName =  YesterdayFileName(DateTime.Now);
            TomorrowFileName = @"C:\Data\TestFileReps\" + AfterCopyName(DateTime.Now);
            AfterFileName = @"C:\Data\TestFileReps\" + TargetFileName;
            
            FileCopy_ChangeFileName(TomorrowFileName, AfterFileName);
        }

        //コピー対象の今日の日付のファイルの名前を取得する
        static string YesterdayFileName(DateTime dt)
        {
            string targetFile;

            targetFile = dt.ToString("yyyyMMdd");
            StringBuilder sb = new StringBuilder(targetFile);
            sb.Append(".txt");
            targetFile = sb.ToString();

            return targetFile;
        }


        //明日の日にちのファイル名を取得する
        static string AfterCopyName(DateTime yesterday)
        {
            string todayFileName;
            DateTime temp = yesterday.AddDays(1);

            todayFileName = temp.ToString("yyyyMMdd");
            StringBuilder sb = new StringBuilder(todayFileName);
            sb.Append(".txt");
            todayFileName = sb.ToString();

            return todayFileName;
            return todayFileName;
        }

        //リネームしてコピーを実施する
        static void FileCopy_ChangeFileName(string todayFile, string yesterdayFile)
        {
            FileInfo newFile = new FileInfo(yesterdayFile);
            newFile.CopyTo(todayFile);
        }
    }
}
