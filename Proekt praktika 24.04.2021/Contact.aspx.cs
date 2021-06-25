using Proekt_praktika_24._04._2021.RandomAlgorithums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proekt_praktika_24._04._2021
{
    public partial class Contact : Page
    {
        protected string result;
        protected void Page_Load(object sender, EventArgs e){}
        string message1 = string.Empty;
        public void GenerateButton_Click(object sender, EventArgs e)
        {
            try
            {
                BoolRandom br = new BoolRandom();

                result = br.BoolRandomGenerator(int.Parse(textIterations.Text));
            }
            catch (FormatException)
            {
                message1= "error";
            }
        }
       
    }
}