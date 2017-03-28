using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CCWin;
using CCWin.SkinControl;
using Edward;
using System.IO.Ports;

namespace Dock_BD_Tester
{
    public partial class frmMain :Skin_Mac
    {

        #region var

        private bool pressRestart = false; //按下Restart=true

        private int iTotal = 0;
        private int iPass = 0;
        private int iFail = 0;

        private string BD_SN = string.Empty;//DOCK的条码
        private string sthex = "02 53 54 30 0D";

        #endregion

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text = "Dock BD Tester, Ver.:" + Application.ProductVersion + ", Company:昆山凯耀电子科技有限公司";
            //初始化
            if (!init())
                Environment.Exit(0);

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            Form f = new frmQuery();
            f.Show();      
           
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Form f = new frmSetting();
            f.ShowDialog();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            pressRestart = true;
            Application.Restart();
        }

        #region 初始化

        /// <summary>
        /// 初始化，如果无错误，则true，出错则false
        /// </summary>
        /// <returns>无错=true，有错= false </returns>
        private  bool  init()
        {
            //初始化界面
            initFormUI();
            //初始化配置文档
            SubFunction.createIni(Param.iniFilePath);
            //读取配置文档的值
            SubFunction.loadINIValue(Param.iniFilePath);
            //MessageBox.Show(Param.portName);
            //
            btnStop.Enabled = false;
            //
            //加载串口
            getSerialPort(comboPLC);


            return true;
        }

        #endregion

        #region 初始化界面
        /// <summary>
        /// 初始化界面
        /// </summary>
        private void initFormUI()
        {
            //
          // lstBarcode.Items.Clear();
            lstCommand.Items.Clear();
            lstBarcode.Items.Clear();
            lstStatus.Items.Clear(); 
            txtBarcode.Text = string.Empty;
            txtBarcode.ReadOnly = true;
            txtFail.Text = string.Empty;
            txtTotal.Text = string.Empty;
            txtPass.Text = string.Empty;
            txtFPY.Text = string.Empty;
            //
           // comboPLC.Text = Param.portName;
        }
        #endregion

        #region CloseFrom

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (!pressRestart)
            {

                if (MessageBox.Show("Are you sure to exit the program ?", "Exit the program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                // Environment.Exit(0);
                { 
                }
                else
                    e.Cancel = true;
            }
        }
        
        #endregion

        #region serial port

        /// <summary>
        /// 獲取串口 
        /// </summary>
        /// <param name="combox"></param>
        private void getSerialPort(ComboBox combox)
        {
            combox.Items.Clear();
            combox.Text = string.Empty;
            foreach (string sp in System.IO.Ports.SerialPort.GetPortNames())
            {
                combox.Items.Add(sp);
            }

            if (combox.Items.Count > 0)
            {
                if (string.IsNullOrEmpty(Param.portName))
                    combox.SelectedIndex = 0;
                else
                    combox.Text = Param.portName;
            }
        }

        /// <summary>
        /// open serial port
        /// </summary>
        /// <param name="sp">serial port</param>
        /// <param name="portname">comport name</param>
        /// <returns>OK=true,NG=false</returns>
        private bool openSerialPort(SerialPort sp, string portname)
        {
            // bool result = true;
            sp.PortName = portname;
            if (!sp.IsOpen)
            {
                try
                {
                    sp.Open();
                    SubFunction.updateMessage( lstStatus ,"Open SerialPort=" + portname + " success.");//Message:" + e.Message);
                    SubFunction.SaveLog(Param.LogType.SysLog, "Open SerialPort=" + portname + " success.",DateTime.Now.ToString ("yyyyMMdd"));//Message:" + e.Message + "\r\n");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Can't open SerialPort=" + portname + ",Message:" + e.Message);
                    SubFunction.updateMessage(lstStatus, "Can't open SerialPort=" + portname + ",Message:" + e.Message);
                    SubFunction.SaveLog(Param.LogType.SysLog, "Can't open SerialPort=" + portname + ",Message:" + e.Message,DateTime.Now.ToString ("yyyyMMdd"));
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// close serial port
        /// </summary>
        /// <param name="sp">OK=true,NG=false</param>
        /// <returns></returns>
        private bool closeSerialPort(SerialPort sp)
        {
            if (sp.IsOpen)
            {
                try
                {
                    sp.Close();
                    SubFunction.updateMessage(lstStatus, "Close SerialPort=" + sp.PortName.ToString() + " success.");
                    SubFunction.SaveLog(Param.LogType.SysLog, "Close SerialPort=" + sp.PortName.ToString() + " success.", DateTime.Now.ToString("yyyyMMdd"));
                }
                catch (Exception e)
                {
                    MessageBox.Show("Can't close SerialPort=" + sp.PortName.ToString() + ",Message:" + e.Message);
                    SubFunction.updateMessage(lstStatus, "Can't close SerialPort=" + sp.PortName.ToString() + ",Message:" + e.Message);
                    SubFunction.SaveLog(Param.LogType.SysLog, "Can't close SerialPort=" + sp.PortName.ToString() + ",Message:" + e.Message, DateTime.Now.ToString("yyyyMMdd"));
                }
            }
            return true;
        }

        /// <summary>
        /// Send string data to serial port
        /// </summary>
        /// <param name="spport">serial port</param>
        /// <param name="strdata">string data</param>
        private void sendData(SerialPort spport, string strdata)
        {
            try
            {
                spport.Write(strdata +Other.Chr (13));
                SubFunction.updateMessage(lstCommand, "PC->PLC:" + strdata);
                SubFunction.updateMessage(lstStatus, "Send " + spport.PortName + " " + strdata);
                SubFunction.SaveLog(Param.LogType.SysLog, "Send " + spport.PortName + " " + strdata, DateTime.Now.ToString("yyyyMMdd"));
                SubFunction.SaveLog(Param.LogType.CommLog, "PC->PLC:" + strdata, DateTime.Now.ToString("yyyyMMdd"));
            }
            catch (Exception e)
            {
                SubFunction.updateMessage(lstStatus, "Send " + spport.PortName + " " + strdata + "fail");
                SubFunction.updateMessage(lstStatus, e.Message);
                SubFunction.SaveLog(Param.LogType.SysLog, "Send " + spport.PortName + " " + strdata + "fail," + e.Message,DateTime.Now.ToString ("yyyyMMdd"));
            }
        }

        /// <summary>
        /// send hex data to serial port
        /// </summary>
        /// <param name="spport">serial port</param>
        /// <param name="hexstr">hex string</param>
        private void sendHex(SerialPort spport, string hexstr)
        {
            try
            {
                //string str = "7E 00 00 FF 00 00 00 00 00 00 00 00 00 00 00 00 00 FF";
                //byte[] bytes = str.Split(' ').Select(s => Convert.ToByte(s, 16)).ToArray();
                //serialport.Write(bytes, 0, bytes.Length);
                byte[] bytes = hexstr.Split(' ').Select(s => Convert.ToByte(s, 16)).ToArray();
                spport.Write(bytes, 0, bytes.Length);
                SubFunction.updateMessage(lstCommand, "PC->PLC:" + hexstr );
                SubFunction.updateMessage(lstStatus, "Send " + spport.PortName + " " + hexstr );
                SubFunction.SaveLog(Param.LogType.SysLog, "Send " + spport.PortName + " " + hexstr , DateTime.Now.ToString("yyyyMMdd"));
                SubFunction.SaveLog(Param.LogType.CommLog, "PC->PLC:" + hexstr  , DateTime.Now.ToString("yyyyMMdd"));
            }
            catch (Exception e)
            {

                SubFunction.updateMessage(lstStatus, "Send " + spport.PortName + " " + hexstr + "fail");
                SubFunction.updateMessage(lstStatus, e.Message);
                SubFunction.SaveLog(Param.LogType.SysLog, "Send " + spport.PortName + " " + hexstr + "fail," + e.Message, DateTime.Now.ToString("yyyyMMdd"));
            }
        }

        #endregion

        #region 开始测试

        private void btnStart_Click(object sender, EventArgs e)
        {
            //判断串口
            if (string.IsNullOrEmpty(Param.portName))
            {
                MessageBox.Show("Comport name cam't be empty!");
                SubFunction.updateMessage(lstStatus, "Comport name cam't be empty!");
                SubFunction.SaveLog(Param.LogType.SysLog, "Comport name cam't be empty!", DateTime.Now.ToString("yyyyMMdd"));
                comboPLC.Focus();
                return;
            }
            //打开串口成功
            if (openSerialPort( spPLC , Param.portName))
            {
                //允许输入条码
                txtBarcode.Enabled = true;
                txtBarcode.ReadOnly = false;
                //
                comboPLC.Enabled = false;
                btnFresh.Enabled = false;
                btnStart.Enabled = false;
                btnStop.Enabled = true;
                btnSetting.Enabled = false;
                btnRestart.Enabled = false;
                //
                lblResult.BackColor = Color.Yellow;
                lblResult.Text = "WAIT";
                //
                txtBarcode.SelectAll();
                txtBarcode.Focus();
                
            }


        }
        
        #endregion

        #region 串口变更       

        private void comboPLC_SelectedIndexChanged(object sender, EventArgs e)
        {
            Param.portName = comboPLC.SelectedItem.ToString();
            IniFile.IniWriteValue("SysConfig", "PortName", Param.portName, Param.iniFilePath);
        }

        #endregion

        #region 刷新串口

        private void btnFresh_Click(object sender, EventArgs e)
        {
            getSerialPort(comboPLC);
        }

        #endregion

        #region 输入条码

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            // if (e.KeyChar.ToString() == SubFunction.Chr(13))
            string sn = txtBarcode.Text.Trim().ToUpper();
            BD_SN = txtBarcode.Text.Trim().ToUpper();
            if (e.KeyChar.ToString() == Other.Chr(13))
            {

                //是否为空
                if (string.IsNullOrEmpty(txtBarcode.Text.Trim ()))
                {
                    SubFunction.updateMessage(lstStatus, "Barcode can't be empty.retry input it.");
                    SubFunction.SaveLog(Param.LogType.SysLog, "Barcode can't be empty.retry input it.", DateTime.Now.ToString("yyyyMMdd"));
                    return;
                }

                //不为空
                if (SubFunction.checkBarcodeLength(sn, Param.snLength,lstStatus ) && SubFunction.checkBarcodeStart(sn, Param.snHead,lstStatus ))
                {
                    //条码检测通过
                    SubFunction.updateMessage(lstBarcode , sn);
                    SubFunction.updateMessage(lstStatus, "SN:" + sn);
                    SubFunction.SaveLog(Param.LogType.SysLog, "SN:" + sn, DateTime.Now.ToString("yyyyMMdd"));
                    //给PLC发送消息准备开始测试
                    sendData(spPLC, "ST0");
                    SubFunction.updateMessage(lstStatus, "PC->PLC:ST0,'请求开始测试'");
                    //sendHex(spPLC, sthex);
                    //SubFunction.updateMessage(lstStatus, "PC->PLC:" + sthex + ",'请求开始测试'");
                    //
                    iTotal += 1;
                    txtTotal.Text = iTotal.ToString();
                    //禁止输入条码
                    txtBarcode.ReadOnly = true;
                    txtBarcode.Enabled = false;
                    //
                    lblResult.BackColor = Color.Yellow;
                    lblResult.Text = "WAIT";
                }
            }
        }      
  
        #endregion

        #region 停止测试      

        private void btnStop_Click(object sender, EventArgs e)
        {
            closeSerialPort(spPLC);
            //禁止输入条码
            txtBarcode.Enabled = false;
            //txtBarcode.ReadOnly = true;
            //
            comboPLC.Enabled = true;
            btnFresh.Enabled = true;
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            btnSetting.Enabled = true;
            btnRestart.Enabled = true;
        }

        #endregion

        #region 串口数据接收

        private void spPLC_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (spPLC.BytesToRead == 0)
                return;

            string sReceive = spPLC.ReadTo(Other.Chr(13));
            spPLC.DiscardInBuffer();
            sReceive = sReceive.Trim();
            this.Invoke((EventHandler)(delegate
            {
                SubFunction.updateMessage(lstCommand, "PLC->PC:" + sReceive);
                SubFunction.SaveLog(Param.LogType.SysLog, "PLC->PC:" + sReceive, DateTime.Now.ToString("yyyyMMdd"));
                SubFunction.SaveLog(Param.LogType.CommLog, "PLC->PC:" + sReceive, DateTime.Now.ToString("yyyyMMdd"));

                switch ( sReceive )
                {
                    case "Tst0":
                        SubFunction.updateMessage(lstStatus, "PLC->PC:Tst0,'确认开始测试'");
                        //
                        lblResult.BackColor = Color.Yellow;
                        lblResult.Text = "TEST";
                        break;
                    case "TPAS":
                        SubFunction.updateMessage(lstStatus, "PLC->PC:PAS,测试PASS");
                        //
                        lblResult.BackColor = Color.Lime;
                        lblResult.Text = "PASS";
                        //
                        iPass +=1;
                        SubFunction.updateFPY(txtTotal, txtFail, txtPass, txtFPY, iTotal, iFail, iPass);
                        //保存结果
                        if (!string.IsNullOrEmpty(BD_SN))
                        {
                            SubFunction.SaveLog(Param.LogType.TestLog, "SN:" + BD_SN + ",Result:PASS", BD_SN);
                            SubFunction.SaveLog(Param.LogType.BackuoLog, "SN:" + BD_SN + ",Result:PASS", BD_SN);
                        }
                        //准备下一次测试
                        BD_SN = string.Empty; //清空条码，接收下一个条码
                        txtBarcode.Enabled = true; //允许输入条码
                        txtBarcode.ReadOnly = false;
                        txtBarcode.SelectAll();
                        txtBarcode.Focus();

                        break;
                    case "TFAI":
                        SubFunction.updateMessage(lstStatus, "PLC->PC:FAI,测试FAIL");
                        //
                        lblResult.BackColor = Color.Red;
                        lblResult.Text = "FAIL";
                        //
                        iFail += 1;
                        SubFunction.updateFPY(txtTotal, txtFail, txtPass, txtFPY, iTotal, iFail, iPass);
                        //保存结果                        
                        if (!string.IsNullOrEmpty(BD_SN))
                        {
                            SubFunction.SaveLog(Param.LogType.TestLog, "SN:" + BD_SN + ",Result:FAIL", BD_SN);
                            SubFunction.SaveLog(Param.LogType.BackuoLog, "SN:" + BD_SN + ",Result:FAIL", BD_SN);
                        }
                        //准备下一次测试
                        BD_SN = string.Empty; //清空条码，接收下一个条码
                        txtBarcode.Enabled = true; //允许输入条码
                        txtBarcode.ReadOnly = false;
                        txtBarcode.SelectAll();
                        txtBarcode.Focus();
                        break;
                    default:

                        if (sReceive.StartsWith("TY"))
                        {
                            SubFunction.updateMessage(lstStatus, "PLC->PC:" + sReceive + ",第" + sReceive.Substring(1, sReceive.Length - 1) + "脚测试PASS");
                            if (!string.IsNullOrEmpty(BD_SN))
                            {
                                SubFunction.SaveLog(Param.LogType.TestLog, "PLC->PC:" + sReceive + ",第" + sReceive.Substring(1, sReceive.Length - 1) + "脚测试PASS", BD_SN);
                                SubFunction.SaveLog(Param.LogType.BackuoLog, "PLC->PC:" + sReceive + ",第" + sReceive.Substring(1, sReceive.Length - 1) + "脚测试PASS", BD_SN);
                            }
                        }

                        if (sReceive.StartsWith("TN"))
                        {
                            SubFunction.updateMessage(lstStatus, "PLC->PC:" + sReceive + ",第" + sReceive.Substring(1, sReceive.Length - 1) + "脚测试FAIL");
                            if (!string.IsNullOrEmpty(BD_SN))
                            {
                                SubFunction.SaveLog(Param.LogType.TestLog, "PLC->PC:" + sReceive + ",第" + sReceive.Substring(1, sReceive.Length - 1) + "脚测试FAIL", BD_SN);
                                SubFunction.SaveLog(Param.LogType.BackuoLog, "PLC->PC:" + sReceive + ",第" + sReceive.Substring(1, sReceive.Length - 1) + "脚测试FAIL", BD_SN);
                            }
                        }
                        break;
                }



            }
           ));
          
        }
        
        #endregion

    }
}
