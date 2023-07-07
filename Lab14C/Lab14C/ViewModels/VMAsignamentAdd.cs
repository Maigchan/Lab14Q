using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Lab14C.ViewModels
{
    public class VMAsignamentAdd : BaseViewModel
    {
        private string color;
        public string Color
        {
            get { return this.color; }
            set { SetValue(ref this.color, value); }
        }

        private List<Asignament> course;

        public List<Asignament> Course
        {
            get { return this.course; }
            set { SetValue(ref this.course, value); }
        }
    }
}