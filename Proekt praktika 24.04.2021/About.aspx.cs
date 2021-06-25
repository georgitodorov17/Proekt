using System;
using Proekt_praktika_24._04._2021.RandomAlgorithums;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proekt_praktika_24._04._2021
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IntRandom ir = new IntRandom();

        }
        protected string result;
        string massage2 = string.Empty;
        public void GenerateButton_Click(object sender, EventArgs e)
        {
            try
            {
                IntRandom ir = new IntRandom();
                result = ir.IntGenerator(int.Parse(textIterations.Text), int.Parse(Min.Text), int.Parse(Max.Text));
            }
            catch (FormatException)
            {
                massage2 = "error";
            }
        }
    }
}