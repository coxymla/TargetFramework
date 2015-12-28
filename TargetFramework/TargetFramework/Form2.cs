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
    public partial class Form2 : Form
    {
        BindingList<SequenceItem> _sequence = new BindingList<SequenceItem>();
        private ThreeWayTarget[] _targets;
        private SerialPort _serialPort = null;
            
        public Form2()
        {
            InitializeComponent();
            dataGridView1.DataSource = _sequence;

            _targets = new[]
            {
                T1,
                T2,
                T3,
                T4,
                T5,
                T6,
                T7,
                T8,
            };

            foreach (var target in _targets)
            {
                target.TargetName = target.Name;
            }
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

        private string GetCurrentTargetArray()
        {
            return $"Display Target Array: T1:{T1.CurrentState}, T2:{T2.CurrentState}, T3:{T3.CurrentState}, T4:{T4.CurrentState}, T5:{T5.CurrentState}, T6:{T6.CurrentState}, T7:{T7.CurrentState}, T8:{T8.CurrentState}";
        }

        private bool[] GetCurrentRelays()
        {
            var relays = new bool[16];

            for (var i = 0; i < _targets.Length; i++)
            {
                var target = _targets[i];
                SetTargetRelays(relays, target, i * 2);
            }

            return relays;
        }

        private void SetTargetRelays(bool[] relays, ThreeWayTarget target, int index)
        {
            switch (target.CurrentState)
            {
                case "Shoot":
                    relays[index + 0] = true;
                    relays[index + 1] = false;
                    break;
                case "No Shoot":
                    relays[index + 0] = false;
                    relays[index + 1] = true;
                    break;
                case "Edge-On":
                    relays[index + 0] = false;
                    relays[index + 1] = false;
                    break;

            }
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

        private void clearSequence_Click(object sender, EventArgs e)
        {
            _sequence.Clear();
        }

        private void runSequence_Click(object sender, EventArgs e)
        {
            try
            {
                //if (_serialPort == null)
                //{
                //    _serialPort = new SerialPort(serialPort.Text, 9600, Parity.None, 8, StopBits.One);
                //}

                //if (!_serialPort.IsOpen)
                //{
                //    _serialPort.Open();
                //}

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

                        bytes[1] = (byte)relays;

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

                        bytes[2] = (byte)relays;

                        //_serialPort.Write(bytes, 0, 5);
                    }
                }

                //_serialPort.Close();
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
