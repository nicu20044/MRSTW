using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Interfaces;

namespace BusinessLogic
{
    class BusinessLogic
    {
        public ISession GetSessionBL()
            {
            return new SessionBL();
        }

    }
}
