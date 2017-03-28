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
using System.IO;

namespace Dock_BD_Tester
{
    public partial class frmQuery : Skin_Mac
    {
        public frmQuery()
        {
            InitializeComponent();
        }

        //=================
        //1,最初height=147
        //2,pass,heigt=212
        //3,fail,heigt=569
        //=================
 
        private void frmQuery_Load(object sender, EventArgs e)
        {
            this.Text = "Dock BD Tester--Query Testlog,Company:昆山凯耀电子科技有限公司";
            //
            init();
        }

        #region init
        private void init()
        {
            //
            this.Height = 147;
            txtSN.Text = string.Empty;
            txtInfo.Text = string.Empty;
           // txtTestTime.Text  = string.Empty;
            lblResult.Text = string.Empty;
            txtErrMsg.Text = string.Empty;
            txtSN.SelectAll();
            txtSN.Focus();
        }
        #endregion

        #region 查询结果

        private void btnQuery_Click(object sender, EventArgs e)
        {
            QueryResult(txtSN.Text.Trim());
        }

        /// <summary>
        /// 查询条码结果
        /// </summary>
        /// <param name="sn">需要查询的条码</param>
        private void QueryResult(string sn)
        {
            //
            txtSN.SelectAll();
            txtSN.Focus();
            this.Height = 147;
            //是否为空
            if (string.IsNullOrEmpty(sn))
            {
                txtInfo.ForeColor = Color.Red;
                txtInfo.Text = "条码为空，请重新输入.";
                return;
            }

            //不为空
            if (SubFunction.checkBarcodeLength(sn, Param.snLength, txtInfo) && SubFunction.checkBarcodeStart(sn, Param.snHead, txtInfo))
            {
                //条码检测通过
                DirectoryInfo di = new DirectoryInfo(Param.backupPath);
                foreach (FileInfo fi in di.GetFiles())
                {
                    //MessageBox.Show(di.Name);
                    if (fi.Name == sn + ".log")
                    {
                        if (getResult(fi.FullName) == "PASS")
                        {
                            //this.Height = 212;
                            this.Height = 569;
                            lblResult.BackColor = Color.Lime;
                            lblResult.Text = "PASS";
                            txtErrMsg.Text = File.ReadAllText(fi.FullName);
                            //displayTestlog(fi.FullName);
                            return;
                        }
                        if (getResult(fi.FullName) == "FAIL")
                        {
                            this.Height = 569;
                            lblResult.BackColor = Color.Red;
                            lblResult.Text = "FAIL";
                            txtErrMsg.Text = File.ReadAllText(fi.FullName);
                            //displayTestlog(fi.FullName);
                            return;
                        }

                       // MessageBox.Show("OK");
                        
                    }
                }
                txtInfo.ForeColor = Color.Red;
                txtInfo.Text = "Can't find the testlog.";
            }
        }

        /// <summary>
        /// 从testlog中读取测试结果,返回PASS or FAIL
        /// </summary>
        /// <param name="filepath">文件路径</param>
        /// <returns>PASS or FAIL返回</returns>
        private string getResult(string filepath)
        {
            //string st = File.ReadAllText(filepath);

            //if (st.Contains("Result:FAIL"))
            //    return "FAIL";
            //else if (st.Contains("Result:PASS"))
            //    return "PASS";
            //else
            //    return string.Empty;       


            string[] txt = File.ReadAllLines(filepath);

            if (txt[txt.Length - 1].Contains("Result:FAIL"))
                return "FAIL";
            else if (txt[txt.Length - 1].Contains("Result:PASS"))
                return "PASS";
            else
                return string.Empty;


        }


        private void  displayTestlog(string filepath)
        {
            string[] txt = File.ReadAllLines(filepath);
            foreach (string st in txt)
            {
                richTxtMsg.AppendText(st + "\r\n");
                if (st.Contains("PASS") && st.Contains("成功"))
                {
                    richTxtMsg.SelectionColor = Color.Green;
                    
                }
                else if (st.Contains("FAIL") && st.Contains("失败"))
                {
                    richTxtMsg.SelectionColor = Color.Red;
                }
                else
                    richTxtMsg.SelectionColor = Color.Blue;
                
            }
        }
        
        #endregion

        private void txtSN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == Other.Chr(13))
            {
                QueryResult(txtSN.Text.Trim());
            }
        }

    }
   
}
