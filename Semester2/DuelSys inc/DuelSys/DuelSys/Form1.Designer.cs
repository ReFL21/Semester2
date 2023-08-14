
namespace DuelSys
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TabControl tabControl1;
            this.tPTournamnets = new System.Windows.Forms.TabPage();
            this.cBoxAvailible = new System.Windows.Forms.CheckBox();
            this.cBoxPending = new System.Windows.Forms.CheckBox();
            this.cBoxNonApplicable = new System.Windows.Forms.CheckBox();
            this.cBocFinished = new System.Windows.Forms.CheckBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.TournamentsGrid = new System.Windows.Forms.DataGridView();
            this.tPUpdateTournament = new System.Windows.Forms.TabPage();
            this.btnUpdateTournamnet = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.UendDate = new System.Windows.Forms.DateTimePicker();
            this.UstartDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbUMaxplayer = new System.Windows.Forms.TextBox();
            this.tbUMinplayers = new System.Windows.Forms.TextBox();
            this.tbUaddress = new System.Windows.Forms.TextBox();
            this.tbUCity = new System.Windows.Forms.TextBox();
            this.UTournamentGrid = new System.Windows.Forms.DataGridView();
            this.tPAddTournament = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.cbSport = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.staringdate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMaxPlayers = new System.Windows.Forms.TextBox();
            this.tbMinPlayers = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.btnAddTournament = new System.Windows.Forms.Button();
            this.tPStaff = new System.Windows.Forms.TabPage();
            this.btnDeleteStaff = new System.Windows.Forms.Button();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.StaffGrid = new System.Windows.Forms.DataGridView();
            this.tPSports = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdateSport = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbSWinningP = new System.Windows.Forms.TextBox();
            this.tbSName = new System.Windows.Forms.TextBox();
            this.btnDeleteSport = new System.Windows.Forms.Button();
            this.btnAddSport = new System.Windows.Forms.Button();
            this.SportGrid = new System.Windows.Forms.DataGridView();
            this.label17 = new System.Windows.Forms.Label();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabControl1.SuspendLayout();
            this.tPTournamnets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TournamentsGrid)).BeginInit();
            this.tPUpdateTournament.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UTournamentGrid)).BeginInit();
            this.tPAddTournament.SuspendLayout();
            this.tPStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffGrid)).BeginInit();
            this.tPSports.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SportGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(this.tPTournamnets);
            tabControl1.Controls.Add(this.tPUpdateTournament);
            tabControl1.Controls.Add(this.tPAddTournament);
            tabControl1.Controls.Add(this.tPStaff);
            tabControl1.Controls.Add(this.tPSports);
            tabControl1.Location = new System.Drawing.Point(1, 1);
            tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(924, 408);
            tabControl1.TabIndex = 0;
            // 
            // tPTournamnets
            // 
            this.tPTournamnets.Controls.Add(this.label17);
            this.tPTournamnets.Controls.Add(this.cBoxAvailible);
            this.tPTournamnets.Controls.Add(this.cBoxPending);
            this.tPTournamnets.Controls.Add(this.cBoxNonApplicable);
            this.tPTournamnets.Controls.Add(this.cBocFinished);
            this.tPTournamnets.Controls.Add(this.btnDelete);
            this.tPTournamnets.Controls.Add(this.TournamentsGrid);
            this.tPTournamnets.Location = new System.Drawing.Point(4, 24);
            this.tPTournamnets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tPTournamnets.Name = "tPTournamnets";
            this.tPTournamnets.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tPTournamnets.Size = new System.Drawing.Size(916, 380);
            this.tPTournamnets.TabIndex = 0;
            this.tPTournamnets.Text = "AllTournaments";
            this.tPTournamnets.UseVisualStyleBackColor = true;
            // 
            // cBoxAvailible
            // 
            this.cBoxAvailible.AutoSize = true;
            this.cBoxAvailible.Location = new System.Drawing.Point(731, 159);
            this.cBoxAvailible.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxAvailible.Name = "cBoxAvailible";
            this.cBoxAvailible.Size = new System.Drawing.Size(71, 19);
            this.cBoxAvailible.TabIndex = 5;
            this.cBoxAvailible.Text = "Availible";
            this.cBoxAvailible.UseVisualStyleBackColor = true;
            this.cBoxAvailible.CheckedChanged += new System.EventHandler(this.cBoxAvailible_CheckedChanged);
            // 
            // cBoxPending
            // 
            this.cBoxPending.AutoSize = true;
            this.cBoxPending.Location = new System.Drawing.Point(731, 118);
            this.cBoxPending.Name = "cBoxPending";
            this.cBoxPending.Size = new System.Drawing.Size(81, 19);
            this.cBoxPending.TabIndex = 4;
            this.cBoxPending.Text = "InProgress";
            this.cBoxPending.UseVisualStyleBackColor = true;
            this.cBoxPending.CheckedChanged += new System.EventHandler(this.cBoxPending_CheckedChanged);
            // 
            // cBoxNonApplicable
            // 
            this.cBoxNonApplicable.AutoSize = true;
            this.cBoxNonApplicable.Location = new System.Drawing.Point(731, 82);
            this.cBoxNonApplicable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxNonApplicable.Name = "cBoxNonApplicable";
            this.cBoxNonApplicable.Size = new System.Drawing.Size(112, 19);
            this.cBoxNonApplicable.TabIndex = 3;
            this.cBoxNonApplicable.Text = "NON Applicable";
            this.cBoxNonApplicable.UseVisualStyleBackColor = true;
            this.cBoxNonApplicable.CheckedChanged += new System.EventHandler(this.cBoxNonApplicable_CheckedChanged);
            // 
            // cBocFinished
            // 
            this.cBocFinished.AutoSize = true;
            this.cBocFinished.Location = new System.Drawing.Point(731, 49);
            this.cBocFinished.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBocFinished.Name = "cBocFinished";
            this.cBocFinished.Size = new System.Drawing.Size(70, 19);
            this.cBocFinished.TabIndex = 2;
            this.cBocFinished.Text = "Finished";
            this.cBocFinished.UseVisualStyleBackColor = true;
            this.cBocFinished.CheckedChanged += new System.EventHandler(this.cBocFinished_CheckedChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(32, 289);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 45);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete Tournament";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // TournamentsGrid
            // 
            this.TournamentsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TournamentsGrid.Location = new System.Drawing.Point(21, 25);
            this.TournamentsGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TournamentsGrid.MultiSelect = false;
            this.TournamentsGrid.Name = "TournamentsGrid";
            this.TournamentsGrid.ReadOnly = true;
            this.TournamentsGrid.RowHeadersWidth = 51;
            this.TournamentsGrid.RowTemplate.Height = 29;
            this.TournamentsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TournamentsGrid.Size = new System.Drawing.Size(668, 243);
            this.TournamentsGrid.TabIndex = 0;
            this.TournamentsGrid.DoubleClick += new System.EventHandler(this.TournamentsGrid_DoubleClick);
            // 
            // tPUpdateTournament
            // 
            this.tPUpdateTournament.Controls.Add(this.btnUpdateTournamnet);
            this.tPUpdateTournament.Controls.Add(this.label13);
            this.tPUpdateTournament.Controls.Add(this.label14);
            this.tPUpdateTournament.Controls.Add(this.UendDate);
            this.tPUpdateTournament.Controls.Add(this.UstartDate);
            this.tPUpdateTournament.Controls.Add(this.label9);
            this.tPUpdateTournament.Controls.Add(this.label10);
            this.tPUpdateTournament.Controls.Add(this.label11);
            this.tPUpdateTournament.Controls.Add(this.label12);
            this.tPUpdateTournament.Controls.Add(this.tbUMaxplayer);
            this.tPUpdateTournament.Controls.Add(this.tbUMinplayers);
            this.tPUpdateTournament.Controls.Add(this.tbUaddress);
            this.tPUpdateTournament.Controls.Add(this.tbUCity);
            this.tPUpdateTournament.Controls.Add(this.UTournamentGrid);
            this.tPUpdateTournament.Location = new System.Drawing.Point(4, 24);
            this.tPUpdateTournament.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tPUpdateTournament.Name = "tPUpdateTournament";
            this.tPUpdateTournament.Size = new System.Drawing.Size(916, 380);
            this.tPUpdateTournament.TabIndex = 2;
            this.tPUpdateTournament.Text = "Update Tournament";
            this.tPUpdateTournament.UseVisualStyleBackColor = true;
            // 
            // btnUpdateTournamnet
            // 
            this.btnUpdateTournamnet.Location = new System.Drawing.Point(22, 324);
            this.btnUpdateTournamnet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateTournamnet.Name = "btnUpdateTournamnet";
            this.btnUpdateTournamnet.Size = new System.Drawing.Size(115, 39);
            this.btnUpdateTournamnet.TabIndex = 22;
            this.btnUpdateTournamnet.Text = "Update";
            this.btnUpdateTournamnet.UseVisualStyleBackColor = true;
            this.btnUpdateTournamnet.Click += new System.EventHandler(this.btnUpdateTournamnet_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(577, 266);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 19);
            this.label13.TabIndex = 21;
            this.label13.Text = "End Date:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(545, 223);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 19);
            this.label14.TabIndex = 20;
            this.label14.Text = "Starting Date:";
            // 
            // UendDate
            // 
            this.UendDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UendDate.Location = new System.Drawing.Point(659, 261);
            this.UendDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UendDate.Name = "UendDate";
            this.UendDate.Size = new System.Drawing.Size(219, 26);
            this.UendDate.TabIndex = 19;
            // 
            // UstartDate
            // 
            this.UstartDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UstartDate.Location = new System.Drawing.Point(659, 218);
            this.UstartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UstartDate.Name = "UstartDate";
            this.UstartDate.Size = new System.Drawing.Size(219, 26);
            this.UstartDate.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(557, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "Max Players:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(560, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 19);
            this.label10.TabIndex = 16;
            this.label10.Text = "Min Players:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(584, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 19);
            this.label11.TabIndex = 15;
            this.label11.Text = "Address:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(612, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 19);
            this.label12.TabIndex = 14;
            this.label12.Text = "City:";
            // 
            // tbUMaxplayer
            // 
            this.tbUMaxplayer.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbUMaxplayer.Location = new System.Drawing.Point(659, 175);
            this.tbUMaxplayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUMaxplayer.Name = "tbUMaxplayer";
            this.tbUMaxplayer.Size = new System.Drawing.Size(180, 26);
            this.tbUMaxplayer.TabIndex = 13;
            // 
            // tbUMinplayers
            // 
            this.tbUMinplayers.Location = new System.Drawing.Point(659, 131);
            this.tbUMinplayers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUMinplayers.Name = "tbUMinplayers";
            this.tbUMinplayers.Size = new System.Drawing.Size(180, 23);
            this.tbUMinplayers.TabIndex = 12;
            // 
            // tbUaddress
            // 
            this.tbUaddress.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbUaddress.Location = new System.Drawing.Point(659, 87);
            this.tbUaddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUaddress.Name = "tbUaddress";
            this.tbUaddress.Size = new System.Drawing.Size(180, 26);
            this.tbUaddress.TabIndex = 11;
            // 
            // tbUCity
            // 
            this.tbUCity.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbUCity.Location = new System.Drawing.Point(659, 44);
            this.tbUCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUCity.Name = "tbUCity";
            this.tbUCity.Size = new System.Drawing.Size(180, 26);
            this.tbUCity.TabIndex = 10;
            // 
            // UTournamentGrid
            // 
            this.UTournamentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UTournamentGrid.Location = new System.Drawing.Point(22, 23);
            this.UTournamentGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UTournamentGrid.MultiSelect = false;
            this.UTournamentGrid.Name = "UTournamentGrid";
            this.UTournamentGrid.ReadOnly = true;
            this.UTournamentGrid.RowHeadersWidth = 51;
            this.UTournamentGrid.RowTemplate.Height = 29;
            this.UTournamentGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UTournamentGrid.Size = new System.Drawing.Size(476, 267);
            this.UTournamentGrid.TabIndex = 0;
            this.UTournamentGrid.DoubleClick += new System.EventHandler(this.UTournamentGrid_DoubleClick);
            // 
            // tPAddTournament
            // 
            this.tPAddTournament.Controls.Add(this.label8);
            this.tPAddTournament.Controls.Add(this.cbSport);
            this.tPAddTournament.Controls.Add(this.label7);
            this.tPAddTournament.Controls.Add(this.label6);
            this.tPAddTournament.Controls.Add(this.label5);
            this.tPAddTournament.Controls.Add(this.endDate);
            this.tPAddTournament.Controls.Add(this.staringdate);
            this.tPAddTournament.Controls.Add(this.label4);
            this.tPAddTournament.Controls.Add(this.label3);
            this.tPAddTournament.Controls.Add(this.label2);
            this.tPAddTournament.Controls.Add(this.label1);
            this.tPAddTournament.Controls.Add(this.tbMaxPlayers);
            this.tPAddTournament.Controls.Add(this.tbMinPlayers);
            this.tPAddTournament.Controls.Add(this.tbAddress);
            this.tPAddTournament.Controls.Add(this.tbCity);
            this.tPAddTournament.Controls.Add(this.rtbDescription);
            this.tPAddTournament.Controls.Add(this.btnAddTournament);
            this.tPAddTournament.Location = new System.Drawing.Point(4, 24);
            this.tPAddTournament.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tPAddTournament.Name = "tPAddTournament";
            this.tPAddTournament.Size = new System.Drawing.Size(916, 380);
            this.tPAddTournament.TabIndex = 3;
            this.tPAddTournament.Text = "Add Tournament";
            this.tPAddTournament.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(40, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Sports:";
            // 
            // cbSport
            // 
            this.cbSport.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbSport.FormattingEnabled = true;
            this.cbSport.Location = new System.Drawing.Point(104, 241);
            this.cbSport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSport.Name = "cbSport";
            this.cbSport.Size = new System.Drawing.Size(180, 27);
            this.cbSport.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(484, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "End Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(452, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Starting Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(480, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Description:";
            // 
            // endDate
            // 
            this.endDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.endDate.Location = new System.Drawing.Point(566, 108);
            this.endDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(219, 26);
            this.endDate.TabIndex = 11;
            // 
            // staringdate
            // 
            this.staringdate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.staringdate.Location = new System.Drawing.Point(566, 64);
            this.staringdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.staringdate.Name = "staringdate";
            this.staringdate.Size = new System.Drawing.Size(219, 26);
            this.staringdate.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Max Players:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(5, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Min Players:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(58, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "City:";
            // 
            // tbMaxPlayers
            // 
            this.tbMaxPlayers.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbMaxPlayers.Location = new System.Drawing.Point(104, 196);
            this.tbMaxPlayers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMaxPlayers.Name = "tbMaxPlayers";
            this.tbMaxPlayers.Size = new System.Drawing.Size(180, 26);
            this.tbMaxPlayers.TabIndex = 5;
            // 
            // tbMinPlayers
            // 
            this.tbMinPlayers.Location = new System.Drawing.Point(104, 152);
            this.tbMinPlayers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMinPlayers.Name = "tbMinPlayers";
            this.tbMinPlayers.Size = new System.Drawing.Size(180, 23);
            this.tbMinPlayers.TabIndex = 4;
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAddress.Location = new System.Drawing.Point(104, 108);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(180, 26);
            this.tbAddress.TabIndex = 3;
            // 
            // tbCity
            // 
            this.tbCity.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCity.Location = new System.Drawing.Point(104, 64);
            this.tbCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(180, 26);
            this.tbCity.TabIndex = 2;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(480, 171);
            this.rtbDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(305, 110);
            this.rtbDescription.TabIndex = 1;
            this.rtbDescription.Text = "";
            // 
            // btnAddTournament
            // 
            this.btnAddTournament.Location = new System.Drawing.Point(361, 317);
            this.btnAddTournament.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddTournament.Name = "btnAddTournament";
            this.btnAddTournament.Size = new System.Drawing.Size(119, 39);
            this.btnAddTournament.TabIndex = 0;
            this.btnAddTournament.Text = "Add Tournament";
            this.btnAddTournament.UseVisualStyleBackColor = true;
            this.btnAddTournament.Click += new System.EventHandler(this.btnAddTournament_Click);
            // 
            // tPStaff
            // 
            this.tPStaff.Controls.Add(this.btnDeleteStaff);
            this.tPStaff.Controls.Add(this.btnAddStaff);
            this.tPStaff.Controls.Add(this.StaffGrid);
            this.tPStaff.Location = new System.Drawing.Point(4, 24);
            this.tPStaff.Name = "tPStaff";
            this.tPStaff.Size = new System.Drawing.Size(916, 380);
            this.tPStaff.TabIndex = 4;
            this.tPStaff.Text = "Staff";
            this.tPStaff.UseVisualStyleBackColor = true;
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.Location = new System.Drawing.Point(261, 299);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(108, 40);
            this.btnDeleteStaff.TabIndex = 2;
            this.btnDeleteStaff.Text = "Delete Staff";
            this.btnDeleteStaff.UseVisualStyleBackColor = true;
            this.btnDeleteStaff.Click += new System.EventHandler(this.btnDeleteStaff_Click);
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Location = new System.Drawing.Point(85, 299);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(108, 40);
            this.btnAddStaff.TabIndex = 1;
            this.btnAddStaff.Text = "Add Staff";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // StaffGrid
            // 
            this.StaffGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffGrid.Location = new System.Drawing.Point(18, 21);
            this.StaffGrid.MultiSelect = false;
            this.StaffGrid.Name = "StaffGrid";
            this.StaffGrid.ReadOnly = true;
            this.StaffGrid.RowHeadersWidth = 51;
            this.StaffGrid.RowTemplate.Height = 25;
            this.StaffGrid.Size = new System.Drawing.Size(613, 228);
            this.StaffGrid.TabIndex = 0;
            // 
            // tPSports
            // 
            this.tPSports.Controls.Add(this.groupBox1);
            this.tPSports.Controls.Add(this.btnDeleteSport);
            this.tPSports.Controls.Add(this.btnAddSport);
            this.tPSports.Controls.Add(this.SportGrid);
            this.tPSports.Location = new System.Drawing.Point(4, 24);
            this.tPSports.Name = "tPSports";
            this.tPSports.Size = new System.Drawing.Size(916, 380);
            this.tPSports.TabIndex = 5;
            this.tPSports.Text = "Sports";
            this.tPSports.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdateSport);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.tbSWinningP);
            this.groupBox1.Controls.Add(this.tbSName);
            this.groupBox1.Location = new System.Drawing.Point(584, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(298, 212);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update:";
            // 
            // btnUpdateSport
            // 
            this.btnUpdateSport.Location = new System.Drawing.Point(14, 157);
            this.btnUpdateSport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateSport.Name = "btnUpdateSport";
            this.btnUpdateSport.Size = new System.Drawing.Size(252, 28);
            this.btnUpdateSport.TabIndex = 4;
            this.btnUpdateSport.Text = "Update";
            this.btnUpdateSport.UseVisualStyleBackColor = true;
            this.btnUpdateSport.Click += new System.EventHandler(this.btnUpdateSport_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(14, 86);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(113, 19);
            this.label16.TabIndex = 3;
            this.label16.Text = "Winning Points:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(14, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 19);
            this.label15.TabIndex = 2;
            this.label15.Text = "Name:";
            // 
            // tbSWinningP
            // 
            this.tbSWinningP.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSWinningP.Location = new System.Drawing.Point(14, 106);
            this.tbSWinningP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSWinningP.Name = "tbSWinningP";
            this.tbSWinningP.Size = new System.Drawing.Size(252, 26);
            this.tbSWinningP.TabIndex = 1;
            // 
            // tbSName
            // 
            this.tbSName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSName.Location = new System.Drawing.Point(14, 50);
            this.tbSName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSName.Name = "tbSName";
            this.tbSName.Size = new System.Drawing.Size(252, 26);
            this.tbSName.TabIndex = 0;
            // 
            // btnDeleteSport
            // 
            this.btnDeleteSport.Location = new System.Drawing.Point(206, 286);
            this.btnDeleteSport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteSport.Name = "btnDeleteSport";
            this.btnDeleteSport.Size = new System.Drawing.Size(108, 38);
            this.btnDeleteSport.TabIndex = 2;
            this.btnDeleteSport.Text = "Delete ";
            this.btnDeleteSport.UseVisualStyleBackColor = true;
            this.btnDeleteSport.Click += new System.EventHandler(this.btnDeleteSport_Click);
            // 
            // btnAddSport
            // 
            this.btnAddSport.Location = new System.Drawing.Point(57, 286);
            this.btnAddSport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddSport.Name = "btnAddSport";
            this.btnAddSport.Size = new System.Drawing.Size(108, 38);
            this.btnAddSport.TabIndex = 1;
            this.btnAddSport.Text = "Add Sport";
            this.btnAddSport.UseVisualStyleBackColor = true;
            this.btnAddSport.Click += new System.EventHandler(this.btnAddSport_Click);
            // 
            // SportGrid
            // 
            this.SportGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SportGrid.Location = new System.Drawing.Point(32, 32);
            this.SportGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SportGrid.Name = "SportGrid";
            this.SportGrid.ReadOnly = true;
            this.SportGrid.RowHeadersWidth = 51;
            this.SportGrid.RowTemplate.Height = 29;
            this.SportGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SportGrid.Size = new System.Drawing.Size(500, 201);
            this.SportGrid.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(588, 360);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(322, 17);
            this.label17.TabIndex = 6;
            this.label17.Text = "*Double click on a tournamnet to see the matches ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 411);
            this.Controls.Add(tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            tabControl1.ResumeLayout(false);
            this.tPTournamnets.ResumeLayout(false);
            this.tPTournamnets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TournamentsGrid)).EndInit();
            this.tPUpdateTournament.ResumeLayout(false);
            this.tPUpdateTournament.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UTournamentGrid)).EndInit();
            this.tPAddTournament.ResumeLayout(false);
            this.tPAddTournament.PerformLayout();
            this.tPStaff.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StaffGrid)).EndInit();
            this.tPSports.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SportGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tPTournamnets;
        private System.Windows.Forms.DataGridView TournamentsGrid;
        private System.Windows.Forms.CheckBox cBoxNonApplicable;
        private System.Windows.Forms.CheckBox cBocFinished;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TabPage tPUpdateTournament;
        private System.Windows.Forms.TabPage tPAddTournament;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.DateTimePicker staringdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMaxPlayers;
        private System.Windows.Forms.TextBox tbMinPlayers;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Button btnAddTournament;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbSport;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView UTournamentGrid;
        private System.Windows.Forms.TabPage tPStaff;
        private System.Windows.Forms.Button btnDeleteStaff;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.DataGridView StaffGrid;
        private System.Windows.Forms.CheckBox cBoxPending;
        private System.Windows.Forms.TabPage tPSports;
        private System.Windows.Forms.CheckBox cBoxAvailible;
        private System.Windows.Forms.DataGridView SportGrid;
        private System.Windows.Forms.Button btnUpdateTournamnet;
        public System.Windows.Forms.TextBox tbUMaxplayer;
        public System.Windows.Forms.TextBox tbUMinplayers;
        public System.Windows.Forms.TextBox tbUaddress;
        public System.Windows.Forms.TextBox tbUCity;
        public System.Windows.Forms.DateTimePicker UstartDate;
        public System.Windows.Forms.DateTimePicker UendDate;
        private System.Windows.Forms.Button btnDeleteSport;
        private System.Windows.Forms.Button btnAddSport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdateSport;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbSWinningP;
        private System.Windows.Forms.TextBox tbSName;
        private System.Windows.Forms.Label label17;
    }
}

