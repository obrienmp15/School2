using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolWeb.Logic.Models
{
  public partial class StudentDTO : SchoolThing
  {
    partial void IsNull(ref string data, string value);

    private string _FirstName = default(string);
    private string _LastName = default(string);

    /// <summary>
    /// 
    /// </summary>
    public string FirstName
    {
      get
      {
        return _FirstName;
      }
      set
      {
        IsNull(ref _FirstName, value);
      }
    }

    public string LastName
    {
      get
      {
        return _LastName;
      }
      set
      {
        IsNull(ref _LastName, value);
      }
    }


    public MajorDTO Major { get; set; }

    public ScheduleDTO Schedule { get; set; }

    public StudentDTO(string firstname, string lastname) : base()
    {

      FirstName = firstname;
      LastName = lastname;
    }


    ~StudentDTO()
    {
      GC.Collect();
    }

  }
}
