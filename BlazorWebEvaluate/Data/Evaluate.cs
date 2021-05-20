using System;
namespace BlazorWebEvaluate.Data
{
    public class Evaluate
    {
        public Assessor assessor { get; set; } = new Assessor();
        public string full_name { get; set; }
        public string level { get; set; }

        public int Max(){
            int top = 0;
            switch(level){
                case "L1" : case "L2" : case "L3" : {
                    top = 1;
                };break;
                case "L4" : case "L5" : {
                    top = 2;
                };break;
                case "L6" : case "L7" : {
                    top = 3;
                };break;
                case "L8" : case "L9" : {
                    top = 4;
                };break;
                case "L10" : case "L11" : {
                    top = 5;
                };break;
            }
            return top;
        }

        public LeadershipData leadership { get; set; } = new LeadershipData();
        public BusinessManagementData businessManagement { get; set; } = new BusinessManagementData();
        public ChangeCatalystData changeCatalyst { get; set; } = new ChangeCatalystData();
        public CSRforSustainableData cSRforSustainable { get; set; } = new CSRforSustainableData();
    }
}
