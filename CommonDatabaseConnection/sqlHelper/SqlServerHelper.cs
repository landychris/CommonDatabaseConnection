/**
* 命名空间: CommonDatabaseConnection.sqlHelper
*
* 功 能： N/A
* 类 名： SqlServerHelper
* 创建人：landy
* 创建时间：2017/7/7 10:58:16
* CLR VERSION: 4.0.30319.42000
* Ver 变更日期 负责人 变更内容
* ───────────────────────────────────
* V0.01 2017/7/7 10:58:16 landy 初版
*
* Copyright (c) 2017 Lir Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：厦门卫生检疫技术研究所 　　　　　　　　　　　　　　     │
*└──────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonDatabaseConnection.sqlHelper
{
    public sealed partial class SqlServerHelper
    {
        private static SqlConnection sqlcon;
        public static String buildConnectionUrl(int authType, String url, String database, String uid, String pwd)
        {
            String connUrl = "";
            if (authType == 0) //windows身份验证
            {
                connUrl = "Data Source=" + url + ";Initial Catalog =" + database + ";Integrated Security=SSPI;";
            }
            else if (authType == 1) //sqlserver身份验证
            {
                connUrl = "Data Source=" + url + ";Database=" + database + ";Uid=" + uid + ";Pwd=" + pwd + ";";
            }
            return connUrl;
        }

        public static bool connect(String connUrl)
        {
            sqlcon = new SqlConnection(connUrl);
            try
            {
                sqlcon.Open();
                return true;
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public static SqlConnection getSqlConnection() {
            return sqlcon;
        }

        public static DataTable getTable()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select name from sysdatabases ", sqlcon);
                DataTable dt = new DataTable("sysdatabases");
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public static DataTable getTableOfCurrentDatabase()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select Name from sysobjects where xtype='u' and status>=0 ", sqlcon);
                DataTable dt = new DataTable("sysobjects");
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
    }
}
