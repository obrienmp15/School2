using SchoolWeb.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SchoolWeb.Client
{
  public partial class entryform : System.Web.UI.Page
  {
    private DataService data = new DataService();
    private Factory<CourseDTO> courseFactory = new Factory<CourseDTO>();

    protected void Page_Load(object sender, EventArgs e)
    {
      
      if (!IsPostBack)
      {
        LoadCourses();
      }
      
    }


    private void LoadCourses()
    {
      SchoolCourse_List.Items.Clear();

      foreach (var item in data.GetCourses())
      {
        SchoolCourse_List.Items.Add(new ListItem() { Text = item.Name, Value = item.AppId.ToString() });
      }
    }

    private bool InsertValidated()
    {
      if (string.IsNullOrWhiteSpace(CourseName_Text.Text) &&
        string.IsNullOrWhiteSpace(SchoolCourse_List.SelectedItem.Value))
      {
        return false;
      }

      var course = courseFactory.Create();
      course.AppId = int.Parse(SchoolCourse_List.SelectedItem.Value);
      course.Name = CourseName_Text.Text;

      return data.InsertCourse(course);
    }

    protected void CourseSubmit_Click(object sender, EventArgs e)
    {
      if (InsertValidated())
      {
        CourseName_Text.Text = string.Empty;
        SchoolCourse_List.SelectedIndex = 0;
      }
    }





  }
}