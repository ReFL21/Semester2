
namespace SynthesisAssignment
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tPRent = new System.Windows.Forms.TabPage();
            this.btnRefreshrentGrid = new System.Windows.Forms.Button();
            this.btnViewAllInspections = new System.Windows.Forms.Button();
            this.btnFinishrent = new System.Windows.Forms.Button();
            this.btnInspection = new System.Windows.Forms.Button();
            this.RentGrid = new System.Windows.Forms.DataGridView();
            this.tPLocation = new System.Windows.Forms.TabPage();
            this.btnLocationGridRefresh = new System.Windows.Forms.Button();
            this.btnDeleteLocation = new System.Windows.Forms.Button();
            this.btnEditLocation = new System.Windows.Forms.Button();
            this.btnAddLocation = new System.Windows.Forms.Button();
            this.LocationGrid = new System.Windows.Forms.DataGridView();
            this.tPEmployee = new System.Windows.Forms.TabPage();
            this.btnEmpGridRefresh = new System.Windows.Forms.Button();
            this.btnDeleteEmp = new System.Windows.Forms.Button();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.EmployeeGrid = new System.Windows.Forms.DataGridView();
            this.tPBoats = new System.Windows.Forms.TabPage();
            this.btnRefreshGrid = new System.Windows.Forms.Button();
            this.btnDeleteBoat = new System.Windows.Forms.Button();
            this.btnAddBoatForm = new System.Windows.Forms.Button();
            this.ContentGrid = new System.Windows.Forms.DataGridView();
            this.tPItems = new System.Windows.Forms.TabPage();
            this.btnRefreshItemsGrid = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.ItemsGrid = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tPRent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RentGrid)).BeginInit();
            this.tPLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LocationGrid)).BeginInit();
            this.tPEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGrid)).BeginInit();
            this.tPBoats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContentGrid)).BeginInit();
            this.tPItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tPRent);
            this.tabControl1.Controls.Add(this.tPLocation);
            this.tabControl1.Controls.Add(this.tPEmployee);
            this.tabControl1.Controls.Add(this.tPBoats);
            this.tabControl1.Controls.Add(this.tPItems);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(843, 476);
            this.tabControl1.TabIndex = 0;
            // 
            // tPRent
            // 
            this.tPRent.Controls.Add(this.btnRefreshrentGrid);
            this.tPRent.Controls.Add(this.btnViewAllInspections);
            this.tPRent.Controls.Add(this.btnFinishrent);
            this.tPRent.Controls.Add(this.btnInspection);
            this.tPRent.Controls.Add(this.RentGrid);
            this.tPRent.Location = new System.Drawing.Point(4, 29);
            this.tPRent.Name = "tPRent";
            this.tPRent.Padding = new System.Windows.Forms.Padding(3);
            this.tPRent.Size = new System.Drawing.Size(835, 443);
            this.tPRent.TabIndex = 0;
            this.tPRent.Text = "Rent";
            this.tPRent.UseVisualStyleBackColor = true;
            // 
            // btnRefreshrentGrid
            // 
            this.btnRefreshrentGrid.Location = new System.Drawing.Point(237, 323);
            this.btnRefreshrentGrid.Name = "btnRefreshrentGrid";
            this.btnRefreshrentGrid.Size = new System.Drawing.Size(121, 58);
            this.btnRefreshrentGrid.TabIndex = 4;
            this.btnRefreshrentGrid.Text = "Refresh Grid";
            this.btnRefreshrentGrid.UseVisualStyleBackColor = true;
            this.btnRefreshrentGrid.Click += new System.EventHandler(this.btnRefreshrentGrid_Click);
            // 
            // btnViewAllInspections
            // 
            this.btnViewAllInspections.Location = new System.Drawing.Point(376, 323);
            this.btnViewAllInspections.Name = "btnViewAllInspections";
            this.btnViewAllInspections.Size = new System.Drawing.Size(121, 58);
            this.btnViewAllInspections.TabIndex = 3;
            this.btnViewAllInspections.Text = "View All Inspetions";
            this.btnViewAllInspections.UseVisualStyleBackColor = true;
            this.btnViewAllInspections.Click += new System.EventHandler(this.btnViewAllInspections_Click);
            // 
            // btnFinishrent
            // 
            this.btnFinishrent.Location = new System.Drawing.Point(520, 322);
            this.btnFinishrent.Name = "btnFinishrent";
            this.btnFinishrent.Size = new System.Drawing.Size(121, 59);
            this.btnFinishrent.TabIndex = 2;
            this.btnFinishrent.Text = "Finish Rent";
            this.btnFinishrent.UseVisualStyleBackColor = true;
            this.btnFinishrent.Click += new System.EventHandler(this.btnFinishrent_Click);
            // 
            // btnInspection
            // 
            this.btnInspection.Location = new System.Drawing.Point(665, 322);
            this.btnInspection.Name = "btnInspection";
            this.btnInspection.Size = new System.Drawing.Size(121, 59);
            this.btnInspection.TabIndex = 1;
            this.btnInspection.Text = "Create Inspection";
            this.btnInspection.UseVisualStyleBackColor = true;
            this.btnInspection.Click += new System.EventHandler(this.btnInspection_Click);
            // 
            // RentGrid
            // 
            this.RentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentGrid.Location = new System.Drawing.Point(187, 27);
            this.RentGrid.MultiSelect = false;
            this.RentGrid.Name = "RentGrid";
            this.RentGrid.ReadOnly = true;
            this.RentGrid.RowHeadersWidth = 51;
            this.RentGrid.RowTemplate.Height = 29;
            this.RentGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RentGrid.Size = new System.Drawing.Size(599, 247);
            this.RentGrid.TabIndex = 0;
            this.RentGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RentGrid_CellContentClick);
            // 
            // tPLocation
            // 
            this.tPLocation.Controls.Add(this.btnLocationGridRefresh);
            this.tPLocation.Controls.Add(this.btnDeleteLocation);
            this.tPLocation.Controls.Add(this.btnEditLocation);
            this.tPLocation.Controls.Add(this.btnAddLocation);
            this.tPLocation.Controls.Add(this.LocationGrid);
            this.tPLocation.Location = new System.Drawing.Point(4, 29);
            this.tPLocation.Name = "tPLocation";
            this.tPLocation.Padding = new System.Windows.Forms.Padding(3);
            this.tPLocation.Size = new System.Drawing.Size(835, 443);
            this.tPLocation.TabIndex = 1;
            this.tPLocation.Text = "Location";
            this.tPLocation.UseVisualStyleBackColor = true;
            // 
            // btnLocationGridRefresh
            // 
            this.btnLocationGridRefresh.Location = new System.Drawing.Point(29, 339);
            this.btnLocationGridRefresh.Name = "btnLocationGridRefresh";
            this.btnLocationGridRefresh.Size = new System.Drawing.Size(162, 56);
            this.btnLocationGridRefresh.TabIndex = 4;
            this.btnLocationGridRefresh.Text = "Refresh";
            this.btnLocationGridRefresh.UseVisualStyleBackColor = true;
            this.btnLocationGridRefresh.Click += new System.EventHandler(this.btnLocationGridRefresh_Click);
            // 
            // btnDeleteLocation
            // 
            this.btnDeleteLocation.Location = new System.Drawing.Point(29, 248);
            this.btnDeleteLocation.Name = "btnDeleteLocation";
            this.btnDeleteLocation.Size = new System.Drawing.Size(162, 61);
            this.btnDeleteLocation.TabIndex = 3;
            this.btnDeleteLocation.Text = "Delete Location";
            this.btnDeleteLocation.UseVisualStyleBackColor = true;
            this.btnDeleteLocation.Click += new System.EventHandler(this.btnDeleteLocation_Click);
            // 
            // btnEditLocation
            // 
            this.btnEditLocation.Location = new System.Drawing.Point(29, 152);
            this.btnEditLocation.Name = "btnEditLocation";
            this.btnEditLocation.Size = new System.Drawing.Size(162, 60);
            this.btnEditLocation.TabIndex = 2;
            this.btnEditLocation.Text = "Edit Location";
            this.btnEditLocation.UseVisualStyleBackColor = true;
            this.btnEditLocation.Click += new System.EventHandler(this.btnEditLocation_Click);
            // 
            // btnAddLocation
            // 
            this.btnAddLocation.Location = new System.Drawing.Point(29, 63);
            this.btnAddLocation.Name = "btnAddLocation";
            this.btnAddLocation.Size = new System.Drawing.Size(162, 62);
            this.btnAddLocation.TabIndex = 1;
            this.btnAddLocation.Text = "Add location";
            this.btnAddLocation.UseVisualStyleBackColor = true;
            this.btnAddLocation.Click += new System.EventHandler(this.btnAddLocation_Click);
            // 
            // LocationGrid
            // 
            this.LocationGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LocationGrid.Location = new System.Drawing.Point(246, 30);
            this.LocationGrid.Name = "LocationGrid";
            this.LocationGrid.RowHeadersWidth = 51;
            this.LocationGrid.RowTemplate.Height = 29;
            this.LocationGrid.Size = new System.Drawing.Size(548, 279);
            this.LocationGrid.TabIndex = 0;
            // 
            // tPEmployee
            // 
            this.tPEmployee.Controls.Add(this.btnEmpGridRefresh);
            this.tPEmployee.Controls.Add(this.btnDeleteEmp);
            this.tPEmployee.Controls.Add(this.btnAddEmp);
            this.tPEmployee.Controls.Add(this.EmployeeGrid);
            this.tPEmployee.Location = new System.Drawing.Point(4, 29);
            this.tPEmployee.Name = "tPEmployee";
            this.tPEmployee.Size = new System.Drawing.Size(835, 443);
            this.tPEmployee.TabIndex = 2;
            this.tPEmployee.Text = "Employee";
            this.tPEmployee.UseVisualStyleBackColor = true;
            // 
            // btnEmpGridRefresh
            // 
            this.btnEmpGridRefresh.Location = new System.Drawing.Point(45, 266);
            this.btnEmpGridRefresh.Name = "btnEmpGridRefresh";
            this.btnEmpGridRefresh.Size = new System.Drawing.Size(158, 40);
            this.btnEmpGridRefresh.TabIndex = 3;
            this.btnEmpGridRefresh.Text = "Refresh";
            this.btnEmpGridRefresh.UseVisualStyleBackColor = true;
            this.btnEmpGridRefresh.Click += new System.EventHandler(this.btnEmpGridRefresh_Click);
            // 
            // btnDeleteEmp
            // 
            this.btnDeleteEmp.Location = new System.Drawing.Point(45, 178);
            this.btnDeleteEmp.Name = "btnDeleteEmp";
            this.btnDeleteEmp.Size = new System.Drawing.Size(158, 49);
            this.btnDeleteEmp.TabIndex = 2;
            this.btnDeleteEmp.Text = "Delete Employee";
            this.btnDeleteEmp.UseVisualStyleBackColor = true;
            this.btnDeleteEmp.Click += new System.EventHandler(this.btnDeleteEmp_Click);
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Location = new System.Drawing.Point(45, 82);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(158, 47);
            this.btnAddEmp.TabIndex = 1;
            this.btnAddEmp.Text = "Add Employee";
            this.btnAddEmp.UseVisualStyleBackColor = true;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // EmployeeGrid
            // 
            this.EmployeeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeGrid.Location = new System.Drawing.Point(284, 36);
            this.EmployeeGrid.MultiSelect = false;
            this.EmployeeGrid.Name = "EmployeeGrid";
            this.EmployeeGrid.ReadOnly = true;
            this.EmployeeGrid.RowHeadersWidth = 51;
            this.EmployeeGrid.RowTemplate.Height = 29;
            this.EmployeeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployeeGrid.Size = new System.Drawing.Size(531, 239);
            this.EmployeeGrid.TabIndex = 0;
            // 
            // tPBoats
            // 
            this.tPBoats.Controls.Add(this.btnRefreshGrid);
            this.tPBoats.Controls.Add(this.btnDeleteBoat);
            this.tPBoats.Controls.Add(this.btnAddBoatForm);
            this.tPBoats.Controls.Add(this.ContentGrid);
            this.tPBoats.Location = new System.Drawing.Point(4, 29);
            this.tPBoats.Name = "tPBoats";
            this.tPBoats.Size = new System.Drawing.Size(835, 443);
            this.tPBoats.TabIndex = 3;
            this.tPBoats.Text = "Boats";
            this.tPBoats.UseVisualStyleBackColor = true;
            // 
            // btnRefreshGrid
            // 
            this.btnRefreshGrid.Location = new System.Drawing.Point(371, 326);
            this.btnRefreshGrid.Name = "btnRefreshGrid";
            this.btnRefreshGrid.Size = new System.Drawing.Size(121, 58);
            this.btnRefreshGrid.TabIndex = 3;
            this.btnRefreshGrid.Text = "Refresh";
            this.btnRefreshGrid.UseVisualStyleBackColor = true;
            this.btnRefreshGrid.Click += new System.EventHandler(this.btnRefreshGrid_Click);
            // 
            // btnDeleteBoat
            // 
            this.btnDeleteBoat.Location = new System.Drawing.Point(217, 325);
            this.btnDeleteBoat.Name = "btnDeleteBoat";
            this.btnDeleteBoat.Size = new System.Drawing.Size(121, 59);
            this.btnDeleteBoat.TabIndex = 2;
            this.btnDeleteBoat.Text = "Delete Boat";
            this.btnDeleteBoat.UseVisualStyleBackColor = true;
            this.btnDeleteBoat.Click += new System.EventHandler(this.btnDeleteBoat_Click);
            // 
            // btnAddBoatForm
            // 
            this.btnAddBoatForm.Location = new System.Drawing.Point(33, 325);
            this.btnAddBoatForm.Name = "btnAddBoatForm";
            this.btnAddBoatForm.Size = new System.Drawing.Size(121, 59);
            this.btnAddBoatForm.TabIndex = 1;
            this.btnAddBoatForm.Text = "Add Boat";
            this.btnAddBoatForm.UseVisualStyleBackColor = true;
            this.btnAddBoatForm.Click += new System.EventHandler(this.btnAddBoatForm_Click);
            // 
            // ContentGrid
            // 
            this.ContentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContentGrid.Location = new System.Drawing.Point(33, 28);
            this.ContentGrid.Name = "ContentGrid";
            this.ContentGrid.RowHeadersWidth = 51;
            this.ContentGrid.RowTemplate.Height = 29;
            this.ContentGrid.Size = new System.Drawing.Size(755, 220);
            this.ContentGrid.TabIndex = 0;
            // 
            // tPItems
            // 
            this.tPItems.Controls.Add(this.btnRefreshItemsGrid);
            this.tPItems.Controls.Add(this.btnDeleteItem);
            this.tPItems.Controls.Add(this.btnAddItem);
            this.tPItems.Controls.Add(this.ItemsGrid);
            this.tPItems.Location = new System.Drawing.Point(4, 29);
            this.tPItems.Name = "tPItems";
            this.tPItems.Padding = new System.Windows.Forms.Padding(3);
            this.tPItems.Size = new System.Drawing.Size(835, 443);
            this.tPItems.TabIndex = 4;
            this.tPItems.Text = "Items";
            this.tPItems.UseVisualStyleBackColor = true;
            // 
            // btnRefreshItemsGrid
            // 
            this.btnRefreshItemsGrid.Location = new System.Drawing.Point(424, 343);
            this.btnRefreshItemsGrid.Name = "btnRefreshItemsGrid";
            this.btnRefreshItemsGrid.Size = new System.Drawing.Size(129, 56);
            this.btnRefreshItemsGrid.TabIndex = 4;
            this.btnRefreshItemsGrid.Text = "Refresh";
            this.btnRefreshItemsGrid.UseVisualStyleBackColor = true;
            this.btnRefreshItemsGrid.Click += new System.EventHandler(this.btnRefreshItemsGrid_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(240, 342);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(129, 57);
            this.btnDeleteItem.TabIndex = 3;
            this.btnDeleteItem.Text = "Delete Item";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(65, 342);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(129, 57);
            this.btnAddItem.TabIndex = 2;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // ItemsGrid
            // 
            this.ItemsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsGrid.Location = new System.Drawing.Point(29, 30);
            this.ItemsGrid.Name = "ItemsGrid";
            this.ItemsGrid.RowHeadersWidth = 51;
            this.ItemsGrid.RowTemplate.Height = 29;
            this.ItemsGrid.Size = new System.Drawing.Size(755, 219);
            this.ItemsGrid.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 492);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tPRent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RentGrid)).EndInit();
            this.tPLocation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LocationGrid)).EndInit();
            this.tPEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGrid)).EndInit();
            this.tPBoats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ContentGrid)).EndInit();
            this.tPItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnInspection;
        private System.Windows.Forms.Button btnDeleteLocation;
        private System.Windows.Forms.Button btnEditLocation;
        private System.Windows.Forms.Button btnAddLocation;
        private System.Windows.Forms.DataGridView LocationGrid;
        private System.Windows.Forms.Button btnDeleteEmp;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.DataGridView EmployeeGrid;
        private System.Windows.Forms.DataGridView ContentGrid;
        private System.Windows.Forms.Button btnAddBoatForm;
        private System.Windows.Forms.Button btnDeleteBoat;
        private System.Windows.Forms.DataGridView ItemsGrid;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnAddItem;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tPRent;
        public System.Windows.Forms.TabPage tPLocation;
        public System.Windows.Forms.TabPage tPEmployee;
        public System.Windows.Forms.TabPage tPBoats;
        public System.Windows.Forms.TabPage tPItems;
        public System.Windows.Forms.DataGridView RentGrid;
        private System.Windows.Forms.Button btnEmpGridRefresh;
        private System.Windows.Forms.Button btnLocationGridRefresh;
        private System.Windows.Forms.Button btnRefreshGrid;
        private System.Windows.Forms.Button btnRefreshItemsGrid;
        private System.Windows.Forms.Button btnFinishrent;
        private System.Windows.Forms.Button btnViewAllInspections;
        private System.Windows.Forms.Button btnRefreshrentGrid;
    }
}

