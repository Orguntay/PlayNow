using System;
using System.Collections.Generic;
using System.Text;

namespace PlayNow.Abstructers
{
    public abstract class CrudShema
    {
        public abstract void Get();
        public abstract void Save();
        public abstract void Update();
        public abstract void Delete();

    }
}
