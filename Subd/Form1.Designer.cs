
namespace Subd
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripOrders = new System.Windows.Forms.ToolStripButton();
            this.toolStripShowClients = new System.Windows.Forms.ToolStripButton();
            this.toolStripShowSales = new System.Windows.Forms.ToolStripButton();
            this.dataCars = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.dataKorzina = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdd_toKorzina = new System.Windows.Forms.Button();
            this.buttonDeleteTovar = new System.Windows.Forms.Button();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAllSum = new System.Windows.Forms.TextBox();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataKorzina)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripOrders,
            this.toolStripShowClients,
            this.toolStripShowSales});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(875, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripOrders
            // 
            this.toolStripOrders.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripOrders.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOrders.Name = "toolStripOrders";
            this.toolStripOrders.Size = new System.Drawing.Size(50, 22);
            this.toolStripOrders.Text = "Заказы";
            this.toolStripOrders.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripShowClients
            // 
            this.toolStripShowClients.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripShowClients.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripShowClients.Name = "toolStripShowClients";
            this.toolStripShowClients.Size = new System.Drawing.Size(59, 22);
            this.toolStripShowClients.Text = "Клиенты";
            this.toolStripShowClients.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripShowSales
            // 
            this.toolStripShowSales.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripShowSales.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripShowSales.Name = "toolStripShowSales";
            this.toolStripShowSales.Size = new System.Drawing.Size(62, 22);
            this.toolStripShowSales.Text = "Продажи";
            this.toolStripShowSales.Click += new System.EventHandler(this.toolStripShowSales_Click);
            // 
            // dataCars
            // 
            this.dataCars.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataCars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataCars.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataCars.BackgroundColor = System.Drawing.Color.White;
            this.dataCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCars.Location = new System.Drawing.Point(20, 74);
            this.dataCars.Margin = new System.Windows.Forms.Padding(2);
            this.dataCars.Name = "dataCars";
            this.dataCars.ReadOnly = true;
            this.dataCars.RowHeadersVisible = false;
            this.dataCars.RowHeadersWidth = 51;
            this.dataCars.RowTemplate.Height = 24;
            this.dataCars.Size = new System.Drawing.Size(833, 196);
            this.dataCars.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(151, 299);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(128, 45);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit.Location = new System.Drawing.Point(459, 299);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(108, 45);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // delete
            // 
            this.delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delete.Location = new System.Drawing.Point(589, 299);
            this.delete.Margin = new System.Windows.Forms.Padding(2);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(108, 45);
            this.delete.TabIndex = 5;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // dataKorzina
            // 
            this.dataKorzina.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataKorzina.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataKorzina.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataKorzina.BackgroundColor = System.Drawing.Color.White;
            this.dataKorzina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKorzina.Location = new System.Drawing.Point(20, 385);
            this.dataKorzina.Margin = new System.Windows.Forms.Padding(2);
            this.dataKorzina.Name = "dataKorzina";
            this.dataKorzina.ReadOnly = true;
            this.dataKorzina.RowHeadersVisible = false;
            this.dataKorzina.RowHeadersWidth = 51;
            this.dataKorzina.RowTemplate.Height = 24;
            this.dataKorzina.Size = new System.Drawing.Size(833, 196);
            this.dataKorzina.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 354);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Корзина";
            // 
            // buttonAdd_toKorzina
            // 
            this.buttonAdd_toKorzina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd_toKorzina.Location = new System.Drawing.Point(302, 299);
            this.buttonAdd_toKorzina.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd_toKorzina.Name = "buttonAdd_toKorzina";
            this.buttonAdd_toKorzina.Size = new System.Drawing.Size(128, 45);
            this.buttonAdd_toKorzina.TabIndex = 8;
            this.buttonAdd_toKorzina.Text = "Добавить в корзину";
            this.buttonAdd_toKorzina.UseVisualStyleBackColor = true;
            this.buttonAdd_toKorzina.Click += new System.EventHandler(this.buttonAdd_toKorzina_Click);
            // 
            // buttonDeleteTovar
            // 
            this.buttonDeleteTovar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteTovar.Location = new System.Drawing.Point(435, 612);
            this.buttonDeleteTovar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeleteTovar.Name = "buttonDeleteTovar";
            this.buttonDeleteTovar.Size = new System.Drawing.Size(166, 50);
            this.buttonDeleteTovar.TabIndex = 9;
            this.buttonDeleteTovar.Text = "Удалить товар с корзины";
            this.buttonDeleteTovar.UseVisualStyleBackColor = true;
            this.buttonDeleteTovar.Click += new System.EventHandler(this.buttonDeleteTovar_Click);
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearAll.Location = new System.Drawing.Point(637, 611);
            this.buttonClearAll.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(166, 50);
            this.buttonClearAll.TabIndex = 10;
            this.buttonClearAll.Text = "Очистить корзину";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 611);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Сумма всех товаров";
            // 
            // textBoxAllSum
            // 
            this.textBoxAllSum.Location = new System.Drawing.Point(20, 627);
            this.textBoxAllSum.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAllSum.Name = "textBoxAllSum";
            this.textBoxAllSum.Size = new System.Drawing.Size(105, 20);
            this.textBoxAllSum.TabIndex = 12;
            // 
            // buttonOrder
            // 
            this.buttonOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOrder.Location = new System.Drawing.Point(224, 612);
            this.buttonOrder.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(166, 50);
            this.buttonOrder.TabIndex = 13;
            this.buttonOrder.Text = "Сделать заказ";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(20, 40);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(112, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(206, 40);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(112, 21);
            this.comboBox2.TabIndex = 15;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 689);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.textBoxAllSum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonClearAll);
            this.Controls.Add(this.buttonDeleteTovar);
            this.Controls.Add(this.buttonAdd_toKorzina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataKorzina);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataCars);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Автомагазин(Список доступных машин)";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataKorzina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripShowClients;
        public System.Windows.Forms.DataGridView dataCars;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button delete;
        public System.Windows.Forms.DataGridView dataKorzina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd_toKorzina;
        private System.Windows.Forms.Button buttonDeleteTovar;
        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBoxAllSum;
        private System.Windows.Forms.Button buttonOrder;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ToolStripButton toolStripOrders;
        private System.Windows.Forms.ToolStripButton toolStripShowSales;
    }
}

