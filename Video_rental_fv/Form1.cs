using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_rental_fv
{
    public partial class Form1 : Form
    {
        String values = "";
        int Rent_FK = 0;
        MovieStoreDataConnection instance = new MovieStoreDataConnection();
        public Form1()
        {
            InitializeComponent();
            //auto genreate the price of the movie by calculating the year 
            txtCost.Enabled = false;
        }

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            values = "";
            //pass the values to the check empty method to check the values
            values = txtName.Text + "," + txtAddress.Text + "," + txtContact.Text + "," + cus_email.Text;
            //check the return values 
            if (instance.checkEmpty(values) == 0)
            {
                instance.CmdQuery("insert into MemberTable values('"+txtName.Text+"','"+txtAddress.Text+"','"+txtContact.Text+"','"+cus_email.Text+"')");
                MessageBox.Show("Member is Sucessfully register in the Store");
            }
            else {
                MessageBox.Show("Must fill all values");
            }
            //reset the values 
            txtName.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            cus_email.Text = "";
            Member_FK.Text = "";
        }

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            values = "";
            values = Member_FK.Text;
            if (instance.checkEmpty(values) == 0)
            {
                DialogResult result = MessageBox.Show("Do you want to Delete the Member?", "Confirmation",MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    if (instance.chkBooking(Member_FK.Text) == 0)
                    {
                        instance.CmdQuery("delete from MemberTable where id="+Convert.ToInt32(Member_FK.Text)+"");
                        MessageBox.Show("Member is deleted");
                    }
                    else {
                        MessageBox.Show("You alrady have an booking so first return that ");
                    }

                    //reset the values 
                    txtName.Text = "";
                    txtContact.Text = "";
                    txtAddress.Text = "";
                    cus_email.Text = "";
                    Member_FK.Text = "";


                }
                //...
                else if (result == DialogResult.No)
                {

                }
                else {

                }
                

            }
            else {
                MessageBox.Show("Select the Member ti delete ");
            }
        }

        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {
            values = "";
            //pass the values to the check empty method to check the values
            values =Member_FK.Text+","+ txtName.Text + "," + txtAddress.Text + "," + txtContact.Text + "," + cus_email.Text;
            //check the return values 
            if (instance.checkEmpty(values) == 0)
            {
                instance.CmdQuery("update MemberTable set Name='" + txtName.Text + "',Address='" + txtAddress.Text + "',Contact='" + txtContact.Text + "',Email='" + cus_email.Text + "' where id="+Convert.ToInt32(Member_FK.Text)+"");
                MessageBox.Show("Member is Sucessfully Updated in the Store");
            }
            else
            {
                MessageBox.Show("Must fill all values");
            }
            //reset the values 
            txtName.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            cus_email.Text = "";
            Member_FK.Text = "";

        }

        private void btnVideoIssue_Click(object sender, EventArgs e)
        {
            values = "";

            values =Movie_FK.Text+","+Member_FK;
            //check the filed is filled or not 
            if (instance.checkEmpty(values) == 0)
            {
                if (instance.checkStatusMovie(Convert.ToInt32(Movie_FK.Text)) == 0)
                {
                    if (instance.chkBooking(Member_FK.Text) < 2)
                    {
                        instance.CmdQuery("insert into BookingTable values('" + Movie_FK.Text + "','" + Member_FK.Text + "','" + BookingDate.Text + "','null')");
                        MessageBox.Show("Movie is booked ");
                    }
                    else {
                        MessageBox.Show("You can't book more movies");
                    }
                }
                else {
                    MessageBox.Show("All Copies are booked ");
                }
                
                
            }
            else {
                MessageBox.Show("select the Movie and Member");
            }


            //reset the values 
            txtName.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            cus_email.Text = "";
            Member_FK.Text = "";

            Movie_FK.Text = "";
            txtTitle.Text = "";
            txtRatting.Text = "";
            txtYear.Text = "";
            txtCost.Text = "";
            txtCopies.Text = "";
            txtGenre.Text = "";

            Rent_FK = 0;

        }

        private void Member_FK_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVideoDel_Click(object sender, EventArgs e)
        {

            //get the rental id and then confirm the deletion 
            if (Rent_FK>0) {
                DialogResult result = MessageBox.Show("Do you want to Delete the Member?", "Confirmation", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    instance.CmdQuery("delete from BookingTable where Rent_PK=" + Rent_FK + "");
                    MessageBox.Show("Record is deleted from movie ");
                }
                else {

                }


                //reset the values 
                txtName.Text = "";
                txtContact.Text = "";
                txtAddress.Text = "";
                cus_email.Text = "";
                Member_FK.Text = "";

                Movie_FK.Text = "";
                txtTitle.Text = "";
                txtRatting.Text = "";
                txtYear.Text = "";
                txtCost.Text = "";
                txtCopies.Text = "";
                txtGenre.Text = "";

                Rent_FK = 0;
            }
        }

        private void btnVideoADd_Click(object sender, EventArgs e)
        {
            //CODE TO ADD THe video in the 
            values = "";
            values = txtTitle.Text + "," + txtRatting.Text + "," + txtYear.Text + "," + txtCost.Text + "," + txtCopies.Text + "," + txtGenre.Text;
            if (instance.checkEmpty(values) == 0)
            {
                instance.CmdQuery("insert into MovieTable values('"+txtTitle.Text+"','"+txtRatting.Text+"','"+txtYear.Text+"','"+txtCost.Text+"','"+txtCopies.Text+"','"+txtGenre.Text+"')");
                MessageBox.Show("Movie is registered in the Portal ");

            }
            else {
                MessageBox.Show("Fill all values to register movie ");
            }


            //reset the values 
            txtName.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            cus_email.Text = "";
            Member_FK.Text = "";

            Movie_FK.Text = "";
            txtTitle.Text = "";
            txtRatting.Text = "";
            txtYear.Text = "";
            txtCost.Text = "";
            txtCopies.Text = "";
            txtGenre.Text = "";

            Rent_FK = 0;
        }

        private void btnVideoDelete_Click(object sender, EventArgs e)
        {
            values = "";
            values = Movie_FK.Text;
            if (instance.checkEmpty(values)==0) {
                DialogResult result = MessageBox.Show("Do you want to Delete the Member?", "Confirmation", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    if (instance.checkMovieStatus(Convert.ToInt32(Movie_FK.Text)) == 0)
                    {
                        instance.CmdQuery("delete from MovieTable where id=" + Convert.ToInt32(Movie_FK.Text) + "");
                        MessageBox.Show("Movie is deleted");
                    }
                    else {
                        MessageBox.Show("Movie is already booked ");
                    }
                    
                }
                else {
                    //do nothing 

                }
                
            }
            else{
                MessageBox.Show("Select the Movie to Delete ");
            }

            //reset the values 
            txtName.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            cus_email.Text = "";
            Member_FK.Text = "";

            Movie_FK.Text = "";
            txtTitle.Text = "";
            txtRatting.Text = "";
            txtYear.Text = "";
            txtCost.Text = "";
            txtCopies.Text = "";
            txtGenre.Text = "";

            Rent_FK = 0;

        }

        private void btnVideoUpdate_Click(object sender, EventArgs e)
        {
            //CODE TO update THe video in the 
            values = "";
            values = Movie_FK.Text + "," + txtTitle.Text + "," + txtRatting.Text + "," + txtYear.Text + "," + txtCost.Text + "," + txtCopies.Text + "," + txtGenre.Text;
            if (instance.checkEmpty(values)==0){

                    instance.CmdQuery("update  MovieTable set Title='" + txtTitle.Text + "',Ratting='" + txtRatting.Text + "',Year='" + txtYear.Text + "',Cost='" + txtCost.Text + "',Copies='" + txtCopies.Text + "',Genre='" + txtGenre.Text + "' where id="+Convert.ToInt32(Movie_FK.Text)+"");
                    MessageBox.Show("Movie record is updated in the Portal ");

                }
            else
            {

                MessageBox.Show("Fill all details and select the movie first");
            }

            //reset the values 
            txtName.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            cus_email.Text = "";
            Member_FK.Text = "";

            Movie_FK.Text = "";
            txtTitle.Text = "";
            txtRatting.Text = "";
            txtYear.Text = "";
            txtCost.Text = "";
            txtCopies.Text = "";
            txtGenre.Text = "";
            Rent_FK = 0;

        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            try {

                txtCost.Text = "" + instance.calcuateCharges(Convert.ToInt32(txtYear.Text));

            }
            catch (Exception ex) {

            }
        }

        private void rbCustomer_CheckedChanged(object sender, EventArgs e)
        {
            rbVideo.Checked = false;
            rbRent.Checked = false;

        }

        private void btnCustomerPanel_Click(object sender, EventArgs e)
        {
            //when we want to view the details of the Member then 
            if (rbCustomer.Checked == true)
            {
                instance.getMember(TableRecord);
            }
            else {
                MessageBox.Show("Select the Member Radio button First ");
            }

            
        }

        private void rbVideo_CheckedChanged(object sender, EventArgs e)
        {
            //reset the radio button 
            rbCustomer.Checked = false;
            rbRent.Checked = false;

        }

        private void btnVideoPanel_Click(object sender, EventArgs e)
        {
            //when we want to view the details of the Movie then 
            if (rbVideo.Checked == true)
            {
                instance.getMovie(TableRecord);
            }
            else
            {
                MessageBox.Show("Select the Movie Radio button First ");
            }

            
        }

        private void btnRentalPanel_Click(object sender, EventArgs e)
        {
            //when we want to view the details of the Rental then 
            if (rbRent.Checked == true)
            {
                instance.getBooking(TableRecord);
            }
            else
            {
                MessageBox.Show("Select the Rental Radio button First ");
            }

            
        }

        private void rbRent_CheckedChanged(object sender, EventArgs e)
        {
            rbCustomer.Checked = false;
            rbVideo.Checked = false;
        }

        private void btnVideoReturn_Click(object sender, EventArgs e)
        {
            if (Rent_FK > 0)
            {
                int bill = instance.billGenerate(Convert.ToInt32(Movie_FK.Text), BookingDate.Text);
            
                instance.CmdQuery("update BookingTable set Movie_FK='" + Movie_FK.Text + "',Member_FK='" + Member_FK.Text + "',IssueDate='" + BookingDate.Text + "',ReturnDate='"+ReturnDate.Text+"' where Rent_PK="+Rent_FK+"");
                MessageBox.Show("Your Bill is " + bill);
            }
            else {
                MessageBox.Show("select the video to return ");
            }


            //reset the values 
            txtName.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            cus_email.Text = "";
            Member_FK.Text = "";

            Movie_FK.Text = "";
            txtTitle.Text = "";
            txtRatting.Text = "";
            txtYear.Text = "";
            txtCost.Text = "";
            txtCopies.Text = "";
            txtGenre.Text = "";
            Rent_FK = 0;



        }

        private void btnBestVideo_Click(object sender, EventArgs e)
        {
            //compare the booking and fetch the most viewed movie
            DataTable tblData = new DataTable();
            tblData = instance.CmdRecord("select * from MovieTable ");
            int x = 0, y = 0, cunt = 0;
            String Title = "";
            for (x = 0; x < tblData.Rows.Count; x++)
            {
                DataTable tblData1 = new DataTable();
                tblData1 = instance.CmdRecord("select * from BookingTable where Movie_FK='" + tblData.Rows[x]["id"].ToString() + "'");

                if (tblData1.Rows.Count > cunt)
                {
                    Title = tblData.Rows[x]["Title"].ToString();
                    cunt = tblData1.Rows.Count;
                }

            }

            MessageBox.Show("Best Video is " + Title);



        }

        private void btnBestCustomer_Click(object sender, EventArgs e)
        {
            //compare the booking and fetch the best Member of the store
            DataTable tblData = new DataTable();
            tblData = instance.CmdRecord("select * from MemberTable ");
            int x = 0, y = 0, cunt = 0;
            String Name = "";
            for (x = 0; x < tblData.Rows.Count; x++)
            {
                DataTable tblData1 = new DataTable();
                tblData1 = instance.CmdRecord("select * from BookingTable where Member_FK='" + tblData.Rows[x]["id"].ToString() + "'");

                if (tblData1.Rows.Count > cunt)
                {
                    Name = tblData.Rows[x]["Name"].ToString();
                    cunt = tblData1.Rows.Count;
                }

            }

            MessageBox.Show("Best Member is " +Name);


        }

        private void TableRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void TableRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rbCustomer.Checked == true)
            {
                Member_FK.Text = TableRecord.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = TableRecord.CurrentRow.Cells[1].Value.ToString();
                txtAddress.Text = TableRecord.CurrentRow.Cells[2].Value.ToString();
                txtContact.Text = TableRecord.CurrentRow.Cells[3].Value.ToString();
                cus_email.Text = TableRecord.CurrentRow.Cells[4].Value.ToString();
            }
            if (rbVideo.Checked == true)
            {

                Movie_FK.Text = TableRecord.CurrentRow.Cells[0].Value.ToString();
                txtTitle.Text = TableRecord.CurrentRow.Cells[1].Value.ToString();
                txtRatting.Text = TableRecord.CurrentRow.Cells[2].Value.ToString();
                txtYear.Text = TableRecord.CurrentRow.Cells[3].Value.ToString();
                txtCost.Text = TableRecord.CurrentRow.Cells[4].Value.ToString();
                txtCopies.Text = TableRecord.CurrentRow.Cells[5].Value.ToString();
                txtGenre.Text = TableRecord.CurrentRow.Cells[6].Value.ToString();
            }
            if (rbRent.Checked == true)
            {
                Rent_FK = Convert.ToInt32(TableRecord.CurrentRow.Cells[0].Value.ToString());
                Movie_FK.Text = TableRecord.CurrentRow.Cells[1].Value.ToString();
                Member_FK.Text = TableRecord.CurrentRow.Cells[2].Value.ToString();
                BookingDate.Text = TableRecord.CurrentRow.Cells[3].Value.ToString();

            }


        }
    }
}
