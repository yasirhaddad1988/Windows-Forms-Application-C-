using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace _Json
{
    public partial class Form1 : Form

    {
        List<Developers> developers = new List<Developers>();
        public Form1()
        {
            InitializeComponent();
            List<Developers> developers = new List<Developers>();
            var all = from devs in developers select devs;
            listView1.Items.Clear();
            using (StreamReader file = File.OpenText("data.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                developers = (List<Developers>)serializer.Deserialize(file, typeof(List<Developers>));
                listView1.Items.Add(file.ReadToEnd());
                file.Close();
            }
            var r = from devs in developers select devs;

            listView1.Items.Clear();


            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;


            listView1.Columns.Add("Name", 150);
            listView1.Columns.Add("ID", 60);
            listView1.Columns.Add("Age", 60);
            listView1.Columns.Add("Address", 200);
            listView1.Columns.Add("Developer Type", 150);
            listView1.Columns.Add("Tax Type", 100);
            listView1.Columns.Add("Monthly Salary", 100);
            listView1.Columns.Add("Annual Salary", 100);
            listView1.Columns.Add("Annual Taxes", 100);


            string[] lines;
            // int count = 0;
            lines = System.IO.File.ReadAllLines(@"data.json");

            List<Developers> developer = new List<Developers>();


            foreach (var line in lines)
            {
                string[] words = line.Split(',');

                Developers devs = new Developers();

            }

            foreach (var devs in developers)
            {
                ListViewItem item = new ListViewItem(devs.Name);
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, Convert.ToString(devs.ID)));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, Convert.ToString(devs.Age)));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, devs.Address));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, devs.DeveloperType));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, devs.TaxType));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, Convert.ToString(devs.MonthlySalary)));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, Convert.ToString(devs.AnnualSalary)));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, Convert.ToString(devs.AnnualTaxes)));
                listView1.Items.Add(item);
            }
        }
        

        private void btnShow_Click(object sender, EventArgs e)
        {
            List<Developers> developers = new List<Developers>();
            var all = from devs in developers select devs;
            listView1.Items.Clear();
            using (StreamReader file = File.OpenText("data.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                developers = (List<Developers>)serializer.Deserialize(file, typeof(List<Developers>));
                listView1.Items.Add(file.ReadToEnd());
                file.Close();
            }
            var r = from devs in developers select devs;

            listView1.Items.Clear();


            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;


            listView1.Columns.Add("Name", 150);
            listView1.Columns.Add("ID", 60);
            listView1.Columns.Add("Age", 60);
            listView1.Columns.Add("Address", 150);
            listView1.Columns.Add("Developer Type", 150);
            listView1.Columns.Add("Tax Type", 100);
            listView1.Columns.Add("Monthly Salary", 100);
            listView1.Columns.Add("Annual Salary", 100);
            listView1.Columns.Add("Annual Taxes", 100);

            
            string[] lines;
           
            lines = System.IO.File.ReadAllLines(@"data.json");

            List<Developers> developer = new List<Developers>();


            foreach (var line in lines)
            {
                string[] words = line.Split(',');

                Developers devs = new Developers();

            }

            foreach (var devs in developers)
            {
                ListViewItem item = new ListViewItem(devs.Name);
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, Convert.ToString(devs.ID)));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, Convert.ToString(devs.Age)));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, devs.Address));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, devs.DeveloperType));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, devs.TaxType));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, Convert.ToString(devs.MonthlySalary)));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, Convert.ToString(devs.AnnualSalary)));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, Convert.ToString(devs.AnnualTaxes)));
                listView1.Items.Add(item);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listView1.Clear();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        { 
        }

        private void btnMofify_Click(object sender, EventArgs e)
        {
            
            if(listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].Text = txtName.Text;
                listView1.SelectedItems[0].SubItems[1].Text = txtID.Text;
                listView1.SelectedItems[0].SubItems[2].Text = txtAge.Text;
                listView1.SelectedItems[0].SubItems[3].Text = txtAddress.Text;
                listView1.SelectedItems[0].SubItems[4].Text = txtDeveloperType.Text;
                listView1.SelectedItems[0].SubItems[5].Text = txtTaxType.Text;
                listView1.SelectedItems[0].SubItems[6].Text = txtMonthlySalry.Text;
                listView1.SelectedItems[0].SubItems[7].Text = txtAnnualSalry.Text;
                listView1.SelectedItems[0].SubItems[8].Text = txtAnnualTaxes.Text;
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            

            ListViewItem item = new ListViewItem(txtName.Text);
            item.SubItems.Add(txtAge.Text);
            item.SubItems.Add(txtAddress.Text);
            item.SubItems.Add(txtDeveloperType.Text);
            item.SubItems.Add(txtTaxType.Text);
            item.SubItems.Add(txtID.Text);
            item.SubItems.Add(txtMonthlySalry.Text);
            item.SubItems.Add(txtAnnualSalry.Text);
            item.SubItems.Add(txtAnnualTaxes.Text);
            listView1.Items.Add(item);
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count >0)
            listView1.Items.Remove(listView1.SelectedItems[0]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value = txtSearch.Text.ToLower();
            for (int i = listView1.Items.Count - 1; -1 < i; i--)
            {
                if
                (listView1.Items[i].Text.ToLower().StartsWith(value) == false)
                {
                    listView1.Items[i].Remove();
                }
            }
            }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Clear();
        }
    }
}
