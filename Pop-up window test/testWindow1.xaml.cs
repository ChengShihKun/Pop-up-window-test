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
using System.Windows.Shapes;

namespace Pop_up_window_test
{
    /// <summary>
    /// testWindow1.xaml 的互動邏輯
    /// </summary>
    public partial class testWindow1 : Window
    {
        MainWindow main;//記錄主視窗
        public testWindow1(MainWindow inp)
        {
            InitializeComponent();
            main = inp;//接收主視窗
        }

        private void textBoxII_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (main!=null) {
                //防止main尚未被建立就拿去使用
                main.textBoxMM.Text = textBoxII.Text;//變數值傳送
            }
        }
    }
}
