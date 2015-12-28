using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TargetFramework
{
    public partial class ThreeWayTarget : UserControl
    {
        public ThreeWayTarget()
        {
            InitializeComponent();
        }

        [Browsable(true)]
        public string TargetName
        {
            set { groupBox1.Text = value; }
        }

        public string CurrentState
        {
            get
            {
                if (edgeOn.Checked)
                {
                    return "Edge-On";
                }
                else if (shoot.Checked)
                {
                    return "Shoot";
                }
                else if (noShoot.Checked)
                {
                    return "No Shoot";
                }

                return "Error";
            }
        }
    }
}
