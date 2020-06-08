﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Externe_Vorspannung
{
    public partial class ReviewForces : Form
    {
        public ReviewForces(Cable k)
        {
            InitializeComponent();
            systemNameLabel.Text = k.systemName;
            nrCableLabel.Text = k.nrCable.ToString();
            quantityCableLabel.Text = k.quantityCable.ToString();
            prestressForceLabel.Text = k.prestressForce.ToString();

            for (int i = 0; i < k.Forces().GetLength(0); i++)
            {
                silyDataGridView.Rows.Add((i+1).ToString(), k.Forces()[i, 0].ToString("N2"), k.Forces()[i, 1].ToString("N2"));
                
            }
        }
    }
}
