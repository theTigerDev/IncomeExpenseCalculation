using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IncomeExpenseCalculation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //Local Function
        //calculation Function
        private int calculation()
        {
            int income = int.Parse(txtIncome.Text); //แปลงค่าจาก textbox ให้เป็น int
            int expense = int.Parse(txtExpense.Text);
            int itemPrice = int.Parse(txtPrice.Text);
            int keepMoney = income - expense;
            int noDate = itemPrice / keepMoney;
            txtKeepMoney.Text = keepMoney.ToString(); //แปลงค่ากลับจาก int ให้เป็น string เพื่อแสดงใน Textbox
            txtNoDate.Text = noDate.ToString();
            return noDate;
        }
        //ClearData In TextBox Function
        private void clearData()
        {
            txtExpense.Clear();
            txtIncome.Clear();
            txtKeepMoney.Clear();
            txtNoDate.Clear();
            txtPrice.Clear();
        }

        //EventClick
        private void btnCal_Click(object sender, RoutedEventArgs e)
        {
            calculation();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            clearData();
        }
    }
}
