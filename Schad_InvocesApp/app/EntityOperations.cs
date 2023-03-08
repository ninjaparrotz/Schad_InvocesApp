using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schad_InvocesApp.app
{
    public  abstract class EntityOperations
    {
        public int Id { get; set; }


        public abstract void Create();
        public abstract void Update();
        public abstract void Delete();

    }
}
