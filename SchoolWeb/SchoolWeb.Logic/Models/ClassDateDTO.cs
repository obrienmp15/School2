using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolWeb.Logic.Models
{
  public partial class ClassDateDTO : SchoolThing
  {

    partial void IsNull(ref string data, string value);

    private string _Day = default(string);

    public TimeSpan ClassTime { get; set; }

    public string Day
    {
      get
      {
        return _Day;
      }
      set
      {
        IsNull(ref _Day, value);
      }
    }


    public ClassDateDTO(string day) : base()
    {

      Day = day;
    }


    ~ClassDateDTO()
    {
      GC.Collect();
    }


  }
}
