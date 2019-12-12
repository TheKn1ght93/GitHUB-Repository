﻿using System;
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
using System.Text.RegularExpressions;
using System.Drawing;

//ToDO
//FInd solution how to add a textboxes dinamically
//1241


namespace Load_Option
{
       
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();            
        }
        string driverName,
            pu_DT,
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



       

      

        private void loadDistance_TB_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            string str1 = dh_TB.Text;
            int.TryParse(str1, out int numbers1);
            string str2 = loadDistance_TB.Text;
            int.TryParse(str2, out int numbers2);
            int totalMiles = (numbers1 + numbers2);
            totalMiles_Label.Content = totalMiles.ToString();
        }
        private void textInputPrew(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }
        private void gross_TB_TextChanged(object sender, TextChangedEventArgs e)
        {
            string gross = gross_TB.Text;
            string totalMileas = totalMiles_Label.Content.ToString();
            double.TryParse(gross, out double grossToint);
            double.TryParse(totalMileas, out double totalMileastoDouble);
            double rateRes = grossToint / totalMileastoDouble;
            rateResult.Content = rateRes.ToString("N2");
        }
        private void Option_Click(object sender, RoutedEventArgs e)
        {
            Option option = new Option();
            option.Show();


            driverName = driverName_Label.Content + driverName_TB.Text;
            pu_DT = pu_DT_Label.Content + pu_DT_TB.Text;
            pu_CS = pu_CS_Label.Content + pu_CS_TB.Text;
            de_DT = de_DT_Label.Content + de_DT_TB.Text;
            de_CS = de_CS_Label.Content + de_CS_TB.Text;
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

            option.text_Option(driverName, pu_DT, pu_CS, de_DT, de_CS, dh, loadDis, mapLink, commodity,
                weight, gross, mc, name, phone, broker, addInfo);
        }
        private void clear_button_Click(object sender, RoutedEventArgs e)
        {
            driverName_TB.Text = "";
            pu_DT_TB.Text = "";
            pu_CS_TB.Text = "";
            de_DT_TB.Text = "";
            de_CS_TB.Text = "";
            dh_TB.Text = "";
            loadDistance_TB.Text = "";
            map_Link_TB.Text = "";
            commodity_TB.Text = "";
            weight_TB.Text = "";
            gross_TB.Text = "";
            mc_TB.Text = "";
            name_TB.Text = "";
            phone_TB.Text = "";
            broker_TB.Text = "";
            add_Info_TB.Text = "";
            rateResult.Content = "0";
            totalMiles_Label.Content = "0";
        }





        private void pu_DT_TB_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down)
            {
                pu_CS_TB.Focus();
            }
        }
        private void pu_CS_TB_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Up)
            {
                pu_DT_TB.Focus();
            }
            else if (e.Key == Key.Down)
            {
                de_DT_TB.Focus();
            }
        }
        private void de_DT_TB_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Up)
            {
                pu_CS_TB.Focus();
            }
            else if (e.Key == Key.Down)
            {
                de_CS_TB.Focus();
            }
        }
        private void de_CS_TB_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Up)
            {
                de_DT_TB.Focus();
            }
            else if (e.Key == Key.Down)
            {
                dh_TB.Focus();
            }
        }
        private void dh_TB_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Up)
            {
                de_CS_TB.Focus();
            }
            else if (e.Key == Key.Down)
            {
                loadDistance_TB.Focus();
            }
        }
        private void loadDistance_TB_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Up)
            {
                dh_TB.Focus();
            }
            else if (e.Key == Key.Down)
            {
                map_Link_TB.Focus();
            }
        }
        private void map_Link_TB_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Up)
            {
                loadDistance_TB.Focus();
            }
            else if (e.Key == Key.Down)
            {
                commodity_TB.Focus();
            }
        }
        private void commodity_TB_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Up)
            {
                map_Link_TB.Focus();
            }
            else if (e.Key == Key.Down)
            {
                weight_TB.Focus();
            }
        }
        private void weight_TB_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Up)
            {
                commodity_TB.Focus();
            }
            else if (e.Key == Key.Down)
            {
                gross_TB.Focus();
            }
        }
        private void gross_TB_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Up)
            {
                weight_TB.Focus();
            }
            else if (e.Key == Key.Down)
            {
                mc_TB.Focus();
            }
        }
        private void mc_TB_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Up)
            {
                gross_TB.Focus();
            }
            else if (e.Key == Key.Down)
            {
                name_TB.Focus();
            }
        }
        private void name_TB_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Up)
            {
                mc_TB.Focus();
            }
            else if (e.Key == Key.Down)
            {
                phone_TB.Focus();
            }
        }
        private void phone_TB_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Up)
            {
                name_TB.Focus();
            }
            else if (e.Key == Key.Down)
            {
                broker_TB.Focus();
            }
        }
        private void broker_TB_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Up)
            {
                phone_TB.Focus();
            }
            else if (e.Key == Key.Down)
            {
                add_Info_TB.Focus();
            }
        }
        private void add_Info_TB_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Up)
            {
                broker_TB.Focus();
            }
        }
    }


}
