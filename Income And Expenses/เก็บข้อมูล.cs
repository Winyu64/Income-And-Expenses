using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Income_And_Expenses
{
    internal class เก็บข้อมูล
    {
        public string alldata = string.Empty;
        private string textBox3 = string.Empty;
        private string textBox4 = string.Empty;
        private string comboBox1 = string.Empty;

        public void addGPA(string com ,string name, string gpa )
        {
            this.alldata += com+ ", " + name + ", " + gpa+ "\r\n" ;
            this.textBox3 = name;
            this.textBox4 = gpa;
            this.comboBox1 = com;

        }


        public string getAlldata()
        {
            return alldata;
        }
    }   
}
       