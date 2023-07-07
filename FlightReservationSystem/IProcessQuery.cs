using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationSystem
{
    public interface IProcessQuery
    {
        void SetQueryCommandParams(SqlCommand command, QueryType queryType);
    }
}
