
namespace SynthesisAssignment
{
    partial class RentedProducts
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
            this.RentedProductsGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.RentedProductsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // RentedProductsGrid
            // 
            this.RentedProductsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentedProductsGrid.Location = new System.Drawing.Point(65, 55);
            this.RentedProductsGrid.Name = "RentedProductsGrid";
            this.RentedProductsGrid.RowHeadersWidth = 51;
            this.RentedProductsGrid.RowTemplate.Height = 29;
            this.RentedProductsGrid.Size = new System.Drawing.Size(601, 231);
            this.RentedProductsGrid.TabIndex = 0;
            // 
            // RentedProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RentedProductsGrid);
            this.Name = "RentedProducts";
            this.Text = "Rented Products";
            this.Load += new System.EventHandler(this.RentedProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RentedProductsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView RentedProductsGrid;
    }
}