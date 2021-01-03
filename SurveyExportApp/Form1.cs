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

        private ExcelExportManager excelManager;

        public ExcelExportManager ExcelManager
        {
            get
            {
                if (excelManager == null)
                {
                    excelManager = new ExcelExportManager();
                }
                return excelManager;
            }
            set
            {
                if (value == null && excelManager != null)
                {
                    excelManager.Reset();
                }
                else
                {
                    excelManager = value;
                };
            }
        }



        public Form1()
        {
            InitializeComponent();

            LoadData();

            exportButton.Click += ExportButton_Click;
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            ExcelManager.ExportSurveyAnswersJoined(Answers, Images);
        }

        private void LoadData()
        {
            Answers = context.SurveyAnswers.ToList();
            Images = context.Images.ToList();

            answersDataGrid.DataSource = Answers;
            imagesDataGrid.DataSource = Images;
        }
    }
}
