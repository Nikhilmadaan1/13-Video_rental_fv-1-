using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_rental_fv
{
    public class EmptyCheck
    {
        public int checkEmpty(String data) {

            //method to verfy the text boxes filed or empty 
            String []Ary= data.Split(',');
            int count = 0;
            for (int y=0;y<Ary.Length;y++) {
                if (Ary[y].Equals("")) {
                    count++;
                }
            }
            return count;
        }


        public int calcuateCharges(int Year) {
            try {

                DateTime dateNow = DateTime.Now;

                int Currentyear = dateNow.Year;

                int diffYear = Currentyear - Convert.ToInt32(Year);
                int cost = 0;
                // MessageBox.Show(diff.ToString());
                if (diffYear >= 5)
                {
                    cost=2;
                }
                if (diffYear >= 0 && diffYear < 5)
                {
                    cost=5;
                }

                return cost;
            }
            catch (Exception ex) {
                return 0;
            }
        }
    }

}
