using Proekt_praktika_24._04._2021.RandomAlgorithums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proekt_praktika_24._04._2021
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        string message = string.Empty;
        protected void GenerateButton_Click(object sender, EventArgs e)
        {
            try
            {
                DoubleRandom randomDoubles = new DoubleRandom();
                DataTable tableRandom = randomDoubles.GetRandomNumbersData(int.Parse(textIterations.Text),
                    int.Parse(textDecimals.Text));
                tableRandom.DefaultView.Sort = "Times desc";
                tableRandom = tableRandom.DefaultView.ToTable();
                repeater.DataSource = tableRandom;
                repeater.DataBind();
            }
            catch(FormatException)
            {
                message= "error";
            }
            
          
            


        }

    }
}