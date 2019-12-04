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

namespace Load_Option
{
       
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();            
        }

        string pu_DT,
            pu_CS,
            de_DT,
            de_CS,
            dh,
            loadDis,
            mapLink,
            commodity,
            weight,
            gross,
            mc,
            name,
            phone,
            broker,
            addInfo;


        private void Option_Click(object sender, RoutedEventArgs e)
        {
            Option option = new Option();
            option.Show();         

            pu_DT = pu_DT_Label.Content + pu_DT_TB.Text;
            pu_CS = pu_CS_Label.Content + pu_CS_TB.Text;
            de_DT = de_DT_Label.Content + de_DT_TB.Text;
            de_CS = de_CS_Label.Content + de_DT_TB.Text;
            dh = dh_Label.Content + dh_TB.Text;
            loadDis = load_Distance_Label.Content + loadDistance_TB.Text;
            mapLink = map_Link_Label.Content + map_Link_TB.Text;
            commodity = commodity_label.Content + commodity_TB.Text;
            weight = weight_label.Content + weight_TB.Text;
            gross = gross_label.Content + gross_TB.Text;
            mc = mc_label.Content + mc_TB.Text;
            name = name_Label.Content + name_TB.Text;
            phone = phone_Label.Content + phone_TB.Text;
            broker = broker_Label.Content + broker_TB.Text;
            addInfo = addInfo_Label.Content + add_Info_TB.Text;

            option.text_Option(pu_DT, pu_CS, de_DT, de_CS, dh, loadDis, mapLink, commodity,
                weight, gross, mc, name, phone, broker, addInfo);
        }
    }
   

}
