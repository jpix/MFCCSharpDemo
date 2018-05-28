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

namespace ProxyClassLibrary
{
    public partial class DtNascitaPicker : UserControl
    {
        public DtNascitaPicker()
        {
            InitializeComponent();
        }

       public CFComponentN18.DataNascitaPicker.DataNascitaPicker DataNascitaPicker
        {
            get { return dataNascitaPicker1; }
            set { dataNascitaPicker1 = value; }
        }

       
    }
}
