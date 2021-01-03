using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Windows.Forms;

namespace SurveyExportApp
{
    public class ExcelExportManager
    {
        Excel.Application excApp;
        Excel.Workbook excWB;
        Excel.Worksheet excWS;
        List<SurveyAnswer> Answers;
        List<Image> Images;



        private void Init(List<SurveyAnswer> answers, List<Image> images)
        {
            excApp = new Excel.Application();
            excWB = excApp.Workbooks.Add(Missing.Value);
            excWS = excWB.ActiveSheet;
            Answers = answers;
            Images = images;

        }

        private void Show()
        {
            excApp.Visible = true;
            excApp.UserControl = true;
        }

        public void ExportSurveyAnswersJoined(List<SurveyAnswer> answers, List<Image> images)
        {
            try
            {
                Init(answers, images);

                FillSheet();

                Show();
            }
            catch (Exception e)
            {
                string error = string.Format("Error: {0}\nAt: {1}", e.Message, e.Source);
                MessageBox.Show(error, "Error");
                excWB.Close(false, Type.Missing, Type.Missing);
                excApp.Quit();
                excWB = null;
                excApp = null;
            }
        }

        private void FillSheet()
        {

            var imageAnswerJoinQuery = from image in Images
                                       join answer in Answers on image.ImageId equals answer.ImageId
                                       select new
                                       {
                                           ImageId = image.ImageId,
                                           PatientId = image.Patient,
                                           Region = image.Region,
                                           NameId = answer.NameId,
                                           Answer = answer.Answer,
                                           Comment = answer.Comment,
                                           Timestamp = answer.Timestamp
                                       };

            string[] headers = new string[]
            {
                "Kép azonosító",
                "Páciens azonosító",
                "Régió",
                "Kiöltő azonosító",
                "Válasz",
                "Megjegyzés",
                "Válaszadás időpontja"
            };

            excWS.get_Range(GetCell(1,1), GetCell(headers.Length,1)).Value2 = headers;
        }

        private string GetCell(int x, int y)
        {
            string ExcelCoordinate = "";
            int dividend = x;
            int modulo;

            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                ExcelCoordinate = Convert.ToChar(65 + modulo).ToString() + ExcelCoordinate;
                dividend = (int)((dividend - modulo) / 26);
            }
            ExcelCoordinate += y.ToString();

            return ExcelCoordinate;
        }

        public void Reset()
        {
            excWB.Close(false, Type.Missing, Type.Missing);
            excApp.Quit();
            excWB = null;
            excApp = null;
            Answers = null;
            Images = null;
        }
    }
}
