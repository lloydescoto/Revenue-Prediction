using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseUp += panel1_MouseUp;
            panel1.MouseMove += panel1_MouseMove;
        }
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkRadioButtons())
            {
                if (radioButton1.Checked)
                {
                    textBox1.Text = ((double.Parse(textBox16.Text) * double.Parse(textBox17.Text)) - (double.Parse(textBox15.Text))).ToString();
                    if(double.Parse(textBox1.Text) < 0) { textBox1.Text = (0).ToString(); }
                }
                if (radioButton2.Checked)
                {
                    textBox2.Text = (double.Parse(textBox1.Text) - (double.Parse(textBox6.Text) + double.Parse(textBox11.Text))).ToString();
                    if (double.Parse(textBox2.Text) < 0) { textBox2.Text = (0).ToString(); }
                }
                if (radioButton3.Checked)
                {
                    textBox6.Text = (double.Parse(textBox1.Text) - (double.Parse(textBox2.Text) + double.Parse(textBox11.Text))).ToString();
                    if (double.Parse(textBox6.Text) < 0) { textBox6.Text = (0).ToString(); }
                }
                if (radioButton4.Checked)
                {
                    textBox11.Text = (double.Parse(textBox1.Text) - (double.Parse(textBox2.Text) + double.Parse(textBox6.Text))).ToString();
                    if (double.Parse(textBox11.Text) < 0) { textBox11.Text = (0).ToString(); }
                }
                if (radioButton5.Checked)
                {
                    textBox3.Text = (double.Parse(textBox5.Text) / double.Parse(textBox4.Text)).ToString();
                    if (double.Parse(textBox3.Text) < 0) { textBox3.Text = (0).ToString(); }
                }
                if (radioButton6.Checked)
                {
                    textBox4.Text = (double.Parse(textBox5.Text) / double.Parse(textBox3.Text)).ToString();
                    if (double.Parse(textBox4.Text) < 0) { textBox4.Text = (0).ToString(); }
                }
                if (radioButton7.Checked)
                {
                    textBox5.Text = textBox2.Text;
                    if (double.Parse(textBox5.Text) < 0) { textBox5.Text = (0).ToString(); }
                }
                if (radioButton8.Checked)
                {
                    textBox7.Text = (double.Parse(textBox6.Text) / (double.Parse(textBox8.Text) + double.Parse(textBox9.Text))).ToString();
                    if (double.Parse(textBox7.Text) < 0) { textBox7.Text = (0).ToString(); }
                }
                if (radioButton9.Checked)
                {
                    textBox8.Text = ((double.Parse(textBox6.Text) - (double.Parse(textBox7.Text) * double.Parse(textBox9.Text))) / double.Parse(textBox7.Text)).ToString();
                    if (double.Parse(textBox8.Text) < 0) { textBox8.Text = (0).ToString(); }
                }
                if (radioButton10.Checked)
                {
                    textBox9.Text = ((double.Parse(textBox6.Text) - (double.Parse(textBox7.Text) * double.Parse(textBox8.Text))) / double.Parse(textBox7.Text)).ToString();
                    if (double.Parse(textBox9.Text) < 0) { textBox9.Text = (0).ToString(); }
                }
                if (radioButton11.Checked)
                {
                    textBox10.Text = (double.Parse(textBox17.Text) / double.Parse(textBox7.Text)).ToString();
                    if (double.Parse(textBox10.Text) < 0) { textBox10.Text = (0).ToString(); }
                }
                if (radioButton12.Checked)
                {
                    textBox12.Text = (double.Parse(textBox11.Text) - (double.Parse(textBox14.Text) + double.Parse(textBox13.Text))).ToString();
                    if (double.Parse(textBox12.Text) < 0) { textBox12.Text = (0).ToString(); }
                }
                if (radioButton13.Checked)
                {
                    textBox13.Text = (double.Parse(textBox11.Text) - (double.Parse(textBox12.Text) + double.Parse(textBox14.Text))).ToString();
                    if (double.Parse(textBox13.Text) < 0) { textBox13.Text = (0).ToString(); }
                }
                if (radioButton14.Checked)
                {
                    textBox14.Text = (double.Parse(textBox11.Text) - (double.Parse(textBox12.Text) + double.Parse(textBox13.Text))).ToString();
                    if (double.Parse(textBox14.Text) < 0) { textBox14.Text = (0).ToString(); }
                }
                if (radioButton15.Checked)
                {
                    textBox17.Text = ((double.Parse(textBox15.Text) + double.Parse(textBox1.Text)) / double.Parse(textBox16.Text)).ToString();
                    if (double.Parse(textBox17.Text) < 0) { textBox17.Text = (0).ToString(); }
                }
                if (radioButton16.Checked)
                {
                    textBox16.Text = ((double.Parse(textBox15.Text) + double.Parse(textBox1.Text)) / double.Parse(textBox17.Text)).ToString();
                    if (double.Parse(textBox16.Text) < 0) { textBox16.Text = (0).ToString(); }
                }
                if (radioButton17.Checked)
                {
                    textBox5.Text = (double.Parse(textBox3.Text) * double.Parse(textBox4.Text)).ToString();
                    textBox2.Text = textBox5.Text;
                    textBox6.Text = (double.Parse(textBox7.Text) * double.Parse(textBox8.Text) + double.Parse(textBox7.Text) * double.Parse(textBox9.Text)).ToString();
                    textBox10.Text = (double.Parse(textBox17.Text) / double.Parse(textBox7.Text)).ToString();
                    textBox11.Text = (double.Parse(textBox12.Text) + double.Parse(textBox13.Text) + double.Parse(textBox14.Text)).ToString();
                    textBox1.Text = (double.Parse(textBox2.Text) + double.Parse(textBox6.Text) + double.Parse(textBox11.Text)).ToString();
                    textBox15.Text = ((double.Parse(textBox17.Text) * double.Parse(textBox16.Text)) - double.Parse(textBox1.Text)).ToString();
                    if (double.Parse(textBox15.Text) < 0) { textBox15.Text = (0).ToString(); }
                }
            }
            if(!checkRadioButtons())
            {
                textBox5.Text = (double.Parse(textBox3.Text) * double.Parse(textBox4.Text)).ToString();
                textBox2.Text = textBox5.Text;
                textBox6.Text = (double.Parse(textBox7.Text) * double.Parse(textBox8.Text) + double.Parse(textBox7.Text) * double.Parse(textBox9.Text)).ToString();
                textBox10.Text = (double.Parse(textBox17.Text) / double.Parse(textBox7.Text)).ToString();
                textBox11.Text = (double.Parse(textBox12.Text) + double.Parse(textBox13.Text) + double.Parse(textBox14.Text)).ToString();
                textBox1.Text = (double.Parse(textBox2.Text) + double.Parse(textBox6.Text) + double.Parse(textBox11.Text)).ToString();
                textBox15.Text = ((double.Parse(textBox17.Text) * double.Parse(textBox16.Text)) - double.Parse(textBox1.Text)).ToString();
                if (double.Parse(textBox15.Text) < 0) { textBox15.Text = (0).ToString(); }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            radioButton9.Checked = false;
            radioButton10.Checked = false;
            radioButton11.Checked = false;
            radioButton12.Checked = false;
            radioButton13.Checked = false;
            radioButton14.Checked = false;
            radioButton15.Checked = false;
            radioButton16.Checked = false;
            radioButton17.Checked = false;
        }

        public bool checkRadioButtons()
        {
            if(radioButton1.Checked)
            {
                return true;
            }
            if (radioButton2.Checked)
            {
                return true;
            }
            if (radioButton3.Checked)
            {
                return true;
            }
            if (radioButton4.Checked)
            {
                return true;
            }
            if (radioButton5.Checked)
            {
                return true;
            }
            if (radioButton6.Checked)
            {
                return true;
            }
            if (radioButton7.Checked)
            {
                return true;
            }
            if (radioButton8.Checked)
            {
                return true;
            }
            if (radioButton9.Checked)
            {
                return true;
            }
            if (radioButton10.Checked)
            {
                return true;
            }
            if (radioButton11.Checked)
            {
                return true;
            }
            if (radioButton12.Checked)
            {
                return true;
            }
            if (radioButton13.Checked)
            {
                return true;
            }
            if (radioButton14.Checked)
            {
                return true;
            }
            if (radioButton15.Checked)
            {
                return true;
            }
            if (radioButton16.Checked)
            {
                return true;
            }
            if (radioButton17.Checked)
            {
                return true;
            }
            return false;
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            try { double.Parse(textBox17.Text);
                if (double.Parse(textBox17.Text) > double.Parse(textBox3.Text))
                { textBox17.Text = (0).ToString(); }
            } catch (System.Exception) { textBox17.Text = (0).ToString(); }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try { double.Parse(textBox1.Text); } catch (System.Exception) { textBox1.Text = (0).ToString(); }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try { double.Parse(textBox2.Text); } catch (System.Exception) { textBox2.Text = (0).ToString(); }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try { double.Parse(textBox3.Text); } catch (System.Exception) { textBox3.Text = (0).ToString(); }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try { double.Parse(textBox4.Text); } catch (System.Exception) { textBox4.Text = (0).ToString(); }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try { double.Parse(textBox5.Text); } catch (System.Exception) { textBox5.Text = (0).ToString(); }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try { double.Parse(textBox6.Text); } catch (System.Exception) { textBox6.Text = (0).ToString(); }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try { double.Parse(textBox7.Text); } catch (System.Exception) { textBox7.Text = (0).ToString(); }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            try { double.Parse(textBox8.Text); } catch (System.Exception) { textBox8.Text = (0).ToString(); }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            try { double.Parse(textBox9.Text); } catch (System.Exception) { textBox9.Text = (0).ToString(); }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            try { double.Parse(textBox10.Text); } catch (System.Exception) { textBox10.Text = (0).ToString(); }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            try { double.Parse(textBox11.Text); } catch (System.Exception) { textBox11.Text = (0).ToString(); }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            try { double.Parse(textBox12.Text); } catch (System.Exception) { textBox12.Text = (0).ToString(); }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            try { double.Parse(textBox13.Text); } catch (System.Exception) { textBox13.Text = (0).ToString(); }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            try { double.Parse(textBox14.Text); } catch (System.Exception) { textBox14.Text = (0).ToString(); }
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            try { double.Parse(textBox16.Text); } catch (System.Exception) { textBox16.Text = (0).ToString(); }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            try { double.Parse(textBox15.Text); } catch(System.Exception) { textBox15.Text = (0).ToString(); }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
