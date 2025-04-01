using Cafe.MainViews.OrderView;
using Dapper;
using Microsoft.VisualBasic.ApplicationServices;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Windows.Forms;

namespace Cafe
{
    public partial class OrderView : Form, IOrderView
    {
        List<MenuItem> menuItemList = new List<MenuItem>();
        OrderPresenter orderPresenter;

        public OrderView()
        {
            InitializeComponent();
            orderPresenter = new OrderPresenter(this);
        }

        private void OrderView_Load(object sender, EventArgs e)
        {
            // ��� �ǿ� ���� AutoScroll Ȱ��ȭ
            foreach (var tab in new[] { tabCoffee, tabTea, tabDessert, tabOthers })
            {
                tab.AutoScroll = true;
            }

            menuItemList = orderPresenter.LoadMenuItems();
            SetTabMenu();


        }

        #region SET TAB MENU
        private void SetTabMenu()
        {
            if (menuItemList.Count == 0) return;

            // �޴� Ÿ�Ժ� ��Ʈ�� �� �ʱ� ��ǥ ����
            var tabMapping = new Dictionary<string, (Control tab, int x, int y, int i)>
            {
                { "COFFEE", (tabCoffee, 6, 6, 0) },
                { "TEA", (tabTea, 6, 6, 0) },
                { "DESSERT", (tabDessert, 6, 6, 0) },
                { "OTHERS", (tabOthers, 6, 6, 0) } // �⺻�� (��Ÿ)
            };



            foreach (var item in menuItemList)
            {
                // ������ Ÿ���� �ƴϸ� "OTHERS"�� ����
                string menuType = (item.MENU_TYPE == "COFFEE" || item.MENU_TYPE == "TEA" || item.MENU_TYPE == "DESSERT")
                    ? item.MENU_TYPE
                    : "OTHERS";

                if (!tabMapping.ContainsKey(menuType)) continue;

                // �ǰ� ��ǥ ��������
                var (tab, x, y, i) = tabMapping[menuType];

                Button btnMenu = new Button
                {
                    Name = $"btnMenu{menuType}{i + 1}",
                    Size = new Size(78, 65),
                    Text = item.MENU_NAME.Trim(),
                    Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0),
                    Location = new Point(x, y)
                };
                if (btnMenu.Text.StartsWith("H)"))
                {
                    btnMenu.ForeColor = Color.PaleVioletRed;
                } 
                else if (btnMenu.Text.StartsWith("C)"))
                {
                    btnMenu.ForeColor = Color.SteelBlue;
                }

                    btnMenu.Click += btnMenu_Click;

                // �ǿ� ��ư �߰�
                tab.Controls.Add(btnMenu);

                i++;

                int columnCount = 3; // �� �ٿ� ��ġ�� ��ư ����
                // ���� ��ư ��ġ ����
                if (i % columnCount == 0)
                {
                    x = 6; // �� �ٲ� �� X ��ǥ �ʱ�ȭ
                    y += btnMenu.Height + 5; // ���� �ٷ� �̵�
                }
                else
                {
                    x += btnMenu.Width + 5; // ���� �̵�
                }

                // ����� ��ġ ���� �ٽ� ����
                tabMapping[menuType] = (tab, x, y, i);
            }
        }
        #endregion


        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (sender is not Button btn) return;

            string menuName = btn.Text; // ��ư�� �ؽ�Ʈ�� �޴� �̸����� ���

            // ���� �޴��� �̹� �ִ��� Ȯ��
            foreach (ListViewItem item in listViewItems.Items)
            {
                if (item.SubItems[1].Text == menuName) // [1] = Menu
                {
                    int quantity = int.Parse(item.SubItems[2].Text) + 1; // [2] = Qty
                    int price = int.Parse(item.SubItems[3].Text); // [3] = Price (���� ����)

                    item.SubItems[2].Text = quantity.ToString();
                    item.SubItems[3].Text = (quantity * price).ToString();
                    return;
                }
            }

            // ���ο� �޴� �߰�
            var menuItem = menuItemList.FirstOrDefault(m => m.MENU_NAME == menuName);
            if (menuItem != null)
            {
                int newNo = listViewItems.Items.Count + 1; // No �� �ڵ� ����
                int price = menuItem.PRICE;

                var listViewItem = new ListViewItem(new[]
                {
            newNo.ToString(),    // No
            menuName,            // Menu
            "1",                 // Qty
            price.ToString()      // Price
        });

                listViewItems.Items.Add(listViewItem);
            }
        }
    }
}
