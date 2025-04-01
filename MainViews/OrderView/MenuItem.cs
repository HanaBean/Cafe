using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MenuItem
{
    public string MENU_ID { get; set; }
    public string MENU_NAME { get; set; }
    public string CATEGORY_ID { get; set; }
    public string MENU_TYPE { get; set; }
    public int PRICE { get; set; }
}