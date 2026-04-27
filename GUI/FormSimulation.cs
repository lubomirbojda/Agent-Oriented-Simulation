using OSPABA;
using OSPAnimatorGIS;
using Simulation;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace GUI
{
    public partial class FormSimulation : Form
    {
        private ElementHost _WPFHost;
        private MySimulation _simulation;

        public FormSimulation()
        {
            InitializeComponent();
            _simulation = new MySimulation();
            _simulation.CreateAnimator();
            _WPFHost = new ElementHost();
            _WPFHost.Dock = DockStyle.Fill;
            _WPFHost.Child = _simulation.Animator.Canvas;
            tabPageAnimation.Controls.Add(_WPFHost);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void StartSimButton_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
