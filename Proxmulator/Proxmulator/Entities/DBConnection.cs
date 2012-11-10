using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxmulator.Entities
{
    public class DBConnection
    {
        public string Name { get; set; }
        public string Host { get; set; }
        public string Port { get; set; }
        public string Schema { get; set; }
        public string SID { get; set; }
        public string User { get; set; }
        public string Password { get; set; }


        public string getConnectionString()
        {
            string oradb = "Data Source=(DESCRIPTION="
                        + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST={0})(PORT={1})))"
                        + "(CONNECT_DATA=(SERVER=DEDICATED)(SID={2})));"
                        + "User Id={3};Password={4};";
            return string.Format(oradb, Host, Port, SID, User, Password);
        }


        public string CreateQuery(string output, string table, string filter, string orderBy)
        {

            var tmp = "select {0} FROM {1} WHERE {2} {3}";

            var sch = table;

            if (!string.IsNullOrEmpty(this.Schema))
            {
                sch = Schema + "." + table;
            }

            return string.Format(tmp, output, sch, filter, orderBy);

        }


    }
}
