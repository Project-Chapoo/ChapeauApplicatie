using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModels;

namespace ChapeauService
{
    public class TablesService
    {
        TablesDAO tablesDb;

        public TablesService()
        {
            this.tablesDb = new TablesDAO();
        }

        public bool Reserved(int tafelNummer)
        {
            return tablesDb.Reserved(tafelNummer);
        }
    }
}
