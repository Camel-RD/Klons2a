using System.ComponentModel;
using System.Runtime.InteropServices;
using NM = KlonsLIB.Components.NM;

namespace KlonsLIB.Components
{
    //[ToolboxBitmap(typeof(TabControl), "TabControl.bmp")]
    [DefaultProperty(nameof(TabPages))]
    public class ExTabControl : TabControl
    {
        private const int TCN_FIRST = -550;
        private const int TCN_SELCHANGING = TCN_FIRST - 2;
        private const int WM_REFLECT = NM.WM_USER + 0x1C00;

        private Color _activeHeaderBackColor;
        private Color _activeHeaderForeColor;

        private Color _backcolor = Color.Empty;
        private Color _borderColor;
        private int _borderThickness;

        private bool _defaultStyle;
        private Color _headerBackColor;
        private Color _headerForeColor;
        private Color _highlightBackColor;
        private Color _highlightForeColor;
        private int _hoverIndex = -1;

        public ExTabControl()
        {
            _defaultStyle = true;
            _borderColor = Color.LightGray;
            _headerForeColor = Color.Black;
            _headerBackColor = SystemColors.Control;
            _activeHeaderForeColor = Color.Black;
            _activeHeaderBackColor = Color.White;
            _highlightBackColor = SystemColors.GradientInactiveCaption;
            _highlightForeColor = Color.Black;
            _borderThickness = 1;

            Invalidate();
        }

        /// <summary>
        ///     Color of the TabControl's border.
        /// </summary>
        [Browsable(true)]
        [Category("Appearance")]
        [DefaultValue(typeof(Color), "LightGray")]
        [Description("Color of the TabControl's border.")]
        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                if (_borderColor == value)
                    return;
                _borderColor = value;
                Invalidate();
            }
        }

        /// <summary>
        ///     Foreground color of the Tab header.
        /// </summary>
        [Browsable(true)]
        [Category("Appearance")]
        [DefaultValue(typeof(Color), "Black")]
        [Description("Foreground color of the Tab header.")]
        public Color HeaderForeColor
        {
            get => _headerForeColor;
            set
            {
                if (_headerForeColor == value)
                    return;
                _headerForeColor = value;
                Invalidate();
            }
        }

        /// <summary>
        ///     Background color of the Tab header.
        /// </summary>
        [Browsable(true)]
        [Category("Appearance")]
        [DefaultValue(typeof(SystemColors), "Control")]
        [Description("Background color of the Tab header.")]
        public Color HeaderBackColor
        {
            get => _headerBackColor;
            set
            {
                if (_headerBackColor == value)
                    return;
                _headerBackColor = value;
                Invalidate();
            }
        }

        /// <summary>
        ///     Foreground color of the active Tab header.
        /// </summary>
        [Browsable(true)]
        [Category("Appearance")]
        [DefaultValue(typeof(Color), "White")]
        [Description("Background color of the active Tab header.")]
        public Color ActiveHeaderBackColor
        {
            get => _activeHeaderBackColor;
            set
            {
                if (_activeHeaderBackColor == value)
                    return;
                _activeHeaderBackColor = value;
                Invalidate();
            }
        }

        /// <summary>
        ///     Foreground color of the active Tab header.
        /// </summary>
        [Browsable(true)]
        [Category("Appearance")]
        [DefaultValue(typeof(Color), "Black")]
        [Description("Foreground color of the active Tab header.")]
        public Color ActiveHeaderForeColor
        {
            get => _activeHeaderForeColor;
            set
            {
                if (_activeHeaderForeColor == value)
                    return;
                _activeHeaderForeColor = value;
                Invalidate();
            }
        }

        /// <summary>
        ///     Background color of the hovered Tab header.
        /// </summary>
        [Browsable(true)]
        [Category("Appearance")]
        [DefaultValue(typeof(SystemColors), "GradientInactiveCaption")]
        [Description("Background color of the hovered Tab header.")]
        public Color HighlightBackColor
        {
            get => _highlightBackColor;
            set
            {
                if (_highlightBackColor == value)
                    return;
                _highlightBackColor = value;
                Invalidate();
            }
        }

        /// <summary>
        ///     Foreground color of the hovered Tab header.
        /// </summary>
        [Browsable(true)]
        [Category("Appearance")]
        [DefaultValue(typeof(Color), "Black")]
        [Description("Foreground color of the hovered Tab header.")]
        public Color HighlightForeColor
        {
            get => _highlightForeColor;
            set
            {
                if (_highlightForeColor == value)
                    return;
                _highlightForeColor = value;
                Invalidate();
            }
        }

        /// <summary>
        ///     Width of the TabControl's border.
        /// </summary>
        [Browsable(true)]
        [Category("Appearance")]
        [DefaultValue(1)]
        [Description("Width of the TabControl's border.")]
        public int BorderThickness
        {
            get => _borderThickness;
            set
            {
                if (_borderThickness == value)
                    return;
                _borderThickness = value;
                Invalidate();
            }
        }

        /// <summary>
        ///     The background color used to display text and graphics in a control.
        /// </summary>
        [Browsable(true)]
        [Description("The background color used to display text and graphics in a control.")]
        public override Color BackColor
        {
            get
            {
                if (_backcolor == Color.Empty)
                    return Parent?.BackColor ?? DefaultBackColor;

                return _backcolor;
            }
            set
            {
                if (_backcolor == value) return;
                _backcolor = value;
                Invalidate();
                base.OnBackColorChanged(EventArgs.Empty);
            }
        }

        /// <summary>Occurs when the <see cref="IExControl.DefaultStyle" /> property changes.</summary>
        [Category("Changed Property")]
        [Description("Occurs when the BorderColor property changes.")]
        public event EventHandler DefaultStyleChanged;

        /// <inheritdoc />
        [Browsable(true)]
        [Category("Appearance")]
        [DefaultValue(true)]
        [Description("Default style of the Control.")]
        public bool DefaultStyle
        {
            get => _defaultStyle;
            set
            {
                if (_defaultStyle == value)
                    return;
                _defaultStyle = value;
                DrawMode = value ? TabDrawMode.Normal : TabDrawMode.OwnerDrawFixed;
                Invalidate();
            }
        }

        [DefaultValue(true)]
        [Category("Behavior")]
        public bool ShowTabStrip { get; set; } = true;


        /// <summary>
        ///     Occurs as a tab is being changed
        /// </summary>
        [Description("Occurs as a tab is being changed.")]
        public event EventHandler<TabPageChangeEventArgs> SelectedIndexChanging;

        /// <inheritdoc />
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            if (!DefaultStyle)
            {
                SetStyle(ControlStyles.UserPaint, true);
                SetStyle(ControlStyles.DoubleBuffer, true);
                SetStyle(ControlStyles.ResizeRedraw, true);
                SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            }
        }

        /// <inheritdoc />
        public override void ResetBackColor()
        {
            _backcolor = Color.Empty;
            Invalidate();
        }

        /// <inheritdoc />
        protected override void OnParentBackColorChanged(EventArgs e)
        {
            base.OnParentBackColorChanged(e);
            Invalidate();
        }

        /// <inheritdoc />
        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            base.OnSelectedIndexChanged(e);
            Invalidate();
        }

        /// <inheritdoc />
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (DefaultStyle)
                return;

            e.Graphics.Clear(BackColor);
            if (TabCount <= 0 || SelectedTab == null) return;

            //Draw a custom background for Transparent TabPages
            var border = SelectedTab.Bounds;
            border.Y++;
            border.Inflate(3, 3);

            //Draw a border around TabPage
            const ButtonBorderStyle bs = ButtonBorderStyle.Solid;
            using var paintBrush = new SolidBrush(BorderColor);
            ControlPaint.DrawBorder(e.Graphics, border,
                paintBrush.Color, BorderThickness, bs,
                paintBrush.Color, BorderThickness, bs,
                paintBrush.Color, BorderThickness, bs,
                paintBrush.Color, BorderThickness, bs);

            SolidBrush brush;

            //Draw the Tabs
            for (var index = 0; index < TabCount; index++)
            {
                var tp = TabPages[index];
                var page = border;
                page.Inflate(-1, -1);
                brush = new SolidBrush(tp.BackColor == Color.Transparent ? ActiveHeaderBackColor : tp.BackColor);
                e.Graphics.FillRectangle(brush, page);
                brush.Dispose();
                var r = GetTabRect(index);
                if (Protrudes(ClientRectangle, r))
                    continue;
                r.Inflate(1, 1);
                r.Width--;
                r.Height--;
                r.Y++;
                if (index == SelectedIndex)
                    continue;

                if (_hoverIndex == index)
                {
                    paintBrush.Color = BorderColor;
                    brush = new SolidBrush(HighlightBackColor);
                    e.Graphics.FillRectangle(brush, r);
                    brush.Dispose();
                    ControlPaint.DrawBorder(e.Graphics, r, paintBrush.Color, bs);
                }
                else
                {
                    paintBrush.Color = BorderColor;
                    brush = new SolidBrush(HeaderBackColor);
                    e.Graphics.FillRectangle(brush, r);
                    brush.Dispose();
                    ControlPaint.DrawBorder(e.Graphics, r, paintBrush.Color, bs);
                }

                Draw(index, r, tp);
            }

            var ra = GetTabRect(SelectedIndex);
            ra.Inflate(1, 0);
            ra.Width--;
            ra.Height += 3;
            ra.Y -= 2;
            paintBrush.Color = BorderColor;
            brush = new SolidBrush(ActiveHeaderBackColor);
            e.Graphics.FillRectangle(brush, ra);
            brush.Dispose();
            ControlPaint.DrawBorder(e.Graphics, ra,
                paintBrush.Color, 1, bs,
                paintBrush.Color, 1, bs,
                paintBrush.Color, 1, bs,
                paintBrush.Color, 0, bs);

            Draw(SelectedIndex, ra, SelectedTab);


            void Draw(int index, Rectangle r, TabPage tp)
            {
                //Set up rotation for left and right aligned tabs
                if (Alignment is TabAlignment.Left or TabAlignment.Right)
                {
                    float rotateAngle = 90;
                    if (Alignment == TabAlignment.Left) rotateAngle = 270;
                    var cp = new PointF(r.Left + (r.Width >> 1), r.Top + (r.Height >> 1));
                    e.Graphics.TranslateTransform(cp.X, cp.Y);
                    e.Graphics.RotateTransform(rotateAngle);
                    r = new Rectangle(-(r.Height >> 1), -(r.Width >> 1), r.Height, r.Width);
                }

                //Draw the Tab Text
                var sf = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center,
                    FormatFlags = StringFormatFlags.NoWrap
                };
                if (tp.Enabled)
                {
                    //TextRenderer.DrawText(e.Graphics, tp.Text, Font, r,
                    //_hoverIndex == index && index != SelectedIndex ? HighlightForeColor : HeaderForeColor);
                    using var brush = new SolidBrush(_hoverIndex == index && index != SelectedIndex ? HighlightForeColor : HeaderForeColor);
                    e.Graphics.DrawString(tp.Text, Font, brush, r, sf);
                }
                else
                    ControlPaint.DrawStringDisabled(e.Graphics, tp.Text, Font, tp.ForeColor, r, sf);

                e.Graphics.ResetTransform();
            }
        }

        private static bool Protrudes(Rectangle rec1, Rectangle rec2)
        {
            return !rec1.Contains(rec2) && rec1.IntersectsWith(rec2);
        }

        /// <inheritdoc />
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (DefaultStyle)
            {
                base.OnMouseMove(e);
                return;
            }

            for (var i = 0; i < TabCount; i++)
                if (GetTabRect(i).Contains(e.Location))
                {
                    if (_hoverIndex != i)
                    {
                        _hoverIndex = i;
                        Invalidate();
                    }

                    return;
                }

            if (_hoverIndex != -1)
            {
                _hoverIndex = -1;
                Invalidate();
            }
        }

        /// <inheritdoc />
        protected override void OnMouseLeave(EventArgs e)
        {
            if (DefaultStyle)
            {
                base.OnMouseLeave(e);
                return;
            }

            if (_hoverIndex != -1)
            {
                _hoverIndex = -1;
                Invalidate();
            }
        }

        /// <inheritdoc />
        protected unsafe override void WndProc(ref Message m)
        {
            if (m.Msg == NM.TCM_ADJUSTRECT && !DesignMode && !ShowTabStrip)
            {
                m.Result = 1;
                return;
            }
            if (m.Msg == WM_REFLECT + NM.WM_NOTIFY)
            {
                var hdr = (NM.NMHDR)Marshal.PtrToStructure(m.LParam, typeof(NM.NMHDR));
                if (hdr.code == TCN_SELCHANGING)
                {
                    var tp = TestTab(PointToClient(Cursor.Position));
                    if (tp != null)
                    {
                        var e = new TabPageChangeEventArgs(SelectedTab, tp);
                        SelectedIndexChanging?.Invoke(this, e);
                        if (e.Cancel || tp.Enabled == false)
                        {
                            m.Result = new nint(1);
                            return;
                        }
                    }
                }
            }
            if (m.Msg == (int)NM.ComCtl32.TCM.GETITEMRECT)
            {
                base.WndProc(ref m);
                int k = (int)m.WParam;
                if (m.Result == nint.Zero || k < 0 || k >= TabCount)
                    return;
                NM.RECT* pRect = (NM.RECT*)m.LParam;
                var tab_rects = GetTabSizes();
                var cr = tab_rects[k];
                //*pRect = cr;
                pRect->Left = cr.Left;
                pRect->Right = cr.Right;
                m.Result = 1;
                return;
            }
            base.WndProc(ref m);
        }

        public Rectangle[] GetTabSizes()
        {
            var ret = new Rectangle[TabCount];
            if (TabCount == 0) return ret;
            using (var gr = CreateGraphics())
            {
                for (int i = 0; i < TabCount; i++)
                {
                    var txt = TabPages[i].Text;
                    var sz = gr.MeasureString(txt, Font);
                    ret[i].Width = (int)sz.Width + 10;
                    ret[i].Height = (int)sz.Height + 8;
                }
            }
            ret[0].X = 2;
            ret[0].Y = 2;
            for (int i = 1; i < TabCount; i++)
            {
                ret[i].X = ret[i - 1].Right + 2;
            }
            return ret;
        }


        private TabPage TestTab(Point pt)
        {
            for (var index = 0; index <= TabCount - 1; index++)
                if (GetTabRect(index).Contains(pt.X, pt.Y))
                    return TabPages[index];
            return null;
        }

        /// <summary>Raises the <see cref="IExControl.DefaultStyleChanged" /> event.</summary>
        protected virtual void OnDefaultStyleChanged() => DefaultStyleChanged?.Invoke(this, EventArgs.Empty);

        protected override void ScaleControl(SizeF factor, BoundsSpecified specified)
        {
            base.ScaleControl(factor, specified);
        }

    }

    /// <summary>
    ///     Event arguments for the <see cref="ExTabControl.SelectedIndexChanging"/> event.
    /// </summary>
    public class TabPageChangeEventArgs : EventArgs
    {
        /// <summary>
        ///     Gets or sets whether the event should be canceled.
        /// </summary>
        public bool Cancel { get; set; }

        /// <summary>
        ///     Constructor
        /// </summary>
        /// <param name="currentTab">current Tab</param>
        /// <param name="newTab">new tab</param>
        public TabPageChangeEventArgs(TabPage currentTab, TabPage newTab)
        {
            CurrentTab = currentTab;
            NewTab = newTab;
        }

        /// <summary>
        ///     Gets the current selected Tab.
        /// </summary>
        public TabPage CurrentTab { get; }


        /// <summary>
        ///     Gets the Tab that is to become current.
        /// </summary>
        public TabPage NewTab { get; }
    }
}