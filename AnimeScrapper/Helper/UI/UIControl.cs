using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimeScrapper.Helper.UI
{
    public class UIControl
    {
        #region HoverOnLabel

        public static void HoverOnLabel(Label lbl)
        {
            lbl.ForeColor = Color.FromArgb(225, 27, 42);
        }

        #endregion

        #region PlainOnLabel

        public static void PlainOnLabel(Label lbl)
        {
            lbl.ForeColor = Color.White;
        }

        #endregion
    }
}
