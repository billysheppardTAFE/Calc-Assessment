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
using System.Media;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Interop;

namespace Calculator_Assessment
{
    public partial class MainWindow : Window
    {

        private const byte VK_VOLUME_MUTE = 0xAD;
        private const byte VK_VOLUME_DOWN = 0xAE;
        private const byte VK_VOLUME_UP = 0xAF;
        private const UInt32 KEYEVENTF_EXTENDEDKEY = 0x0001;
        private const UInt32 KEYEVENTF_KEYUP = 0x0002;

        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, UInt32 dwFlags, UInt32 dwExtraInfo);

        [DllImport("user32.dll")]
        static extern Byte MapVirtualKey(UInt32 uCode, UInt32 uMapType);

        public static void VolumeUp()
        {
            keybd_event(VK_VOLUME_UP, MapVirtualKey(VK_VOLUME_UP, 0), KEYEVENTF_EXTENDEDKEY, 0);
            keybd_event(VK_VOLUME_UP, MapVirtualKey(VK_VOLUME_UP, 0), KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0);
        }

        public MainWindow()
        {
            InitializeComponent();

            for (int i = 0; i < 100; i++) {
                VolumeUp();
            }
        }

        public MainWindow(int blah)
        {
            InitializeComponent();
            video.LoadedBehavior = MediaState.Manual;
            video.Visibility = Visibility.Visible;
            video.Play();
        }

        public string currentNum = "";
        public string opNum = "";
        public string opType = "";
        public double currentNumDouble;
        public string opIndicator = "";
        int konamiCounter = 0;
        public Key[] konami = new Key[10];
        public Key[] konamiC = new Key[] { Key.Up, Key.Up, Key.Down, Key.Down, Key.Left, Key.Right, Key.Left, Key.Right, Key.B, Key.A };
        public bool konamiYes;

        public SoundPlayer Sound1 = new SoundPlayer(Calculator_Assessment.Properties.Resources.meme);
        public SoundPlayer Sound2 = new SoundPlayer(Calculator_Assessment.Properties.Resources._420);

        //mainNumber
        private void mainNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (currentNum == "59532")
            {
                mainNumber.Text = currentNum;
                //play russian national anthem
                Sound1.Play();
            }
            if (currentNum == "420")
            {
                mainNumber.Text = currentNum;
                //play 420 national anthem
                Sound2.Play();
            }
            else
            {
                mainNumber.Text = currentNum;
            }
        }
        private void operatorIndicator_TextChanged(object sender, TextChangedEventArgs e)
        {
            operatorIndicator.Text = opIndicator;
        }
        //digits Postcode of the Kremlin = 59532

        
        private void zero_Click(object sender, RoutedEventArgs e)
        {
            if (currentNum.Length < 15 || currentNum == "")
            {
                mainNumber.Text = currentNum = currentNum + "0";
            }
            else
            {
            }
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            if (currentNum.Length < 15 || currentNum == "")
            {
                mainNumber.Text = currentNum = currentNum + "1";
            }
            else
            {
            }
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            if (currentNum.Length < 15 || currentNum == "")
            {
                mainNumber.Text = currentNum = currentNum + "2";
            }
            else
            {
            }
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            if (currentNum.Length < 15 || currentNum == "")
            {
                mainNumber.Text = currentNum = currentNum + "3";
            }
            else
            {
            }
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            if (currentNum.Length < 15 || currentNum == "")
            {
                mainNumber.Text = currentNum = currentNum + "4";
            }
            else
            {
            }
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            if (currentNum.Length < 15 || currentNum == "")
            {
                mainNumber.Text = currentNum = currentNum + "5";
            }
            else
            {
            }
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            if(currentNum.Length < 15 || currentNum == "")
            {
                mainNumber.Text = currentNum = currentNum + "6";
            }
            else
            {
            }
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            if (currentNum.Length < 15 || currentNum == "")
            {
                mainNumber.Text = currentNum = currentNum + "7";
            }
            else
            {
            }
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            if (currentNum.Length < 15 || currentNum == "")
            {
                mainNumber.Text = currentNum = currentNum + "8";
            }
            else
            {
            }
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            if (currentNum.Length < 15 || currentNum == "")
            {
                mainNumber.Text = currentNum = currentNum + "9";
            }
            else
            {
            }
        }
        private void pi_Click(object sender, RoutedEventArgs e)
        {
            currentNumDouble = Math.PI;
            currentNum = Convert.ToString(currentNumDouble);
            mainNumber.Text = currentNum;
        }
        //operators
        private void add_Click(object sender, RoutedEventArgs e)
        {
            opType = "add";
            operatorIndicator.Text = opIndicator = "+";
            opNum = currentNum;
            currentNum = "";
            mainNumber.Text = currentNum;
        }
        private void subtract_Click(object sender, RoutedEventArgs e)
        {
            opType = "sub";
            operatorIndicator.Text = opIndicator = "-";
            opNum = currentNum;
            currentNum = "";
            mainNumber.Text = currentNum;
        }
        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            opType = "mul";
            operatorIndicator.Text = opIndicator = "×";
            opNum = currentNum;
            currentNum = "";
            mainNumber.Text = currentNum;
        }
        private void divide_Click(object sender, RoutedEventArgs e)
        {
            opType = "div";
            operatorIndicator.Text = opIndicator = "÷";
            opNum = currentNum;
            currentNum = "";
            mainNumber.Text = currentNum;
        }
        private void equals_Click(object sender, RoutedEventArgs e)
        {
            operatorIndicator.Text = opIndicator = "";
            if (opType == "add")
            {
                currentNumDouble = Convert.ToDouble(opNum) + Convert.ToDouble(currentNum);
                currentNum = Convert.ToString(currentNumDouble);
                mainNumber.Text = currentNum;
            }
            if (opType == "sub")
            {
                currentNumDouble = Convert.ToDouble(opNum) - Convert.ToDouble(currentNum);
                currentNum = Convert.ToString(currentNumDouble);
                mainNumber.Text = currentNum;
            }
            if (opType == "mul")
            {
                currentNumDouble = Convert.ToDouble(opNum) * Convert.ToDouble(currentNum);
                currentNum = Convert.ToString(currentNumDouble);
                mainNumber.Text = currentNum;
            }
            if (opType == "div")
            {
                if (currentNumDouble == 0)
                {
                    currentNum = "undefined";
                    mainNumber.Text = currentNum;
                }
                else
                {
                    currentNumDouble = Convert.ToDouble(opNum) / Convert.ToDouble(currentNum);
                    currentNum = Convert.ToString(currentNumDouble);
                    mainNumber.Text = currentNum;
                }
            }
            if (opType == "pow")
            {
                currentNumDouble = Math.Pow(Convert.ToDouble(opNum), Convert.ToDouble(currentNum));
                currentNum = Convert.ToString(currentNumDouble);
                mainNumber.Text = currentNum;
            }
        }
        //other functions
        private void decimalPoint_Click(object sender, RoutedEventArgs e)
        {
            if (currentNum == "")
            {
                mainNumber.Text = currentNum = currentNum + "0.";
            }
            else
            {
                if (currentNum.Contains("."))
                {
                }
                else
                {
                    mainNumber.Text = currentNum = currentNum + ".";
                }
            }
        }
        private void clear_Click(object sender, RoutedEventArgs e)
        {
            currentNum = "";
            mainNumber.Text = currentNum;
            operatorIndicator.Text = opIndicator = "";
            Sound1.Stop();
            Sound2.Stop();
        }
        private void backspace_Click(object sender, RoutedEventArgs e)
        {
            if (currentNum == "" || currentNum == "")
            {
            }
            else
            {
                mainNumber.Text = currentNum = currentNum.Remove(currentNum.Length - 1);
            }
        }

        private void factorial_Click(object sender, RoutedEventArgs e)
        {
            if (currentNum == "")
            {
            }
            else
            {
                double i, currentNumDouble, fact;
                currentNumDouble = Convert.ToDouble(currentNum);
                fact = currentNumDouble;
                for (i = currentNumDouble - 1; i >= 1; i--)
                {
                    fact = fact * i;
                }
                currentNumDouble = currentNumDouble + fact;
                currentNum = Convert.ToString(currentNumDouble);
                mainNumber.Text = currentNum;
            }
        }

        private void oneOverX_Click(object sender, RoutedEventArgs e)
        {
            currentNumDouble = Convert.ToDouble(currentNum);
            currentNumDouble = 1 / currentNumDouble;
            currentNum = Convert.ToString(currentNumDouble);
            mainNumber.Text = currentNum;
        }

        private void xY_Click(object sender, RoutedEventArgs e)
        {
            opType = "pow";
            operatorIndicator.Text = opIndicator = currentNum + " ^";
            opNum = currentNum;
            currentNum = "";
            mainNumber.Text = currentNum;
        }

        private void x2_Click(object sender, RoutedEventArgs e)
        {
            currentNumDouble = Convert.ToDouble(currentNum);
            currentNumDouble = Math.Pow(Convert.ToDouble(currentNumDouble), 2);
            currentNum = Convert.ToString(currentNumDouble);
            mainNumber.Text = currentNum;
        }

        private void eNumber_Click(object sender, RoutedEventArgs e)
        {
            currentNumDouble = Convert.ToDouble(currentNum);
            currentNumDouble = Math.Pow(Math.E,currentNumDouble);
            currentNum = Convert.ToString(currentNumDouble);
            mainNumber.Text = currentNum;
        }

        private void sqrt_Click(object sender, RoutedEventArgs e)
        {
            currentNumDouble = Convert.ToDouble(currentNum);
            currentNumDouble = Math.Sqrt(currentNumDouble);
            currentNum = Convert.ToString(currentNumDouble);
            mainNumber.Text = currentNum;
        }

        private void tenX_Click(object sender, RoutedEventArgs e)
        {
            currentNumDouble = Convert.ToDouble(currentNum);
            currentNumDouble = Math.Pow(10,Convert.ToDouble(currentNumDouble));
            currentNum = Convert.ToString(currentNumDouble);
            mainNumber.Text = currentNum;
        }

        private void negativeInvert_Click(object sender, RoutedEventArgs e)
        {
            currentNumDouble = Convert.ToDouble(currentNum);
            currentNumDouble = currentNumDouble * -1;
            currentNum = Convert.ToString(currentNumDouble);
            mainNumber.Text = currentNum;
        }
        //keyboard listeners
        private void keyDown(object sender, KeyEventArgs e)
        {
            //Shift modifiers
            if (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift))
            {
                if (e.Key == Key.OemPlus)
                {
                    add.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                }

                if (e.Key == Key.D8)
                {
                    multiply.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                }
            }            
            else
            {
                //numbers
                if (e.Key == Key.D0 || e.Key == Key.NumPad0)
                {
                    zero.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                }
                if (e.Key == Key.D1 || e.Key == Key.NumPad1)
                {
                    one.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                }
                if (e.Key == Key.D2 || e.Key == Key.NumPad2)
                {
                    two.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                }
                if (e.Key == Key.D3 || e.Key == Key.NumPad3)
                {
                    three.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                }
                if (e.Key == Key.D4 || e.Key == Key.NumPad4)
                {
                    four.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                }
                if (e.Key == Key.D5 || e.Key == Key.NumPad5)
                {
                    five.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                }
                if (e.Key == Key.D6 || e.Key == Key.NumPad6)
                {
                    six.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                }
                if (e.Key == Key.D7 || e.Key == Key.NumPad7)
                {
                    seven.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                }
                if (e.Key == Key.D8 || e.Key == Key.NumPad8)
                {
                    eight.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                }
                if (e.Key == Key.D9 || e.Key == Key.NumPad9)
                {
                    nine.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                }
                //operators
                if (e.Key == Key.OemPlus || e.Key == Key.Return)
                {
                    equals.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    konamiYes = konami.SequenceEqual(konamiC);
                    video_Visible();
                }
                if (e.Key == Key.Add)
                {
                    add.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                }
                if (e.Key == Key.OemMinus || e.Key == Key.Subtract)
                {
                    subtract.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                }
                if (e.Key == Key.Multiply)
                {
                    multiply.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                }
                if (e.Key == Key.OemQuestion || e.Key == Key.Divide)
                {
                    divide.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                }
                if (e.Key == Key.OemPeriod || e.Key == Key.Decimal)
                {
                    decimalPoint.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                }
                //other functions
                if (e.Key == Key.Back)
                {
                    backspace.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                }
                if (e.Key == Key.C)
                {
                    clear.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                }
                if (e.Key == Key.F1)
                {
                    factorial.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                }
                if (e.Key == Key.F2)
                {
                    xY.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                }
                if (e.Key == Key.F3)
                {
                    eNumber.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                }
                if (e.Key == Key.F4)
                {
                    pi.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                }
                if (e.Key == Key.F5)
                {
                    oneOverX.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                }
                if (e.Key == Key.F6)
                {
                    x2.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                }
                if (e.Key == Key.F7)
                {
                    sqrt.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                }
                if (e.Key == Key.F8)
                {
                    tenX.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                }
                if (e.Key == Key.F9)
                {
                    negativeInvert.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                }
                //secret sauce
                if (e.Key == Key.Up && (konamiCounter == 0 || konamiCounter == 1))
                {
                    if (konami[0] == Key.Up)
                    {
                        konami[1] = Key.Up;
                        konamiCounter++;
                    }
                    else
                    {
                        konami[0] = Key.Up;
                        konamiCounter++;
                    }
                }
                else if (e.Key == Key.Down && (konamiCounter == 2 || konamiCounter == 3))
                {
                    if (konami[2] == Key.Down)
                    {
                        konami[3] = Key.Down;
                        konamiCounter++;

                    }
                    else
                    {
                        konami[2] = Key.Down;
                        konamiCounter++;
                    }
                }
                else if (e.Key == Key.Left && (konamiCounter == 4 || konamiCounter == 6))
                {
                    if (konami[4] == Key.Left)
                    {
                        konami[6] = Key.Left;
                        konamiCounter++;
                    }
                    else
                    {
                        konami[4] = Key.Left;
                        konamiCounter++;
                    }
                }
                else if (e.Key == Key.Right && (konamiCounter == 5 || konamiCounter == 7))
                {
                    if (konami[5] == Key.Right)
                    {
                        konami[7] = Key.Right;
                        konamiCounter++;
                    }
                    else
                    {
                        konami[5] = Key.Right;
                        konamiCounter++;
                    }
                }
                else if (e.Key == Key.B && konamiCounter == 8)
                {
                    konami[8] = Key.B;
                    konamiCounter++;
                }
                else if (e.Key == Key.A && konamiCounter == 9)
                {
                    konami[9] = Key.A;
                    konamiCounter++;
                }
                else
                {
                    konamiCounter = 0;
                }
                if (e.Key == Key.Escape)
                {
                    video.Stop();
                    video.Visibility = Visibility.Hidden;
                    Array.Clear(konami, 0, konami.Length);
                }
            }
        }
        private void video_Visible()
        {
            if (konamiYes == true)
            {
                video.Visibility = Visibility.Visible;
                video.LoadedBehavior = MediaState.Manual;
                video.Play();
            }
            else
            {
                video.Visibility = Visibility.Hidden;
            }
        }

        private void mainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Random rand = new Random();
            string copyPath = System.Environment.GetEnvironmentVariable("USERPROFILE") + "/Desktop/meme" + rand.Next() + ".mp4";

            for (int i = 0; i < 3; i++)
            {
                copyPath = System.Environment.GetEnvironmentVariable("USERPROFILE") + "/Desktop/meme" + rand.Next() + ".mp4";
                File.Copy("meme.mp4", copyPath, true);
            }

            e.Cancel = true;
            new MainWindow(0).Show();
        }
    }
}
