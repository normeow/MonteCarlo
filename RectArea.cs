using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonteCarlo
{


    public partial class RectArea : UserControl, IArea
    {

        public RectArea()
        {
            InitializeComponent();
        }

        public Shape getShape()
        {
            return new Rect((int)cntrlX1.Value, (int)cntrlY1.Value, (int)cntrlX2.Value, (int)cntrlY2.Value);
        }
        
    }
}
