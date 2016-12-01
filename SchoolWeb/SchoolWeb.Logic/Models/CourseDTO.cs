using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolWeb.Logic.Models
{
  public partial class CourseDTO : SchoolThing
  {
    partial void IsNull(ref string data, string value);

    private string _Name = default(string);

    /// <summary>
    /// 
    /// </summary>
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

    public TeacherDTO Teacher { get; set; }

    private int Capacity { get; set; }
    private int Credit { get; set; }

    public StudentDTO Student { get; set; }
    public DepartmentDTO Department { get; set; }
    public ScheduleDTO Schedule { get; set; }

    public CourseDTO(string name) : base()
    {

      Name = name;
    }


    ~CourseDTO()
    {
      GC.Collect();
    }

  }
}
