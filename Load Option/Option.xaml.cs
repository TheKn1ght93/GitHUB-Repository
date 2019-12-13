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

namespace Load_Option
{    
    public partial class Option : Window
    {
        public Option()
        {
            InitializeComponent();
        }
        public void text_Option(string driverName, string pu_DT, string pu_CS, string de_DT, string de_CS, string dh, string loadDis, string mapLink, string commodity, string weight,
            string gross, string mc, string name, string phone, string broker, string addInfo)
        {
            if (addInfo == "Additional Info: ")
            {
                loadText.Text = 
                driverName + "\n" + "\n" +
                pu_DT + "\n" +
                pu_CS + "\n" +
                de_DT + "\n" +
                de_CS + "\n" +
                dh + "\n" +
                loadDis + "\n" +
                mapLink + "\n" +
                commodity + "\n" +
                weight + "\n" +
                gross + "\n" +
                mc + "\n" +
                name + "\n" +
                phone + "\n" +
                broker + "\n";
            }
            else
            {
                loadText.Text = 
                   driverName + "\n" + "\n" +
                   pu_DT + "\n" +
                   pu_CS + "\n" +
                   de_DT + "\n" +
                   de_CS + "\n" +
                   dh + "\n" +
                   loadDis + "\n" +
                   mapLink + "\n" +
                   commodity + "\n" +
                   weight + "\n" +
                   gross + "\n" +
                   mc + "\n" +
                   name + "\n" +
                   phone + "\n" +
                   broker + "\n" +
                   addInfo;
            }
        }

        private void clipBoard_copy_Click(object sender, RoutedEventArgs e)
        {
            string text = loadText.Text;
            Clipboard.SetText(text);
            this.Close();
        }
        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            this.Topmost = true;
        }
        private void checkBox_Unchecked(object sender, RoutedEventArgs e)
        {
            this.Topmost = false;
        }
    }
}
