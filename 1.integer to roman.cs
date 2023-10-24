public class Solution {
    public string IntToRoman(int num) {
        string res = "";
        while(num>0){
            //System.Console.WriteLine(num);
            if(num>=1000){
                res += "M";
                num = num-1000;
            }
            else if(num>=900){
                res += "CM";
                num = num-900;
            }
            else if(num>=500){
                res += "D";
                num = num-500;
            }
            else if(num>=400){
                res += "CD";
                num = num-400;
            }
            else if(num>=100){
                res += "C";
                num = num-100;
            }
            else if(num>=90){
                res += "XC";
                num = num-90;
            }
            else if(num>=50){
                res += "L";
                num = num-50;
            }
            else if(num>=40){
                res += "XL";
                num = num-40;
            }
            else if(num>=10){
                res += "X";
                num = num-10;
            }
            else if(num>=9){
                res += "IX";
                num = num-9;
            }
            else if(num>=5){
                res += "V";
                num = num-5;
            }
            else if(num>=4){
                res += "IV";
                num = num-4;
            }
            else if(num>=1){
                res += "I";
                num = num-1;
            }
        }     
        return res;           
    }
}