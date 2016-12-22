using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlapsUI
{
    public class SlapsProgram
    {
        #region FILEOPEN
        //********************************SlapsOpenFile()********************************
        public string SlapsOpenFile()
        {
            UI_OpenFile window = new UI_OpenFile();
            var res = window.ShowDialog();
            //Check if user clicked "OK" button, "Cancel" button or "Clear" button
            if (!(res.HasValue && res.Value)) 
                window.Close();

            string filePath = window._Filepath;
            return filePath;
        }
        #endregion

        #region SLIDER
        //********************************SlapSlider()********************************
        public double SlapSlider1(double min, double max, string labelName)
        {
            UI_Slider1 window = new UI_Slider1();
            window.Input.Content = labelName;
            window.Slider.Minimum = min;
            window.Slider.Maximum = max;
            var res = window.ShowDialog();
            //Check if user clicked "OK" button, "Cancel" button or "Clear" button
            if (!(res.HasValue && res.Value))
                window.Close();

            double num = window.Slider.Value;;
            
            return num;
        }

        //********************************SlapSlider2()********************************
        public List<double> SlapSlider2(double min1, double max1, double min2, double max2, 
                                        string labelName_1, string labelName_2)
        {
            UI_Slider2 window = new UI_Slider2();
            window.Input.Content = labelName_1;
            window.Input_2.Content = labelName_2;
            window.Slider.Minimum = min1;
            window.Slider.Maximum = max1;
            window.Slider_2.Minimum = min2;
            window.Slider_2.Maximum = max2;
            var res = window.ShowDialog();
            //Check if user clicked "OK" button, "Cancel" button or "Clear" button
            if (!(res.HasValue && res.Value))
                window.Close();

            List<double> numList = new List<double>();
            double num = window.Slider.Value;
            double num2 = window.Slider_2.Value;
            numList.Add(num);
            numList.Add(num2);
            return numList;
        }

        //********************************SlapSlider3()********************************
        public List<double> SlapSlider3(double min1, double max1, double min2, double max2,
                                        double min3, double max3,
                                        string labelName_1, string labelName_2, string labelName_3)
        {
            UI_Slider3 window = new UI_Slider3();
            window.Input.Content = labelName_1;
            window.Input_2.Content = labelName_2;
            window.Input_3.Content = labelName_3;
            window.Slider.Minimum = min1;
            window.Slider.Maximum = max1;
            window.Slider_2.Minimum = min2;
            window.Slider_2.Maximum = max2;
            window.Slider_3.Minimum = min3;
            window.Slider_3.Maximum = max3;
            var res = window.ShowDialog();
            //Check if user clicked "OK" button, "Cancel" button or "Clear" button
            if (!(res.HasValue && res.Value))
                window.Close();

            List<double> numList = new List<double>();
            double num = window.Slider.Value;
            double num2 = window.Slider_2.Value;
            double num3 = window.Slider_3.Value;
            numList.Add(num);
            numList.Add(num2);
            numList.Add(num3);
            return numList;
        }

        //********************************SlapSlider4()********************************
        public List<double> SlapSlider4(double min1, double max1, double min2, double max2,
                                        double min3, double max3, double min4, double max4,
                                        string labelName_1, string labelName_2, string labelName_3, string labelName_4)
        {
            UI_Slider4 window = new UI_Slider4();
            window.Input.Content = labelName_1;
            window.Input_2.Content = labelName_2;
            window.Input_3.Content = labelName_3;
            window.Input_4.Content = labelName_4;
            window.Slider.Minimum = min1;
            window.Slider.Maximum = max1;
            window.Slider_2.Minimum = min2;
            window.Slider_2.Maximum = max2;
            window.Slider_3.Minimum = min3;
            window.Slider_3.Maximum = max3;
            window.Slider_4.Minimum = min4;
            window.Slider_4.Maximum = max4;
            var res = window.ShowDialog();
            //Check if user clicked "OK" button, "Cancel" button or "Clear" button
            if (!(res.HasValue && res.Value))
                window.Close();

            List<double> numList = new List<double>();
            double num = window.Slider.Value;
            double num2 = window.Slider_2.Value;
            double num3 = window.Slider_3.Value;
            double num4 = window.Slider_4.Value;
            numList.Add(num);
            numList.Add(num2);
            numList.Add(num3);
            numList.Add(num4);
            return numList;
        }
        #endregion 

        #region TEXTBOX INPUTS
        //********************************SlapsInput()********************************
        public string SlapsInput1(string labelName)
        {
            UI_InputBox1 window = new UI_InputBox1();
            window.Input.Content = labelName;
            var res = window.ShowDialog();
            //Check if user clicked "OK" button, "Cancel" button or "Clear" button
            if (!(res.HasValue && res.Value))
                window.Close();
            string data = window.textBox.Text;
            return data;
        }

        //********************************SlapsInput2()********************************
        public List<string> SlapsInput2(string labelName1, string labelName2)
        {
            UI_InputBox2 window = new UI_InputBox2();
            window.Input.Content = labelName1;
            window.Input_2.Content = labelName2;
            var res = window.ShowDialog();
            //Check if user clicked "OK" button, "Cancel" button or "Clear" button
            if (!(res.HasValue && res.Value))
                window.Close();

            List<string> dataList = new List<string>();
            string data1 = window.textBox.Text;
            string data2 = window.textBox_2.Text;
            dataList.Add(data1);
            dataList.Add(data2);
            return dataList;
        }

        //********************************SlapsInput3()********************************
        public List<string> SlapsInput3(string labelName1, string labelName2, string labelName3)
        {
            UI_InputBox3 window = new UI_InputBox3();
            window.Input.Content = labelName1;
            window.Input_2.Content = labelName2;
            window.Input_3.Content = labelName3;
            var res = window.ShowDialog();
            //Check if user clicked "OK" button, "Cancel" button or "Clear" button
            if (!(res.HasValue && res.Value))
                window.Close();

            List<string> dataList = new List<string>();
            string data1 = window.textBox.Text;
            string data2 = window.textBox_2.Text;
            string data3 = window.textBox_3.Text;
            dataList.Add(data1);
            dataList.Add(data2);
            dataList.Add(data3);
            return dataList;
        }

            //********************************SlapsInput4()********************************
        public List<string> SlapsInput4(string labelName1, string labelName2, string labelName3, string labelName4)
        {
            UI_InputBox4 window = new UI_InputBox4();
            window.Input.Content = labelName1;
            window.Input_2.Content = labelName2;
            window.Input_3.Content = labelName3;
            window.Input_4.Content = labelName4;
            var res = window.ShowDialog();
            //Check if user clicked "OK" button, "Cancel" button or "Clear" button
            if (!(res.HasValue && res.Value))
                window.Close();

            List<string> dataList = new List<string>();
            string data1 = window.textBox.Text;
            string data2 = window.textBox_2.Text;
            string data3 = window.textBox_3.Text;
            string data4 = window.textBox_4.Text;
            dataList.Add(data1);
            dataList.Add(data2);
            dataList.Add(data3);
            dataList.Add(data4);
            return dataList;
        }
        #endregion
        
        #region COMBOBOX
        //********************************SlapsComboBox()********************************
        public Object SlapsComboBox1(List<Object> list, string labelName)
        {
            UI_ComboBox1 window = new UI_ComboBox1();
            window.Input.Content = labelName;
            window.ComboBox.ItemsSource = list;
            var res = window.ShowDialog();
            //Check if user clicked "OK" button, "Cancel" button or "Clear" button
            if (!(res.HasValue && res.Value))
                window.Close();
            var data = window.ComboBox.SelectedItem;
            return data;
        }

        //********************************SlapsComboBox2()********************************
        public List<Object> SlapsComboBox2(List<Object> list1, List<Object> list2,
                                           string labelName1, string labelName2)
        {
            UI_ComboBox2 window = new UI_ComboBox2();
            window.Input.Content = labelName1;
            window.Input_2.Content = labelName2;
            window.ComboBox.ItemsSource = list1;
            window.ComboBox_2.ItemsSource = list2;

            var res = window.ShowDialog();
            //Check if user clicked "OK" button, "Cancel" button or "Clear" button
            if (!(res.HasValue && res.Value))
                window.Close();

            List<Object> dataList = new List<object>();
            var data = window.ComboBox.SelectedItem;
            var data2 = window.ComboBox_2.SelectedItem;
            dataList.Add(data);
            dataList.Add(data2);
            return dataList;
        }

        //********************************SlapsComboBox3()********************************
        public List<Object> SlapsComboBox3(List<Object> list1, List<Object> list2, List<Object> list3,
                                           string labelName1, string labelName2, string labelName3)
        {
            UI_ComboBox3 window = new UI_ComboBox3();
            window.Input.Content = labelName1;
            window.Input_2.Content = labelName2;
            window.Input_3.Content = labelName3;
            window.ComboBox.ItemsSource = list1;
            window.ComboBox_2.ItemsSource = list2;
            window.ComboBox_3.ItemsSource = list3;

            var res = window.ShowDialog();
            //Check if user clicked "OK" button, "Cancel" button or "Clear" button
            if (!(res.HasValue && res.Value))
                window.Close();

            List<Object> dataList = new List<object>();
            var data = window.ComboBox.SelectedItem;
            var data2 = window.ComboBox_2.SelectedItem;
            var data3 = window.ComboBox_3.SelectedItem;
            dataList.Add(data);
            dataList.Add(data2);
            dataList.Add(data3);
            return dataList;
        }

        //********************************SlapsComboBox4()********************************
        public List<Object> SlapsComboBox4(List<Object> list1, List<Object> list2,
                                           List<Object> list3, List<Object> list4,
                                           string labelName1, string labelName2,
                                           string labelName3, string labelName4)
        {
            UI_ComboBox4 window = new UI_ComboBox4();
            window.Input.Content = labelName1;
            window.Input_2.Content = labelName2;
            window.Input_3.Content = labelName3;
            window.Input_4.Content = labelName4;
            window.ComboBox.ItemsSource = list1;
            window.ComboBox_2.ItemsSource = list2;
            window.ComboBox_3.ItemsSource = list3;
            window.ComboBox_4.ItemsSource = list4;

            var res = window.ShowDialog();
            //Check if user clicked "OK" button, "Cancel" button or "Clear" button
            if (!(res.HasValue && res.Value))
                window.Close();

            List<Object> dataList = new List<object>();
            var data = window.ComboBox.SelectedItem;
            var data2 = window.ComboBox_2.SelectedItem;
            var data3 = window.ComboBox_3.SelectedItem;
            var data4 = window.ComboBox_4.SelectedItem;
            dataList.Add(data);
            dataList.Add(data2);
            dataList.Add(data3);
            dataList.Add(data4);
            return dataList;
        }
        
        #endregion
    }
}
