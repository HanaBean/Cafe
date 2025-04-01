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
            // 모든 탭에 대해 AutoScroll 활성화
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

            // 메뉴 타입별 컨트롤 및 초기 좌표 관리
            var tabMapping = new Dictionary<string, (Control tab, int x, int y, int i)>
            {
                { "COFFEE", (tabCoffee, 6, 6, 0) },
                { "TEA", (tabTea, 6, 6, 0) },
                { "DESSERT", (tabDessert, 6, 6, 0) },
                { "OTHERS", (tabOthers, 6, 6, 0) } // 기본값 (기타)
            };



            foreach (var item in menuItemList)
            {
                // 지정된 타입이 아니면 "OTHERS"로 설정
                string menuType = (item.MENU_TYPE == "COFFEE" || item.MENU_TYPE == "TEA" || item.MENU_TYPE == "DESSERT")
                    ? item.MENU_TYPE
                    : "OTHERS";

                if (!tabMapping.ContainsKey(menuType)) continue;

                // 탭과 좌표 가져오기
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

                // 탭에 버튼 추가
                tab.Controls.Add(btnMenu);

                i++;

                int columnCount = 3; // 한 줄에 배치할 버튼 개수
                // 다음 버튼 위치 조정
                if (i % columnCount == 0)
                {
                    x = 6; // 줄 바꿈 후 X 좌표 초기화
                    y += btnMenu.Height + 5; // 다음 줄로 이동
                }
                else
                {
                    x += btnMenu.Width + 5; // 가로 이동
                }

                // 변경된 위치 값을 다시 저장
                tabMapping[menuType] = (tab, x, y, i);
            }
        }
        #endregion


        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (sender is not Button btn) return;

            string menuName = btn.Text; // 버튼의 텍스트를 메뉴 이름으로 사용

            // 같은 메뉴가 이미 있는지 확인
            foreach (ListViewItem item in listViewItems.Items)
            {
                if (item.SubItems[1].Text == menuName) // [1] = Menu
                {
                    int quantity = int.Parse(item.SubItems[2].Text) + 1; // [2] = Qty
                    int price = int.Parse(item.SubItems[3].Text); // [3] = Price (개당 가격)

                    item.SubItems[2].Text = quantity.ToString();
                    item.SubItems[3].Text = (quantity * price).ToString();
                    return;
                }
            }

            // 새로운 메뉴 추가
            var menuItem = menuItemList.FirstOrDefault(m => m.MENU_NAME == menuName);
            if (menuItem != null)
            {
                int newNo = listViewItems.Items.Count + 1; // No 값 자동 증가
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
