using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace fee
{
    //connection
    public abstract class clscon
    {
        protected SqlConnection con = new SqlConnection();
        public clscon()
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["mirza"].ConnectionString;
        }
    }
    //end connection

    //start tb register
    public interface register
    {
        Int32 regid
        {
            get;
            set;
        }
        Int32 studentid
        {
            set;
            get;
        }

        int hostelfee
        {
            get;
            set;
        }

        string hostelfee1
        {
            get;
            set;
        }
        string busfee
        {
            get;
            set;
        }
        string f_name
        {
            get;
            set;
        }

        string total
        {
            get;
            set;
        }

        string pending
        {
            get;
            set;
        }
      string acadmics
        {
            get;
            set;
        }

        string fine
        {
            get;
            set;

        }
       string extra
        {
            get;
            set;
        }
        string exam
        {
            get;
            set;
        }
        string l_name
        {
            get;
            set;
        }
        string rollno
        {
            set;
            get;
        }
        string dept
        {
            set; get;
        }
        string sem
        {
            set; get;
        }
        string dob
        {
            set;
            get;
        }
        string father
        {
            set;
            get;
        }

        String parent
        {
            set;
            get;

        }

        String parentemail
        {
            set;
            get;
        }

        String parentcontact
        {
            set;
            get;

        }
        string mother
        {
            set;
            get;
        }
        string email
        {
            get;
            set;
        }
        string contact
        {
            get; set;
        }
        string address
        {
            get;
            set;
        }
        string password
        {
            get;
            set;
        }

        string parentpassword
        {
            get;
            set;
        }
        string hostel
        {
            set;
            get;
        }
        string bus
        {
            set;
            get;
        }
        string acc_type
        {
            set;
            get;
        }
        string lastupd
        {
            set;
            get;
        }
    }

    public class clsregistrationprp : register
    {
        private Int32 prvregid, prvstudentid, prvhostelfee;
        private string prvemail, prvparentpassword, prvhostelfee1, prvbusfee, prvpending, prvtotal, prvfine, prvextra, prvexam, prvpassword, prvf_name, prvacadmics, prvl_name, prvparent, prvparentemail, prvparentcontact, prvaddress, prvcontact, prvrollno, prvdept, prvsem, prvdob, prvfather, prvmother, prvhostel, prvbus, prvacctype, prvlastupd;

        public int regid
        {
            get
            {
                return prvregid;
            }

            set
            {
                prvregid = value;
            }
        }

        public int studentid
        {
            get
            {
                return prvstudentid;
            }

            set
            {
                prvstudentid = value;
            }
        }
        public string f_name
        {
            get
            {
                return prvf_name;
            }

            set
            {
                prvf_name = value;
            }
        }

        public string acadmics
        {
            get
            {
                return prvacadmics;
            }

            set
            {
                prvacadmics = value;
            }
        }

        public string total
        {
            get
            {
                return prvtotal;
            }

            set
            {
                prvtotal = value;
            }
        }

        public string pending
        {
            get
            {
                return prvpending;
            }

            set
            {
                prvpending = value;
            }
        }
        public string fine
        {
            get
            {
                return prvfine;
            }

            set
            {
                prvfine = value;
            }
        }

        public string extra
        {
            get
            {
                return prvextra;
            }

            set
            {
                prvextra = value;
            }
        }
        public string exam
        {
            get
            {
                return prvexam;
            }

            set
            {
                prvexam = value;
            }
        }

        public string busfee
        {
            get
            {
                return prvbusfee;
            }

            set
            {
                prvbusfee = value;
            }
        }
        public int hostelfee
        {
            get
            {
                return prvhostelfee;
            }

            set
            {
                prvhostelfee = value;
            }
        }

        public string hostelfee1
        {
            get
            {
                return prvhostelfee1;
            }

            set
            {
                prvhostelfee1 = value;
            }
        }
        public string l_name
        {
            get
            {
                return prvl_name;
            }

            set
            {
                prvl_name = value;
            }
        }
        public string parent
        {
            get
            {
                return prvparent;
            }

            set
            {
                prvparent = value;
            }
        }
        public string parentcontact
        {
            get
            {
                return prvparentcontact;
            }

            set
            {
                prvparentcontact = value;
            }
        }
        public string parentemail
        {
            get
            {
                return prvparentemail;
            }

            set
            {
                prvparentemail = value;
            }
        }
        public string email
        {
            get
            {
                return prvemail;
            }

            set
            {
                prvemail = value;
            }
        }

        public string parentpassword
        {
            get
            {
                return prvparentpassword;
            }

            set
            {
                prvparentpassword = value;
            }
        }
        public string password
        {
            get
            {
                return prvpassword;
            }

            set
            {
                prvpassword = value;
            }
        }

        public string address
        {
            get
            {
                return prvaddress;
            }

            set
            {
                prvaddress = value;
            }
        }
        public string contact
        {
            get
            {
                return prvcontact;
            }
            set
            {
                prvcontact = value;
            }
        }
        public string rollno
        {
            get
            {
                return prvrollno;
            }

            set
            {
                prvrollno = value;
            }
        }

        public string dept
        {
            get
            {
                return prvdept;
            }

            set
            {
                prvdept = value;
            }
        }

        public string sem
        {
            get
            {
                return prvsem;
            }

            set
            {
                prvsem = value;
            }
        }

        public string dob
        {
            get
            {
                return prvdob;
            }

            set
            {
                prvdob = value;
            }
        }

        public string father
        {
            get
            {
                return prvfather;
            }

            set
            {
                prvfather = value;
            }
        }

        public string mother
        {
            get
            {
                return prvmother;

            }

            set
            {
                prvmother = value;
            }
        }

        public string hostel
        {
            get
            {
                return prvhostel;
            }

            set
            {
                prvhostel = value;
            }
        }

        public string bus
        {
            get
            {
                return prvbus;
            }

            set
            {
                prvbus = value;
            }
        }

        public string acc_type
        {
            get
            {
                return prvacctype;
            }

            set
            {
                prvacctype = value;
            }
        }

        public string lastupd
        {
            get
            {
                return prvlastupd;
            }

            set
            {
                prvlastupd = value;
            }
        }

    }

    public class clsregister : clscon
    {
        public Int32 logincheck(clsregistrationprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("logincheck", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = p.email;
            cmd.Parameters.Add("@password", SqlDbType.VarChar, 50).Value = p.password;
            cmd.Parameters.Add("@cod", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@acc_type", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            //  Int32 a = Convert.ToInt32(cmd.Parameters["@cod"].Value);
            Int32 b = Convert.ToInt32(cmd.Parameters["@acc_type"].Value);
            cmd.Dispose();
            con.Close();
            return b;
        }
        public Int32 logincheck1(clsregistrationprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("logincheck", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = p.email;
            cmd.Parameters.Add("@password", SqlDbType.VarChar, 50).Value = p.password;
            cmd.Parameters.Add("@cod", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@acc_type", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            Int32 a = Convert.ToInt32(cmd.Parameters["@cod"].Value);
            Int32 b = Convert.ToInt32(cmd.Parameters["@acc_type"].Value);
            cmd.Dispose();
            con.Close();
            return a;
        }
        public Int32 logincheckrollb(clsregistrationprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("logincheckroll", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@rollno", SqlDbType.VarChar, 50).Value = p.rollno;
            cmd.Parameters.Add("@password", SqlDbType.VarChar, 50).Value = p.password;
            cmd.Parameters.Add("@cod", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@acc_type", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            //  Int32 a = Convert.ToInt32(cmd.Parameters["@cod"].Value);
            Int32 b = Convert.ToInt32(cmd.Parameters["@acc_type"].Value);
            cmd.Dispose();
            con.Close();
            return b;
        }

        public Int32 logincheckrolla(clsregistrationprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("logincheckroll", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@rollno", SqlDbType.VarChar, 50).Value = p.rollno;
            cmd.Parameters.Add("@password", SqlDbType.VarChar, 50).Value = p.password;
            cmd.Parameters.Add("@cod", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@acc_type", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            Int32 a = Convert.ToInt32(cmd.Parameters["@cod"].Value);
            // Int32 b = Convert.ToInt32(cmd.Parameters["@acc_type"].Value);
            cmd.Dispose();
            con.Close();
            return a;
        }

        public Int32 findid(clsregistrationprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("getid", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@rollno", SqlDbType.VarChar, 50).Value = p.rollno;
            cmd.Parameters.Add("@reg", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            Int32 a = Convert.ToInt32(cmd.Parameters["@reg"].Value);

            cmd.Dispose();
            con.Close();
            return a;
        }
        public void save_rec(clsregistrationprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();

            }
            SqlCommand cmd = new SqlCommand("insreg", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = p.email;
            cmd.Parameters.Add("@password", SqlDbType.VarChar, 50).Value = p.password;
            cmd.Parameters.Add("@f_name", SqlDbType.VarChar, 50).Value = p.f_name;
            cmd.Parameters.Add("@l_name", SqlDbType.VarChar, 50).Value = p.l_name;
            cmd.Parameters.Add("@contact", SqlDbType.VarChar, 50).Value = p.contact;
            cmd.Parameters.Add("@address", SqlDbType.VarChar, 50).Value = p.address;
            cmd.Parameters.Add("@rollno", SqlDbType.VarChar, 50).Value = p.rollno;
            cmd.Parameters.Add("@department", SqlDbType.VarChar, 50).Value = p.dept;
            cmd.Parameters.Add("@semester", SqlDbType.VarChar, 50).Value = p.sem;
            cmd.Parameters.Add("@dob", SqlDbType.VarChar, 50).Value = p.dob;
            cmd.Parameters.Add("@father", SqlDbType.VarChar, 50).Value = p.father;
            cmd.Parameters.Add("@mother", SqlDbType.VarChar, 50).Value = p.mother;
            cmd.Parameters.Add("@hostel", SqlDbType.VarChar, 50).Value = p.hostel;
            cmd.Parameters.Add("@bus", SqlDbType.VarChar, 50).Value = p.bus;
            cmd.Parameters.Add("@acc_type", SqlDbType.VarChar, 50).Value = p.acc_type;
            cmd.Parameters.Add("@lastupd", SqlDbType.VarChar, 50).Value = p.lastupd;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }

        public void update_rec(clsregistrationprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updreg", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@regid", SqlDbType.Int).Value = p.regid;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = p.email;
            cmd.Parameters.Add("@password", SqlDbType.VarChar, 50).Value = p.password;
            cmd.Parameters.Add("@f_name", SqlDbType.VarChar, 50).Value = p.f_name;
            cmd.Parameters.Add("@l_name", SqlDbType.VarChar, 50).Value = p.l_name;
            cmd.Parameters.Add("@contact", SqlDbType.VarChar, 50).Value = p.contact;
            cmd.Parameters.Add("@address", SqlDbType.VarChar, 50).Value = p.address;
            cmd.Parameters.Add("@rollno", SqlDbType.VarChar, 50).Value = p.rollno;
            cmd.Parameters.Add("@department", SqlDbType.VarChar, 50).Value = p.dept;
            cmd.Parameters.Add("@semester", SqlDbType.VarChar, 50).Value = p.sem;
            cmd.Parameters.Add("@dob", SqlDbType.VarChar, 50).Value = p.dob;
            cmd.Parameters.Add("@father", SqlDbType.VarChar, 50).Value = p.father;
            cmd.Parameters.Add("@mother", SqlDbType.VarChar, 50).Value = p.mother;
            cmd.Parameters.Add("@hostel", SqlDbType.VarChar, 50).Value = p.hostel;
            cmd.Parameters.Add("@bus", SqlDbType.VarChar, 50).Value = p.bus;
            cmd.Parameters.Add("@acc_type", SqlDbType.VarChar, 50).Value = p.acc_type;
            cmd.Parameters.Add("@lastupd", SqlDbType.VarChar, 50).Value = p.lastupd;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }

        public void update_parent(clsregistrationprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("parentupd", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = p.parentemail;
            cmd.Parameters.Add("@contact", SqlDbType.VarChar, 50).Value = p.parentcontact;
            cmd.Parameters.Add("@address", SqlDbType.VarChar, 50).Value = p.address;
            cmd.Parameters.Add("@rollno", SqlDbType.Int).Value = p.regid ;
            cmd.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = p.parent;
            cmd.Parameters.Add("@lastupd", SqlDbType.VarChar, 50).Value = p.lastupd;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }

        public void delete_rec(clsregistrationprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("delreg", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@regid", SqlDbType.Int).Value = p.regid;

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        public List<clsregistrationprp> disp_rec()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();

            }
            SqlCommand cmd = new SqlCommand("dispreg", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsregistrationprp> obj = new List<clsregistrationprp>();
            while (dr.Read())
            {
                clsregistrationprp k = new clsregistrationprp();
                k.regid = Convert.ToInt32(dr[0]);
                k.email = dr[1].ToString();
                k.password = dr[2].ToString();
                k.f_name = dr[3].ToString();
                k.l_name = dr[4].ToString();
                k.address = dr[5].ToString();
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;

        }

        public List<clsregistrationprp> find_rec(Int32 regid)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();

            }
            SqlCommand cmd = new SqlCommand("findreg", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@regid", SqlDbType.Int).Value = regid;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsregistrationprp> obj = new List<clsregistrationprp>();
            if (dr.HasRows)
            {
                dr.Read();
                clsregistrationprp k = new clsregistrationprp();
                k.regid = Convert.ToInt32(dr[0]);
                k.f_name = dr[1].ToString();
                k.l_name = dr[2].ToString();
                k.rollno = dr[3].ToString();
                k.dept = dr[4].ToString();
                k.sem = dr[5].ToString();
                k.dob = dr[6].ToString();
                k.father = dr[7].ToString();
                k.mother = dr[8].ToString();
                k.email = dr[9].ToString();
                k.contact = dr[10].ToString();
                k.address = dr[11].ToString();
                k.password = dr[12].ToString();
                k.hostel = dr[13].ToString();
                k.bus = dr[14].ToString();
                k.acc_type = dr[15].ToString();
                k.lastupd = dr[16].ToString();
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }

        public List<clsregistrationprp> find_parent(Int32 regid)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();

            }
            SqlCommand cmd = new SqlCommand("findparent", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@rollno", SqlDbType.Int).Value = regid;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsregistrationprp> obj = new List<clsregistrationprp>();
            if (dr.HasRows)
            {
                dr.Read();
                clsregistrationprp p = new clsregistrationprp();
               
                p.parentemail = dr[2].ToString();
               p.parentcontact = dr[3].ToString();
               
              
                obj.Add(p);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }
        //kanha//
        public Int32 adminlogin(clsregistrationprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("adminlogin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = p.email;
            cmd.Parameters.Add("@password", SqlDbType.VarChar, 50).Value = p.password;
            cmd.Parameters.Add("@pass", SqlDbType.Int).Direction = ParameterDirection.Output;

            cmd.ExecuteNonQuery();

            Int32 a = Convert.ToInt32(cmd.Parameters["@pass"].Value);
            cmd.Dispose();
            con.Close();
            return a;
        }
        public Int32 parent_login(clsregistrationprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("parentlogin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = p.email;
            cmd.Parameters.Add("@pass", SqlDbType.VarChar, 50).Value = p.password;
            cmd.Parameters.Add("@cod", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@stu", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            Int32 a = Convert.ToInt32(cmd.Parameters["@cod"].Value);
            Int32 b = Convert.ToInt32(cmd.Parameters["@stu"].Value);

            cmd.Dispose();
            con.Close();
            return a;
        }
        public void save_rec_admin(clsregistrationprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();

            }
            SqlCommand cmd = new SqlCommand("insreg", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = p.email;
            cmd.Parameters.Add("@password", SqlDbType.VarChar, 50).Value = p.password;
            cmd.Parameters.Add("@f_name", SqlDbType.VarChar, 50).Value = p.f_name;
            cmd.Parameters.Add("@l_name", SqlDbType.VarChar, 50).Value = p.l_name;
            cmd.Parameters.Add("@contact", SqlDbType.VarChar, 50).Value = p.contact;
            cmd.Parameters.Add("@address", SqlDbType.VarChar, 50).Value = DBNull.Value;
            cmd.Parameters.Add("@rollno", SqlDbType.VarChar, 50).Value = p.rollno;
            cmd.Parameters.Add("@department", SqlDbType.VarChar, 50).Value = p.dept;
            cmd.Parameters.Add("@semester", SqlDbType.VarChar, 50).Value = p.sem;
            cmd.Parameters.Add("@dob", SqlDbType.VarChar, 50).Value = DBNull.Value;
            cmd.Parameters.Add("@father", SqlDbType.VarChar, 50).Value = DBNull.Value;
            cmd.Parameters.Add("@mother", SqlDbType.VarChar, 50).Value = DBNull.Value;
            cmd.Parameters.Add("@hostel", SqlDbType.VarChar, 50).Value = DBNull.Value;
            cmd.Parameters.Add("@bus", SqlDbType.VarChar, 50).Value = DBNull.Value;
            cmd.Parameters.Add("@acc_type", SqlDbType.VarChar, 50).Value = p.acc_type;
            cmd.Parameters.Add("@lastupd", SqlDbType.VarChar, 50).Value = p.lastupd;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }
        public void join_family(clsregistrationprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();

            }
            SqlCommand cmd = new SqlCommand("joinfamily", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = p.parentemail;
            cmd.Parameters.Add("@password", SqlDbType.VarChar, 50).Value = p.parentpassword;
            cmd.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = p.parent;
            cmd.Parameters.Add("@contact", SqlDbType.VarChar, 50).Value = p.parentcontact;
            cmd.Parameters.Add("@student", SqlDbType.Int).Value = p.studentid;
            cmd.Parameters.Add("@address", SqlDbType.VarChar, 50).Value = DBNull.Value;
            cmd.Parameters.Add("@lstupd", SqlDbType.VarChar, 50).Value = p.lastupd;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }

        public void data_entry(clsregistrationprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();

            }
            SqlCommand cmd = new SqlCommand("dataentry", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@rollno", SqlDbType.VarChar, 50).Value = p.rollno;
            cmd.Parameters.Add("@acadmics", SqlDbType.Int).Value =Convert.ToInt32( p.acadmics);
            cmd.Parameters.Add("@hostel", SqlDbType.Int).Value = Convert.ToInt32 (p.hostelfee1);
            cmd.Parameters.Add("@extra", SqlDbType.Int).Value = Convert.ToInt32(p.extra);
            cmd.Parameters.Add("@exam", SqlDbType.Int).Value = Convert.ToInt32( p.exam);
            cmd.Parameters.Add("@fine", SqlDbType.Int).Value = Convert.ToInt32( p.fine);
            cmd.Parameters.Add("@bus", SqlDbType.Int).Value = Convert.ToInt32 (p.busfee);
            cmd.Parameters.Add("@pending", SqlDbType.Int).Value = Convert.ToInt32(p.pending);
            cmd.Parameters.Add("@total", SqlDbType.Int).Value = Convert.ToInt32( p.total);
               cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }
        public void update_rec_parent(clsregistrationprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updregparent", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@regid", SqlDbType.Int).Value = p.regid;
            cmd.Parameters.Add("@f_name", SqlDbType.VarChar, 50).Value = p.f_name;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = p.email;
            cmd.Parameters.Add("@contact", SqlDbType.VarChar, 50).Value = p.contact;
            cmd.Parameters.Add("@address", SqlDbType.VarChar, 800).Value = p.address;
            cmd.Parameters.Add("@password", SqlDbType.VarChar, 50).Value = p.password;
            cmd.Parameters.Add("lastupd", SqlDbType.VarChar, 50).Value = p.lastupd;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }
        public void change_pass(clsregistrationprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("passchange", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@regid", SqlDbType.Int).Value = p.regid;
            cmd.Parameters.Add("@password", SqlDbType.VarChar, 50).Value = p.password;
            cmd.Parameters.Add("@lastupd", SqlDbType.VarChar, 50).Value = p.lastupd;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }
        public void change_pass_parent(clsregistrationprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("passchangeparent", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@regid", SqlDbType.Int).Value = p.regid;
            cmd.Parameters.Add("@password", SqlDbType.VarChar, 50).Value = p.password;
            cmd.Parameters.Add("@lastupd", SqlDbType.VarChar, 50).Value = p.lastupd;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }
        public List<clsregistrationprp> find_rec_parent(Int32 regid)
        {

            if (con.State == ConnectionState.Closed)
            {
                con.Open();

            }
            SqlCommand cmd = new SqlCommand("findregparent", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@regid", SqlDbType.Int).Value = regid;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsregistrationprp> obj = new List<clsregistrationprp>();
            if (dr.HasRows)
            {
                dr.Read();
                clsregistrationprp k = new clsregistrationprp();
                k.regid = Convert.ToInt32(dr[0]);
                k.f_name = dr[1].ToString();
                k.email = dr[2].ToString();
                k.contact = dr[3].ToString();
                k.address = dr[4].ToString();
                k.password = dr[5].ToString();
                k.lastupd = dr[7].ToString();
                obj.Add(k);

            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;


        }


    }

}