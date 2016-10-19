using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Profesor
        {
            // Field
            public string id_profesor;

            // Constructor
            public Profesor(string id)
            {
                id_profesor = id;
            }

            public void load_database_dis()
            {
                //database computing for profesor with id "id"
            }

            public void load_database_cours()
            {
                // load database for courses related to students
            }

            public void get_discipline(string id_dis)
            {
                //load discipline from database
            }

            public void update_mark(string student, string discipline)
            {
                //add or update mark
            }

            public void update_activity(string student)
            {
                // update activity
            }
        }

        public class Decanat
        {

            public void set_prof_dis(string prof, string dis)
            {
                //update database with professor and discipline
            }

            public void relate_dis_student(string dis, string student)
            {
                //add relation between student and discipline
            }

            public void calc_med(string student)
            {

            }

            public void generate_raport(string raport_type)
            {

            }

        }


        public class Student
        {

            public void see_marks(string dis, string type)
            {

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
