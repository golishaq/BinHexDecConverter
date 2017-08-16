using System;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace BinHexDecConv
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

        byte[] fullAddr1 = new byte[] { 0, 0, 0 };
        bool[] addr1 = new bool[4];
        bool[] addr2 = new bool[3];

        public static int HexToBinary(string hexValue)
        {
            int temper = 0;
            for (int i = 0; i < hexValue.Length; i++)
            {
                temper += HexCharToInt(hexValue[i]) << ((hexValue.Length - 1 - i) * 4);
            }
            return temper;
        }

        public static int HexCharToInt(char ch)
        {
            if (ch < 48 || (ch > 57 && ch < 65) || ch > 70)
                throw new Exception("HexCharToInt: input out of range for Hex value");
            return (ch < 58) ? ch - 48 : ch - 55;
        }

        private byte ConvertBoolArrayToByte(bool[] source)
        {
            byte result = 0;
            // This assumes the array never contains more than 8 elements!
            int index = 3 - source.Length;

            // Loop through the array
            foreach (bool b in source)
            {
                // if the element is 'true' set the bit at that position
                if (b)
                    result |= (byte)(1 << (2 - index));

                index++;
            }

            return result;
        }

        public static string ByteArrayToString(byte[] ba)
        {
            string hex = BitConverter.ToString(ba);
            return hex.Replace("-", " ");
        }

        private void ChBAddr1_1(object sender, RoutedEventArgs e)
        {
            addr1[3] = true;
            fullAddr1[1] = ConvertBoolArrayToByte(addr1);
            labelVal.Content = ConvertBoolArrayToByte(addr1);
            fullAddr.Content = ByteArrayToString(fullAddr1).Substring(1);
            string hexAddr = fullAddr.Content.ToString().Replace(" ", "");
            decAddr.Content = HexToBinary(hexAddr);
        }

        private void ChBAddr1_2(object sender, RoutedEventArgs e)
        {
            addr1[2] = true;
            fullAddr1[1] = ConvertBoolArrayToByte(addr1);
            labelVal.Content = ConvertBoolArrayToByte(addr1);
            fullAddr.Content = ByteArrayToString(fullAddr1).Substring(1);
            string hexAddr = fullAddr.Content.ToString().Replace(" ", "");
            decAddr.Content = HexToBinary(hexAddr);
        }

        private void ChBAddr1_3(object sender, RoutedEventArgs e)
        {
            addr1[1] = true;
            fullAddr1[1] = ConvertBoolArrayToByte(addr1);
            labelVal.Content = ConvertBoolArrayToByte(addr1);
            fullAddr.Content = ByteArrayToString(fullAddr1).Substring(1);
            string hexAddr = fullAddr.Content.ToString().Replace(" ", "");
            decAddr.Content = HexToBinary(hexAddr);
        }

        private void ChBAddr1_4(object sender, RoutedEventArgs e)
        {
            addr1[0] = true;
            fullAddr1[1] = ConvertBoolArrayToByte(addr1);
            labelVal.Content = ConvertBoolArrayToByte(addr1);
            fullAddr.Content = ByteArrayToString(fullAddr1).Substring(1);
            string hexAddr = fullAddr.Content.ToString().Replace(" ", "");
            decAddr.Content = HexToBinary(hexAddr);
        }

        private void ChBAddr1_1U(object sender, RoutedEventArgs e)
        {
            addr1[3] = false;
            fullAddr1[1] = ConvertBoolArrayToByte(addr1);
            labelVal.Content = ConvertBoolArrayToByte(addr1);
            fullAddr.Content = ByteArrayToString(fullAddr1).Substring(1);
            string hexAddr = fullAddr.Content.ToString().Replace(" ", "");
            decAddr.Content = HexToBinary(hexAddr);
        }

        private void ChBAddr1_2U(object sender, RoutedEventArgs e)
        {
            addr1[2] = false;
            fullAddr1[1] = ConvertBoolArrayToByte(addr1);
            labelVal.Content = ConvertBoolArrayToByte(addr1);
            fullAddr.Content = ByteArrayToString(fullAddr1).Substring(1);
            string hexAddr = fullAddr.Content.ToString().Replace(" ", "");
            decAddr.Content = HexToBinary(hexAddr);
        }

        private void ChBAddr1_3U(object sender, RoutedEventArgs e)
        {
            addr1[1] = false;
            fullAddr1[1] = ConvertBoolArrayToByte(addr1);
            labelVal.Content = ConvertBoolArrayToByte(addr1);
            fullAddr.Content = ByteArrayToString(fullAddr1).Substring(1);
            string hexAddr = fullAddr.Content.ToString().Replace(" ", "");
            decAddr.Content = HexToBinary(hexAddr);
        }

        private void ChBAddr1_4U(object sender, RoutedEventArgs e)
        {
            addr1[0] = false;
            fullAddr1[1] = ConvertBoolArrayToByte(addr1);
            labelVal.Content = ConvertBoolArrayToByte(addr1);
            fullAddr.Content = ByteArrayToString(fullAddr1).Substring(1);
            string hexAddr = fullAddr.Content.ToString().Replace(" ", "");
            decAddr.Content = HexToBinary(hexAddr);
        }

        private void ChBAddr2_1(object sender, RoutedEventArgs e)
        {
            addr2[2] = true;
            fullAddr1[0] = ConvertBoolArrayToByte(addr2);
            labelVal2.Content = ConvertBoolArrayToByte(addr2);
            fullAddr.Content = ByteArrayToString(fullAddr1).Substring(1);
            string hexAddr = fullAddr.Content.ToString().Replace(" ", "");
            decAddr.Content = HexToBinary(hexAddr);
        }

        private void ChBAddr2_2(object sender, RoutedEventArgs e)
        {
            addr2[1] = true;
            fullAddr1[0] = ConvertBoolArrayToByte(addr2);
            labelVal2.Content = ConvertBoolArrayToByte(addr2);
            fullAddr.Content = ByteArrayToString(fullAddr1).Substring(1);
            string hexAddr = fullAddr.Content.ToString().Replace(" ", "");
            decAddr.Content = HexToBinary(hexAddr);
        }

        private void ChBAddr2_3(object sender, RoutedEventArgs e)
        {
            addr2[0] = true;
            fullAddr1[0] = ConvertBoolArrayToByte(addr2);
            labelVal2.Content = ConvertBoolArrayToByte(addr2);
            fullAddr.Content = ByteArrayToString(fullAddr1).Substring(1);
            string hexAddr = fullAddr.Content.ToString().Replace(" ", "");
            decAddr.Content = HexToBinary(hexAddr);
        }

        private void ChBAddr2_1U(object sender, RoutedEventArgs e)
        {
            addr2[2] = false;
            fullAddr1[0] = ConvertBoolArrayToByte(addr2);
            labelVal2.Content = ConvertBoolArrayToByte(addr2);
            fullAddr.Content = ByteArrayToString(fullAddr1).Substring(1);
            string hexAddr = fullAddr.Content.ToString().Replace(" ", "");
            decAddr.Content = HexToBinary(hexAddr);
        }

        private void ChBAddr2_2U(object sender, RoutedEventArgs e)
        {
            addr2[1] = false;
            fullAddr1[0] = ConvertBoolArrayToByte(addr2);
            labelVal2.Content = ConvertBoolArrayToByte(addr2);
            fullAddr.Content = ByteArrayToString(fullAddr1).Substring(1);
            string hexAddr = fullAddr.Content.ToString().Replace(" ", "");
            decAddr.Content = HexToBinary(hexAddr);
        }

        private void ChBAddr2_3U(object sender, RoutedEventArgs e)
        {
            addr2[0] = false;
            fullAddr1[0] = ConvertBoolArrayToByte(addr2);
            labelVal2.Content = ConvertBoolArrayToByte(addr2);
            fullAddr.Content = ByteArrayToString(fullAddr1).Substring(1);
            string hexAddr = fullAddr.Content.ToString().Replace(" ", "");
            decAddr.Content = HexToBinary(hexAddr);
        }


        private void rBtn(object sender, RoutedEventArgs e)
        {
            
            var radioButton = sender as RadioButton;
            if (radioButton == null)
                return;
            string variable = (string)(sender as RadioButton).Content;
            labelPort.Content = Convert.ToUInt64(variable, 16);
                        
            byte byteIndex = Convert.ToByte(variable, 16);
            fullAddr1[2] = byteIndex;
            fullAddr.Content = ByteArrayToString(fullAddr1).Substring(1);
            string hexAddr = fullAddr.Content.ToString().Replace(" ", "");
            decAddr.Content = HexToBinary(hexAddr);
        }
    }
}
