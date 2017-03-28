using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dock_BD_Tester
{
    public class Param
    {
        //INI配置文件
        public static string iniFilePath = Application.StartupPath + @"\DockBDTester.ini";
        //system文件夹
        public static string sysFolder = Application.StartupPath + @"\DockBD";
        //系统log，存放全部log
        public static string syslogFolder = Param.sysFolder + @"\SystemLog";
        //backup文件，for query testlog 使用
        public static string backupPath =   Param.sysFolder +  @"\BACKUP";
        //存放当日testlog的文件夹
        public static string testlogPath = Param.sysFolder +@"\Testlog\" + DateTime.Now.ToString("yyyyMMdd");
        //存放命令列表的文件夹
        public static string commlogPath = Param.sysFolder + @"\Commlog";
        //串口号
        public static string portName = string.Empty;
        //条码头的限制，空或者null，不检测条码头
        public static string snHead = "SC50F54313";
        //条码的长度,0 or 空，不检测条码
        public static int snLength = 23;


        /// <summary>
        /// log的类型
        /// </summary>
        public enum LogType:int 
        {
            SysLog,
            TestLog,
            CommLog,
            BackuoLog            
        }

    }
}
