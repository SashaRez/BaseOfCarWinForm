
namespace Subd
{
    partial class FormOrder
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
            this.tableOrder = new System.Windows.Forms.DataGridView();
            this.dataOrder = new System.Windows.Forms.DataGridView();
            this.buttonAcceptOrder = new System.Windows.Forms.Button();
            this.buttonDeleteOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // tableOrder
            // 
            this.tableOrder.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tableOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableOrder.Location = new System.Drawing.Point(0, 0);
            this.tableOrder.Margin = new System.Windows.Forms.Padding(2);
            this.tableOrder.Name = "tableOrder";
            this.tableOrder.RowHeadersWidth = 51;
            this.tableOrder.RowTemplate.Height = 24;
            this.tableOrder.Size = new System.Drawing.Size(571, 227);
            this.tableOrder.TabIndex = 0;
            // 
            // dataOrder
            // 
            this.dataOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataOrder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataOrder.BackgroundColor = System.Drawing.Color.White;
            this.dataOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOrder.GridColor = System.Drawing.Color.Gray;
            this.dataOrder.Location = new System.Drawing.Point(0, 0);
            this.dataOrder.Margin = new System.Windows.Forms.Padding(2);
            this.dataOrder.Name = "dataOrder";
            this.dataOrder.ReadOnly = true;
            this.dataOrder.RowHeadersVisible = false;
            this.dataOrder.RowHeadersWidth = 51;
            this.dataOrder.RowTemplate.Height = 24;
            this.dataOrder.Size = new System.Drawing.Size(571, 123);
            this.dataOrder.TabIndex = 2;
            // 
            // buttonAcceptOrder
            // 
            this.buttonAcceptOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAcceptOrder.Location = new System.Drawing.Point(116, 151);
            this.buttonAcceptOrder.Name = "buttonAcceptOrder";
            this.buttonAcceptOrder.Size = new System.Drawing.Size(135, 42);
            this.buttonAcceptOrder.TabIndex = 3;
            this.buttonAcceptOrder.Text = "Оплатить заказ";
            this.buttonAcceptOrder.UseVisualStyleBackColor = true;
            this.buttonAcceptOrder.Click += new System.EventHandler(this.buttonAcceptOrder_Click);
            // 
            // buttonDeleteOrder
            // 
            this.buttonDeleteOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteOrder.Location = new System.Drawing.Point(317, 151);
            this.buttonDeleteOrder.Name = "buttonDeleteOrder";
            this.buttonDeleteOrder.Size = new System.Drawing.Size(135, 42);
            this.buttonDeleteOrder.TabIndex = 4;
            this.buttonDeleteOrder.Text = "Отменить заказ";
            this.buttonDeleteOrder.UseVisualStyleBackColor = true;
            this.buttonDeleteOrder.Click += new System.EventHandler(this.buttonDeleteOrder_Click);
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 227);
            this.Controls.Add(this.buttonDeleteOrder);
            this.Controls.Add(this.buttonAcceptOrder);
            this.Controls.Add(this.dataOrder);
            this.Controls.Add(this.tableOrder);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormOrder";
            this.Text = "Заказы";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tableOrder;
        public System.Windows.Forms.DataGridView dataOrder;
        private System.Windows.Forms.Button buttonAcceptOrder;
        private System.Windows.Forms.Button buttonDeleteOrder;
    }
}