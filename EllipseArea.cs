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
    public partial class EllipseArea : UserControl, IArea
    {
        public EllipseArea()
        {
            InitializeComponent();
        }

        public Shape getShape()
        {
            return new Ellipse((int)cntrlX1.Value, (int)cntrlY1.Value, (int)cntrlA.Value, (int)cntrlB.Value);
        }
    }
}
