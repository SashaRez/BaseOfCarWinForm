
namespace Subd
{
    partial class ClientsForm
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
            this.dataClients = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataClients)).BeginInit();
            this.SuspendLayout();
            // 
            // dataClients
            // 
            this.dataClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataClients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataClients.BackgroundColor = System.Drawing.Color.White;
            this.dataClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataClients.GridColor = System.Drawing.Color.Gray;
            this.dataClients.Location = new System.Drawing.Point(0, 0);
            this.dataClients.Margin = new System.Windows.Forms.Padding(2);
            this.dataClients.Name = "dataClients";
            this.dataClients.ReadOnly = true;
            this.dataClients.RowHeadersVisible = false;
            this.dataClients.RowHeadersWidth = 51;
            this.dataClients.RowTemplate.Height = 24;
            this.dataClients.Size = new System.Drawing.Size(523, 126);
            this.dataClients.TabIndex = 3;
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 122);
            this.Controls.Add(this.dataClients);
            this.Name = "ClientsForm";
            this.Text = "Клиенты";
            this.Load += new System.EventHandler(this.ClientsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataClients;
    }
}