using Api.brive.DataAccess.DataAccess.Mock;
using Api.brive.DataAccess.DataAccess.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.brive.DataAccess
{
    public class App
    {
        //SINGLETON
        private static IDataAccess dataAccess;


        public static IDataAccess DataAccess
        {
            get
            {
                if (App.dataAccess == null)
                {
                    //switch
                    App.dataAccess = new MockDataAcess();
                }


                return App.dataAccess;
            }
        }
    }
}
