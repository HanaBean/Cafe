using Dapper;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.MainViews.OrderView
{
    public class OrderPresenter
    {
        private readonly IOrderView _view;

        public OrderPresenter(IOrderView view)
        {
            _view = view;
        }

        public List<MenuItem> LoadMenuItems()
        {
            using (var conn = new OracleConnection(DBConnection.connectionString))
            {
                conn.Open();
                return conn.Query<MenuItem>("SELECT MENU_ID, MENU_NAME, CATEGORY_ID, MENU_TYPE, PRICE FROM T1_MENU").ToList();
            }
        }
    }

}
