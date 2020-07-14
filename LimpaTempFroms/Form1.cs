using System;
using System.Drawing;
using System.IO;
using System.Security.Policy;
using System.Windows.Forms;

namespace LimpaTempFroms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            AtualTempFiles();
            AtualComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (string s in LocalDatas.TempDirectory())
                    Directory.Delete(s, true);
            }
            catch (UnauthorizedAccessException)
            {
                labelStatus.ForeColor = Color.Green;
                labelStatus.Text = "LIMPO";
            }
            catch (System.IO.IOException exc)
            {
                labelStatus.ForeColor = Color.Blue;
                labelStatus.Text = "LIMPO";
            }
            catch (Exception exc)
            {
                labelStatus.ForeColor = Color.Red;
                labelStatus.Text = "FALHA";
            }

            FormMain_Load(sender, e);
        }

        private void AtualTempFiles()
        {
            labelQtdTempFiles.Text = LocalDatas.QtdTempFiles().ToString();
        }

        private void AtualComboBox()
        {
            if(comboBoxLocals.Items.Count == 0)
                comboBoxLocals.Items.AddRange(LocalDatas.TempDirectory().ToArray());
        }

        private void comboBoxLocals_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelQtdTempFiles.Text = LocalDatas.QtdTempFiles(comboBoxLocals.SelectedItem.ToString()).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Directory.Delete(comboBoxLocals.SelectedItem.ToString(), true);
            }
            catch (UnauthorizedAccessException)
            {
                labelStatus.ForeColor = Color.Green;
                labelStatus.Text = "LIMPO";
            }
            catch (System.IO.IOException exc)
            {
                labelStatus.ForeColor = Color.Blue;
                labelStatus.Text = "LIMPO";
            }
            catch (Exception exc)
            {
                labelStatus.ForeColor = Color.Red;
                labelStatus.Text = "FALHA";
            }
        }
    }
}
