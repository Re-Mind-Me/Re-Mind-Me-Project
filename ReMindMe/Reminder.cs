using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReMindMe
{
    public class Reminder
    {
        public int Id
        { get; set; }
        public string Date
        { get; set; }
        public string Time
        { get; set; }
        public string Note
        { get; set; }
    }
}