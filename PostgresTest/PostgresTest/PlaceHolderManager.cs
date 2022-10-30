using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PostgresTest
{
    public static class PlaceHolderManager
    {
        public static void AddPlaceHolder(this TextBox tb, string PlaceHolderText)
        {
            tb.ForeColor = Color.Gray;
            tb.Text = PlaceHolderText;

            tb.Enter += (s, e) =>
            {
                if (tb.Text == PlaceHolderText)
                {
                    tb.Text = "";
                    tb.ForeColor = Color.Black;
                }
            };

            tb.Leave += (s, e) =>
            {
                if (tb.Text == "")
                {
                    tb.ForeColor = Color.Gray;
                    tb.Text = PlaceHolderText;
                }
            };
        }
    }
}
