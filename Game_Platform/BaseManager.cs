using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Platform
{
    public abstract class BaseManager<T>
    {
        public abstract void Save(T t);
        public abstract void Update(T t);
        public abstract void Delete(T t);
    }
}
