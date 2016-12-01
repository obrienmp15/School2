using SchoolWeb.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolWeb.Logic
{
  public class DataService
  {
    private SchoolServiceClient msc = new SchoolServiceClient();
    private Factory<CourseDTO> courseFactory = new Factory<CourseDTO>();

    public List<CourseDTO> GetCourses()
    {
      var courses = new List<CourseDTO>();

      foreach (var item in msc.GetCourses())
      {
        var c = courseFactory.Create();

        c.AppId = item.Id;
        c.Name = item.Name;

        courses.Add(c);
      }

      return courses;
    }

  }
}
