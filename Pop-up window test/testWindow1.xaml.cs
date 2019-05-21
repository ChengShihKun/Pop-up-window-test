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
                int inp = 0;
                int.TryParse(textBoxII.Text, out inp);



                //main.textBoxMM.Text = arrayF(inp);//變數值傳送(數列)
                //main.textBoxMM.Text=recF(inp)+"";//變數值傳送(數項)

            }
        }
        

        string arrayF(int inp) {
            //陣列版本費是數列
            string Ans = "F(";;
            Console.WriteLine("輸入值為：" + inp);
            Ans += inp + ")：";

            int[] array = new int[inp > 2 ? inp : 2];
            array[0] = 1;
            array[1] = 1;

            for (int A = 2; A < inp; A++)
            {
                array[A] = array[A - 1] + array[A - 2];
            }

            foreach (int a in array)
            {
                Ans += a + ",";
            }

            return Ans;
        }

        int recF(int inp) {

            if (inp<3) {
                return 1;
            } else {
                return recF(inp - 1) + recF(inp - 2);
            }
        }

    }
}
