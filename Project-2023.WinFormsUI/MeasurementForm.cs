using Project_2023.Models;
using Project_2023.Models.Measurements;

namespace Project_2023.WinFormsUI
{
    public partial class MeasurementForm : Form
    {
        public Measurement Measurement { get; private set; } = null!;
        public Unit Unit { get; private set; } = null!;
        private MeasurementType type;
        private SystemConvert system;
        private readonly List<Unit> lengthUnits = new() { LengthUnits.Inch, LengthUnits.Foot, LengthUnits.Yard, LengthUnits.Mile };
        private readonly List<Unit> weightUnits = new() { WeightUnits.Pound, WeightUnits.Stone, WeightUnits.Ounce };
        public MeasurementForm(MeasurementType type, SystemConvert system)
        {
            InitializeComponent();
            this.type = type;
            this.system = system;
            label3.Text = (system == SystemConvert.Metric) ? "Конвертуємо з" : "Конвертуємо в";
            if (type == MeasurementType.Length)
            {
                comboBox1.Items.AddRange(lengthUnits.ToArray());
            }
            else
            {
                comboBox1.Items.AddRange(weightUnits.ToArray());
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(numericUpDown1.Value);
                Unit = (Unit)comboBox1.SelectedItem;
                if (system == SystemConvert.Metric)
                {
                    Measurement = (type == MeasurementType.Length) ? new Length(value, Unit) : new Weight(value, Unit);
                }
                else
                {
                    Measurement = (type == MeasurementType.Length) ? new Length(value) : new Weight(value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
