﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTimeStarted
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
            OnStart();

        }

        public void OnStart()
        {
            Form f = FindForm();
            f.Controls.Add(new MenuScreen());

        }
        
       
    }
}