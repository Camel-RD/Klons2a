using System;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using KlonsLIB.Data;
using KlonsLIB.Forms;
using KlonsLIB.Misc;
using MyLib7;

namespace KlonsLIB.Components
{
    [DesignerSerializer("System.Windows.Forms.Design.ToolStripCodeDomSerializer, " + MyAssemblyRef.SystemDesign, "System.ComponentModel.Design.Serialization.CodeDomSerializer, " + MyAssemblyRef.SystemDesign)]
    [Designer("System.Windows.Forms.Design.ToolStripDesigner, " + MyAssemblyRef.SystemDesign)]
    [DefaultProperty(nameof(Items))]
    public class MyBindingNavigator : BindingNavigator, ISupportInitialize
    {
        private bool initializing = false;

        public MyBindingNavigator()
        {
            if(KlonsLIB.MyData.Settings != null)
                this.Renderer = new MyToolStripRenderer(KlonsLIB.MyData.Settings.ColorTheme);
            DataGrid = null;
            CountItemFormat = " no {0}";
            InitialImageScalingFactor.Width = ImageScalingSize.Width / 16.0f;
            InitialImageScalingFactor.Height = ImageScalingSize.Height / 16.0f;
        }

        SizeF InitialImageScalingFactor = SizeF.Empty;

        [DefaultValue(typeof(Size), "16,16")]
        [Category("Appearance")]
        public new Size ImageScalingSize
        {
            get
            {
                return base.ImageScalingSize;
            }
            set
            {
                // DPI scaling is applied to the default ImageSize in the ToolStrip constructor
                // when ImageScalingSize is assigned a value in InitializeComponent, DPI scaling is ignored
                // default ImageScalingSize is (16, 16)
                if (InitialImageScalingFactor == SizeF.Empty)
                {
                    base.ImageScalingSize = value;
                }
                else
                {
                    var sz = value;
                    sz.Width = (int)((float)sz.Width * InitialImageScalingFactor.Width);
                    sz.Height = (int)((float)sz.Height * InitialImageScalingFactor.Height);
                    base.ImageScalingSize = sz;
                }
            }
        }


        private System.Windows.Forms.ToolStripButton _SaveItem = null;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool DoAddStandardItems
        {
            get => false;
            set
            {
                if (value)
                    AddStandardItems();
            }
        }

        public override void AddStandardItems()
        {
            if (Items.Count > 1) return;

            //
            // Create items
            //

            MoveFirstItem = new System.Windows.Forms.ToolStripButton();
            MovePreviousItem = new System.Windows.Forms.ToolStripButton();
            MoveNextItem = new System.Windows.Forms.ToolStripButton();
            MoveLastItem = new System.Windows.Forms.ToolStripButton();
            PositionItem = new System.Windows.Forms.ToolStripTextBox();
            CountItem = new System.Windows.Forms.ToolStripLabel();
            AddNewItem = new System.Windows.Forms.ToolStripButton();
            DeleteItem = new System.Windows.Forms.ToolStripButton();
            SaveItem = new System.Windows.Forms.ToolStripButton();

            ToolStripSeparator separator1 = new System.Windows.Forms.ToolStripSeparator();
            ToolStripSeparator separator2 = new System.Windows.Forms.ToolStripSeparator();
            ToolStripSeparator separator3 = new System.Windows.Forms.ToolStripSeparator();

            //
            // Set up strings
            //

            // Hacky workaround for VSWhidbey 407243
            // Default to lowercase for null name, because C# dev is more likely to create controls programmatically than
            // vb dev.
            char ch = string.IsNullOrEmpty(Name) || char.IsLower(Name[0]) ? 'b' : 'B';

            MoveFirstItem.Name = ch + "indingNavigatorMoveFirstItem";
            MovePreviousItem.Name = ch + "indingNavigatorMovePreviousItem";
            MoveNextItem.Name = ch + "indingNavigatorMoveNextItem";
            MoveLastItem.Name = ch + "indingNavigatorMoveLastItem";
            PositionItem.Name = ch + "indingNavigatorPositionItem";
            CountItem.Name = ch + "indingNavigatorCountItem";
            AddNewItem.Name = ch + "indingNavigatorAddNewItem";
            DeleteItem.Name = ch + "indingNavigatorDeleteItem";
            SaveItem.Name = ch + "indingNavigatorSaveItem";
            separator1.Name = ch + "indingNavigatorSeparator";
            separator2.Name = ch + "indingNavigatorSeparator";
            separator3.Name = ch + "indingNavigatorSeparator";

            MoveFirstItem.Text = "Iet uz pirmo";
            MovePreviousItem.Text = "Iet uz iepriekšējo";
            MoveNextItem.Text = "Iet uz nākošo";
            MoveLastItem.Text = "Iet uz pēdējo";
            AddNewItem.Text = "Jauns";
            DeleteItem.Text = "Dzēst";
            SaveItem.Text = "Saglabāt";

            CountItem.ToolTipText = "Ierakstu skaits";
            PositionItem.ToolTipText = "Pašreizējā pozīcija";
            CountItem.AutoToolTip = false;
            PositionItem.AutoToolTip = false;

            //
            // Set up images
            //

            Bitmap GetBitmapFromIcon(Type t, string name)
            {
                Icon b = new Icon(t, name);
                Bitmap bitmap = b.ToBitmap();
                b.Dispose();
                return bitmap;
            }

            /*
            Bitmap moveFirstImage = GetBitmapFromIcon(typeof(BindingNavigator), "BindingNavigator.MoveFirst");
            Bitmap movePreviousImage = GetBitmapFromIcon(typeof(BindingNavigator), "BindingNavigator.MovePrevious");
            Bitmap moveNextImage = GetBitmapFromIcon(typeof(BindingNavigator), "BindingNavigator.MoveNext");
            Bitmap moveLastImage = GetBitmapFromIcon(typeof(BindingNavigator), "BindingNavigator.MoveLast");
            */
            Bitmap addNewImage = GetBitmapFromIcon(typeof(BindingNavigator), "BindingNavigator.AddNew");
            Bitmap deleteImage = GetBitmapFromIcon(typeof(BindingNavigator), "BindingNavigator.Delete");

            Bitmap moveFirstImage = Resource1.MoveFirst;
            Bitmap movePreviousImage = Resource1.MovePrevious;
            Bitmap moveNextImage = Resource1.MoveNext;
            Bitmap moveLastImage = Resource1.MoveLast;

            GetSaveImages();

            MoveFirstItem.Image = moveFirstImage;
            MovePreviousItem.Image = movePreviousImage;
            MoveNextItem.Image = moveNextImage;
            MoveLastItem.Image = moveLastImage;
            AddNewItem.Image = addNewImage;
            DeleteItem.Image = deleteImage;
            SaveItem.Image = SaveBlue;

            MoveFirstItem.RightToLeftAutoMirrorImage = true;
            MovePreviousItem.RightToLeftAutoMirrorImage = true;
            MoveNextItem.RightToLeftAutoMirrorImage = true;
            MoveLastItem.RightToLeftAutoMirrorImage = true;
            AddNewItem.RightToLeftAutoMirrorImage = true;
            DeleteItem.RightToLeftAutoMirrorImage = true;

            MoveFirstItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            MovePreviousItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            MoveNextItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            MoveLastItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            AddNewItem.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            DeleteItem.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;

            //
            // Set other random properties
            //
            PositionItem.AutoSize = false;
            PositionItem.Width = 50;

            //
            // Add items to strip
            //

            var newitems = new ToolStripItem[] {
                                MoveFirstItem,
                                MovePreviousItem,
                                separator1,
                                PositionItem,
                                CountItem,
                                separator2,
                                MoveNextItem,
                                MoveLastItem,
                                separator3,
                                AddNewItem,
                                DeleteItem,
                                SaveItem
                                };

            Items.AddRange(newitems);
            if (Site?.Container != null)
            {
                foreach (var item in newitems)
                    Site.Container.Add(item);
            }
        }

        [TypeConverter(typeof(ReferenceConverter)),
        Category("My"),
        DefaultValue(null)]
        public MyDataGridView DataGrid { get; set; }


        [TypeConverter(typeof(ReferenceConverter)),
        Category("Items")]
        public new ToolStripItem DeleteItem
        {
            get
            {
                return base.DeleteItem;
            }

            set
            {
                base.DeleteItem = value;
                if (value == null) return;
                Utils.ClearEventInvocations(value, "s_clickEvent");
                value.Click += OnDelete;
            }
        }


        [TypeConverter(typeof(ReferenceConverter)),
        Category("Items")]
        public new ToolStripItem AddNewItem
        {
            get
            {
                return base.AddNewItem;
            }

            set
            {
                base.AddNewItem = value;
                if (value == null) return;
                Utils.ClearEventInvocations(value, "s_clickEvent");
                value.Click += OnAddNew;
            }
        }


        [TypeConverter(typeof(ReferenceConverter)),
        Category("Items")]
        public ToolStripButton SaveItem
        {
            get
            {
                return _SaveItem;
            }

            set
            {
                if (value == null)
                {
                    if(_SaveItem != null) _SaveItem.Click -= OnSaveClicked;
                    _SaveItem = null;
                    return;
                }
                _SaveItem = value;
                _SaveItem.Click += OnSaveClicked;
            }
        }

        public event CancelEventHandler ItemDeleting;
        public event EventHandler ItemDeleted;
        public event EventHandler SaveClicked;

        private void OnDelete(object sender, EventArgs e)
        {
            DeleteCurrent();
        }

        private void OnAddNew(object sender, EventArgs e)
        {
            try
            {
                AddNew();
            }
            catch (Exception )
            {
                
            }
        }

        private void OnSaveClicked(object sender, EventArgs e)
        {
            if (SaveClicked != null)
                SaveClicked(this, new EventArgs());
        }


        private void ShowException(Exception e)
        {
            if (DataGrid != null)
                Form_Error.ShowException(e, DataGrid);
            else if (BindingSource is MyBindingSource2)
                Form_Error.ShowException(e, BindingSource as MyBindingSource2);
            else
                Form_Error.ShowException(e);
        }

        public void DeleteCurrent()
        {
            if (this.DataGrid != null)
            {
                if (this.DataGrid.CurrentRow == null || this.DataGrid.CurrentRow.IsNewRow) return;
                if (!this.DataGrid.EndEditX()) return;
            }
            if (!Validate()) return;
            if (BindingSource == null) return;

            CancelEventArgs ce = new CancelEventArgs();
            if (ItemDeleting != null)
            {
                ItemDeleting(this, ce);
                if (ce.Cancel) return;
            }
            try
            {
                BindingSource.RemoveCurrent();
            }
            catch(Exception e)
            {
                ShowException(e);
            }
            RefreshItemsInternal2();
            if (ItemDeleted != null)
            {
                ItemDeleted(this, new EventArgs());
            }
        }
        public void AddNew()
        {
            if (!Validate()) return;
            if (BindingSource == null) return;

            if (DataGrid != null)
            {
                if (!DataGrid.AllowUserToAddRows || DataGrid.ReadOnly) return;
                DataGrid.Focus();
                DataGrid.MoveToNewRow();
            }
            else
            {
                BindingSource.AddNew();
            }

            RefreshItemsInternal2();
        }

        private void RefreshItemsInternal2()
        {
            if (initializing)
            {
                return;
            }
            OnRefreshItems();
        }
        
        void ISupportInitialize.BeginInit()
        {
            initializing = true;
            base.BeginInit();
        }

        void ISupportInitialize.EndInit()
        {
            initializing = false;
            base.EndInit();
        }

        private static Image SaveBlue = null;
        private static Image SaveRed = null;

        private void GetSaveImages()
        {
            if (SaveBlue != null) return;
            SaveBlue = KlonsLIB.Resource1.Save1;
            SaveRed = KlonsLIB.Resource1.Save2;
        }

        public void SetSaveButton(ToolStripButton tsb, bool red)
        {
            int isred = red ? 1 : 0;
            Image im;
            GetSaveImages();
            if (red) im = SaveRed;
            else im = SaveBlue;
            tsb.Image = im;
        }

        private bool IsSaveButtonRed = false;

        public void SetSaveButtonRed(bool red)
        {
            if (SaveItem == null) return;
            if (IsSaveButtonRed == red) return;
            IsSaveButtonRed = red;
            GetSaveImages();
            var im = red ? SaveRed : SaveBlue;
            SaveItem.Image = im;
        }


    }
}
