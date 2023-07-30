
namespace Subd
{
    partial class FormSales
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
            this.dataSales = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataSales)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSales
            // 
            this.dataSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataSales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataSales.BackgroundColor = System.Drawing.Color.White;
            this.dataSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataSales.GridColor = System.Drawing.Color.Gray;
            this.dataSales.Location = new System.Drawing.Point(0, 0);
            this.dataSales.Margin = new System.Windows.Forms.Padding(2);
            this.dataSales.Name = "dataSales";
            this.dataSales.ReadOnly = true;
            this.dataSales.RowHeadersVisible = false;
            this.dataSales.RowHeadersWidth = 51;
            this.dataSales.RowTemplate.Height = 24;
            this.dataSales.Size = new System.Drawing.Size(686, 448);
            this.dataSales.TabIndex = 4;
            // 
            // FormSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 448);
            this.Controls.Add(this.dataSales);
            this.Name = "FormSales";
            this.Text = "Продажи";
            this.Load += new System.EventHandler(this.FormSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataSales;
    }
}