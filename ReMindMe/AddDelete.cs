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
    class AddDelete
    {
        ArrayList Alist;
        ArrayAdapter Aadpt;
        public AddDelete(ArrayAdapter adapter, ArrayList list)
        {
            this.Aadpt = adapter;
            this.Alist = list;
        }
        public Boolean add(String name)
        {
            try
            {
                Alist.Add(name);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public Boolean delete(int id)
        {
            try
            {
                Alist.RemoveAt(id);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}