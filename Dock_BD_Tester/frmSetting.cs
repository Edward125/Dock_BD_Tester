using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Edward;
using CCWin;
using CCWin.SkinControl;

namespace Dock_BD_Tester
{
    public partial class frmSetting : Skin_Mac 
    {
        public frmSetting()
        {
            InitializeComponent();
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {
            this.Text = "Dock BD Tester--Setting,Compay:昆山凯耀电子科技有限公司";

            init();
        }

        #region SNLength

        private void txtSnLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            SubFunction.onlyInputNumber(sender, e);
        }

        #endregion

        #region loadFolder&SN
        
        /// <summary>
        /// 加载条码设置的值和文件夹设置的值
        /// </summary>
      
        private void loadFolder_SN()
        {
            txtSnHead.Text = Param.snHead;
            txtSnLength.Text = Param.snLength.ToString();
           // txtSysFolder.Text = Param.sysFolder;
            txtSysLogFolder.Text = Param.syslogFolder;
            txtCommLogFolder.Text = Param.commlogPath;
            txtTestLogFolder.Text = Param.testlogPath;
            txtBackupFolder.Text = Param.backupPath;
        }

        #endregion

        #region init

        /// <summary>
        /// 初始化
        /// </summary>
        private void init()
        {
            //
            loadFolder_SN();
            //

        }
        #endregion

        #region 设置水印

        /// <summary>
        /// 给文本框设置水印
        /// </summary>
        private void setWaterText()
        {
           // txtSysFolder.SetWatermark("双击此处选择系统文件夹路径");
            txtSysLogFolder.SetWatermark("双击此处选择系统Log存放路径");
            txtCommLogFolder.SetWatermark("双击此处选择命令Log存放路径");
            txtTestLogFolder.SetWatermark("双击此处选择测试Log存放路径");
            txtBackupFolder.SetWatermark("双击此处选择备份Log存放路径");
            
            //
            txtSnHead.SetWatermark("设置条码头");
            
        }
        
        #endregion

        #region SNHead

        private void txtSnHead_TextChanged(object sender, EventArgs e)
        {
            Param.snHead = txtSnHead.Text.Trim().ToUpper();
            txtSnHead.SelectionStart = txtSnHead.Text.Length;
        }

        private void txtSnLength_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty (txtSnLength.Text.Trim()))
                Param.snLength =0 ;
            else 
                Param.snLength = Convert.ToInt16 (txtSnLength.Text.Trim ());

            IniFile.IniWriteValue("SysConfig", "SnLength", Param.snLength.ToString(), Param.iniFilePath);
        }

        #endregion
        
        #region SaveIniValue

        private void saveINIValue()
        {
            //
            Param.snHead = txtSnHead.Text.Trim().ToUpper();
            IniFile.IniWriteValue("SysConfig", "SnHead", Param.snHead, Param.iniFilePath);
            //
            if (string.IsNullOrEmpty(txtSnLength.Text.Trim()))
                Param.snLength = 0;
            else
                Param.snLength = Convert.ToInt16(txtSnLength.Text.Trim());
            IniFile.IniWriteValue("SysConfig", "SnLength", Param.snLength.ToString(), Param.iniFilePath);
            //
            
        }

        #endregion

        #region FormClosing       
   
        private void frmSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = true;
            if (!checkTextboxValue(txtSysLogFolder))
            {
                e.Cancel = true;
                return;
            }
            if (!checkTextboxValue(txtCommLogFolder))
            {
                e.Cancel = true;
                return;
            }
            if (!checkTextboxValue(txtTestLogFolder))
            {
                e.Cancel = true;
                return;
            }
            if (!checkTextboxValue(txtBackupFolder))
            {
                e.Cancel = true;
                return;
            }

            saveINIValue();
        }

        #endregion

        #region checkTextboxvalue

        /// <summary>
        /// 检查textbox的值是否为空，空则为false，不为空则为true
        /// </summary>
        /// <param name="textbox">需要检查的textbox</param>
        /// <returns></returns>
        private bool checkTextboxValue(TextBox textbox)
        {
            if (string.IsNullOrEmpty(textbox.Text.Trim()))
            {
                MessageBox.Show("检测到有空值，请重新输入", "Check Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


        #endregion

        #region 文件夹设置      

        private void txtSysLogFolder_DoubleClick(object sender, EventArgs e)
        {
            SubFunction.openFolder(txtSysLogFolder);
            Param.syslogFolder = txtSysLogFolder.Text.Trim();
            IniFile.IniWriteValue("SysConfig", "SysLogFolder", Param.syslogFolder, Param.iniFilePath);

        }

        private void txtSysLogFolder_TextChanged(object sender, EventArgs e)
        {
            Param.syslogFolder = txtSysLogFolder.Text.Trim();
            IniFile.IniWriteValue("SysConfig", "SysLogFolder", Param.syslogFolder, Param.iniFilePath);
        }

        private void txtCommLogFolder_DoubleClick(object sender, EventArgs e)
        {
            SubFunction.openFolder(txtCommLogFolder);
            Param.commlogPath = txtCommLogFolder.Text.Trim();
            IniFile.IniWriteValue("SysConfig", "CommLogFolder", Param.commlogPath, Param.iniFilePath);
        }

        private void txtCommLogFolder_TextChanged(object sender, EventArgs e)
        {
            Param.commlogPath = txtCommLogFolder.Text.Trim();
            IniFile.IniWriteValue("SysConfig", "CommLogFolder", Param.commlogPath, Param.iniFilePath);
        }

        private void txtTestLogFolder_DoubleClick(object sender, EventArgs e)
        {
            SubFunction.openFolder(txtTestLogFolder);
            Param.testlogPath = txtTestLogFolder.Text.Trim();
            IniFile.IniWriteValue("SysConfig", "TestLogFolder", Param.testlogPath, Param.iniFilePath);
        }

        private void txtTestLogFolder_TextChanged(object sender, EventArgs e)
        {
            Param.testlogPath = txtTestLogFolder.Text.Trim();
            IniFile.IniWriteValue("SysConfig", "TestLogFolder", Param.testlogPath, Param.iniFilePath);
        }

        private void txtBackupFolder_DoubleClick(object sender, EventArgs e)
        {
            SubFunction.openFolder(txtBackupFolder);
            Param.backupPath = txtBackupFolder.Text.Trim();
            IniFile.IniWriteValue("SysConfig", "BackupFolder", Param.backupPath, Param.iniFilePath);
        }

        private void txtBackupFolder_TextChanged(object sender, EventArgs e)
        {
            Param.backupPath = txtBackupFolder.Text.Trim();
            IniFile.IniWriteValue("SysConfig", "BackupFolder", Param.backupPath, Param.iniFilePath);
        }

        #endregion


    }
}
