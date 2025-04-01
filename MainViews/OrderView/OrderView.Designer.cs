namespace Cafe
{
    partial class OrderView
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
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            listViewItems = new ListView();
            columnHeaderNo = new ColumnHeader();
            columnHeaderMenu = new ColumnHeader();
            columnHeaderQty = new ColumnHeader();
            columnHeaderPrice = new ColumnHeader();
            panel2 = new Panel();
            textBox1 = new TextBox();
            button4 = new Button();
            button1 = new Button();
            label1 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            btnCard = new Button();
            btnCash = new Button();
            btnCancelAll = new Button();
            btnCancelMenu = new Button();
            tabControl1 = new TabControl();
            tabCoffee = new TabPage();
            tabTea = new TabPage();
            tabDessert = new TabPage();
            tabOthers = new TabPage();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(578, 450);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(578, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(listViewItems, 0, 0);
            tableLayoutPanel2.Controls.Add(panel2, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 62.5287361F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 37.4712639F));
            tableLayoutPanel2.Size = new Size(283, 444);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // listViewItems
            // 
            listViewItems.Columns.AddRange(new ColumnHeader[] { columnHeaderNo, columnHeaderMenu, columnHeaderQty, columnHeaderPrice });
            listViewItems.Dock = DockStyle.Fill;
            listViewItems.GridLines = true;
            listViewItems.Location = new Point(3, 3);
            listViewItems.Name = "listViewItems";
            listViewItems.Size = new Size(277, 271);
            listViewItems.TabIndex = 0;
            listViewItems.UseCompatibleStateImageBehavior = false;
            listViewItems.View = View.Details;
            // 
            // columnHeaderNo
            // 
            columnHeaderNo.Text = "No";
            columnHeaderNo.TextAlign = HorizontalAlignment.Center;
            columnHeaderNo.Width = 30;
            // 
            // columnHeaderMenu
            // 
            columnHeaderMenu.Text = "Menu";
            columnHeaderMenu.TextAlign = HorizontalAlignment.Center;
            columnHeaderMenu.Width = 120;
            // 
            // columnHeaderQty
            // 
            columnHeaderQty.Text = "Qty";
            columnHeaderQty.TextAlign = HorizontalAlignment.Center;
            columnHeaderQty.Width = 40;
            // 
            // columnHeaderPrice
            // 
            columnHeaderPrice.Text = "Price";
            columnHeaderPrice.TextAlign = HorizontalAlignment.Center;
            columnHeaderPrice.Width = 85;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 280);
            panel2.Name = "panel2";
            panel2.Size = new Size(277, 161);
            panel2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(101, 10);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(46, 23);
            textBox1.TabIndex = 3;
            // 
            // button4
            // 
            button4.Location = new Point(156, 9);
            button4.Name = "button4";
            button4.Size = new Size(45, 23);
            button4.TabIndex = 2;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(50, 10);
            button1.Name = "button1";
            button1.Size = new Size(45, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 14);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "수량";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel3.Controls.Add(tabControl1, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(292, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel3.Size = new Size(283, 444);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.Controls.Add(btnCard, 3, 0);
            tableLayoutPanel4.Controls.Add(btnCash, 2, 0);
            tableLayoutPanel4.Controls.Add(btnCancelAll, 1, 0);
            tableLayoutPanel4.Controls.Add(btnCancelMenu, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 367);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(277, 74);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // btnCard
            // 
            btnCard.Location = new Point(210, 3);
            btnCard.Name = "btnCard";
            btnCard.Size = new Size(61, 44);
            btnCard.TabIndex = 3;
            btnCard.Text = "Card";
            btnCard.UseVisualStyleBackColor = true;
            // 
            // btnCash
            // 
            btnCash.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCash.Location = new Point(141, 3);
            btnCash.Name = "btnCash";
            btnCash.Size = new Size(61, 44);
            btnCash.TabIndex = 2;
            btnCash.Text = "Cash";
            btnCash.UseVisualStyleBackColor = true;
            // 
            // btnCancelAll
            // 
            btnCancelAll.Location = new Point(72, 3);
            btnCancelAll.Name = "btnCancelAll";
            btnCancelAll.Size = new Size(61, 44);
            btnCancelAll.TabIndex = 1;
            btnCancelAll.Text = "All Cancel";
            btnCancelAll.UseVisualStyleBackColor = true;
            // 
            // btnCancelMenu
            // 
            btnCancelMenu.Location = new Point(3, 3);
            btnCancelMenu.Name = "btnCancelMenu";
            btnCancelMenu.Size = new Size(61, 44);
            btnCancelMenu.TabIndex = 0;
            btnCancelMenu.Text = "Menu Cancel";
            btnCancelMenu.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabCoffee);
            tabControl1.Controls.Add(tabTea);
            tabControl1.Controls.Add(tabDessert);
            tabControl1.Controls.Add(tabOthers);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(277, 358);
            tabControl1.TabIndex = 1;
            // 
            // tabCoffee
            // 
            tabCoffee.Location = new Point(4, 24);
            tabCoffee.Name = "tabCoffee";
            tabCoffee.Padding = new Padding(3);
            tabCoffee.Size = new Size(269, 330);
            tabCoffee.TabIndex = 0;
            tabCoffee.Text = "Coffee";
            tabCoffee.UseVisualStyleBackColor = true;
            // 
            // tabTea
            // 
            tabTea.Location = new Point(4, 24);
            tabTea.Name = "tabTea";
            tabTea.Padding = new Padding(3);
            tabTea.Size = new Size(269, 330);
            tabTea.TabIndex = 1;
            tabTea.Text = "Tea";
            tabTea.UseVisualStyleBackColor = true;
            // 
            // tabDessert
            // 
            tabDessert.Location = new Point(4, 24);
            tabDessert.Name = "tabDessert";
            tabDessert.Padding = new Padding(3);
            tabDessert.Size = new Size(269, 330);
            tabDessert.TabIndex = 2;
            tabDessert.Text = "Dessert";
            tabDessert.UseVisualStyleBackColor = true;
            // 
            // tabOthers
            // 
            tabOthers.Location = new Point(4, 24);
            tabOthers.Name = "tabOthers";
            tabOthers.Size = new Size(269, 330);
            tabOthers.TabIndex = 3;
            tabOthers.Text = "others";
            tabOthers.UseVisualStyleBackColor = true;
            // 
            // OrderView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrderView";
            Text = "주문";
            Load += OrderView_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private ListView listViewItems;
        private ColumnHeader columnHeaderMenu;
        private ColumnHeader columnHeaderQty;
        private ColumnHeader columnHeaderPrice;
        private TableLayoutPanel tableLayoutPanel4;
        private Button btnCard;
        private Button btnCash;
        private Button btnCancelAll;
        private Button btnCancelMenu;
        private TabControl tabControl1;
        private TabPage tabCoffee;
        private TabPage tabTea;
        private TabPage tabDessert;
        private Panel panel2;
        private Label label1;
        private Button button4;
        private Button button1;
        private TextBox textBox1;
        private TabPage tabOthers;
        private ColumnHeader columnHeaderNo;
    }
}
