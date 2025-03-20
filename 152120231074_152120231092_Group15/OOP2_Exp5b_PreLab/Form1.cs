using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2_Exp5b_PreLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public bool is_valid_name(string name)
        {

            if (name.StartsWith(" "))
                return false;

            name = name.Trim();

            if (name.Length < 1)
                return false;


            for (int i = 0; i < name.Length; i++)
            {
                if (!(char.IsLetter(name[i]) || name[i] == ' '))
                {
                    return false;
                }
            }

            return true;
        }

        private void btn_create_order_Click(object sender, EventArgs e)
        {

            if (!is_valid_name(textBox_name.Text))
            {
                MessageBox.Show("Geçersiz Ad-Soyad");
                return;
            }
            else if (!maskedTextBox_phone.MaskFull)
            {
                MessageBox.Show("Geçersiz Telefon Numarası");
                return;
            }
            else if (listBox_dishes.SelectedIndex == -1)
            {
                MessageBox.Show("Yemek seçili değil");
                return;
            }
            else if (listBox_city.SelectedIndex == -1)
            {
                MessageBox.Show("İl seçili değil");
                return;
            }
            else if (listBox_district.SelectedIndex == -1)
            {
                MessageBox.Show("İlçe seçili değil");
                return;
            }



            DateTime order_date = DateTime.Now;

            listBox_orders.Items.Add(order_date.ToString() + " tarihli");
            listBox_orders.Items.Add("siparişiniz oluşturuldu:");
            listBox_orders.Items.Add(textBox_name.Text + ",");
            listBox_orders.Items.Add(maskedTextBox_phone.Text + ",");
            listBox_orders.Items.Add(listBox_dishes.Text + ",");
            listBox_orders.Items.Add(numericUpDown_quantity.Value + ",");
            listBox_orders.Items.Add(listBox_city.Text + ",");
            listBox_orders.Items.Add(listBox_district.Text + ",");
            listBox_orders.Items.Add("---------------------------------");

        }


        List<string> city0_districts = new List<string>{
            "Gürsu",
            "Kestel",
            "Nilüfer",
            "Osmangazi",
            "Yıldırım"
        };

        List<string> city1_districts = new List<string>{
            "Odunpazarı",
            "Tepebaşı"
        };


        private void listBox_city_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected_index = listBox_city.SelectedIndex;

            List<string> selected_city = new List<string>{};
            switch (selected_index)
            {
                case 0: // Bursa
                    selected_city = city0_districts;
                    break;
                case 1: // Eskisehir
                    selected_city = city1_districts;
                    break;
                default:
                    break;
            }

            listBox_district.Items.Clear();
            
            for (int i = 0; i < selected_city.Count; i++)
            {
                listBox_district.Items.Add(selected_city[i]);
            }
        }

        private void listBox_district_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected_index = listBox_district.SelectedIndex;
        }

        private void listBox_dishes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool is_making_selection = false;
        private void listBox_orders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (is_making_selection) return;
            
            if (listBox_orders.SelectedIndex == -1) return;

            is_making_selection = true;



            ListBox.SelectedIndexCollection selected_indices = listBox_orders.SelectedIndices;

            int group1 = -1;
            int group2 = -1;

            int group1_count = 0;
            int group2_count = 0;

            for (int i = 0; i < selected_indices.Count; i++)
            {
                int group_index = (selected_indices[i] / 9) * 9;

                
                if (group1 == -1)
                {
                    group1 = group_index;
                    group1_count++;
                }
                else if (group_index == group1)
                {
                    group1_count++;
                }
                else if (group2 == -1)
                {
                    group2 = group_index;
                    group2_count++;
                }
                else
                {
                    group2_count++;
                }
            }


            int selected_index = listBox_orders.SelectedIndex;


            if (group2 != -1)
            {
                if (group1_count == 1)
                {
                    selected_index = group1;
                }
                else if (group2_count == 1) 
                { 
                    selected_index = group2;
                }
            }



            

            int groupStartIndex = (selected_index / 9) * 9;

            listBox_orders.ClearSelected();

            for (int i = 0; i < 9; i++)
            {
                listBox_orders.SetSelected(groupStartIndex + i, true);
            }

            is_making_selection = false;

        }

        private void textBox_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btn_delete_order_Click(object sender, EventArgs e)
        {
            if (listBox_orders.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Silmek istediğiniz siparişi seçiniz");
            }
            if (listBox_orders.SelectedItems.Count > 0)
            {

                listBox_orders.SelectedIndexChanged -= listBox_orders_SelectedIndexChanged;

                for (int i = listBox_orders.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    listBox_orders.Items.RemoveAt(listBox_orders.SelectedIndices[i]);
                }

                listBox_orders.SelectedIndexChanged += listBox_orders_SelectedIndexChanged;
            }
        }

    }
}
