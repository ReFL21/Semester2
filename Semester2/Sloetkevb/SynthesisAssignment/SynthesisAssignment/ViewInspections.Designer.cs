
namespace SynthesisAssignment
{
    partial class ViewInspections
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
            this.InspectionsGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.InspectionsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // InspectionsGrid
            // 
            this.InspectionsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InspectionsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InspectionsGrid.Location = new System.Drawing.Point(76, 35);
            this.InspectionsGrid.MultiSelect = false;
            this.InspectionsGrid.Name = "InspectionsGrid";
            this.InspectionsGrid.ReadOnly = true;
            this.InspectionsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.InspectionsGrid.RowTemplate.Height = 29;
            this.InspectionsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InspectionsGrid.Size = new System.Drawing.Size(603, 276);
            this.InspectionsGrid.TabIndex = 0;
            // 
            // ViewInspections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 374);
            this.Controls.Add(this.InspectionsGrid);
            this.Name = "ViewInspections";
            this.Text = "ViewInspections";
            this.Load += new System.EventHandler(this.ViewInspections_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InspectionsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView InspectionsGrid;
    }
}