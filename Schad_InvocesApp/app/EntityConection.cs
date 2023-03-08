using Schad_InvocesApp.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schad_InvocesApp.app
{
    internal class EntityConection
    {
        public static schad_InvocesEntities _Dbcontext;
        
        public static schad_InvocesEntities getInstance()
        {
            if(_Dbcontext == null)
            {
                _Dbcontext = new schad_InvocesEntities();
            }
            return _Dbcontext;
        }
        public static schad_InvocesEntities getNewInstance()
        {
                return new schad_InvocesEntities();
        }
    }
}
