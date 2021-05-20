using System;
using System.Collections.Generic;

namespace BlazorWebEvaluate.Data
{
    public class EvaluateData
    {
        public string full_name { get; set; }
        public string top_level { get; set; }

        public static List<string> AllLevels {
            get {
                return new List<string>() {
                    "L7",
                    "L8",
                    "L9",
                    "L10",
                    "L11"
                };
            }
        }

        public int Max(){
            int top = 0;
            switch(top_level){
                case "L7" : {
                    top = 1;
                    };break;
                case "L8":
                    {
                        top = 2;
                    }; break;
                case "L9" : {
                    top = 3;
                    };break;
                case "L10":
                    {
                        top = 4;
                    }; break;
                case "L11" : {
                    top = 5;
                    };break;
            }
            return top;
        }

        #region <Leadership>

        public string leadership_level1_c1 { get;set;}
        public string leadership_level1_c2 { get;set;}
        public string leadership_level1_c3 { get;set;}

        public string leadership_level3_c1 { get;set;}
        public string leadership_level3_c2 { get;set;}
        public string leadership_level3_c3 { get;set;}

        public string leadership_level5_c1 { get;set;}
        public string leadership_level5_c2 { get;set;}
        public string leadership_level5_c3 { get;set;}
        public string leadership_level5_c4 { get;set;}

        public int leadership_Scroll(){
            int top = 0;

            // L1 3
            if(this.leadership_level1_c1 == "1" && this.leadership_level1_c2 == "1" && this.leadership_level1_c3 == "1"){
                top = 1;

                // L3 3
                if(this.leadership_level3_c1 == "1" && this.leadership_level3_c2 == "1" && this.leadership_level3_c3 == "1"){
                    top = 3;

                    // L5 4
                    if(this.leadership_level5_c1 == "1" && this.leadership_level5_c2 == "1" && this.leadership_level5_c3 == "1" && this.leadership_level5_c4 == "1"){
                        top = 5;
                    }
                }
            }
            
            return top;
        }
        #endregion

        #region <Business Management>
        public string businessManagement_level1_c1 { get;set;}
        public string businessManagement_level1_c2  { get;set;}
        public string businessManagement_level1_c3  { get;set; }
        public string businessManagement_level1_c4 { get; set; }

        public string businessManagement_level3_c1 { get;set;}        
        public string businessManagement_level3_c2  { get;set;}
        public string businessManagement_level3_c3 { get;set;}

        public string businessManagement_level5_c1 { get;set;}
        public string businessManagement_level5_c2  { get;set;}
        public string businessManagement_level5_c3  { get;set; }
        public string businessManagement_level5_c4 { get; set; }

        public int businessManagement_Scroll(){
            int top = 0;

            // L1 4
            if(this.businessManagement_level1_c1 == "1" && this.businessManagement_level1_c2 == "1" && this.businessManagement_level1_c3 == "1" && this.businessManagement_level1_c4 == "1")
            {
                top = 1;

                // L3 3
                if(this.businessManagement_level3_c1 == "1" && this.businessManagement_level3_c2 == "1" && this.businessManagement_level3_c3 == "1"){
                    top = 3;

                    // L5 4
                    if(this.businessManagement_level5_c1 == "1" && this.businessManagement_level5_c2 == "1" && this.businessManagement_level5_c3 == "1" && this.businessManagement_level5_c4 == "1")
                    {
                        top = 5;
                    }
                }
            }
            
            return top;
         }
        #endregion

        #region <Change Catalyst>
        public string changeCatalyst_level1_c1{ get;set;}
        public string changeCatalyst_level1_c2{ get;set;}
        public string changeCatalyst_level1_c3{ get;set; }
        public string changeCatalyst_level1_c4 { get; set; }
        public string changeCatalyst_level1_c5 { get; set; }
        public string changeCatalyst_level3_c1 { get;set;}
        public string changeCatalyst_level3_c2{ get;set;}
        public string changeCatalyst_level3_c3{ get;set;}
        public string changeCatalyst_level3_c4{ get;set; }
        public string changeCatalyst_level3_c5 { get; set; }
        public string changeCatalyst_level5_c1 { get;set;}
        public string changeCatalyst_level5_c2 { get;set;}
        public string changeCatalyst_level5_c3 { get;set;}
        public string changeCatalyst_level5_c4 { get;set;}
        public string changeCatalyst_level5_c5 { get; set; }

        public int changeCatalyst_Scroll(){
            int top = 0;

            // L1 5
            if(this.changeCatalyst_level1_c1 == "1" && this.changeCatalyst_level1_c2 == "1" && this.changeCatalyst_level1_c3 == "1" && this.changeCatalyst_level1_c4 == "1" && this.changeCatalyst_level1_c5 == "1")
            {
                top = 1;

                // L3 5
                if(this.changeCatalyst_level3_c1 == "1" && this.changeCatalyst_level3_c2 == "1" && this.changeCatalyst_level3_c3 == "1" && this.changeCatalyst_level3_c4 == "1" && this.changeCatalyst_level3_c5 == "1")
                {
                    top = 3;

                    // L5 5
                    if(this.changeCatalyst_level5_c1 == "1" && this.changeCatalyst_level5_c2 == "1" && this.changeCatalyst_level5_c3 == "1" && this.changeCatalyst_level5_c4 == "1" && this.changeCatalyst_level5_c5 == "1")
                    {
                        top = 5;
                    }
                }
            }
            
            return top;
        }
        #endregion

        #region <CSR for Sustainable>
        public string cSRforSustainable_level1_c1 { get;set;}
        public string cSRforSustainable_level1_c2 { get;set;}
        public string cSRforSustainable_level1_c3 { get;set; }
        public string cSRforSustainable_level1_c4 { get; set; }

        public string cSRforSustainable_level3_c1{ get;set;}
        public string cSRforSustainable_level3_c2 { get;set;}
        public string cSRforSustainable_level3_c3 { get;set; }
        public string cSRforSustainable_level3_c4 { get; set; }

        public string cSRforSustainable_level5_c1 { get;set;}
        public string cSRforSustainable_level5_c2 { get;set;}
        public string cSRforSustainable_level5_c3 { get;set;}
        public string cSRforSustainable_level5_c4 { get;set;}
        
        public int cSRforSustainable_Scroll(){
            int top = 0;

            // L1 4
            if(this.cSRforSustainable_level1_c1 == "1" && this.cSRforSustainable_level1_c2 == "1" && this.cSRforSustainable_level1_c3 == "1" && this.cSRforSustainable_level1_c4 == "1")
            {
                top = 1;

                // L3 4
                if(this.cSRforSustainable_level3_c1 == "1" && this.cSRforSustainable_level3_c2 == "1" && this.cSRforSustainable_level3_c3 == "1" && this.cSRforSustainable_level3_c4 == "1")
                {
                    top = 3;

                    // L5 4
                    if(this.cSRforSustainable_level5_c1 == "1" && this.cSRforSustainable_level5_c2 == "1" && this.cSRforSustainable_level5_c3 == "1" && this.cSRforSustainable_level5_c4 == "1"){
                        top = 5;
                    }
                }
            }
            
            return top;
        }
        #endregion

    }
}
