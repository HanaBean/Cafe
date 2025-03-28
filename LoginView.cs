using Cafe.zGlobal;
using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;


namespace Cafe
{
    public partial class LoginView : Form
    {
        #region Global Parameter
        string connectionString = "User Id=cafe_dev;Password=CAFE;Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVICE_NAME=orcl)))";


        #endregion

        public LoginView()
        {
            InitializeComponent();
        }

        #region Form Load Event
        private void loginView_Load(object sender, EventArgs e)
        {
            lblVer.Text = Global.APP_VERGION;
        }
        #endregion

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userId = txtName.Text.Trim(); // 입력값 가져오기

            if (string.IsNullOrWhiteSpace(userId))
            {
                MessageBox.Show("Input your User ID.");
                return;
            }

            if (ValidateUser(userId)) // DB에서 유효성 체크
            {
                Global.loginUser = userId;  // 로그인 성공 시 사용자 정보 저장
                Global.mainView = new MainView
                {
                    StartPosition = FormStartPosition.CenterScreen
                };
                Global.mainView.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login failed. User not found or inactive.");
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return) // Press Enter key
            {
                btnLogin_Click(sender, e);
            }
        }

        // 🔹 DB에서 사용자 조회 (Dapper 사용)
        private bool ValidateUser(string userId)
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM T9_USER WHERE USER_ID = :userId AND USE_FLAG = 'Y'";

                    // OracleDataAdapter를 사용하여 DataTable에 데이터를 채운다.
                    using (OracleDataAdapter adapter = new OracleDataAdapter(query, conn))
                    {
                        adapter.SelectCommand.Parameters.Add(new OracleParameter(":userId", userId));

                        // DataTable 객체에 결과를 채운다.
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // 결과가 0보다 크면 사용자가 존재한다고 판단
                        return dt.Rows.Count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB 연결 오류: " + ex.Message);
                return false;
            }
        }
    }
}
