using CommonDatabaseConnection.sqlHelper;
using Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonDatabaseConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            url.Text = "localhost"; //默认地址
            port.Text = "1433";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //windows身份验证不需要用户名密码
            username.Enabled = password.Enabled = false; 
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //sqlserver身份验证需要用户名密码
            username.Enabled = password.Enabled = true; 
        }

        private void rb_sqlserver_CheckedChanged(object sender, EventArgs e)
        {
            url.Text = "localhost"; //默认地址
            port.Text = "1433";
            radioButton1.Enabled = radioButton2.Enabled = true;
        }

        private void rb_mysql_CheckedChanged(object sender, EventArgs e)
        {
            url.Text = "localhost"; //默认地址
            port.Text = "3306";
            radioButton1.Enabled = radioButton2.Enabled = false;
        }

        private void rb_oracle_CheckedChanged(object sender, EventArgs e)
        {
            url.Text = "192.168.1.250"; //默认地址
            port.Text = "1521";
            radioButton1.Enabled = radioButton2.Enabled = false;
            comboBox1.Text = "ORCL";
            username.Text = "MIBP_SYS_DEV2";
            password.Text = "123456";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String uid = username.Text;
            String pwd = password.Text;

            //刷新数据库连接
            if (this.validDbUser(uid, pwd))
            {
                if (rb_sqlserver.Checked) //连接sqlServer
                {
                    this.RefreshSqlServerDb(uid, pwd);
                }
                else if (rb_mysql.Checked) //连接mysql
                {
                    this.RefreshMysql(uid, pwd);
                }
                else if(rb_oracle.Checked)
                {
                    this.RefreshOracle(uid, pwd);
                }
            }
        }

        private bool connectSqlServerDb(String db,String uid,String pwd)
        {
            int authType = 1;
            if (radioButton1.Checked) //windows身份验证
            {
                authType = 0;
            }
            else
            {
                authType = 1;
            }
            String connUrl = SqlServerHelper.
                buildConnectionUrl(authType, url.Text, db, uid, pwd);
            bool isConnected = SqlServerHelper.connect(connUrl);
            return isConnected;
        }

        private void RefreshSqlServerDb(String uid,String pwd)
        {
            bool isconnected = this.connectSqlServerDb("master", uid, pwd);
            if (isconnected)
            {
                comboBox1.DataSource = SqlServerHelper.getTable();
                comboBox1.DisplayMember = "name";
                comboBox1.ValueMember = "name";
            }
            else {
                conn_info.Text = "连接失败……";
            }
        }

        private void RefreshMysql(String uid, String pwd)
        {
            string mysqlConnStr = "server=" + url.Text + ";user id=" + uid + ";password=" + pwd + ";database=information_schema" ; //根据自己的设置
            Helpers.MySqlHelper mysqlHelper = new Helpers.MySqlHelper(mysqlConnStr);

            String sql = "select schema_name name from SCHEMATA ";
            MySqlParameter[] parms = new MySqlParameter[] { };
            DataTable dt = mysqlHelper.ExecuteDataTable(sql, parms);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "name";
        }

        private void RefreshOracle(String uid, String pwd)
        {
            String ConnectionString = //"Data Source="+ url.Text+";user Id="+uid+";Password="+pwd;

            //"Data Source = (DESCRIPTION = (ADDRESS_LIST= (ADDRESS = (PROTOCOL = TCP)(HOST =" + url.Text + ")(PORT = "+port.Text+")))(CONNECT_DATA =(SERVICE_NAME = "+comboBox1.Text+" )));User ID = "+uid+" ;Password=  "+pwd;  //这里改为copy下的服务名和用户名和密码

            "Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = " + url.Text + ")(PORT = " + port.Text + "))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = " + comboBox1.Text + ")));User ID = " + uid + " ;Password=  " + pwd;

            OracleHelper.connstr = ConnectionString; //oh = new OracleHelper(ConnectionString);
            try
            {
                OracleHelper.init();

                String sql = "SELECT TABLE_NAME FROM USER_TABLES";

                
                System.IO.StringWriter sw = new System.IO.StringWriter();
                System.Xml.XmlTextWriter xw = new System.Xml.XmlTextWriter(sw);
                //当前数据库所有的用户表
                DataTable dt = OracleHelper.GetDataTable(sql);
                dt.WriteXml(xw);
                string s = sw.ToString();
                conn_info.Text = "连接成功……\n所有的用户表展示如下：\n" + s;
            }
            catch (System.Exception ex)
            {
                conn_info.Text = "连接失败……";
                Console.WriteLine(ex.ToString());
            }

        }

        private bool connectMySql(String db, String uid, String pwd)
        {
            string mysqlConnStr = "server=" + url.Text + ";user id=" + uid + ";password=" + pwd + ";database="+db; //根据自己的设置

            MySqlConnection connection = new MySqlConnection(mysqlConnStr);
            try
            {
                connection.Open();
            }
            catch (System.Exception ex)
            {
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String uid = username.Text;
            String pwd = password.Text;
            //刷新数据库连接
            if (this.validDbUser(uid, pwd))
            {
                if (rb_sqlserver.Checked) //连接sqlServer
                {
                    String db = comboBox1.Text;
                    bool isConnected = this.connectSqlServerDb(db, uid, pwd);

                    if (isConnected)
                    {
                        conn_info.Clear();
                        System.IO.StringWriter sw = new System.IO.StringWriter();
                        System.Xml.XmlTextWriter xw = new System.Xml.XmlTextWriter(sw);
                        //当前数据库所有的用户表
                        DataTable dt = SqlServerHelper.getTableOfCurrentDatabase();
                        dt.WriteXml(xw);
                        string s = sw.ToString();
                        conn_info.Text = "连接成功……\n所有的用户表展示如下：\n" + s;
                    }
                    else
                    {
                        conn_info.Text = "连接失败……";
                    }
                }
                else if (rb_mysql.Checked) //连接mysql
                {
                    String db = comboBox1.Text;
                    bool isConnected = this.connectMySql(db, uid, pwd);
                    if (isConnected)
                    {
                        string mysqlConnStr = "server=" + url.Text + ";user id=" + uid + ";password=" + pwd + ";database=" + db; //根据自己的设置
                        Helpers.MySqlHelper mysqlHelper = new Helpers.MySqlHelper(mysqlConnStr);

                        String sql = "show tables ";
                        MySqlParameter[] parms = new MySqlParameter[] { };
                        DataTable dt = mysqlHelper.ExecuteDataTable(sql, parms);

                        conn_info.Clear();
                        System.IO.StringWriter sw = new System.IO.StringWriter();
                        System.Xml.XmlTextWriter xw = new System.Xml.XmlTextWriter(sw);
                        //当前数据库所有的用户表
                        dt.WriteXml(xw);
                        string s = sw.ToString();
                        conn_info.Text = "连接成功……\n" + s;
                    }
                    else
                    {
                        conn_info.Text = "连接失败……";
                    }
                }
                else if (rb_oracle.Checked)
                {
                    this.RefreshOracle(uid, pwd);
                    
                }
            }
        }

        private bool validDbUser(String uid,String pwd)
        {
            if (uid == null || uid == "")
            {
                MessageBox.Show("用户名必须要输入!!!");//只显示一个“确定”按钮。
                return false;
            }
            if (pwd == null || pwd == "")
            {
                MessageBox.Show("密码必须要输入!!!");//只显示一个“确定”按钮。
                return false;
            }
            return true;
        }
    }
}
