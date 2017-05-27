using System;
using Microsoft.Practices.Unity;

namespace TP3Unity
{
    public class Container : UnityContainer
    {
        public void Configure()
        {
            this.RegisterType<DataAccess.IData, DataAccess.MemoryData>();
        }

    }
}