using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebEvaluate.Data
{
    public class BusinessAcu
    {
        public Level level1 { get; set; }
        public Level level3 { get; set; }
        public Level level5 { get; set; }

        public int Scroll(){
            int top = 0;

            // L1
            if(this.level1 !=null && this.level1.c1 == true && this.level1.c2 == true && this.level1.c3 == true && this.level1.c4 == true){
                top = 1;

                // L3
                if(this.level3 !=null && this.level3.c1 == true && this.level3.c2 == true && this.level3.c3 == true && this.level3.c4 == true){
                    top = 3;

                    // L5
                    if(this.level5 !=null && this.level5.c1 == true && this.level5.c2 == true && this.level5.c3 == true && this.level5.c4 == true){
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
    }
}
