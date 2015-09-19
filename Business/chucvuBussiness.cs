using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Database;
using Library;

using System.Data.SqlClient;

namespace Business
{
    public class chucvuBussiness
    {
        connectDatabase conn = null;
        public chucvuBussiness()
        {
            conn = new connectDatabase();
        }
    }
}
