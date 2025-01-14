using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MeoIS
{
    class Register_of_summons_to_enlistment__office
    {

        public void addSummons(string documentNumber)
        {

        }

        public void editOrDeleteSummons()
        {

        }

        public void editStatusSummons()
        {

        }

        public bool updateActiveSummons()
        {
            Advanced_search search = new Advanced_search();
            DataTable table = new DataTable();
            table = search.searchAllSummonsByDocNumberToTable(Transfer.Doc_num);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
