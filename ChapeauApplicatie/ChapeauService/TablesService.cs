using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModels;
using ChapeauDAL;


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

        public List<Tables> GetTables()
        {
            List<Tables> tables = tablesdb.GetAllTables();
            return tables;
        }

    }
}
