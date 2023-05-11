using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExtremeMvcApp1.Service
{
    public interface ICronosService
    {
        void generateExpression();
        string generateCronosGeneralised(string times, int max);
        string generateExpressionCronos(string min, string hour, string dayow,string month);

        string generateDayOfMonth(string dayom, int max);
    }
}
