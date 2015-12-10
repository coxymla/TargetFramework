using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TargetFramework
{
    public partial class Form1 : Form
    {
        BindingList<SequenceItem> _sequence = new BindingList<SequenceItem>();
        private TextBox[] _targets;
        private SerialPort _serialPort = null;
         
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = _sequence;
            _targets = new[] {t1_txt, t2_txt, t3_txt, t4_txt, t5_txt, t6_txt, t7_txt, t8_txt,};
        }

        private void addTargetArrayToSequenceBtn_Click(object sender, EventArgs e)
        {
            if (_sequence.Any() && _sequence.Last().Type == SequenceItemType.Array)
            {
                MessageBox.Show("You must insert a Delay between Target changes.");
                return;
            }

            _sequence.Add(new SequenceItem() { Type = SequenceItemType.Array, Description = GetCurrentTargetArray(), Relays = GetCurrentRelays() });
        }

        private bool[] GetCurrentRelays()
        {
            var relays = new bool[16];

            for (var i = 0; i < _targets.Length; i++)
            {
                var target = _targets[i];
                SetTargetRelays(relays, target, i*2);
            }

            return relays;
        }

        private void SetTargetRelays(bool[] relays, TextBox target, int index)
        {
            if (target.Text == "S")
            {
                relays[index + 0] = true;
                relays[index + 1] = false;
            }
            else
            {
                relays[index + 0] = false;
                relays[index + 1] = true;
            }
        }

        private string GetCurrentTargetArray()
        {
            return $"Display Target Array: T1:{t1_txt.Text}, T2:{t2_txt.Text}, T3:{t3_txt.Text}, T4:{t4_txt.Text}, T5:{t5_txt.Text}, T6:{t6_txt.Text}, T7:{t7_txt.Text}, T8:{t8_txt.Text}";
        }

        private void addDelayToSequenceBtn_Click(object sender, EventArgs e)
        {
            _sequence.Add(new SequenceItem() { Type = SequenceItemType.Delay, Description = $"Delay: {delay.Text} second(s)", Delay = GetDelay() });
        }

        private int GetDelay()
        {
            int delayMs = -99;
            if (int.TryParse(delay.Text, out delayMs))
            {
                return delayMs * 1000;
            }

            throw new ApplicationException("Delay must be an integer.");
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
            try
            {
                if (_serialPort == null)
                {
                    _serialPort = new SerialPort(serialPort.Text, 9600, Parity.None, 8, StopBits.One);
                }

                if (!_serialPort.IsOpen)
                {
                    _serialPort.Open();
                }

                var bytes = new byte[5];
                bytes[0] = BitConverter.GetBytes('x')[0];
                bytes[3] = BitConverter.GetBytes('/')[0];
                bytes[4] = BitConverter.GetBytes('/')[0];

                foreach (var sequenceItem in _sequence)
                {
                    if (sequenceItem.Type == SequenceItemType.Delay)
                    {
                        Thread.Sleep(sequenceItem.Delay);
                    }
                    else
                    {
                        var relays = new Relays();
                        if (sequenceItem.Relays[0])
                        {
                            relays = relays | Relays.Relay1;
                        }
                        if (sequenceItem.Relays[1])
                        {
                            relays = relays | Relays.Relay2;
                        }
                        if (sequenceItem.Relays[2])
                        {
                            relays = relays | Relays.Relay3;
                        }
                        if (sequenceItem.Relays[3])
                        {
                            relays = relays | Relays.Relay4;
                        }
                        if (sequenceItem.Relays[4])
                        {
                            relays = relays | Relays.Relay5;
                        }
                        if (sequenceItem.Relays[5])
                        {
                            relays = relays | Relays.Relay6;
                        }
                        if (sequenceItem.Relays[6])
                        {
                            relays = relays | Relays.Relay7;
                        }
                        if (sequenceItem.Relays[7])
                        {
                            relays = relays | Relays.Relay8;
                        }

                        bytes[1] = (byte) relays;

                        relays = Relays.None;
                        if (sequenceItem.Relays[8])
                        {
                            relays = relays | Relays.Relay1;
                        }
                        if (sequenceItem.Relays[9])
                        {
                            relays = relays | Relays.Relay2;
                        }
                        if (sequenceItem.Relays[10])
                        {
                            relays = relays | Relays.Relay3;
                        }
                        if (sequenceItem.Relays[11])
                        {
                            relays = relays | Relays.Relay4;
                        }
                        if (sequenceItem.Relays[12])
                        {
                            relays = relays | Relays.Relay5;
                        }
                        if (sequenceItem.Relays[13])
                        {
                            relays = relays | Relays.Relay6;
                        }
                        if (sequenceItem.Relays[14])
                        {
                            relays = relays | Relays.Relay7;
                        }
                        if (sequenceItem.Relays[15])
                        {
                            relays = relays | Relays.Relay8;
                        }

                        bytes[2] = (byte) relays;

                        _serialPort.Write(bytes, 0, 5);
                    }
                }

                _serialPort.Close();
            }
            finally
            {
                if (_serialPort != null)
                {
                    _serialPort.Dispose();
                    _serialPort = null;
                }
            }
        }
    }
}
