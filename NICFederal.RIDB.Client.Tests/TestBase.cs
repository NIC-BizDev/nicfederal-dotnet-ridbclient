using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NICFederal.RIDB.Client.Tests
{
    public class TestBase
    {
        protected RIDBClient GetClient()
        {
            return new RIDBClient();
        }
    }
}
