using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolWeb.Logic.Models
{
  public partial class MajorDTO : SchoolThing
  {
    partial void IsNull(ref string data, string value);

    private string _Name = default(string);

    public string Name
    {
      get
      {
        return _Name;
      }
      set
      {
        IsNull(ref _Name, value);
      }
    }

    internal MajorDTO() : base()
    {

    }

    internal override MajorDTO Create<MajorDTO>()
    {
      return new MajorDTO();
    }

  }
}
