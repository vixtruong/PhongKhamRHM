using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhongKhamDaKhoa.Group8.RJControls
{
    public class Calendar : MonthCalendar
    {
        private Color backgroundColor = Color.White;

        [Category("Custom Properties")]
        public Color BackgroundColor
        {
            get { return backgroundColor; }
            set
            {
                backgroundColor = value;
                this.Invalidate();
            }
        }

        public Calendar()
        {
            this.BackColor = backgroundColor;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Rectangle rect = this.ClientRectangle;
            using (SolidBrush brush = new SolidBrush(backgroundColor))
            {
                e.Graphics.FillRectangle(brush, rect);
            }
        }

        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
        {
            int newWidth = Math.Max(225, width);
            int newHeight = Math.Max(180, height);
            base.SetBoundsCore(x, y, newWidth, newHeight, specified);
        }
    }
}
