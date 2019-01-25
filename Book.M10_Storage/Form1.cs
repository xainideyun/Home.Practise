using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book.M10_Storage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnSubmit.Click += BtnSubmit_Click;
            btnReset.Click += BtnReset_Click;
            txtPrice.KeyDown += MyKeyDown; ;
            txtQuantity.KeyDown += MyKeyDown;
            Init();
        }

        void Init()
        {
            cbMode.Items.AddRange(new[] {
                new StorageData(StorageMode.Normal),
                new StorageData(StorageMode.Return, 300, 100),
                new StorageData(StorageMode.Return, 600, 250),
                new StorageData(StorageMode.Discount, 0.8)
            });
            cbMode.SelectedIndex = 0;
        }

        private void MyKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                BtnSubmit_Click(null, null);
            }
        }
        

        public double Total { get; set; }
        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtPrice.Text = "";
            txtQuantity.Text = "";
            Total = 0;
            lblTotal.Text = "";
            listOrder.Items.Clear();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            var price = Convert.ToDouble(txtPrice.Text);
            var quantity = Convert.ToDouble(txtQuantity.Text);
            var mode = (StorageData)cbMode.SelectedItem;
            if(price == 0 || quantity == 0)
            {
                MessageBox.Show("请输入价格或数量");
                return;
            }
            var money = new CashContext(mode).CashResult(price * quantity);
            Total += money;
            listOrder.Items.Add($"单价：{price}，数量：{quantity}，模式：{mode}，费用：{money}");
            lblTotal.Text = "总价：" + Total;
        }
    }
}
