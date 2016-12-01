using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolWeb.Logic
{
  public class Factory<T> where T : SchoolThing, new()
  {
    public T Create()
    {
      var o = new T();
      return o.Create<T>();
    }
  }
}
