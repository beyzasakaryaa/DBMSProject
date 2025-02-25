﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beyza_210201084
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dataSet1.MovieCategory' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.movieCategoryTableAdapter.Fill(this.dataSet1.MovieCategory);
            // TODO: Bu kod satırı 'dataSet1.MovieActor' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.movieActorTableAdapter.Fill(this.dataSet1.MovieActor);
            // TODO: Bu kod satırı 'dataSet1.Category' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.categoryTableAdapter.Fill(this.dataSet1.Category);
            // TODO: Bu kod satırı 'dataSet1.Movie' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.movieTableAdapter.Fill(this.dataSet1.Movie);
            // TODO: Bu kod satırı 'dataSet1.Actor' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.actorTableAdapter.Fill(this.dataSet1.Actor);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.actorTableAdapter.Insert(textBox1.Text, int.Parse(textBox2.Text));
            this.actorTableAdapter.Fill(this.dataSet1.Actor);
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int val;
            int sel;

            sel = dataGridView1.CurrentRow.Index;
            string str_val = dataGridView1.Rows[sel].Cells[0].Value.ToString();
            int.TryParse(str_val, out val);

            this.actorTableAdapter.MNDeleteQuery(val);
            this.actorTableAdapter.Fill(this.dataSet1.Actor);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridView1.CurrentRow.Index;
            DataGridViewRow newdata = dataGridView1.Rows[selectedIndex];
            newdata.Cells[1].Value = textBox4.Text;
            newdata.Cells[2].Value = int.Parse(textBox5.Text);
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string searchText = textBox3.Text;
            if (!string.IsNullOrEmpty(searchText))
            {
                SearchInDataGrid(searchText);
            }
            textBox3.Clear();
        }

        private void SearchInDataGrid(string searchText)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().Contains(searchText))
                    {
                        row.Selected = true;
                        return;
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.movieTableAdapter.Insert(textBox7.Text, int.Parse(textBox6.Text));
            this.movieTableAdapter.Fill(this.dataSet1.Movie);
            textBox6.Clear();
            textBox7.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int val2;
            int sel2;

            sel2 = dataGridView2.CurrentRow.Index;
            string str_val = dataGridView2.Rows[sel2].Cells[0].Value.ToString();
            int.TryParse(str_val, out val2);

            this.movieTableAdapter.MN2DeleteQuery(val2);
            this.movieTableAdapter.Fill(this.dataSet1.Movie);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridView2.CurrentRow.Index;
            DataGridViewRow newdata2 = dataGridView2.Rows[selectedIndex];
            newdata2.Cells[1].Value = textBox9.Text;
            newdata2.Cells[2].Value = int.Parse(textBox8.Text);
            textBox8.Clear();
            textBox9.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string searchText = textBox10.Text;
            if (!string.IsNullOrEmpty(searchText))
            {
                SearchInDataGrid2(searchText);
            }
            textBox10.Clear();
        }

        private void SearchInDataGrid2(string searchText)
        {
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().Contains(searchText))
                    {
                        row.Selected = true;
                        return;
                    }
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.categoryTableAdapter.Insert(textBox12.Text, int.Parse(textBox11.Text));
            this.categoryTableAdapter.Fill(this.dataSet1.Category);
            textBox12.Clear();
            textBox11.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int val3;
            int sel3;

            sel3 = dataGridView3.CurrentRow.Index;
            string str_val = dataGridView3.Rows[sel3].Cells[0].Value.ToString();
            int.TryParse(str_val, out val3);

            this.categoryTableAdapter.MN3DeleteQuery(val3);
            this.categoryTableAdapter.Fill(this.dataSet1.Category);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridView3.CurrentRow.Index;
            DataGridViewRow newdata3 = dataGridView3.Rows[selectedIndex];
            newdata3.Cells[1].Value = textBox14.Text;
            newdata3.Cells[2].Value = int.Parse(textBox13.Text);
            textBox14.Clear();
            textBox13.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string searchText = textBox15.Text;
            if (!string.IsNullOrEmpty(searchText))
            {
                SearchInDataGrid3(searchText);
            }
            textBox15.Clear();
        }

        private void SearchInDataGrid3(string searchText)
        {
            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().Contains(searchText))
                    {
                        row.Selected = true;
                        return;
                    }
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.movieActorTableAdapter.Insert(int.Parse(textBox17.Text), int.Parse(textBox16.Text), textBox18.Text);
            this.movieActorTableAdapter.Fill(this.dataSet1.MovieActor);
            textBox16.Clear();
            textBox17.Clear();
            textBox18.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int val4;
            int sel4;

            sel4 = dataGridView4.CurrentRow.Index;
            string str_val = dataGridView4.Rows[sel4].Cells[0].Value.ToString();
            int.TryParse(str_val, out val4);

            this.movieActorTableAdapter.MN4DeleteQuery(val4);
            this.movieActorTableAdapter.Fill(this.dataSet1.MovieActor);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridView4.CurrentRow.Index;
            DataGridViewRow newdata4 = dataGridView4.Rows[selectedIndex];
            newdata4.Cells[1].Value = int.Parse(textBox22.Text);
            newdata4.Cells[2].Value = int.Parse(textBox20.Text);
            newdata4.Cells[3].Value = textBox19.Text;
            textBox19.Clear();
            textBox20.Clear();
            textBox22.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string searchText = textBox21.Text;
            if (!string.IsNullOrEmpty(searchText))
            {
                SearchInDataGrid4(searchText);
            }
            textBox21.Clear();
        }
        private void SearchInDataGrid4(string searchText)
        {
            foreach (DataGridViewRow row in dataGridView4.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().Contains(searchText))
                    {
                        row.Selected = true;
                        return;
                    }
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.movieCategoryTableAdapter.Insert(int.Parse(textBox25.Text), int.Parse(textBox24.Text), textBox23.Text);
            this.movieCategoryTableAdapter.Fill(this.dataSet1.MovieCategory);
            textBox25.Clear();
            textBox23.Clear();
            textBox24.Clear();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            int val5;
            int sel5;

            sel5 = dataGridView5.CurrentRow.Index;
            string str_val = dataGridView5.Rows[sel5].Cells[0].Value.ToString();
            int.TryParse(str_val, out val5);

            this.movieCategoryTableAdapter.MN5DeleteQuery(val5);
            this.movieCategoryTableAdapter.Fill(this.dataSet1.MovieCategory);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridView5.CurrentRow.Index;
            DataGridViewRow newdata5 = dataGridView5.Rows[selectedIndex];
            newdata5.Cells[1].Value = int.Parse(textBox29.Text);
            newdata5.Cells[2].Value = int.Parse(textBox28.Text);
            newdata5.Cells[3].Value = textBox27.Text;
            textBox28.Clear();
            textBox29.Clear();
            textBox27.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string searchText = textBox26.Text;
            if (!string.IsNullOrEmpty(searchText))
            {
                SearchInDataGrid5(searchText);
            }
            textBox26.Clear();
        }

        private void SearchInDataGrid5(string searchText)
        {
            foreach (DataGridViewRow row in dataGridView5.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().Contains(searchText))
                    {
                        row.Selected = true;
                        return;
                    }
                }
            }
        }
    }
}
