using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Timers;
using System.Runtime.InteropServices;


public class Slide
{

    public void SLIDER(PictureBox _Slide3, PictureBox _Slide2, PictureBox _Slide1, RadioButton _btn_Slide3, RadioButton _btn_Slide2, RadioButton _btn_Slide1)
    {
        if (_Slide3.Visible == true)
        {
            _btn_Slide3_click(_Slide3,_Slide1,_Slide2, _btn_Slide3, _btn_Slide2, _btn_Slide1);
            _btn_Slide2_click(_Slide2, _Slide1, _Slide3, _btn_Slide3, _btn_Slide2, _btn_Slide1);
        }
        else if (_Slide2.Visible == true)
        {
            _btn_Slide2_click(_Slide2,_Slide1,_Slide3, _btn_Slide3, _btn_Slide2, _btn_Slide1);
            _btn_Slide1_click(_Slide1, _Slide2, _Slide3, _btn_Slide3, _btn_Slide2, _btn_Slide1);
        }
        else if (_Slide1.Visible == true)
        {
            _btn_Slide1_click(_Slide1,_Slide2,_Slide3, _btn_Slide3, _btn_Slide2, _btn_Slide1);
            _btn_Slide3_click(_Slide3, _Slide1, _Slide2, _btn_Slide3, _btn_Slide2, _btn_Slide1);
        }
    }

    public static class Util
    {
        public enum Effect { Roll, Slide, Center, Blend }

        public static void Animate(Control ctl, Effect effect, int msec, int angle)
        {
            int flags = effmap[(int)effect];

            if (ctl.Visible)
            {
                flags |= 0x10000; angle += 360;
            }
            else
            {
                if (ctl.TopLevelControl == ctl) flags |= 0x1000;
                else if (effect == Effect.Blend) throw new ArgumentException();
            }
            flags |= dirmap[(angle % 360) / 1];
            bool ok = AnimateWindow(ctl.Handle, msec, flags);
            if (!ok) throw new Exception("Animation failed");
            ctl.Visible = !ctl.Visible;
        }

        private static int[] dirmap = { 1, 5, 4, 6, 2, 10, 8, 9 };
        private static int[] effmap = { 0, 0x40000, 0x10, 0x80000 };

        [DllImport("user32.dll")]
        private static extern bool AnimateWindow(IntPtr handle, int msec, int tags);
    }
    public void _btn_Slide3_click(PictureBox _Slide3, PictureBox _Slide1, PictureBox _Slide2, RadioButton _btn_Slide3, RadioButton _btn_Slide2, RadioButton _btn_Slide1)
    {
        _Slide3.BringToFront();

        Util.Animate(_Slide3, Util.Effect.Slide, 360, 360);

        _btn_Slide3.Checked = false;
        _btn_Slide2.Checked = false;
        _btn_Slide1.Checked = true;

        _Slide2.Visible = false;
        _Slide1.Visible = false;
    }

    public void _btn_Slide2_click(PictureBox _Slide2, PictureBox _Slide1, PictureBox _Slide3, RadioButton _btn_Slide3, RadioButton _btn_Slide2, RadioButton _btn_Slide1)
    {
        _Slide2.BringToFront();

        Util.Animate(_Slide2, Util.Effect.Slide, 360, 360);

        _btn_Slide3.Checked = false;
        _btn_Slide2.Checked = true;
        _btn_Slide1.Checked = false;


        _Slide3.Visible = false;
        _Slide1.Visible = false;
    }

    public void _btn_Slide1_click(PictureBox _Slide1, PictureBox _Slide2, PictureBox _Slide3, RadioButton _btn_Slide3, RadioButton _btn_Slide2, RadioButton _btn_Slide1)
    {
        _Slide1.BringToFront();

        Util.Animate(_Slide1, Util.Effect.Slide, 360, 360);

        _btn_Slide3.Checked = true;
        _btn_Slide2.Checked = false;
        _btn_Slide1.Checked = false;


        _Slide2.Visible = false;
        _Slide3.Visible = false;
    }
}