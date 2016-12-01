using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SchoolWeb.Client
{
  public partial class _default : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      GetCourses();
      GetClassDates();
      GetMajors();
      GetDepartments();
      GetSchedules();
      GetStudents();
      GetTeachers();
    }

    private void GetCourses()
    {
      var data = new DataService();
      courselist.Items.Clear();

      foreach (var item in data.GetGenders())
      {
        courselist.Items.Add(item.Name);
      }
    }
    private void GetClassDates()
    {
      var data = new DataService();
      classdatelist.Items.Clear();

      foreach (var item in data.GetGenders())
      {
        classdatelist.Items.Add(item.Name);
      }
    }
    private void GetMajors()
    {
      var data = new DataService();
      majorlist.Items.Clear();

      foreach (var item in data.GetGenders())
      {
        majorlist.Items.Add(item.Name);
      }
    }
    private void GetDepartments()
    {
      var data = new DataService();
      departmentlist.Items.Clear();

      foreach (var item in data.GetGenders())
      {
        departmentlist.Items.Add(item.Name);
      }
    }
    private void GetSchedules()
    {
      var data = new DataService();
      schedulelist.Items.Clear();

      foreach (var item in data.GetGenders())
      {
        schedulelist.Items.Add(item.Name);
      }
    }
    private void GetStudents()
    {
      var data = new DataService();
      studentlist.Items.Clear();

      foreach (var item in data.GetGenders())
      {
        studentlist.Items.Add(item.Name);
      }
    }
    private void GetTeachers()
    {
      var data = new DataService();
      teacherlist.Items.Clear();

      foreach (var item in data.GetGenders())
      {
        teacherlist.Items.Add(item.Name);
      }
    }



  }
}