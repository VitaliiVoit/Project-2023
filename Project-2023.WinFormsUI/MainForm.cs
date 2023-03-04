using Project_2023.Models;
using Project_2023.Models.Converters;
using Project_2023.Models.Measurements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2023.WinFormsUI
{
    public enum SystemConvert { Metric, NoMetric }
    public partial class MainForm : Form
    {
        private IMetricConverter converter;
        private MeasurementType type;
        private SystemConvert system;
        private Measurement measurement = null!;
        private Unit unit = null!;
        public MainForm()
        {
            InitializeComponent();
            converter = new LengthConverter();
            type = MeasurementType.Length;
            system = SystemConvert.Metric;
        }

        private void OpenMeasurementForm_Click(object sender, EventArgs e)
        {
            var measurementForm = new MeasurementForm(type, system);
            if (measurementForm.ShowDialog() == DialogResult.OK)
            {
                measurement = measurementForm.Measurement;
                unit = measurementForm.Unit;
                textBox1.Text = $"{measurementForm.Measurement}";
            }
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            try
            {
                Measurement convertedMeasurement;
                if (system == SystemConvert.Metric)
                {
                    convertedMeasurement = converter.ConvertToMetric(measurement);
                }
                else
                {
                    convertedMeasurement = converter.ConvertFromMetric(measurement, unit);
                }
                textBox2.Text = $"{convertedMeasurement}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ChooseLengthConverter_CheckedChanged(object sender, EventArgs e)
        {
            converter = new LengthConverter();
            type = MeasurementType.Length;
        }

        private void ChooseWeightConverter_CheckedChanged(object sender, EventArgs e)
        {
            converter = new WeightConverter();
            type = MeasurementType.Weigth;
        }

        private void ChooseMetricSystem_CheckedChanged(object sender, EventArgs e)
        {
            system = SystemConvert.Metric;
        }

        private void ChooseNoMetricSystem_CheckedChanged(object sender, EventArgs e)
        {
            system = SystemConvert.NoMetric;
        }
    }
}
