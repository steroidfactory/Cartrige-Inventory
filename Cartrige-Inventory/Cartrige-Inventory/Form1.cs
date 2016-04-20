using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cartrige_Inventory
{

    public partial class Form1 : Form
    {
        Database db = new Database();
        List<string> brandList = new List<string>();
        Dictionary <string,List<string>> modelList = new Dictionary<string, List< string>>();



        public Form1()
        {
            InitializeComponent();
            try
            {
                db.initDB();
                updateUI();
            }
            catch { }
            
        }



        private void updateUI()
        {
            listBrand.Items.Clear();
            listPrinter.Items.Clear();      
            brandList = db.selectBrand();
            foreach (string brand in brandList)
            {
                listBrand.Items.Add(brand);
            }
            if (brandList.Count > 0)
            {
                listBrand.SelectedIndex = 0;
            }
            inputBrand.Text = "";
            inputCartridge.Text = "";
            listBrand.Update();
            listPrinter.Update();
        }

        private void addCartrige_Click(object sender, EventArgs e)
        {
            modelList.Add(listBrand.SelectedItem.ToString(), );
            Console.WriteLine(modelList[listBrand.SelectedItem.ToString()].Count);
        }

        private void addBrand_Click(object sender, EventArgs e)
        {
            if (inputBrand.Text != "")
            {
                db.addNewBrand(inputBrand.Text);
            }
            updateUI();
        }

        private void dataGridView1_LocationChanged(object sender, EventArgs e)
        {
             
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           // MessageBox.Show(e.)
        }

        private void addPrinter_Click(object sender, EventArgs e)
        {
            modelList[listBrand.SelectedItem.ToString()] = db.selectModel(listBrand.SelectedItem.ToString());
            if (inputPrinter.Text != "" && listBrand.SelectedItem.ToString() != "")
            {
                db.addNewModel(listBrand.SelectedItem.ToString(), inputPrinter.Text.ToString());
            }
            updateUI();
        }

        private void listBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (modelList.ContainsKey(listBrand.SelectedItem.ToString()))
            {
                foreach (string model in modelList[listBrand.SelectedItem.ToString()])
                {
                    listPrinter.Items.Add(model);
                }
            }
            if (modelList.ContainsKey(listBrand.SelectedItem.ToString()))
            {
                listPrinter.SelectedIndex = 1;
            }


        }
    }
}
