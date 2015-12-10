using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TargetFramework
{
    public partial class Form1 : Form
    {
        BindingList<SequenceItem> _sequence = new BindingList<SequenceItem>();
         
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = _sequence;
        }

        private void addTargetArrayToSequenceBtn_Click(object sender, EventArgs e)
        {
            if (_sequence.Any() && _sequence.Last().Type == SequenceItemType.Array)
            {
                MessageBox.Show("You must insert a Delay between Target changes.");
                return;
            }

            _sequence.Add(new SequenceItem() { Type = SequenceItemType.Array, Description = GetCurrentTargetArray()});
        }

        private string GetCurrentTargetArray()
        {
            return $"Display Target Array: T1:{t1_txt.Text}, T2:{t2_txt.Text}, T3:{t3_txt.Text}, T4:{t4_txt.Text}, T5:{t5_txt.Text}, T6:{t6_txt.Text}, T7:{t7_txt.Text}, T8:{t8_txt.Text}";
        }

        private void addDelayToSequenceBtn_Click(object sender, EventArgs e)
        {
            _sequence.Add(new SequenceItem() { Type = SequenceItemType.Delay, Description = $"Delay: {delay.Text} second(s)" });
        }

        private void ChangeTarget(Button buttonToEnable, Button buttonToDisable, TextBox textBoxToUpdate, string text)
        {
            buttonToEnable.Enabled = true;
            buttonToDisable.Enabled = false;
            textBoxToUpdate.Text = text;

            if (text == "S")
            {
                textBoxToUpdate.BackColor = System.Drawing.SystemColors.Control;
            }
            else
            {
                textBoxToUpdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            }
        }

        private void t1_s_btn_Click(object sender, EventArgs e)
        {
            ChangeTarget(t1_ns_btn, t1_s_btn, t1_txt, "S");
        }

        private void t1_ns_btn_Click(object sender, EventArgs e)
        {
            ChangeTarget(t1_s_btn, t1_ns_btn, t1_txt, "NS");
        }

        private void t2_s_btn_Click(object sender, EventArgs e)
        {
            ChangeTarget(t2_ns_btn, t2_s_btn, t2_txt, "S");
        }

        private void t2_ns_btn_Click(object sender, EventArgs e)
        {
            ChangeTarget(t2_s_btn, t2_ns_btn, t2_txt, "NS");
        }

        private void t3_s_btn_Click(object sender, EventArgs e)
        {
            ChangeTarget(t3_ns_btn, t3_s_btn, t3_txt, "S");
        }

        private void t3_ns_btn_Click(object sender, EventArgs e)
        {
            ChangeTarget(t3_s_btn, t3_ns_btn, t3_txt, "NS");
        }

        private void t4_s_btn_Click(object sender, EventArgs e)
        {
            ChangeTarget(t4_ns_btn, t4_s_btn, t4_txt, "S");
        }

        private void t4_ns_btn_Click(object sender, EventArgs e)
        {
            ChangeTarget(t4_s_btn, t4_ns_btn, t4_txt, "NS");
        }

        private void t5_s_btn_Click(object sender, EventArgs e)
        {
            ChangeTarget(t5_ns_btn, t5_s_btn, t5_txt, "S");
        }

        private void t5_ns_btn_Click(object sender, EventArgs e)
        {
            ChangeTarget(t5_s_btn, t5_ns_btn, t5_txt, "NS");
        }

        private void t6_s_btn_Click(object sender, EventArgs e)
        {
            ChangeTarget(t6_ns_btn, t6_s_btn, t6_txt, "S");
        }

        private void t6_ns_btn_Click(object sender, EventArgs e)
        {
            ChangeTarget(t6_s_btn, t6_ns_btn, t6_txt, "NS");
        }

        private void t7_s_btn_Click(object sender, EventArgs e)
        {
            ChangeTarget(t7_ns_btn, t7_s_btn, t7_txt, "S");
        }

        private void t7_ns_btn_Click(object sender, EventArgs e)
        {
            ChangeTarget(t7_s_btn, t7_ns_btn, t7_txt, "NS");
        }

        private void t8_s_btn_Click(object sender, EventArgs e)
        {
            ChangeTarget(t8_ns_btn, t8_s_btn, t8_txt, "S");
        }

        private void t8_ns_btn_Click(object sender, EventArgs e)
        {
            ChangeTarget(t8_s_btn, t8_ns_btn, t8_txt, "NS");
        }

        private void clearSequence_Click(object sender, EventArgs e)
        {
            _sequence.Clear();
        }

        private void runSequence_Click(object sender, EventArgs e)
        {

        }
    }
}
