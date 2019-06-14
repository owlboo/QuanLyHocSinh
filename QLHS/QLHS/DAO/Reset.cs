using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS.DAO
{
    class Reset
    {
        public static void ResetAllControls(Control form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                }

                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Items.Count > 0)
                        comboBox.SelectedIndex = 0;
                }

                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }

                if (control is ListBox)
                {
                    ListBox listBox = (ListBox)control;
                    listBox.ClearSelected();
                }

                if (control is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)control;
                    radioButton.Checked = false;
                }
                if (control is DateTimePicker)
                {
                    DateTimePicker dateTimePicker = (DateTimePicker)control;
                    dateTimePicker.ResetText();
                }
                if (control is PictureBox)
                {
                    PictureBox pictureBox = (PictureBox)control;
                    pictureBox.Hide();
                }
            }

        }
        public static void ResetFocus(Control textbox1, Control textbox2)
        {
            if (textbox1.Focus() == true)
            {
                textbox2.Focus();
            }
            else if (textbox2.Focus() == true)
            {
                textbox1.Focus();
            }
        }
        public static bool CheckTextControl(Control form)
        {
            int count = 0;

            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    if (textBox.Text == "")
                    {
                        return true;
                    }
                }
                if (control is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)control;
                    if (!radioButton.Checked)
                    {
                        count++;
                    }
                }
            }
            if (count == 2)
                return true;
            return false;
        }
        public static void ChangeFocus(Control form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    if (textBox.Text == "")
                    {
                        textBox.Focus();
                    }
                }
            }
        }
    }
}
