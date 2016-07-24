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
    public partial class CircleArea : UserControl, IArea
    {
        public CircleArea()
        {
            InitializeComponent();
        }

        public Shape getShape()
        {
            return new Circle((int)cntrlX1.Value, (int)cntrlY1.Value, (int)cntrlR.Value);
        }
    }
}
