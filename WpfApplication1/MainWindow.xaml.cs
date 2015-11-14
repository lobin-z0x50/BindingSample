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

namespace WpfApplication1
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public class Table1
        {
            public string _FirstName { get; set; }

        }


        public class ViewModel : Models.BindableBase
        {
            public Table1 _t1;

            // 氏名
            private string _text1;

            public string Text1
            {
                get { return _text2 + "　" + _t1._FirstName; }
                //set { _text1 = value; RaisePropertyChanged("Text1"); }
            }

            // 名前

            public string FirstName
            {
                get { return _t1._FirstName; }
                set { base.SetProperty(()=> _t1._FirstName, value); RaisePropertyChanged(nameof(Text1)); } 
            }

            // 名字
            private string _text2;

            public string FamilyName
            {
                get { return _text2; }
                set { _text2 = value; RaisePropertyChanged(nameof(FamilyName)); RaisePropertyChanged(nameof(Text1)); }
            }

        }

        public ViewModel vm;

        public MainWindow()
        {
            InitializeComponent();
            vm = new ViewModel();
            vm._t1 = new Table1()
            {
                _FirstName = "前田"
            };

            this.DataContext = vm;
        }

        /// <summary>
        /// ボタン押下時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Click(object sender, RoutedEventArgs e)
        {

          //  vm.Text1 = "WWWWW";
            // textBox1.Text = "ZZZZZ";

//            textBlock2.Text = "YYYY";
        }
    }
}
