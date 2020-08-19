using System;
namespace BlazorWebEvaluate.Data
{
    public class EvaluateData
    {
        public string full_name { get; set; }
        public string top_level { get; set; }

        public int Max(){
            int top = 0;
            switch(top_level){
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

        #region <BusinessAcumen>

        public int businessAcu_level1_c1 { get;set;}
        public int businessAcu_level1_c2 { get;set;}
        public int businessAcu_level1_c3{ get;set;}
        public int businessAcu_level1_c4 { get;set;}

        public int businessAcu_level3_c1 { get;set;}
        public int businessAcu_level3_c2 { get;set;}
        public int businessAcu_level3_c3 { get;set;}
        public int businessAcu_level3_c4 { get;set;}

        public int businessAcu_level5_c1 { get;set;}
        public int businessAcu_level5_c2 { get;set;}
        public int businessAcu_level5_c3 { get;set;}
        public int businessAcu_level5_c4 { get;set;}

        public int businessAcu_Scroll(){
            int top = 0;

            // L1
            if(this.businessAcu_level1_c1 == 1 && this.businessAcu_level1_c2 == 1 && this.businessAcu_level1_c3 == 1 && this.businessAcu_level1_c4 == 1){
                top = 1;

                // L3
                if(this.businessAcu_level3_c1 == 1 && this.businessAcu_level3_c2 == 1 && this.businessAcu_level3_c3 == 1 && this.businessAcu_level3_c4 == 1){
                    top = 3;

                    // L5
                    if(this.businessAcu_level5_c1 == 1 && this.businessAcu_level5_c2 == 1 && this.businessAcu_level5_c3 == 1 && this.businessAcu_level5_c4 == 1){
                        top = 5;
                    }else{
                        top = 4;
                    }
                }else{
                    top = 2;
                }
            }else{
                top = 1;
            }
            
            return top;
        }
        #endregion

        #region <Initiative>
        public int initiative_level1_c1 { get;set;}
        public int initiative_level1_c2  { get;set;}
        public int initiative_level1_c3  { get;set;}

        public int initiative_level3_c1 { get;set;}        
        public int initiative_level3_c2  { get;set;}
        public int initiative_level3_c3 { get;set;}
        public int initiative_level3_c4  { get;set;}
        public int initiative_level3_c5 { get;set;}

        public int initiative_level5_c1 { get;set;}
        public int initiative_level5_c2  { get;set;}
        public int initiative_level5_c3  { get;set;}

        public int initiative_Scroll(){
            int top = 0;

            // L1 3
            if(this.initiative_level1_c1 == 1 && this.initiative_level1_c2 == 1 && this.initiative_level1_c3 == 1){
                top = 1;

                // L3 5
                if(this.initiative_level3_c1 == 1 && this.initiative_level3_c2 == 1 && this.initiative_level3_c3 == 1 && this.initiative_level3_c4 == 1 && this.initiative_level3_c5 == 1){
                    top = 3;

                    // L5 3
                    if(this.initiative_level5_c1 == 1 && this.initiative_level5_c2 == 1 && this.initiative_level5_c3 == 1){
                        top = 5;
                    }else{
                        top = 4;
                    }
                }else{
                    top = 2;
                }
            }else{
                top = 1;
            }
            
            return top;
         }
        #endregion

        #region <Collaboration>
        public int collaboration_level1_c1{ get;set;}
        public int collaboration_level1_c2{ get;set;}
        public int collaboration_level1_c3{ get;set;}

        public int collaboration_level3_c1 { get;set;}
        public int collaboration_level3_c2{ get;set;}
        public int collaboration_level3_c3{ get;set;}
        public int collaboration_level3_c4{ get;set;}

        public int collaboration_level5_c1 { get;set;}
        public int collaboration_level5_c2 { get;set;}
        public int collaboration_level5_c3 { get;set;}
        public int collaboration_level5_c4 { get;set;}
        public int collaboration_Scroll(){
            int top = 0;

            // L1 3
            if(this.collaboration_level1_c1 == 1 && this.collaboration_level1_c2 == 1 && this.collaboration_level1_c3 == 1){
                top = 1;

                // L3 4
                if(this.collaboration_level3_c1 == 1 && this.collaboration_level3_c2 == 1 && this.collaboration_level3_c3 == 1 && this.collaboration_level3_c4 == 1){
                    top = 3;

                    // L5 4
                    if(this.collaboration_level5_c1 == 1 && this.collaboration_level5_c2 == 1 && this.collaboration_level5_c3 == 1 && this.collaboration_level5_c4 == 1){
                        top = 5;
                    }else{
                        top = 4;
                    }
                }else{
                    top = 2;
                }
            }else{
                top = 1;
            }
            
            return top;
        }
        #endregion

        #region <ServiceExcellence>
        public int serviceExcellence_level1_c1 { get;set;}
        public int serviceExcellence_level1_c2 { get;set;}
        public int serviceExcellence_level1_c3 { get;set;}

        public int serviceExcellence_level3_c1{ get;set;}
        public int serviceExcellence_level3_c2 { get;set;}
        public int serviceExcellence_level3_c3 { get;set;}

        public int serviceExcellence_level5_c1 { get;set;}
        public int serviceExcellence_level5_c2 { get;set;}
        public int serviceExcellence_level5_c3 { get;set;}
        public int serviceExcellence_level5_c4 { get;set;}
        public int serviceExcellence_level5_c5 { get;set;}
        
        public int serviceExcellence_Scroll(){
            int top = 0;

            // L1 3
            if(this.serviceExcellence_level1_c1 == 1 && this.serviceExcellence_level1_c2 == 1 && this.serviceExcellence_level1_c3 == 1){
                top = 1;

                // L3 3
                if(this.serviceExcellence_level3_c1 == 1 && this.serviceExcellence_level3_c2 == 1 && this.serviceExcellence_level3_c3 == 1){
                    top = 3;

                    // L5 5
                    if(this.serviceExcellence_level5_c1 == 1 && this.serviceExcellence_level5_c2 == 1 && this.serviceExcellence_level5_c3 == 1 && this.serviceExcellence_level5_c4 == 1 && this.serviceExcellence_level5_c5 == 1){
                        top = 5;
                    }else{
                        top = 4;
                    }
                }else{
                    top = 2;
                }
            }else{
                top = 1;
            }
            
            return top;
        }
        #endregion

        #region <SafetyAndSecurity>
        public int safetyAndSecurity_level1_c1 { get;set;}
        public int safetyAndSecurity_level1_c2  { get;set;}
        public int safetyAndSecurity_level1_c3 { get;set;}

        public int safetyAndSecurity_level3_c1  { get;set;}
        public int safetyAndSecurity_level3_c2  { get;set;}
        public int safetyAndSecurity_level3_c3  { get;set;}
        public int safetyAndSecurity_level3_c4  { get;set;}

        public int safetyAndSecurity_level5_c1  { get;set;}
        public int safetyAndSecurity_level5_c2  { get;set;}
        public int safetyAndSecurity_level5_c3  { get;set;}
        public int safetyAndSecurity_level5_c4  { get;set;}

        public int safetyAndSecurity_Scroll(){
            int top = 0;

            // L1 3
            if(this.safetyAndSecurity_level1_c1 == 1 && this.safetyAndSecurity_level1_c2 == 1 && this.safetyAndSecurity_level1_c3 == 1){
                top = 1;

                // L3 4
                if(this.safetyAndSecurity_level3_c1 == 1 && this.safetyAndSecurity_level3_c2 == 1 && this.safetyAndSecurity_level3_c3 == 1 && this.safetyAndSecurity_level3_c4 == 1){
                    top = 3;

                    // L5 4
                    if(this.safetyAndSecurity_level5_c1 == 1 && this.safetyAndSecurity_level5_c2 == 1 && this.safetyAndSecurity_level5_c3 == 1 && this.safetyAndSecurity_level5_c4 == 1){
                        top = 5;
                    }else{
                        top = 4;
                    }
                }else{
                    top = 2;
                }
            }else{
                top = 1;
            }
            
            return top;
        }
        #endregion

        #region <DigitalLiteracy>
        public int digitalLiteracy_level1_c1  { get;set;}
        public int digitalLiteracy_level1_c2   { get;set;}
        public int digitalLiteracy_level1_c3  { get;set;}

        public int digitalLiteracy_level3_c1  { get;set;}
        public int digitalLiteracy_level3_c2  { get;set;}
        public int digitalLiteracy_level3_c3  { get;set;}
        public int digitalLiteracy_level3_c4  { get;set;}

        public int digitalLiteracy_level5_c1   { get;set;}
        public int digitalLiteracy_level5_c2   { get;set;}
        public int digitalLiteracy_level5_c3   { get;set;}
        public int digitalLiteracy_level5_c4   { get;set;}

        public int digitalLiteracy_Scroll(){
            int top = 0;

            // L1 3
            if(this.digitalLiteracy_level1_c1 == 1 && this.digitalLiteracy_level1_c2 == 1 && this.digitalLiteracy_level1_c3 == 1){
                top = 1;

                // L3 4
                if(this.digitalLiteracy_level3_c1 == 1 && this.digitalLiteracy_level3_c2 == 1 && this.digitalLiteracy_level3_c3 == 1 && this.digitalLiteracy_level3_c4 == 1){
                    top = 3;

                    // L5 4
                    if(this.digitalLiteracy_level5_c1 == 1 && this.digitalLiteracy_level5_c2 == 1 && this.digitalLiteracy_level5_c3 == 1 && this.digitalLiteracy_level5_c4 == 1){
                        top = 5;
                    }else{
                        top = 4;
                    }
                }else{
                    top = 2;
                }
            }else{
                top = 1;
            }
            
            return top;
        }
        #endregion
    }
}
