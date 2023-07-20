using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.CommonServices
{
    public class DBDataSource //PostgreDataSource : from Data Source (I or Abstract)?
    {
        public DBDataSource(string conn)
        {
            dataSource = NpgsqlDataSource.Create(conn);
        }

        public NpgsqlDataSource dataSource { get; }
    }
}
