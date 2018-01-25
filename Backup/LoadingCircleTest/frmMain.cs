//#####################################################################################
//★★★★★★★           http://www.cnpopsoft.com [华普软件]           ★★★★★★★
//★★★★★★★           华普软件-VB、C#专业论文与源码荟萃！           ★★★★★★★
//#####################################################################################

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CNPOPSOFT.Controls
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            loadingCircle.Active = true;
            loadingCircleFF.Active = true;
            loadingCircleIE7.Active = true;
            loadingCircleMacOSX.Active = true;
        }

        private void btnDesactivate_Click(object sender, EventArgs e)
        {
            loadingCircle.Active = false;
            loadingCircleFF.Active = false;
            loadingCircleIE7.Active = false;
            loadingCircleMacOSX.Active = false;
        }

        private void nudInnerCircleRadius_ValueChanged(object sender, EventArgs e)
        {
            loadingCircle.InnerCircleRadius = (int)nudInnerCircleRadius.Value;
        }

        private void nudNumberSpoke_ValueChanged(object sender, EventArgs e)
        {
            loadingCircle.NumberSpoke = (short)nudNumberSpoke.Value;
        }

        private void nudSpokesThickness_ValueChanged(object sender, EventArgs e)
        {
            loadingCircle.SpokeThickness = (int)nudSpokesThickness.Value;
        }

        private void nudOuterCircleRadius_ValueChanged(object sender, EventArgs e)
        {
            loadingCircle.OuterCircleRadius = (int)nudOuterCircleRadius.Value;
        }

        private void cbColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadingCircle.Color = Color.FromKnownColor((System.Drawing.KnownColor)Enum.Parse(typeof(System.Drawing.KnownColor), cbColors.SelectedItem.ToString()));
        }

        private void nudRotationSpeed_ValueChanged(object sender, EventArgs e)
        {
            loadingCircle.RotationSpeed = (int)nudRotationSpeed.Value;
        }

        private void btnMacOSXStyle_Click(object sender, EventArgs e)
        {
            nudNumberSpoke.Value = 12;
            nudSpokesThickness.Value = 2;
            nudInnerCircleRadius.Value = 5;
            nudOuterCircleRadius.Value = 11;
            nudRotationSpeed.Value = 80;
        }

        private void btnFireFoxStyle_Click(object sender, EventArgs e)
        {
            nudNumberSpoke.Value = 9;
            nudSpokesThickness.Value = 4;
            nudInnerCircleRadius.Value = 6;
            nudOuterCircleRadius.Value = 7;
            nudRotationSpeed.Value = 80;
        }

        private void btnIE7Style_Click(object sender, EventArgs e)
        {
            nudNumberSpoke.Value = 36;
            nudSpokesThickness.Value = 4;
            nudInnerCircleRadius.Value = 8;
            nudOuterCircleRadius.Value = 9;
            nudRotationSpeed.Value = 20;
        }

        private void lnkMartinGagne_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:martingagne@gmail.com?subject=LoadingCircle");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            foreach (string strColor in Enum.GetNames(typeof(System.Drawing.KnownColor)))
            {
                cbColors.Items.Add(strColor);
            }

            nudNumberSpoke.Value = loadingCircle.NumberSpoke;
            nudSpokesThickness.Value = loadingCircle.SpokeThickness;
            nudInnerCircleRadius.Value = loadingCircle.InnerCircleRadius;
            nudOuterCircleRadius.Value = loadingCircle.OuterCircleRadius;
            nudRotationSpeed.Value = loadingCircle.RotationSpeed;
            cbColors.SelectedIndex = cbColors.FindString(loadingCircle.Color.ToKnownColor().ToString());
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.cnpopsoft.com");
        }
    }
}