using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class clsDrag
{
    Point lastPoint;
    public void drag(Control c, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            c.Left += e.X - lastPoint.X;
            c.Top += e.Y - lastPoint.Y;
        }
    }
    public void down(MouseEventArgs e)
    {
        lastPoint = new Point(e.X, e.Y);
    }
}
