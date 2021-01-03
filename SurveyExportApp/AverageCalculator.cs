using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyExportApp
{
    static class AverageCalculator
    {
        public static double CalculateAverageOfRegion(List<SurveyAnswer> answers, List<Image> images, RegionEnum region)
        {
            var regionQuery = from image in images
                              join answer in answers on image.ImageId equals answer.ImageId
                              where image.Region == region.ToString()
                              select new { answer.Answer };
            double sum = 0;
            foreach (var rating in regionQuery)
            {
                sum += rating.Answer;
            }

            return sum / regionQuery.Count();
        }
    }
}
