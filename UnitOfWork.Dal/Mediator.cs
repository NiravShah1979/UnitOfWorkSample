using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.SqlCommand;

namespace UnitOfWork.Dal
{
    abstract class Mediator<T> where T : class
    {
        public abstract void Send(string message);
    }
}
