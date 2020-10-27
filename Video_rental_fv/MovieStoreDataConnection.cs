using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_rental_fv
{
    public class MovieStoreDataConnection : EmptyCheck
    {
        //create the instance of the SQL Connection class
        SqlConnection conn;

        //write the connection sstring to assthe data form one for to the database 
        String conStr = "Data Source=DESKTOP-G2UGPMF\\SQLEXPRESS;Initial Catalog=VideoRentalStore;Integrated Security=True";

        //command are use to excute the command of isnert , delete , update
        SqlCommand cmd;

        //data reader is used to read thedata from the database table 
        SqlDataReader DReader;


        //method used to execute query which doent return any thing only modifit the database
        public void CmdQuery(String query)
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        // this method is used to search the record from the data base and then pass the whole record to the query using where clause of the sql
        public DataTable CmdRecord(String qry)
        {
            DataTable tbl = new DataTable();

            conn = new SqlConnection(conStr);

            conn.Open();

            cmd = new SqlCommand(qry, conn);

            DReader = cmd.ExecuteReader();

            tbl.Load(DReader);

            conn.Close();

            return tbl;
        }

        //return the value how much booking the member alreadyhave
        public int chkBooking(String Member_FK) {
            DataTable tbl = new DataTable();
            tbl = CmdRecord("select * from BookingTable where Member_FK='" + Member_FK + "' and ReturnDate='null'");
            return tbl.Rows.Count;
        }

        //load the data from the database and show in the data grid view
        public void getMember(DataGridView dgv){
            DataTable tbl = new DataTable();
            tbl = CmdRecord("select * from MemberTable");
            dgv.DataSource = "";
            dgv.DataSource = tbl;
        }

        //load the data from the database and show in the data grid view
        public void getMovie(DataGridView dgv)
        {
            DataTable tbl = new DataTable();
            tbl = CmdRecord("select * from MovieTable");
            dgv.DataSource = "";
            dgv.DataSource = tbl;
        }



        //load the data from the database and show in the data grid view
        public void getBooking(DataGridView dgv)
        {
            DataTable tbl = new DataTable();
            tbl = CmdRecord("select * from BookingTable");
            dgv.DataSource = "";
            dgv.DataSource = tbl;
        }

        //check the movie is already booked or not 
        public int checkMovieStatus(int Movie_FK) {
            DataTable tbl = new DataTable();
            tbl = CmdRecord("select * from BookingTable where Movie_FK='"+Movie_FK.ToString()+"' and ReturnDate='null'");
            return tbl.Rows.Count;
        }


        //check how much copies of the movie is booked 
        public int checkStatusMovie(int Member_FK)
        {
            DataTable tbl = new DataTable();
            int copies = 0;
            tbl = CmdRecord("select * from MovieTable where id=" + Member_FK + "");
            copies=Convert.ToInt32(tbl.Rows[0]["Copies"].ToString());
            tbl = new DataTable();
            tbl = CmdRecord("select * from BookingTable where Member_FK='" + Member_FK.ToString() + "' and ReturnDate='null'");
            if (copies > tbl.Rows.Count)
            {
                return 0;
            }
            else {
                return 1;
            }
        }

        public int billGenerate(int Movie_FK,String BookingDate) {
            //first get the cost of the movie
            DataTable tbl = new DataTable();
            int cost = 0;
            tbl = CmdRecord("select * from MovieTable where id="+Movie_FK+"");
            cost=Convert.ToInt32(tbl.Rows[0]["Copies"].ToString());

            DateTime current_date = DateTime.Now;

            //convert the old date from string to Date fromat
            DateTime prev_date = Convert.ToDateTime(BookingDate);


            //get the difference in the days fromat
            String Daysdiff = (current_date - prev_date).TotalDays.ToString();


            // calculate the round off value 
            Double DaysInterval = Math.Round(Convert.ToDouble(Daysdiff));


            return cost * (Convert.ToInt32(DaysInterval));

        }




    }


}
