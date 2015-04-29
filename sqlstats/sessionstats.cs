using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Threading.Tasks;
namespace sqlstats
{
    public delegate void collectsessionstats(object s);
    public partial class sessionstats : Form
    {
        private DataSet dsFormDataSource;
        private DataTable dtFormDataTable;
        private string sqlinstance;
        public sessionstats()
        {
            InitializeComponent();
            dsFormDataSource = new DataSet("local");
            dtFormDataTable = dsFormDataSource.Tables.Add("localSessionStats");
            dgvsessionstats.DataSource = dsFormDataSource;
            dgvsessionstats.DataMember = dsFormDataSource.Tables["localSessionStats"].ToString();
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlinstance = txtinstance.Text.ToString().Trim();
            Task collecttask = new Task(this.collectsessionstats, new object());
            collecttask.Start();

        }
        public void collectsessionstats(object o)
        {
            try
            {
                collectsessionstatsAction(sqlinstance);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void collectsessionstatsAction(String sqlinstance)
        {
            SqlConnection myconn = new SqlConnection(@"data source = " + sqlinstance +"; initial catalog = master; integrated security = sspi;");
            SqlCommand mycom  = myconn.CreateCommand();
            SqlDataAdapter myda = new SqlDataAdapter(mycom);
                 
            mycom.CommandType = CommandType.Text;
            mycom.CommandText = @"select  session_id,program_name,login_name,nt_user_name,status,last_request_start_time,last_request_end_time,login_time,getdate() as current_daytime 
from sys.dm_exec_sessions sess
outer apply ( select connection_id from sys.dm_exec_connections conn where conn.session_id = sess.session_id 
 or conn.most_recent_session_id = sess.session_id ) tm";
            try
            {
                myconn.Open();
                myda.Fill(dtFormDataTable);
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message.ToString() + @"data source = " + sqlinstance + "; initial catalog = master; integrated security = sspi;");
            }
        }

        
    }
}
