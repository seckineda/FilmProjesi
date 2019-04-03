﻿using FilmClassLib.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmProjesi.Formlar
{
    public partial class FilmOyuncuEkle : Form
    {
        public FilmOyuncuEkle()
        {
            InitializeComponent();
            CbRol.DataSource = Enum.GetNames(typeof(RolTipi));
        }
    }
}
