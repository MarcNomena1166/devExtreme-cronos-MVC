using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace DevExtremeMvcApp1.Service
{
    public class CronosService:ICronosService
    {
        public void generateExpression()
        {
            Debug.WriteLine("injection dependency");
        }

        public string generateCronosGeneralised(string times,int max)
        {
            string retour = times;
            int timesTemp;
            bool isNumber = int.TryParse(times, out timesTemp);
            if(isNumber)retour = $"{times}";
            

            return retour;
        }

        public string generateDayOfMonth(string dayom, int max)
        {
            string retour = dayom;
            int timesTemp;
            bool isNumber = int.TryParse(dayom, out timesTemp);
            if (isNumber) retour = $"{dayom}";

            return retour;
        }
        public string generateExpressionCronos(string min, string hour,string dayow,string month)
        {
            string minutes = this.generateCronosGeneralised(min, 59);
            string hours = this.generateCronosGeneralised(hour, 23);
            string dayofMonth = this.generateDayOfMonth(dayow, 31);
            string months= this.generateDayOfMonth(month, 12);
            return $"{minutes} {hours} {dayofMonth} {months}" ;
        }
    }
}