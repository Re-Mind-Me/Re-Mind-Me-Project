using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace ReMindMe
{
    [Activity(Label = "", MainLauncher = true)]
    public class MainActivity : Activity
    {
        ArrayList namelist;
        ListView Vlist;
        ArrayAdapter adapter;
        AddDelete op;
        EditText Etext;
        Button addBtn, deleteBtn;

        int selectedItem = -1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(ReMindMe.Resource.Layout.List);

            Vlist = FindViewById<ListView>(ReMindMe.Resource.Id.lv);
            Etext = FindViewById<EditText>(ReMindMe.Resource.Id.nameTxt);
            addBtn = FindViewById<Button>(ReMindMe.Resource.Id.addBtn);
            deleteBtn = FindViewById<Button>(ReMindMe.Resource.Id.deleteBtn);

            namelist = new ArrayList();

            adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, namelist);
            Vlist.Adapter = adapter;

            op = new AddDelete(adapter, namelist);

            Vlist.ItemClick += lv_ItemClick;
            addBtn.Click += addBtn_Click;
            deleteBtn.Click += deleteBtn_Click;
        }
        void deleteBtn_Click(object sender, EventArgs e)
        {
            if (op.delete(selectedItem))
            {
                Etext.Text = "";
                adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, namelist);
                Vlist.Adapter = adapter;
            }
        }
        void addBtn_Click(object sender, EventArgs e)
        {
            if (op.add(Etext.Text))
            {
                Etext.Text = "";
                adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, namelist);
                Vlist.Adapter = adapter;
            }
        }
        void lv_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            this.selectedItem = e.Position;
            Etext.Text = namelist[selectedItem].ToString();
        }
    }
}