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
    public partial class TxtNome : UserControl
    {
        public TxtNome()
        {
            InitializeComponent();
        }

        public CFComponentN18.NomeTextBox.NomeTextBox NomeTextBox
        {
            get { return nomeTextBox1; }
            set { nomeTextBox1 = value; }
        }
    }
}
