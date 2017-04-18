using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Common;
using StackExchange.Redis;
using System.IO;
using System.Configuration;

namespace WinFormFTPEntFile
{
    public partial class Form_main : Form
    {
        int i = 0;//临时测试使用，可删除
        List<ftpItem> ftpItems = new List<ftpItem>();
        string direc_pdf = ConfigurationManager.AppSettings["filedir"];//文件服务器存放文件的一级目录

        //获取缓存数据库
        IDatabase db = SeRedis.redis.GetDatabase();
        public Form_main()
        {
            InitializeComponent();
        }

        private void Form_main_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            bindData();
        }


        //开启服务
        private void btn_sevice_Click(object sender, EventArgs e)
        {
            //Thread myThread = new Thread(new ThreadStart(s));
            //Thread myThread = new Thread(new ThreadStart(delegate{ThreadTask(a,b)}));传参

            //添加到list中状态Statusflag置为true,并更新列表的状态

            foreach (DataGridViewRow row in this.gr_ftpitem.Rows)
	        {
                if (row.Cells["Column_check"].EditedFormattedValue.ToString().ToUpper() == "TRUE" && row.Cells["STATUSFLAG"].Value.ToString().Trim()=="停止")
                {
                    int id = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                    row.Cells["STATUSFLAG"].Value = "运行中";
                    ftpItem ftpitem= getItem(id);
                    ftpitem.Statusflag = true;
                    ftpItems.Add(ftpitem);
                    //暂时不开线程
                    //Thread myThread = new Thread(new ParameterizedThreadStart(s));
                    //myThread.IsBackground = true;
                    //myThread.Start(ftpitem);

                    row.Cells["Column_check"].Value = false;
                }
		 
	        }

         }
        //关闭服务
        private void btn_close_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.gr_ftpitem.Rows)
            {
                if (row.Cells["Column_check"].EditedFormattedValue.ToString().ToUpper() == "TRUE" && row.Cells["STATUSFLAG"].Value.ToString().Trim() == "运行中")
                {
                    int id = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                    row.Cells["STATUSFLAG"].Value = "停止";
                    ftpItem item = ftpItems.Find(finditem =>
                    {
                        if (finditem.ID == id)
                        {
                            finditem.Statusflag = false;
                            return true;
                        }
                        return false;
                    });
                   //应该可以在此删除LIST中的对象
                    row.Cells["Column_check"].Value = false;
                }

            }
        }
        private void s(object arg)
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000;
      
           // int find_id=(int)arg;
           // ftpItem item = ftpItems.Find(finditem=>{
           //     if (finditem.ID == find_id)
           //     {
           //         return true;
           //     }
           //     return false;
           //});

            ftpItem item = (ftpItem)arg;

            FtpHelper ftp = null;
            System.Uri compal_ftp_uri = new Uri("ftp://" + item.ADDRESS + ":21");
            string compal_ftp_username = item.USERNAME;
            string compal_ftp_psd = item.PSWD;
            ftp = new FtpHelper(compal_ftp_uri, compal_ftp_username, compal_ftp_psd);

            timer.Elapsed += (sender, args) =>
            {
                System.Timers.Timer t = (System.Timers.Timer)sender;//当前的计时器
                //进入先关闭
                t.Stop();

                if (!item.Statusflag)//标志是否关闭
                {   
                    t.Stop();
                    Thread.CurrentThread.Abort();//结束当前进程
                    //从list中移除关闭的
                    ftpItems.Remove(item);
                }
                else
                {
                    //调用ftp程式
                    getFtpFile(item,ftp);
                }

                //结束再打开
                t.Start();
            };
            timer.Start();
       
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            string address=this.txt_address.Text.Trim();
            string username = this.txt_username.Text.Trim();
            string password = this.txt_password.Text.Trim();
            string reciveunitcode = this.txt_reciveunitcode.Text.Trim();
            string reciveunitname = this.txt_reciveunitname.Text.Trim();
            string declareunitcode = this.txt_declareunitcode.Text.Trim();
            string declareunitname = this.txt_declareunitname.Text.Trim();
            string enterprisecode = this.txt_enterprisecode.Text.Trim();
            string enterprisename = this.txt_enterprisename.Text.Trim();
            string templetename = this.txt_templetename.Text.Trim();

            string sql_add = @"insert into CONFIG_FTPFILE (id,address,username,pswd,reciveunitcode,reciveunitname,declareunitcode,declareunitname,enterprisecode,enterprisename,templetename)
                               values(CONFIG_FTPFILE_ID.Nextval,'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')";
            sql_add = string.Format(sql_add, address, username, password, reciveunitcode, reciveunitname, declareunitcode, declareunitname, enterprisecode, enterprisename, templetename);
            DBMgr.ExecuteNonQuery(sql_add);
            foreach (Control ctr in this.Controls)
            {
                if (ctr is TextBox)
                {
                    ctr.Text = "";
                }
            }
            bindData();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.gr_ftpitem.Rows)
            {
                string ids = string.Empty;

                if (row.Cells["Column_check"].EditedFormattedValue.ToString().ToUpper() == "TRUE")
                {
                   ids+=row.Cells["ID"].Value.ToString()+",";
                    
                }
                ids=ids.TrimEnd(',');
                if (ids!=string.Empty)
                {
                    string sql_del = "delete from config_ftpfile where id in (" + ids + ")";
                    DBMgr.ExecuteNonQuery(sql_del);
                    bindData();
                }

            }
        }

        private void bindData()
        {
            string sql_bind =@"select '停止' STATUSFLAG,ID,ADDRESS,USERNAME,PSWD,RECIVEUNITCODE,RECIVEUNITNAME,DECLAREUNITCODE,
                               DECLAREUNITNAME,ENTERPRISECODE,DECLAREUNITNAME,ENTERPRISECODE,ENTERPRISENAME,TEMPLETENAME from CONFIG_FTPFILE";
            DataTable dt_bind = DBMgr.GetDataTable(sql_bind);
            this.gr_ftpitem.DataSource = dt_bind;
            this.gr_ftpitem.Columns["STATUSFLAG"].HeaderText = "服务状态";
            this.gr_ftpitem.Columns["ID"].HeaderText = "ID";
            this.gr_ftpitem.Columns["ADDRESS"].HeaderText = "FTP地址";
            this.gr_ftpitem.Columns["USERNAME"].HeaderText = "FTP用户名";
            this.gr_ftpitem.Columns["PSWD"].HeaderText = "FTP密码";
            this.gr_ftpitem.Columns["RECIVEUNITCODE"].HeaderText = "文件接收单位代码";
            this.gr_ftpitem.Columns["RECIVEUNITNAME"].HeaderText = "文件接收单位名称";
            this.gr_ftpitem.Columns["DECLAREUNITCODE"].HeaderText = "文件申报单位代码";
            this.gr_ftpitem.Columns["DECLAREUNITNAME"].HeaderText = "文件申报单位名称";
            this.gr_ftpitem.Columns["ENTERPRISECODE"].HeaderText = "委托企业代码";
            this.gr_ftpitem.Columns["ENTERPRISENAME"].HeaderText = "委托企业名称";
            this.gr_ftpitem.Columns["TEMPLETENAME"].HeaderText = "模板名";
            
        }

        #region
        private void gr_ftpitem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // bool btnStatus = true;
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                #region
                /**
                int id = Convert.ToInt32(this.gr_ftpitem.CurrentRow.Cells["ID"].Value.ToString());
                ftpItem item = null;
                if (ftpItems.Count != 0)
                {
                    item = ftpItems.Find(ftpitem_temp =>
                    {
                        if (ftpitem_temp.ID == id)
                        {
                            ftpitem_temp.Statusflag = ftpitem_temp.Statusflag ? false : true;

                            if (ftpitem_temp.Statusflag)
                            {
                                Thread myThread = new Thread(new ParameterizedThreadStart(s));
                                myThread.IsBackground = true;
                                // myThread.Start(ftpitem_temp.ID);//启动线程,传参
                                myThread.Start(ftpitem_temp);

                            }

                            return true;
                        }

                        return false;
                    });

                }

                if (item != null)
                {
                    btnStatus = item.Statusflag;
                }
                else
                {
                    ftpItem item_temp = getItem(id);
                    item_temp.Statusflag = true;

                    Thread myThread = new Thread(new ParameterizedThreadStart(s));
                    myThread.IsBackground = true;
                    //myThread.Start(item_temp.ID);//启动线程,传参
                    myThread.Start(item_temp);

                    ftpItems.Add(item_temp);
                }

                DataGridViewButtonCell currentBtn = (DataGridViewButtonCell)this.gr_ftpitem.CurrentCell;
                if (!btnStatus)
                {
                    currentBtn.Value = "启动"; currentBtn.Tag = true;
                }
                else
                {
                    currentBtn.Value = "暂停"; currentBtn.Tag = true;

                }
                 */
                #endregion

                DataGridViewCheckBoxCell checkbox = (DataGridViewCheckBoxCell)this.gr_ftpitem.CurrentCell;
                string objValue = checkbox.EditedFormattedValue.ToString().ToUpper();
                checkbox.Value =objValue=="FALSE"?true:false;

            }
        }
        #endregion


        private ftpItem getItem(int id)
        {     
            string sql_item = "select * from config_ftpfile where id='"+id.ToString()+"'";
            DataTable dt_item = DBMgr.GetDataTable(sql_item);
            string json_item = JsonConvert.SerializeObject(dt_item).TrimStart('[').TrimEnd(']');
            ftpItem item = JsonConvert.DeserializeObject<ftpItem>(json_item);
            return item;
        }


        private void getFtpFile(ftpItem item,FtpHelper ftp)
        {
            

                try
                {
                    string destination = DateTime.Now.ToString("yyyy-MM-dd");
                    List<FileStruct> fis = ftp.GetFileAndDirectoryList(@"\");
                    foreach (FileStruct fs in fis)
                    {
                        int seconds = Convert.ToInt32((DateTime.Now - fs.UpdateTime.Value).TotalSeconds);
                        #region 处理文件开始
                        if (!fs.IsDirectory && fs.Size > 0 && seconds > 10)//有时候文件还在生成中，故加上时间范围限制
                        {
                            //提取合同协议号 如果无_，则直接将文件主名称作为合同协议号,如果有,则截取
                            int start = fs.Name.IndexOf("_");
                            string contractno = string.Empty;
                            if (start >= 0)
                            {
                                contractno = fs.Name.Substring(0, start);
                            }
                            else
                            {
                                start = fs.Name.IndexOf("-");//有些文件比较特殊是中杠
                                if (start >= 0)
                                {
                                    contractno = fs.Name.Substring(0, start);
                                }
                                else
                                {
                                    start = fs.Name.IndexOf(".");
                                    contractno = fs.Name.Substring(0, start);
                                }
                            }
                            bool content = update_entorder(fs, destination, contractno,item);
                            //如果数据库信息插入或者更新成功
                            if (content)
                            {
                                if (!Directory.Exists(direc_pdf + destination))
                                {
                                    Directory.CreateDirectory(direc_pdf + destination);
                                }
                                bool result = false;
                                if (fs.Name.IndexOf(".txt") > 0 || fs.Name.IndexOf(".TXT") > 0)
                                {
                                    string[] split = fs.Name.Split(new string[] { "." }, StringSplitOptions.RemoveEmptyEntries);
                                    result = ftp.DownloadFile(@"\" + fs.Name, direc_pdf + destination + @"\" + split[0] + "_0." + split[1]);
                                    if (result) //TXT文件在下载成功的情况下
                                    {
                                        try
                                        {
                                            StreamReader sr = new StreamReader(direc_pdf + destination + @"\" + split[0] + "_0." + split[1], Encoding.GetEncoding("BIG5"));
                                            String line;
                                            FileStream fs2 = new FileStream(direc_pdf + destination + @"\" + fs.Name, FileMode.Create);
                                            while ((line = sr.ReadLine()) != null)
                                            {
                                                byte[] dst = Encoding.UTF8.GetBytes(line);
                                                fs2.Write(dst, 0, dst.Length);
                                                fs2.WriteByte(13);
                                                fs2.WriteByte(10);
                                            }
                                            fs2.Flush();  //清空缓冲区、关闭流
                                            fs2.Close();
                                        }
                                        catch (Exception ex)
                                        {
                                            
                                            break;//add by panhuaguo 20170118
                                        }
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                    result = ftp.DownloadFile(@"\" + fs.Name, direc_pdf + destination + @"\" + fs.Name);
                                }
                                if (result)//下载成功的情况下
                                {
                                    ftp.MoveFile(@"\" + fs.Name, @"\backup\" + fs.Name);
                                }
                                else
                                {
                                    break;
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                        #endregion
                    }
                }
                catch (Exception ex)
                {
                    foreach (DataGridViewRow row in this.gr_ftpitem.Rows)
                    {
                        if (row.Cells["ID"].Value.ToString()==item.ID.ToString())
                        {
                            row.Cells["STATUSFLAG"].Value = ex.Message.ToString();
                        }

                    }
                    
                }
            }


        private bool update_entorder(FileStruct fs, string directory, string contractno,ftpItem item)
        {
            bool content = false;
            string sql = string.Empty;
            #region
            try
            {
                string enterprisecode = string.Empty;
                string enterprisename = string.Empty;
                string prefix = fs.Name.Substring(0, 3);
                string entid = string.Empty;
                if (prefix == "E1P" || prefix == "E1B" || prefix == "IMP" || prefix == "IMB")
                {
                    enterprisecode = "3223640003";//海关10位编码  空运出口
                    enterprisename = "仁宝电子科技(昆山)有限公司";
                }
                if (prefix == "E1W" || prefix == "E2W" || prefix == "E1D" || prefix == "E2D" || prefix == "E7D" || prefix == "IMW" || prefix == "IMD" || prefix == "LMW" || prefix == "LMD" || prefix == "IAD" || prefix == "IEW" || prefix == "IED" || prefix == "E7W" || prefix == "LDD" || prefix == "LGW" || prefix == "LGD" || prefix == "LDW")
                {
                    enterprisecode = "3223640047";
                    enterprisename = "仁宝信息技术(昆山)有限公司";
                }
                if (prefix == "E1C" || prefix == "E1Q" || prefix == "E1O" || prefix == "IMQ" || prefix == "IMC" || prefix == "E2Q" || prefix == "E2C" || prefix == "LGC")
                {
                    enterprisecode = "3223640038";
                    enterprisename = "仁宝资讯工业(昆山)有限公司";
                }
                if (prefix == "IVS" || prefix == "EAS")
                {
                    enterprisecode = "3223660037";
                    enterprisename = "昆山柏泰电子技术服务有限公司";
                }
                //code是企业编号 仁宝格式 E1Q1603927_sheet.txt 
                int start = fs.Name.LastIndexOf("_");
                int end = fs.Name.LastIndexOf(".");
                string suffix = fs.Name.Substring(end + 1, 3).ToUpper();//文件扩展名
                string filetype = fs.Name.Substring(start + 1, end - start - 1).ToUpper();
                int filetypeid = 0;
                switch (filetype)
                {
                    case "CONTRACT":
                        filetypeid = 50;
                        break;
                    case "INVOICE":
                        filetypeid = 51;
                        break;
                    case "PACKING":
                        filetypeid = 52;
                        break;
                    case "SHEET":
                        filetypeid = 44;
                        break;
                    default:
                        filetypeid = 50;
                        break;
                }
                sql = "select * from ent_order where code='" + contractno + "'";
                DataTable dt_ent = DBMgr.GetDataTable(sql);
                if (dt_ent.Rows.Count == 0)
                {
                    sql = "select ENT_ORDER_ID.Nextval from dual";
                    entid = DBMgr.GetDataTable(sql).Rows[0][0] + "";
                    sql = @"insert into ent_order(ID,CODE,CREATETIME,SUBMITTIME,UNITCODE,ENTERPRISECODE,ENTERPRISENAME,FILEDECLAREUNITCODE,FILEDECLAREUNITNAME,
                            FILERECEVIEUNITCODE,FILERECEVIEUNITNAME,TEMPLATENAME,CUSTOMDISTRICTCODE,CUSTOMDISTRICTNAME) VALUES
                            ('{3}','{0}',sysdate,sysdate,(select fun_AutoQYBH(sysdate) from dual),'{1}','{2}','{4}','{5}','{6}','{7}','{8}','2369','昆山综保')";
                    sql = string.Format(sql, contractno, enterprisecode, enterprisename, entid, item.DECLAREUNIUTCODE,item.DECLAREUNITNAME,item.RECIVEUNITCODE,item.RECIVEUNITNAME,item.TEMPLETENAME);
                    DBMgr.ExecuteNonQuery(sql);
                }
                else
                {
                    entid = dt_ent.Rows[0]["ID"] + "";
                }
                //写入随附文件表 
                sql = @"select * from list_attachment where originalname='" + fs.Name + "' and entid='" + entid + "'";
                DataTable dt_att = DBMgr.GetDataTable(sql);//因为客户有可能会重复传文件,此是表记录不需要变化，替换文件即可
                if (dt_att.Rows.Count > 0)
                {
                    sql = "delete from list_attachment where id='" + dt_att.Rows[0]["ID"] + "'";
                    DBMgr.ExecuteNonQuery(sql);
                }
                //dt_att = DBMgr.GetDataTable("select LIST_ATTACHMENT_ID.Nextval ATTACHMENTID from dual");
                sql = @"insert into list_attachment(ID,FILENAME,ORIGINALNAME,UPLOADTIME,FILETYPE,SIZES,ENTID,FILESUFFIX,UPLOADUSERID,CUSTOMERCODE,isupload) values(
                   LIST_ATTACHMENT_ID.Nextval,'{0}','{1}',sysdate,'{2}','{3}','{4}','{5}','404','{6}','1')";
                sql = string.Format(sql, "/" + directory + "/" + fs.Name, fs.Name, filetypeid, fs.Size, entid, suffix, enterprisecode);
                int result = DBMgr.ExecuteNonQuery(sql);
                if (result > 0 && fs.Name.IndexOf(".txt") > 0)
                {
                    db.ListRightPush("compal_sheet_topdf_queen", "{ENTID:'" + entid + "',FILENAME:" + "'/" + directory + "/" + fs.Name + "'}");//保存随附文件ID到队列
                }
                content = true;
            }
            #endregion
            catch (Exception ex)
            {
                content = false;
                foreach (DataGridViewRow row in this.gr_ftpitem.Rows)
                {
                    if (row.Cells["ID"].Value.ToString() == item.ID.ToString())
                    {
                        row.Cells["STATUSFLAG"].Value = ex.Message.ToString();
                    }

                }
            }
            return content;
        }

       
    }
}
