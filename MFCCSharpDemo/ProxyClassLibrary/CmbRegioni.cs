/* ** ** ** ** ** ** ** ** ** ** **

MFC Components and Controls demo

Copyright 2018 Giuseppe Pischedda
All rights reserved

https://www.software-on-demand-ita.com

This project is released under MIT license

** ** ** ** ** ** ** ** ** ** ** **/



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CFComponentN18.RegioniDropDownList;

namespace ProxyClassLibrary
{
    public partial class CmbRegioni : UserControl
    {
        public CmbRegioni()
        {
            InitializeComponent();
        }

        public RegioniDropDownList RegioniDropDownList
        {
            get { return regioniDropDownList1; }
            set { regioniDropDownList1 = value; }
        }
    }
}
