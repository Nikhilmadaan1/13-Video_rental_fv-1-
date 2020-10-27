namespace Video_rental_fv
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBestVideo = new System.Windows.Forms.Button();
            this.btnVideoUpdate = new System.Windows.Forms.Button();
            this.btnVideoDelete = new System.Windows.Forms.Button();
            this.btnVideoADd = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCopies = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRatting = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnBestCustomer = new System.Windows.Forms.Button();
            this.btnCustomerUpdate = new System.Windows.Forms.Button();
            this.btnCustomerDelete = new System.Windows.Forms.Button();
            this.btnCustomerAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnVideoDel = new System.Windows.Forms.Button();
            this.btnVideoReturn = new System.Windows.Forms.Button();
            this.btnVideoIssue = new System.Windows.Forms.Button();
            this.ReturnDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.BookingDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TableRecord = new System.Windows.Forms.DataGridView();
            this.rbRent = new System.Windows.Forms.RadioButton();
            this.rbVideo = new System.Windows.Forms.RadioButton();
            this.rbCustomer = new System.Windows.Forms.RadioButton();
            this.btnRentalPanel = new System.Windows.Forms.Button();
            this.btnVideoPanel = new System.Windows.Forms.Button();
            this.btnCustomerPanel = new System.Windows.Forms.Button();
            this.Member_FK = new System.Windows.Forms.TextBox();
            this.Movie_FK = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cus_email = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TableRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBestVideo
            // 
            this.btnBestVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBestVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBestVideo.ForeColor = System.Drawing.Color.White;
            this.btnBestVideo.Location = new System.Drawing.Point(176, 233);
            this.btnBestVideo.Name = "btnBestVideo";
            this.btnBestVideo.Size = new System.Drawing.Size(158, 36);
            this.btnBestVideo.TabIndex = 35;
            this.btnBestVideo.Text = "Best Video";
            this.btnBestVideo.UseVisualStyleBackColor = false;
            this.btnBestVideo.Click += new System.EventHandler(this.btnBestVideo_Click);
            // 
            // btnVideoUpdate
            // 
            this.btnVideoUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVideoUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideoUpdate.ForeColor = System.Drawing.Color.White;
            this.btnVideoUpdate.Location = new System.Drawing.Point(12, 233);
            this.btnVideoUpdate.Name = "btnVideoUpdate";
            this.btnVideoUpdate.Size = new System.Drawing.Size(158, 36);
            this.btnVideoUpdate.TabIndex = 34;
            this.btnVideoUpdate.Text = "Video Update";
            this.btnVideoUpdate.UseVisualStyleBackColor = false;
            this.btnVideoUpdate.Click += new System.EventHandler(this.btnVideoUpdate_Click);
            // 
            // btnVideoDelete
            // 
            this.btnVideoDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVideoDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideoDelete.ForeColor = System.Drawing.Color.White;
            this.btnVideoDelete.Location = new System.Drawing.Point(180, 191);
            this.btnVideoDelete.Name = "btnVideoDelete";
            this.btnVideoDelete.Size = new System.Drawing.Size(158, 36);
            this.btnVideoDelete.TabIndex = 33;
            this.btnVideoDelete.Text = "Video Delete";
            this.btnVideoDelete.UseVisualStyleBackColor = false;
            this.btnVideoDelete.Click += new System.EventHandler(this.btnVideoDelete_Click);
            // 
            // btnVideoADd
            // 
            this.btnVideoADd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVideoADd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideoADd.ForeColor = System.Drawing.Color.White;
            this.btnVideoADd.Location = new System.Drawing.Point(12, 191);
            this.btnVideoADd.Name = "btnVideoADd";
            this.btnVideoADd.Size = new System.Drawing.Size(158, 36);
            this.btnVideoADd.TabIndex = 24;
            this.btnVideoADd.Text = "Video Add";
            this.btnVideoADd.UseVisualStyleBackColor = false;
            this.btnVideoADd.Click += new System.EventHandler(this.btnVideoADd_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(180, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 19);
            this.label9.TabIndex = 32;
            this.label9.Text = "Genre";
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(183, 150);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(155, 20);
            this.txtGenre.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(180, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 19);
            this.label8.TabIndex = 30;
            this.label8.Text = "Copies";
            // 
            // txtCopies
            // 
            this.txtCopies.Location = new System.Drawing.Point(183, 95);
            this.txtCopies.Name = "txtCopies";
            this.txtCopies.Size = new System.Drawing.Size(155, 20);
            this.txtCopies.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(180, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 19);
            this.label7.TabIndex = 28;
            this.label7.Text = "Cost";
            // 
            // txtCost
            // 
            this.txtCost.Enabled = false;
            this.txtCost.Location = new System.Drawing.Point(183, 46);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(155, 20);
            this.txtCost.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 19);
            this.label6.TabIndex = 26;
            this.label6.Text = "Year";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(17, 150);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(155, 20);
            this.txtYear.TabIndex = 25;
            this.txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "Ratting";
            // 
            // txtRatting
            // 
            this.txtRatting.Location = new System.Drawing.Point(18, 95);
            this.txtRatting.Name = "txtRatting";
            this.txtRatting.Size = new System.Drawing.Size(155, 20);
            this.txtRatting.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(15, 46);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(155, 20);
            this.txtTitle.TabIndex = 20;
            // 
            // btnBestCustomer
            // 
            this.btnBestCustomer.BackColor = System.Drawing.Color.Teal;
            this.btnBestCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBestCustomer.ForeColor = System.Drawing.Color.White;
            this.btnBestCustomer.Location = new System.Drawing.Point(430, 315);
            this.btnBestCustomer.Name = "btnBestCustomer";
            this.btnBestCustomer.Size = new System.Drawing.Size(171, 30);
            this.btnBestCustomer.TabIndex = 45;
            this.btnBestCustomer.Text = "Best Customer";
            this.btnBestCustomer.UseVisualStyleBackColor = false;
            this.btnBestCustomer.Click += new System.EventHandler(this.btnBestCustomer_Click);
            // 
            // btnCustomerUpdate
            // 
            this.btnCustomerUpdate.BackColor = System.Drawing.Color.Teal;
            this.btnCustomerUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerUpdate.ForeColor = System.Drawing.Color.White;
            this.btnCustomerUpdate.Location = new System.Drawing.Point(401, 286);
            this.btnCustomerUpdate.Name = "btnCustomerUpdate";
            this.btnCustomerUpdate.Size = new System.Drawing.Size(171, 30);
            this.btnCustomerUpdate.TabIndex = 44;
            this.btnCustomerUpdate.Text = "Customer Update";
            this.btnCustomerUpdate.UseVisualStyleBackColor = false;
            this.btnCustomerUpdate.Click += new System.EventHandler(this.btnCustomerUpdate_Click);
            // 
            // btnCustomerDelete
            // 
            this.btnCustomerDelete.BackColor = System.Drawing.Color.Teal;
            this.btnCustomerDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerDelete.ForeColor = System.Drawing.Color.White;
            this.btnCustomerDelete.Location = new System.Drawing.Point(401, 250);
            this.btnCustomerDelete.Name = "btnCustomerDelete";
            this.btnCustomerDelete.Size = new System.Drawing.Size(171, 30);
            this.btnCustomerDelete.TabIndex = 43;
            this.btnCustomerDelete.Text = "Customer Delete";
            this.btnCustomerDelete.UseVisualStyleBackColor = false;
            this.btnCustomerDelete.Click += new System.EventHandler(this.btnCustomerDelete_Click);
            // 
            // btnCustomerAdd
            // 
            this.btnCustomerAdd.BackColor = System.Drawing.Color.Teal;
            this.btnCustomerAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerAdd.ForeColor = System.Drawing.Color.White;
            this.btnCustomerAdd.Location = new System.Drawing.Point(401, 214);
            this.btnCustomerAdd.Name = "btnCustomerAdd";
            this.btnCustomerAdd.Size = new System.Drawing.Size(171, 30);
            this.btnCustomerAdd.TabIndex = 40;
            this.btnCustomerAdd.Text = "Customer Add";
            this.btnCustomerAdd.UseVisualStyleBackColor = false;
            this.btnCustomerAdd.Click += new System.EventHandler(this.btnCustomerAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(397, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 42;
            this.label3.Text = "Contact";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(397, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 41;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(397, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 39;
            this.label1.Text = "Name";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(400, 143);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(155, 20);
            this.txtContact.TabIndex = 38;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(400, 95);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(155, 20);
            this.txtAddress.TabIndex = 37;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(400, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(155, 20);
            this.txtName.TabIndex = 36;
            // 
            // btnVideoDel
            // 
            this.btnVideoDel.BackColor = System.Drawing.Color.Teal;
            this.btnVideoDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideoDel.ForeColor = System.Drawing.Color.White;
            this.btnVideoDel.Location = new System.Drawing.Point(622, 250);
            this.btnVideoDel.Name = "btnVideoDel";
            this.btnVideoDel.Size = new System.Drawing.Size(179, 30);
            this.btnVideoDel.TabIndex = 54;
            this.btnVideoDel.Text = "Delete";
            this.btnVideoDel.UseVisualStyleBackColor = false;
            this.btnVideoDel.Click += new System.EventHandler(this.btnVideoDel_Click);
            // 
            // btnVideoReturn
            // 
            this.btnVideoReturn.BackColor = System.Drawing.Color.Teal;
            this.btnVideoReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideoReturn.ForeColor = System.Drawing.Color.White;
            this.btnVideoReturn.Location = new System.Drawing.Point(622, 214);
            this.btnVideoReturn.Name = "btnVideoReturn";
            this.btnVideoReturn.Size = new System.Drawing.Size(179, 30);
            this.btnVideoReturn.TabIndex = 53;
            this.btnVideoReturn.Text = "Return";
            this.btnVideoReturn.UseVisualStyleBackColor = false;
            this.btnVideoReturn.Click += new System.EventHandler(this.btnVideoReturn_Click);
            // 
            // btnVideoIssue
            // 
            this.btnVideoIssue.BackColor = System.Drawing.Color.Teal;
            this.btnVideoIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideoIssue.ForeColor = System.Drawing.Color.White;
            this.btnVideoIssue.Location = new System.Drawing.Point(622, 178);
            this.btnVideoIssue.Name = "btnVideoIssue";
            this.btnVideoIssue.Size = new System.Drawing.Size(179, 30);
            this.btnVideoIssue.TabIndex = 52;
            this.btnVideoIssue.Text = "Issue";
            this.btnVideoIssue.UseVisualStyleBackColor = false;
            this.btnVideoIssue.Click += new System.EventHandler(this.btnVideoIssue_Click);
            // 
            // ReturnDate
            // 
            this.ReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ReturnDate.Location = new System.Drawing.Point(723, 146);
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.Size = new System.Drawing.Size(102, 20);
            this.ReturnDate.TabIndex = 51;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(613, 150);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 19);
            this.label13.TabIndex = 50;
            this.label13.Text = "Return Date";
            // 
            // BookingDate
            // 
            this.BookingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BookingDate.Location = new System.Drawing.Point(723, 112);
            this.BookingDate.Name = "BookingDate";
            this.BookingDate.Size = new System.Drawing.Size(102, 20);
            this.BookingDate.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(613, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 19);
            this.label11.TabIndex = 48;
            this.label11.Text = "Booking Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(617, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 19);
            this.label12.TabIndex = 47;
            this.label12.Text = "Customer ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(618, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 19);
            this.label10.TabIndex = 46;
            this.label10.Text = "Video ID";
            // 
            // TableRecord
            // 
            this.TableRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableRecord.Location = new System.Drawing.Point(13, 351);
            this.TableRecord.Name = "TableRecord";
            this.TableRecord.Size = new System.Drawing.Size(825, 192);
            this.TableRecord.TabIndex = 55;
            this.TableRecord.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableRecord_CellClick);
            this.TableRecord.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableRecord_CellContentClick);
            // 
            // rbRent
            // 
            this.rbRent.AutoSize = true;
            this.rbRent.BackColor = System.Drawing.Color.Teal;
            this.rbRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRent.ForeColor = System.Drawing.Color.White;
            this.rbRent.Location = new System.Drawing.Point(630, 300);
            this.rbRent.Name = "rbRent";
            this.rbRent.Size = new System.Drawing.Size(65, 20);
            this.rbRent.TabIndex = 61;
            this.rbRent.TabStop = true;
            this.rbRent.Text = "Rental";
            this.rbRent.UseVisualStyleBackColor = false;
            this.rbRent.CheckedChanged += new System.EventHandler(this.rbRent_CheckedChanged);
            // 
            // rbVideo
            // 
            this.rbVideo.AutoSize = true;
            this.rbVideo.BackColor = System.Drawing.Color.Teal;
            this.rbVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVideo.ForeColor = System.Drawing.Color.White;
            this.rbVideo.Location = new System.Drawing.Point(232, 300);
            this.rbVideo.Name = "rbVideo";
            this.rbVideo.Size = new System.Drawing.Size(62, 20);
            this.rbVideo.TabIndex = 60;
            this.rbVideo.TabStop = true;
            this.rbVideo.Text = "Video";
            this.rbVideo.UseVisualStyleBackColor = false;
            this.rbVideo.CheckedChanged += new System.EventHandler(this.rbVideo_CheckedChanged);
            // 
            // rbCustomer
            // 
            this.rbCustomer.AutoSize = true;
            this.rbCustomer.BackColor = System.Drawing.Color.Teal;
            this.rbCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCustomer.ForeColor = System.Drawing.Color.White;
            this.rbCustomer.Location = new System.Drawing.Point(18, 300);
            this.rbCustomer.Name = "rbCustomer";
            this.rbCustomer.Size = new System.Drawing.Size(83, 20);
            this.rbCustomer.TabIndex = 59;
            this.rbCustomer.TabStop = true;
            this.rbCustomer.Text = "Customer";
            this.rbCustomer.UseVisualStyleBackColor = false;
            this.rbCustomer.CheckedChanged += new System.EventHandler(this.rbCustomer_CheckedChanged);
            // 
            // btnRentalPanel
            // 
            this.btnRentalPanel.BackColor = System.Drawing.Color.Teal;
            this.btnRentalPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentalPanel.ForeColor = System.Drawing.Color.White;
            this.btnRentalPanel.Location = new System.Drawing.Point(630, 317);
            this.btnRentalPanel.Name = "btnRentalPanel";
            this.btnRentalPanel.Size = new System.Drawing.Size(171, 30);
            this.btnRentalPanel.TabIndex = 58;
            this.btnRentalPanel.Text = "Rental Panel";
            this.btnRentalPanel.UseVisualStyleBackColor = false;
            this.btnRentalPanel.Click += new System.EventHandler(this.btnRentalPanel_Click);
            // 
            // btnVideoPanel
            // 
            this.btnVideoPanel.BackColor = System.Drawing.Color.Teal;
            this.btnVideoPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideoPanel.ForeColor = System.Drawing.Color.White;
            this.btnVideoPanel.Location = new System.Drawing.Point(232, 317);
            this.btnVideoPanel.Name = "btnVideoPanel";
            this.btnVideoPanel.Size = new System.Drawing.Size(171, 30);
            this.btnVideoPanel.TabIndex = 57;
            this.btnVideoPanel.Text = "Video Panel";
            this.btnVideoPanel.UseVisualStyleBackColor = false;
            this.btnVideoPanel.Click += new System.EventHandler(this.btnVideoPanel_Click);
            // 
            // btnCustomerPanel
            // 
            this.btnCustomerPanel.BackColor = System.Drawing.Color.Teal;
            this.btnCustomerPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerPanel.ForeColor = System.Drawing.Color.White;
            this.btnCustomerPanel.Location = new System.Drawing.Point(13, 315);
            this.btnCustomerPanel.Name = "btnCustomerPanel";
            this.btnCustomerPanel.Size = new System.Drawing.Size(171, 30);
            this.btnCustomerPanel.TabIndex = 56;
            this.btnCustomerPanel.Text = "Customer Panel";
            this.btnCustomerPanel.UseVisualStyleBackColor = false;
            this.btnCustomerPanel.Click += new System.EventHandler(this.btnCustomerPanel_Click);
            // 
            // Member_FK
            // 
            this.Member_FK.Location = new System.Drawing.Point(704, 83);
            this.Member_FK.Name = "Member_FK";
            this.Member_FK.Size = new System.Drawing.Size(155, 20);
            this.Member_FK.TabIndex = 62;
            this.Member_FK.TextChanged += new System.EventHandler(this.Member_FK_TextChanged);
            // 
            // Movie_FK
            // 
            this.Movie_FK.Location = new System.Drawing.Point(704, 46);
            this.Movie_FK.Name = "Movie_FK";
            this.Movie_FK.Size = new System.Drawing.Size(155, 20);
            this.Movie_FK.TabIndex = 63;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(113, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 24);
            this.label14.TabIndex = 64;
            this.label14.Text = "Video ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(502, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 24);
            this.label15.TabIndex = 65;
            this.label15.Text = "Customer";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(719, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 24);
            this.label16.TabIndex = 66;
            this.label16.Text = "Rental";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(400, 166);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 19);
            this.label17.TabIndex = 68;
            this.label17.Text = "Email";
            // 
            // cus_email
            // 
            this.cus_email.Location = new System.Drawing.Point(403, 189);
            this.cus_email.Name = "cus_email";
            this.cus_email.Size = new System.Drawing.Size(155, 20);
            this.cus_email.TabIndex = 67;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(871, 555);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cus_email);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Movie_FK);
            this.Controls.Add(this.Member_FK);
            this.Controls.Add(this.rbRent);
            this.Controls.Add(this.rbVideo);
            this.Controls.Add(this.rbCustomer);
            this.Controls.Add(this.btnRentalPanel);
            this.Controls.Add(this.btnVideoPanel);
            this.Controls.Add(this.btnCustomerPanel);
            this.Controls.Add(this.TableRecord);
            this.Controls.Add(this.btnVideoDel);
            this.Controls.Add(this.btnVideoReturn);
            this.Controls.Add(this.btnVideoIssue);
            this.Controls.Add(this.ReturnDate);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.BookingDate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnBestCustomer);
            this.Controls.Add(this.btnCustomerUpdate);
            this.Controls.Add(this.btnCustomerDelete);
            this.Controls.Add(this.btnCustomerAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnBestVideo);
            this.Controls.Add(this.btnVideoUpdate);
            this.Controls.Add(this.btnVideoDelete);
            this.Controls.Add(this.btnVideoADd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCopies);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRatting);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TableRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBestVideo;
        private System.Windows.Forms.Button btnVideoUpdate;
        private System.Windows.Forms.Button btnVideoDelete;
        private System.Windows.Forms.Button btnVideoADd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCopies;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRatting;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnBestCustomer;
        private System.Windows.Forms.Button btnCustomerUpdate;
        private System.Windows.Forms.Button btnCustomerDelete;
        private System.Windows.Forms.Button btnCustomerAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnVideoDel;
        private System.Windows.Forms.Button btnVideoReturn;
        private System.Windows.Forms.Button btnVideoIssue;
        private System.Windows.Forms.DateTimePicker ReturnDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker BookingDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView TableRecord;
        private System.Windows.Forms.RadioButton rbRent;
        private System.Windows.Forms.RadioButton rbVideo;
        private System.Windows.Forms.RadioButton rbCustomer;
        private System.Windows.Forms.Button btnRentalPanel;
        private System.Windows.Forms.Button btnVideoPanel;
        private System.Windows.Forms.Button btnCustomerPanel;
        private System.Windows.Forms.TextBox Member_FK;
        private System.Windows.Forms.TextBox Movie_FK;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox cus_email;
    }
}

