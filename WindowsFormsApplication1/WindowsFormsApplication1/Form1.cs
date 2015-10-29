using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private readonly Model _model;

        public Form1()
        {
            InitializeComponent();
            _model = new Model();
            textBoxA.DataBindings.Add(nameof(textBoxA.Text), _model, nameof(_model.A), false, DataSourceUpdateMode.OnPropertyChanged);
            textBoxLower.DataBindings.Add(nameof(textBoxLower.Text), _model, nameof(_model.Lower), false, DataSourceUpdateMode.Never);
            textBoxUpper.DataBindings.Add(nameof(textBoxLower.Text), _model, nameof(_model.Upper), false, DataSourceUpdateMode.Never);
            cbUseThread.DataBindings.Add(nameof(cbUseThread.Checked), _model, nameof(_model.UseThread));
        }
    }
}
