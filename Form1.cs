using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Web.Script.Serialization;

namespace json_emoji
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Root> GetEmjList()
        {
            JavaScriptSerializer dataJS = new JavaScriptSerializer();

            string contentJs = File.ReadAllText("smiley_content.json");

            return dataJS.Deserialize<List<Root>>(contentJs);            



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var lisT = GetEmjList();
            DisplayEmjList(lisT);

        }

        private void DisplayEmjList(List<Root> lisT)
        {
            foreach (Root item in lisT)
            {
                Label lbl = new Label() (Text = item.category);
                lbl.AutoSize = false;
                lbl.Width = this.ClientSize.Width;
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.Margin = new Padding(0, 20, 0, 20);
                flowLayoutPanel1.SetFlowBreak(lbl, true);



            }

        }
    }
}
