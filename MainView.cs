using Cafe.AdditionalViews;
using Cafe.zGlobal;

namespace Cafe
{
    public partial class MainView : Form
    {

        Panel panel = null;
        private Form currentSubForm = null;

        public MainView()
        {
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e)
        {

            panel = new Panel { Dock = DockStyle.Fill, Parent = pnlMainView };
            lblManager.Text = Global.loginUser;

            //초기 기본 화면
            ShowSubForm(new OrderView());
            this.Text = "Order";


        }

        #region Page Click Event
        private void ToolStripMenu_Click(object sender, EventArgs e)
        {
            OpenView(sender, e);

        }

        private void ButtonMenu_Click(object sender, EventArgs e)
        {
            OpenView(sender, e);
        }

        private void OpenView(object sender, EventArgs e)
        {
            string menuName = "";
            string menuText = "";

            if (sender is ToolStripMenuItem toolStripMenuItem)
            {
                var menuItem = sender as ToolStripMenuItem;
                if (menuItem != null)
                {
                    menuName = menuItem.Name;
                    menuText = menuItem.Text;
                }
            }
            else if (sender is Button button)
            {
                var menuItem = sender as Button;
                if (menuItem != null)
                {
                    menuName = menuItem.Name;
                    menuText = menuItem.Text;
                }
            }

            if (string.IsNullOrEmpty(menuName)) return;

            Form subForm = GetSubForm(menuName); // Take the form selected
            if (subForm == null) return;

            ShowSubForm(subForm);
            this.Text = menuText;
            panel.BringToFront();
            this.Refresh();

        }
        #endregion

        #region SubForm
        private Form GetSubForm(string menuItemName)
        {
            switch (menuItemName)
            {
                //MainViews
                case "btnInventory":
                    return new InventoryView();

                case "btnMember":
                    return new MemberView();

                case "btnOrder":
                    return new OrderView();

                case "btnSales":
                    return new SalesView();

                //Additional Views
                case "mnuReceipt":
                    return new ReceiptView();

                case "mnuCoupon":
                //return new ReceiptView();


                default:
                    return null;
            }
        }

        private void ShowSubForm(Form subForm)
        {
            if (currentSubForm != null) // Old Form removed
            {
                currentSubForm.Hide();
                panel.Controls.Remove(currentSubForm);
                currentSubForm.Dispose();
            }

            currentSubForm = subForm;
            subForm.Dock = DockStyle.Fill;
            subForm.TopLevel = false;
            subForm.SuspendLayout(); // 폼의 변경을 즉각 반영하지 않겠다. 변경을 한번에 적용하기 위해서 일시 멈추는 듯 함.
            panel.Controls.Add(subForm);
            subForm.Show();
            subForm.ResumeLayout(false); // 일시정지 해제.
        }
        #endregion



        #region Form Closing Event
        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("프로그램을 종료하시겠습니까?", "종료", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;

            }
            else
            {
                Environment.Exit(0); // 프로세스 종료
            }
        }
        #endregion

        private void tmrNow_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss");
        }
    }
}
