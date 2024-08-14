using System.ComponentModel;
using System.Data;
using System.Drawing.Design;
using KlonsLIB.Components;
using System;
using System.Collections;
using MyLib7.ObjectSelector;
using MyLib7.Data;
using Equin.ApplicationFramework;
using MyLib7.BindingListView;
using KGySoft.ComponentModel;

namespace KlonsLIB.Data
{
    public class MyBindingSourceEf : BindingSource
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new object DataSource
        {
            get { return base.DataSource; }
            set
            {
                if (!string.IsNullOrEmpty(_MyDataSource.DataMember?.Value)) return;
                base.DataSource = value;
            }
        }

        private KlonsDbSetSelector _MyDataSource = KlonsDbSetSelector.Empty;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IBindingListView BindingListView { get; protected set; } = null;

        [Category("Data")]
        [RefreshProperties(RefreshProperties.All)]
        public KlonsDbSetSelector MyDataSource
        {
            get => _MyDataSource;
            set
            {
                if (_MyDataSource.Equals(value)) return;
                _MyDataSource = new KlonsDbSetSelector(value?.DataSource, value?.DataMember);
                var dbsetbl = KlonsDataModuleEF.St.GetDbSetBindingList(_MyDataSource.DataSource, _MyDataSource.DataMember);
                if (dbsetbl == null)
                {
                    if (_MyDataSource.DataMember?.Value != null && _MyDataSource.DataSource?.Value != null)
                        _MyDataSource = KlonsDbSetSelector.Empty;
                    SetDataSourceAsListView(null);
                    //base.DataSource = null;
                    return;
                }
                SetDataSourceAsListView(dbsetbl);
                //base.DataSource = dbsetbl;
            }
        }

        protected void SetDataSourceAsListView(object new_datasource)
        {
            var current_datarasource = DataSource;
            if (current_datarasource != null && current_datarasource is IMyBindingListView imblv)
            {
                imblv.KillView();
            }
            if (new_datasource == null)
            {
                base.DataSource = null;
                BindingListView = null;
                return;
            }
            var tp = new_datasource.GetType();
            if (new_datasource is IBindingList && tp.IsGenericType &&
                tp.IsAssignableTo(typeof(BindingList<>).MakeGenericType(tp.GenericTypeArguments)))
            {
                var tp_blv = typeof(BindingListView<>);
                object new_blv = null;
                bool rt = Reflector.TryCreateInstanceByType(tp_blv, tp.GenericTypeArguments, ReflectionWays.Auto, false, out new_blv);
                if (!rt)
                {
                    base.DataSource = new_datasource;
                    BindingListView = null;
                    return;
                }
                var source_lists = new List<object> { new_datasource };
                var imyblv = new_blv as IMyBindingListView;
                imyblv.SourceLists = source_lists;
                imyblv.NewItemsList = new_datasource as IList; 
                base.DataSource = new_blv;
                BindingListView = new_blv as IBindingListView;
                return;
            }
            base.DataSource = new_datasource;
            BindingListView = null;
        }

        public MyBindingSourceEf() : base()
        {
        }


        public MyBindingSourceEf(System.ComponentModel.IContainer container) : this() {
            if (container == null)
            {
                throw new ArgumentNullException("container");
            }

            container.Add(this);
        }

        public MyBindingSourceEf(object dataSource, string dataMember) : base(dataSource, dataMember) 
        {

        }

    }


}
