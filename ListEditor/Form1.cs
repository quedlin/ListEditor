using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_addPrefixPostfix_Click(object sender, EventArgs e)
        {


            string[] tempArray = textBox_SourceText.Lines;




            Console.WriteLine("textBox_SourceText.Lines.Length");
            if (tempArray.Length > 0)
            {

                for (int i=0; i< tempArray.Length; i++)
                {
                    //Console.WriteLine(i);
                    //Console.WriteLine(tempArray[i]);

                    tempArray[i] = textBox_Prefix.Text.Replace("[line]", tempArray[i]) + tempArray[i] + textBox_Postfix.Text.Replace("[line]", tempArray[i]);
                    //Console.WriteLine(tempArray[i]);

                }

                textBox_SourceText.Lines = tempArray;

            }

                

            





        }
    }
}
