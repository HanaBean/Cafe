namespace Cafe
{
    partial class MainView
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            mnuAdditional = new ToolStripMenuItem();
            mnuCoupon = new ToolStripMenuItem();
            mnuReceipt = new ToolStripMenuItem();
            tpnlMain = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            btnOrder = new Button();
            pnlMainView = new Panel();
            panel1 = new Panel();
            lblHi = new Label();
            lblDate = new Label();
            lblManager = new Label();
            tmrNow = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            tpnlMain.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuAdditional });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(584, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuAdditional
            // 
            mnuAdditional.DropDownItems.AddRange(new ToolStripItem[] { mnuCoupon, mnuReceipt });
            mnuAdditional.Name = "mnuAdditional";
            mnuAdditional.Size = new Size(125, 20);
            mnuAdditional.Text = "Additional Function";
            // 
            // mnuCoupon
            // 
            mnuCoupon.Name = "mnuCoupon";
            mnuCoupon.Size = new Size(117, 22);
            mnuCoupon.Text = "Coupon";
            mnuCoupon.Click += ToolStripMenu_Click;
            // 
            // mnuReceipt
            // 
            mnuReceipt.Name = "mnuReceipt";
            mnuReceipt.Size = new Size(117, 22);
            mnuReceipt.Text = "Receipt";
            mnuReceipt.Click += ToolStripMenu_Click;
            // 
            // tpnlMain
            // 
            tpnlMain.ColumnCount = 1;
            tpnlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tpnlMain.Controls.Add(tableLayoutPanel2, 0, 1);
            tpnlMain.Controls.Add(pnlMainView, 0, 2);
            tpnlMain.Controls.Add(panel1, 0, 0);
            tpnlMain.Dock = DockStyle.Fill;
            tpnlMain.Location = new Point(0, 24);
            tpnlMain.Name = "tpnlMain";
            tpnlMain.RowCount = 3;
            tpnlMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tpnlMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tpnlMain.RowStyles.Add(new RowStyle(SizeType.Percent, 88.8888855F));
            tpnlMain.Size = new Size(584, 542);
            tpnlMain.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(button4, 3, 0);
            tableLayoutPanel2.Controls.Add(button3, 2, 0);
            tableLayoutPanel2.Controls.Add(button2, 1, 0);
            tableLayoutPanel2.Controls.Add(btnOrder, 0, 0);
            tableLayoutPanel2.Location = new Point(3, 33);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(578, 50);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Fill;
            button4.Location = new Point(435, 3);
            button4.Name = "button4";
            button4.Size = new Size(140, 44);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.Location = new Point(291, 3);
            button3.Name = "button3";
            button3.Size = new Size(138, 44);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(147, 3);
            button2.Name = "button2";
            button2.Size = new Size(138, 44);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            btnOrder.Dock = DockStyle.Fill;
            btnOrder.Location = new Point(3, 3);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(138, 44);
            btnOrder.TabIndex = 0;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += ButtonMenu_Click;
            // 
            // pnlMainView
            // 
            pnlMainView.Dock = DockStyle.Fill;
            pnlMainView.Location = new Point(3, 89);
            pnlMainView.Name = "pnlMainView";
            pnlMainView.Size = new Size(578, 450);
            pnlMainView.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblHi);
            panel1.Controls.Add(lblDate);
            panel1.Controls.Add(lblManager);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(578, 24);
            panel1.TabIndex = 2;
            // 
            // lblHi
            // 
            lblHi.AutoSize = true;
            lblHi.Location = new Point(65, 4);
            lblHi.Name = "lblHi";
            lblHi.Size = new Size(86, 15);
            lblHi.TabIndex = 2;
            lblHi.Text = "님 반갑습니다.";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(454, 4);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(121, 15);
            lblDate.TabIndex = 1;
            lblDate.Text = "2025.03.00 12:34:56";
            // 
            // lblManager
            // 
            lblManager.AutoSize = true;
            lblManager.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblManager.ForeColor = Color.MidnightBlue;
            lblManager.Location = new Point(9, 4);
            lblManager.Name = "lblManager";
            lblManager.Size = new Size(60, 15);
            lblManager.TabIndex = 0;
            lblManager.Text = "Manager";
            // 
            // tmrNow
            // 
            tmrNow.Enabled = true;
            tmrNow.Interval = 1000;
            tmrNow.Tick += tmrNow_Tick;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 566);
            Controls.Add(tpnlMain);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainView";
            Text = "Form2";
            FormClosing += MainView_FormClosing;
            Load += MainView_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tpnlMain.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private Panel pnlMain;
        private ToolStripMenuItem mnuAdditional;
        private ToolStripMenuItem mnuCoupon;
        private ToolStripMenuItem mnuReceipt;
        private TableLayoutPanel tpnlMain;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button btnOrder;
        private Panel pnlMainView;
        private Panel panel1;
        private Label lblDate;
        private Label lblManager;
        private System.Windows.Forms.Timer tmrNow;
        private Label lblHi;
    }
}