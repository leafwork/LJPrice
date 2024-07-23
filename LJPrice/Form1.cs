using System.Runtime.InteropServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace LJPrice
{

    public partial class MainForm : Form
    {
        Item currentItem;
        public MainForm()
        {
            currentItem = new Item();
            InitializeComponent();

        }

        public class Item
        {
            public string name { get; set; } = "Item";
            public float rpi1 { get; set; }
            public float inches1 { get; set; }
            public float rpu1 { get; set; }
            public float ppu1 { get; set; }
            public float rpi2 { get; set; }
            public float inches2 { get; set; }
            public float rpu2 { get; set; }
            public float ppu2 { get; set; }
            public float findings { get; set; }
            public float lpr { get; set; }
            public float overhead { get; set; }
            public int rings1 { get; set; }
            public int rings2 { get; set; }
            public float units1 { get; set; }
            public float cost1 { get; set; }
            public float units2 { get; set; }
            public float cost2 { get; set; }
            public float materialcost { get; set; }
            public float totallabor { get; set; }
            public float finalprice { get; set; }

        }

        private void txtRPI1_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtInches1_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtRPU1_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtPPU1_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtRPI2_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtInches2_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtRPU2_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtPPU2_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtFindings_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtLPR_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtOverhead_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void buttonClear1_Click(object sender, EventArgs e)
        {
            txtRPI1.Text = "0";
            txtInches1.Text = "0";
            txtRPU1.Text = "0";
            txtPPU1.Text = "0";
        }

        private void buttonClear2_Click(object sender, EventArgs e)
        {
            txtRPI2.Text = "0";
            txtInches2.Text = "0";
            txtRPU2.Text = "0";
            txtPPU2.Text = "0";
        }

        public void Calculate()
        {

            //get inputs
            currentItem.name = txtItemName.Text;

            currentItem.rpi1 = float.Parse("0" + txtRPI1.Text);
            currentItem.inches1 = float.Parse("0" + txtInches1.Text);
            currentItem.rpu1 = float.Parse("0" + txtRPU1.Text);
            currentItem.ppu1 = float.Parse("0" + txtPPU1.Text);

            currentItem.rpi2 = float.Parse("0" + txtRPI2.Text);
            currentItem.inches2 = float.Parse("0" + txtInches2.Text);
            currentItem.rpu2 = float.Parse("0" + txtRPU2.Text);
            currentItem.ppu2 = float.Parse("0" + txtPPU2.Text);

            currentItem.findings = float.Parse("0" + txtFindings.Text);
            currentItem.lpr = float.Parse("0" + txtLPR.Text);
            currentItem.overhead = float.Parse("0" + txtOverhead.Text);

            //calculate materials
            currentItem.rings1 = (int)Math.Ceiling(currentItem.rpi1 * currentItem.inches1);
            currentItem.rings2 = (int)Math.Ceiling(currentItem.rpi2 * currentItem.inches2);

            if (currentItem.inches1 != 0 && currentItem.rpu1 != 0)
            {
                currentItem.units1 = currentItem.rings1 / currentItem.rpu1;
                currentItem.cost1 = currentItem.units1 * currentItem.ppu1;
            }

            if (currentItem.inches2 != 0 && currentItem.rpu2 != 0)
            {
                currentItem.units2 = currentItem.rings2 / currentItem.rpu2;
                currentItem.cost2 = currentItem.units2 * currentItem.ppu2;
            }

            int totalrings = currentItem.rings1 + currentItem.rings2;

            //display material info
            lblRings1.Text = "Rings 1: " + currentItem.rings1.ToString();
            lblUnits1.Text = "Units 1: " + currentItem.units1.ToString("F");
            lblRings2.Text = "Rings 2: " + currentItem.rings2.ToString();
            lblUnits2.Text = "Units 2: " + currentItem.units2.ToString("F");

            lblTotalRings.Text = "Total Rings: " + totalrings.ToString();

            currentItem.materialcost = currentItem.cost1 + currentItem.cost2 + currentItem.findings;
            lblMaterialCost.Text = "Material Cost: $" + currentItem.materialcost.ToString("F");

            //calculate labor
            currentItem.totallabor = totalrings * currentItem.lpr;
            lblTotalLabor.Text = "Total Labor: $" + currentItem.totallabor.ToString("F");

            //calculate final price with overhead
            currentItem.finalprice = currentItem.materialcost + currentItem.totallabor;
            if (currentItem.overhead != 0)
            {
                currentItem.finalprice = currentItem.finalprice + (currentItem.finalprice * (currentItem.overhead / 100));
            }

            //output result
            lblFinalPrice.Text = "Final Price: $" + currentItem.finalprice.ToString("F");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Calculate();

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save Item Information";
            saveFileDialog.Filter = "JSON files|*.json";
            saveFileDialog.FileName = currentItem.name;
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                using FileStream createStream = File.Create(saveFileDialog.FileName);
                JsonSerializer.Serialize(createStream, currentItem);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Load Item Information";
            openFileDialog.Filter = "JSON files|*.json";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using FileStream openStream = File.OpenRead(openFileDialog.FileName);
                Item readItem = JsonSerializer.Deserialize<Item>(openStream)!;

                txtItemName.Text = readItem.name;

                txtRPI1.Text = readItem.rpi1.ToString();
                txtInches1.Text = readItem.inches1.ToString();
                txtRPU1.Text = readItem.rpu1.ToString();
                txtPPU1.Text = readItem.ppu1.ToString();

                txtRPI2.Text = readItem.rpi2.ToString();
                txtInches2.Text = readItem.inches2.ToString();
                txtRPU2.Text = readItem.rpu2.ToString();
                txtPPU2.Text = readItem.ppu2.ToString();

                txtFindings.Text = readItem.findings.ToString();
                txtLPR.Text = readItem.lpr.ToString();
                txtOverhead.Text = readItem.overhead.ToString();

                Calculate();
            }
        }

        private void txtItemName_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}