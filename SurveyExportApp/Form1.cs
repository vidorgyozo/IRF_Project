using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurveyExportApp
{
    public partial class Form1 : Form
    {
        IRF_PROJECT_DB_COPYEntities context = new IRF_PROJECT_DB_COPYEntities();
        List<SurveyAnswer> Answers;
        List<Image> Images;


        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            Answers = context.SurveyAnswers.ToList();
            Images = context.Images.ToList();
        }
    }
}
