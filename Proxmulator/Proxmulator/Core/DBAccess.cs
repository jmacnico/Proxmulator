using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
using Proxmulator.Entities;

namespace Proxmulator.Core
{
   public class DBAccess
    {



       public static List<MessageInfo> GetMessages(string businessId, DBConnection connection){

           var connString = connection.getConnectionString();

           var result = new List<MessageInfo>();

           var output = "npu, correlationNpu, businessid, creationdate, processid, interfacetoinvoke, operation, payload";
           var filter = string.Format(" businessId = '{0}' ", businessId) ;
           var orderBy = " ORDER BY creationdate ASC";

           if (!string.IsNullOrEmpty(Configuration.IgnoreOperations))
           {
               var opers = Configuration.IgnoreOperations.Split(';');

               var formOper = " {0} AND NPU not like '%{1}%' ";

               foreach (var o in opers)
               {
                   filter = string.Format(formOper, filter, o);
               }
           }



           using(OracleConnection conn = new OracleConnection(connString)){

               var command = conn.CreateCommand();

               command.CommandText = connection.CreateQuery(output, "pt_msg_inbound", filter, orderBy);
               conn.Open();

               var reader = command.ExecuteReader();

               while (reader.Read())
               {
                   var msg = MessageInfo.LoadFromDB(reader);
                   result.Add(msg);
               }

               command.CommandText = connection.CreateQuery(output, "pt_msg_inbound_archive", filter, orderBy);
               reader = command.ExecuteReader();
              

               while (reader.Read())
               {
                   var msg = MessageInfo.LoadFromDB(reader);
                   result.Add(msg);
                   
               }

           }

           result = result.OrderBy(a => a.ReceivedDatetime).ToList();

           return result;

       }



    }
}
