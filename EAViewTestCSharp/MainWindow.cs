﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EAViewEngine;


namespace EAViewTestCSharp
{
    public partial class MainWindow : Form
    {
        EAViewGlobe ea;
        public MainWindow()
        {
            try
            {
                InitializeComponent();
                ea = this.eaViewGlobeControl1.Object as EAViewGlobe;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            
        }

        private void loadModelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog oDlg = new OpenFileDialog();
                oDlg.Filter = "模型文件|*.osg;*.osgt;*.ive";
                oDlg.Multiselect = false;
                if (oDlg.ShowDialog()==DialogResult.OK)
                {
                    ea.LoadOSGModel(oDlg.FileName);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            
        }

        private void loadProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog oDlg = new OpenFileDialog();
                oDlg.Filter = "工程文件|*.eaml";
                oDlg.Multiselect = false;
                if (oDlg.ShowDialog() == DialogResult.OK)
                {
                    ea.LoadProject(oDlg.FileName);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
    }
}
