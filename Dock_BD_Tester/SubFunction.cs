using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCWin.SkinControl;
using Edward;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.IO.Ports;

namespace Dock_BD_Tester
{
    public  class SubFunction
    {

        #region checkFolder

        /// <summary>
        /// check folder,if not exits,create;OK=true,NG=false
        /// </summary>
        /// <returns>OK=true,NG=false</returns>
        private bool checkFolder()
        {
            if (!Directory.Exists(Param.backupPath ))
            {
                try
                {
                    Directory.CreateDirectory (Param.backupPath  );
                }
                catch (Exception e)
                {
                    MessageBox.Show("Create BackupPath fail,message:" + e.Message);
                    return false;
                }
            }

            if (!Directory.Exists(Param.testlogPath))
            {
                try
                {
                    Directory.CreateDirectory(Param.testlogPath);
                }
                catch (Exception e)
                {

                    MessageBox.Show("Create TestlogPath fail,message:" + e.Message);
                    return false;
                }
            }

            if (!Directory.Exists(Param.commlogPath))
            {
                try
                {
                    Directory.CreateDirectory(Param.commlogPath);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Create CommandLogPath fail,message:" + e.Message);
                    return false;
                }
            }

            return true;
        }

        #endregion

        #region savelog    
        
        /// <summary>
        /// save log by log type
        /// </summary>
        /// <param name="logtype">log type</param>
        /// <param name="logContent">log content</param>
        /// <param name="logname">log name</param>
        public static void SaveLog(Param.LogType logtype, string logContent,string logname)
        {

            //1,check folder exits
            //2,check file exits
            //3,write log content
            string logFile = string.Empty;
            string logContents = DateTime.Now.ToString("yyyyMMddHHmmss") + "     " + @logContent + "\r\n";

            switch (logtype)
            {
                case Param.LogType.SysLog:
                    logFile = Param.syslogFolder  + @"\SysLog_" + logname  + @".log";
                    //check folder
                    if (!Directory.Exists(@Param.syslogFolder))
                    {
                        Directory.CreateDirectory(@Param.syslogFolder);
                    }
                    //check file
                    if (!File.Exists(logFile))
                    {
                        FileStream fs = File.Create(logFile);
                        fs.Close();
                    }
                    //write log
                    try
                    {
                        File.AppendAllText(logFile, logContents);
                    }
                    catch (Exception)
                    {

                        // throw;
                    }
                    break;
                case Param.LogType.TestLog:
                    logFile = Param.testlogPath + @"\" + logname + @".log";
                    //check folder
                    if (!Directory.Exists(@Param.testlogPath))
                    {
                        Directory.CreateDirectory(@Param.testlogPath);
                    }
                    //check file
                    if (!File.Exists(logFile))
                    {
                        FileStream fs = File.Create(logFile);
                        fs.Close();
                    }
                    //write log
                    try
                    {
                        File.AppendAllText(logFile, logContents);
                    }
                    catch (Exception)
                    {

                        // throw;
                    }
                    break;
                case Param.LogType.CommLog:
                    logFile = Param.commlogPath +  @"\SysLog_" + logname  + @".log";
                    //check folder
                    if (!Directory.Exists(@Param.commlogPath ))
                    {
                        Directory.CreateDirectory(@Param.commlogPath);
                    }
                    //check file
                    if (!File.Exists(logFile))
                    {
                        FileStream fs = File.Create(logFile);
                        fs.Close();
                    }
                    //write log
                    try
                    {
                        File.AppendAllText(logFile, logContents);
                    }
                    catch (Exception)
                    {

                        // throw;
                    }
                    break;
                case Param.LogType.BackuoLog:
                    logFile = Param.backupPath  + @"\" + logname + @".log";
                    //check folder
                    if (!Directory.Exists(@Param.backupPath ))
                    {
                        Directory.CreateDirectory(@Param.backupPath );
                    }
                    //check file
                    if (!File.Exists(logFile))
                    {
                        FileStream fs = File.Create(logFile);
                        fs.Close();
                    }
                    //write log
                    try
                    {
                        File.AppendAllText(logFile, logContents);
                    }
                    catch (Exception)
                    {

                        // throw;
                    }
                    break;
                default:
                    break;
            }
        }

        #endregion

        #region updatemessage

        /// <summary>
        /// update message to list box
        /// </summary>
        /// <param name="listbox">list box name</param>
        /// <param name="message">message</param>
        public static void updateMessage(ListBox listbox, string message)
        {
            if (listbox.Items.Count > 100)
                listbox.Items.Clear();
            string item = DateTime.Now.ToString("HH:mm:ss") + " " + @message;
            listbox.Items.Add(item);
            if (listbox.Items.Count > 1)
            {
                listbox.TopIndex = listbox.Items.Count - 1;
                listbox.SetSelected(listbox.Items.Count - 1, true);
            }
        }

        /// <summary>
        /// update message to list box
        /// </summary>
        /// <param name="listbox">list box name</param>
        /// <param name="message">message</param>
        public static void updateMessage(SkinListBox  listbox, string message)
        {
            if (listbox.Items.Count > 100)
                listbox.Items.Clear();
            SkinListBoxItem item = new SkinListBoxItem();
            item.Text =  DateTime.Now.ToString("HH:mm:ss") + " " + @message;
            listbox.Items.Add(item);
            if (listbox.Items.Count > 1)
            {
                listbox.TopIndex = listbox.Items.Count - 1;
                listbox.SetSelected(listbox.Items.Count - 1, true);
            }
        }

        #endregion

        #region OnlyNumbers 
        /// <summary>
        /// 只能輸入數字和退格
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">KeyPressEventArgs</param>
        public static void onlyInputNumber(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
                e.Handled = true;
        }
        #endregion

        #region CreateINI

        /// <summary>
        /// 创建INI配置文档
        /// </summary>
        /// <param name="inifilepath"></param>
        public static  void createIni(string inifilepath)
        {
            if (!File.Exists(inifilepath))
            {
                try
                {
                    FileStream fs = File.Create(inifilepath);
                    fs.Close();

                    IniFile.IniWriteValue("SysConfig", "SnHead", Param.snHead, inifilepath);
                    IniFile.IniWriteValue("SysConfig", "SnLength", Param.snLength.ToString(), inifilepath);
                    IniFile.IniWriteValue("SysConfig", "SysLogFolder", Param.syslogFolder, inifilepath);
                    IniFile.IniWriteValue("SysConfig", "CommLogFolder", Param.commlogPath, inifilepath);
                    IniFile.IniWriteValue("SysConfig", "TestLogFolder", Param.testlogPath, inifilepath);
                    IniFile.IniWriteValue("SysConfig", "BackupFolder", Param.backupPath, inifilepath);
                    IniFile.IniWriteValue("SysConfig", "PortName", Param.portName, inifilepath);

                }
                catch (Exception)
                {
                    
                    throw;
                }

            }


        }

        #endregion

        #region loadIniValue

        /// <summary>
        /// 读取INI配置文档中的值
        /// </summary>
        /// <param name="inifilepath"></param>
        public static  void loadINIValue(string inifilepath)
        {
            Param.snHead = IniFile.IniReadValue("SysConfig", "SnHead", inifilepath);
            Param.snLength = Convert.ToInt16(IniFile.IniReadValue("SysConfig", "SnLength", inifilepath));
            Param.syslogFolder = IniFile.IniReadValue("SysConfig", "SysLogFolder", inifilepath);
            Param.commlogPath = IniFile.IniReadValue("SysConfig", "CommLogFolder", inifilepath);
            Param.testlogPath = IniFile.IniReadValue("SysConfig", "TestLogFolder", inifilepath);
            Param.backupPath = IniFile.IniReadValue("SysConfig", "BackupFolder", inifilepath);
            Param.portName = IniFile.IniReadValue("SysConfig", "PortName", inifilepath);
        }

        #endregion

        #region openFolder

        /// <summary>
        /// 选择文件夹爱
        /// </summary>
        /// <param name="textbox">显示文件夹的textbox</param>
        public static void openFolder(TextBox textbox)
        {
            FolderBrowserDialog openfolderdiag = new FolderBrowserDialog();
            if (openfolderdiag.ShowDialog() == DialogResult.OK)
                textbox.Text = openfolderdiag.SelectedPath;

        }


        #endregion

        #region checkSN

        /// <summary>
        /// check barcode length,success = true,fail = false
        /// </summary>
        /// <param name="barcode">barcode</param>
        /// <param name="length">barcode length</param>
        /// <param name="lstbox">diplay info listbox</param>
        /// <returns>success = ture,fail = false </returns>
        public static  bool checkBarcodeLength(string barcode, int length,SkinListBox lstbox)
        {
            if (string.IsNullOrEmpty(barcode.Trim()))
            {
                SubFunction.updateMessage(lstbox , "Check Barcode Length Error,barcode is empty or null.");
                SubFunction.SaveLog(Param.LogType.SysLog, "Check Barcode Length Error,barcode is empty or null.", DateTime.Now.ToString("yyyyMMdd"));
                return false;
            }

            if (length == 0)
            {
                SubFunction.updateMessage(lstbox , "Check Barcode Length SKIP,Length is 0.");
                SubFunction.SaveLog(Param.LogType.SysLog, "Check Barcode Length SKIP,Length is 0.", DateTime.Now.ToString("yyyyMMdd"));
                return true;
            }
            else
            {
                if (barcode.Trim().Length == length)
                {
                    SubFunction.updateMessage(lstbox , "Check Barcode Length Success,Length is " + length);
                    SubFunction.SaveLog(Param.LogType.SysLog, "Check Barcode Length Success,Length is " + length, DateTime.Now.ToString("yyyyMMdd"));
                    return true;
                }
                else
                {
                    SubFunction.updateMessage(lstbox , "Check Barcode Length Fail,Length is " + length + ",Actual length is " + barcode.Length);
                    SubFunction.SaveLog(Param.LogType.SysLog, "Check Barcode Length Fail,Length is " + length + ",Actual length is " + barcode.Length, DateTime.Now.ToString("yyyyMMdd"));
                    return false;
                }
            }
        }

        /// <summary>
        /// check barcode length,success = true,fail = false
        /// </summary>
        /// <param name="barcode">barcode</param>
        /// <param name="length">barcode length</param>
        /// <param name="textbox">display info textbox</param>
        /// <returns>success = ture,fail = false </returns>
        public static bool checkBarcodeLength(string barcode, int length, TextBox textbox)
        {
            if (string.IsNullOrEmpty(barcode.Trim()))
            {
                textbox.ForeColor = Color.Red;
                textbox.Text = "Check Barcode Length Error,barcode is empty or null.";
                return false;
            }

            if (length == 0)
            {
                textbox.ForeColor = Color.Blue;
                textbox.Text = "Check Barcode Length SKIP,Length is 0.";
                return true;
            }
            else
            {
                if (barcode.Trim().Length == length)
                {
                    textbox.ForeColor = Color.Blue;
                    textbox.Text = "Check Barcode Length Success,Length is " + length;
                    return true;
                }
                else
                {
                    textbox.ForeColor = Color.Red;
                    textbox.Text = "Check Barcode Length Fail,Length is " + length + ",Actual length is " + barcode.Length;
                    return false;
                }
            }
        }

        /// <summary>
        /// check barcode length,success = true,fail = false
        /// </summary>
        /// <param name="barcode">barcode</param>
        /// <param name="length">barcode length</param>
        /// <returns>success = ture,fail = false </returns>
        public static bool checkBarcodeLength(string barcode, int length)
        {
            if (string.IsNullOrEmpty(barcode.Trim()))
            {
                SubFunction.SaveLog(Param.LogType.SysLog, "Check Barcode Length Error,barcode is empty or null.", DateTime.Now.ToString("yyyyMMdd"));
                return false;
            }

            if (length == 0)
            {
                SubFunction.SaveLog(Param.LogType.SysLog, "Check Barcode Length SKIP,Length is 0.", DateTime.Now.ToString("yyyyMMdd"));
                return true;
            }
            else
            {
                if (barcode.Trim().Length == length)
                {
                    SubFunction.SaveLog(Param.LogType.SysLog, "Check Barcode Length Success,Length is " + length, DateTime.Now.ToString("yyyyMMdd"));
                    return true;
                }
                else
                {
                    SubFunction.SaveLog(Param.LogType.SysLog, "Check Barcode Length Fail,Length is " + length + ",Actual length is " + barcode.Length, DateTime.Now.ToString("yyyyMMdd"));
                    return false;
                }
            }
        }

        /// <summary>
        /// check barocde start with string,success = true, fail = false
        /// </summary>
        /// <param name="barcode">barcode</param>
        /// <param name="snhead">start with string</param>
        /// <param name="lstbox">diplay info listbox</param>
        /// <returns>success = true,fail = false</returns>
        public static  bool checkBarcodeStart(string barcode, string snhead,SkinListBox lstbox)
        {
            if (string.IsNullOrEmpty(barcode.Trim()))
            {
                SubFunction.updateMessage(lstbox , "Check Barcode Start Whit Error,barcode is empty or null.");
                SubFunction.SaveLog(Param.LogType.SysLog, "Check Barcode Start Whit Error,barcode is empty or null.", DateTime.Now.ToString("yyyyMMdd"));

                return false;
            }

            if (string.IsNullOrEmpty(snhead.Trim()))
            {
                SubFunction.updateMessage(lstbox , "Check Barcode Start Whit SKIP,start with is empty or null.");
                SubFunction.SaveLog(Param.LogType.SysLog, "Check Barcode Start Whit SKIP,start with is empty or null.", DateTime.Now.ToString("yyyyMMdd"));

                return true;
            }
            else
            {

                if (barcode.ToUpper().StartsWith(snhead.ToUpper()))
                {
                    SubFunction.updateMessage(lstbox , "Check Barcode Start Whit Success,start with is " + snhead);
                    SubFunction.SaveLog(Param.LogType.SysLog, "Check Barcode Start Whit Success,start with is " + snhead, DateTime.Now.ToString("yyyyMMdd"));

                    return true;
                }
                else
                {
                    SubFunction.updateMessage(lstbox , "Check Barcode Start Whit Fail,start with is " + snhead);
                    SubFunction.SaveLog(Param.LogType.SysLog, "Check Barcode Start Whit Fail,start with is " + snhead, DateTime.Now.ToString("yyyyMMdd"));

                    return false;
                }
            }
        }

        /// <summary>
        /// check barocde start with string,success = true, fail = false
        /// </summary>
        /// <param name="barcode">barcode</param>
        /// <param name="snhead">start with string</param>
        /// <param name="textbox">display info textbox</param>
        /// <returns>success = true,fail = false</returns>
        public static bool checkBarcodeStart(string barcode, string snhead, TextBox textbox)
        {
            if (string.IsNullOrEmpty(barcode.Trim()))
            {
                textbox.ForeColor = Color.Red;
                textbox.Text = "Check Barcode Start Whit Error,barcode is empty or null."; 
                return false;
            }

            if (string.IsNullOrEmpty(snhead.Trim()))
            {
                textbox.ForeColor = Color.Blue;
                textbox .Text = "Check Barcode Start Whit SKIP,start with is empty or null.";   
                return true;
            }
            else
            {

                if (barcode.ToUpper().StartsWith(snhead.ToUpper()))
                {
                    textbox.ForeColor = Color.Blue;
                    textbox.Text = "Check Barcode Start Whit Success,start with is " + snhead;
                    return true;
                }
                else
                {
                    textbox.ForeColor = Color.Red;
                    textbox.Text = "Check Barcode Start Whit Fail,start with is " + snhead;
                    return false;
                }
            }
        }

        /// <summary>
        /// check barocde start with string,success = true, fail = false
        /// </summary>
        /// <param name="barcode">barcode</param>
        /// <param name="snhead">start with string</param>
        /// <returns>success = true,fail = false</returns>
        public static bool checkBarcodeStart(string barcode, string snhead)
        {
            if (string.IsNullOrEmpty(barcode.Trim()))
            {
                SubFunction.SaveLog(Param.LogType.SysLog, "Check Barcode Start Whit Error,barcode is empty or null.", DateTime.Now.ToString("yyyyMMdd"));
                return false;
            }

            if (string.IsNullOrEmpty(snhead.Trim()))
            {
                SubFunction.SaveLog(Param.LogType.SysLog, "Check Barcode Start Whit SKIP,start with is empty or null.", DateTime.Now.ToString("yyyyMMdd"));
                return true;
            }
            else
            {

                if (barcode.ToUpper().StartsWith(snhead.ToUpper()))
                {
                    SubFunction.SaveLog(Param.LogType.SysLog, "Check Barcode Start Whit Success,start with is " + snhead, DateTime.Now.ToString("yyyyMMdd"));
                    return true;
                }
                else
                {
                    SubFunction.SaveLog(Param.LogType.SysLog, "Check Barcode Start Whit Fail,start with is " + snhead, DateTime.Now.ToString("yyyyMMdd"));
                    return false;
                }
            }
        }

        #endregion

        /// <summary>
        /// update FPY
        /// </summary>
        /// <param name="txttotal">display total</param>
        /// <param name="txtfail">display fail</param>
        /// <param name="txtfpy">display fpt</param>
        /// <param name="itotal"> total </param>
        /// <param name="ifail">fail</param>
        public static void updateFPY(TextBox txttotal, TextBox txtfail, TextBox txtfpy, int itotal, int ifail)
        {
            int ipass = itotal - ifail;
            txttotal.Text = itotal.ToString();
            txtfail.Text = ifail.ToString();

            if (itotal == 0)
                txtfpy.Text = "0%";
            else
            {
                Int32 temp = Convert.ToInt32((((itotal - ifail) / itotal) * 10000));
                int dfpy = temp / 100;
                txtfpy.Text = dfpy.ToString() + "%";
            }
        }

        /// <summary>
        /// update FPY
        /// </summary>
        /// <param name="txttotal">display total</param>
        /// <param name="txtfail">display fail</param>
        /// <param name="txtpass">display pass</param>
        /// <param name="txtfpy">display fpy</param>
        /// <param name="itotal">total</param>
        /// <param name="ifail">fail </param>
        /// <param name="ipass">pass</param>
        public static void updateFPY(SkinTextBox  txttotal, SkinTextBox  txtfail,SkinTextBox txtpass, SkinTextBox  txtfpy, int itotal, int ifail,int ipass)
        {
            txtpass.Text = ipass.ToString();
            txtfail.Text = ifail.ToString();
            if ((ipass + ifail ) == 0)
                txtfpy.Text = "0%";
            else
            {
                Int32 temp = Convert.ToInt32((( (double)ipass /(double)(ifail + ipass )) * 10000));                
                int dfpy = temp / 100;
                txtfpy.Text = dfpy.ToString() + "%";
            }
        }
    }
}
