﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

//“空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 上有介绍

namespace UWPCalculator
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        public string a = "0";
        public string b = "";
        public bool c;
        public string d = "0";
        private bool isShiftKeyPressed;

        private void Button_Click1(object sender, RoutedEventArgs e)//数字按钮的功能实现
        {
            if (b != "Error!")//除数为0报错后停止功能实现
            {
                if (B.Text == "0")//判断初始值是否为0
                {
                    d = "1";
                }
                else
                {
                    d += "1";
                }
                B.Text = d;
            }
            else
                B.Text = "Please clear it.";
            c = true;
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            if (b != "Error!")
            {
                if (B.Text == "0")
                {
                    d = "2";
                }
                else
                {
                    d += "2";
                }
                B.Text = d;
            }
            else
                B.Text = "Please clear it.";
            c = true;
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            if (b != "Error!")
            {
                if (B.Text == "0")
                {
                    d = "3";
                }
                else
                {
                    d += "3";
                }
                B.Text = d;
            }
            else
                B.Text = "Please clear it.";
            c = true;
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            if (b != "Error!")
            {
                if (B.Text == "0")
                {
                    d = "4";
                }
                else
                {
                    d += "4";
                }
                B.Text = d;
            }
            else
                B.Text = "Please clear it.";
            c = true;
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            if (b != "Error!")
            {
                if (B.Text == "0")
                {
                    d = "5";
                }
                else
                {
                    d += "5";
                }
                B.Text = d;
            }
            else
                B.Text = "Please clear it.";
            c = true;
        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            if (b != "Error!")
            {
                if (B.Text == "0")
                {
                    d = "6";
                }
                else
                {
                    d += "6";
                }
                B.Text = d;
            }
            else
                B.Text = "Please clear it.";
            c = true;
        }

        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            if (b != "Error!")
            {
                if (B.Text == "0")
                {
                    d = "7";
                }
                else
                {
                    d += "7";
                }
                B.Text = d;
            }
            else
                B.Text = "Please clear it.";
            c = true;
        }

        private void Button_Click8(object sender, RoutedEventArgs e)
        {
            if (b != "Error!")
            {
                if (B.Text == "0")
                {
                    d = "8";
                }
                else
                {
                    d += "8";
                }
                B.Text = d;
            }
            else
                B.Text = "Please clear it.";
            c = true;
        }

        private void Button_Click9(object sender, RoutedEventArgs e)
        {
            if (b != "Error!")
            {
                if (B.Text == "0")
                {
                    d = "9";
                }
                else
                {
                    d += "9";
                }
                B.Text = d;
            }
            else
                B.Text = "Please clear it.";
            c = true;
        }

        private void Button_Click0(object sender, RoutedEventArgs e)
        {
            if (b != "Error!")
            {
                if (B.Text != "0")
                {
                    d += "0";
                }
                B.Text = d;
            }
            else
                B.Text = "Please clear it.";
            c = true;
        }

        bool point = true;

        private void Button_Click(object sender, RoutedEventArgs e)//小数点按钮功能实现
        {
            if (b != "Error!")
            {
                if (point == true)//判断是否出现过小数点
                {
                    if (d != "")
                    {
                        d += ".";
                    }
                    else
                    {
                        d = "0.";
                    }
                    point = false;//禁止在同一个数中在次出现小数点
                }
                B.Text = d;
            }
            else
                B.Text = "Please clear it.";
            c = true;
        }

        double num1 = 0;

        private void Button_ClickA(object sender, RoutedEventArgs e)//运算符按钮功能实现
        {
            if (b != "Error!")
            {
                if (c == false) { }//判断是否在运算符后直接添加运算符
                else
                {
                    d = Convert.ToDouble(d).ToString();
                    b = b + d + " + ";
                    d = "";
                    if (b.Contains("÷ 0 "))//判断除数为0报错
                    {
                        b = "Error!";
                        A.Text = b;
                        B.Text = b;
                    }
                    else
                    {
                        A.Text = b;
                        point = true;//更改小数点为可添加状态
                        switch (a)//判断之前的运算符并运算
                        {
                            case "0":
                                num1 = Convert.ToDouble(B.Text);
                                break;
                            case "A":
                                num1 += Convert.ToDouble(B.Text);
                                B.Text = num1.ToString();
                                break;
                            case "B":
                                num1 -= Convert.ToDouble(B.Text);
                                B.Text = num1.ToString();
                                break;
                            case "C":
                                num1 *= Convert.ToDouble(B.Text);
                                B.Text = num1.ToString();
                                break;
                            case "D":
                                num1 /= Convert.ToDouble(B.Text);
                                B.Text = num1.ToString();
                                break;
                        }
                        a = "A";//设置下一次计算使用的运算符
                    }
                }
            }
            else
                B.Text = "Please clear it.";
            c = false;
        }

        private void Button_ClickB(object sender, RoutedEventArgs e)
        {
            if (b != "Error!")
            {
                if (c == false) { }
                else
                {
                    d = Convert.ToDouble(d).ToString();
                    b = b + d + " - ";
                    d = "";
                    if (b.Contains("÷ 0 "))
                    {
                        b = "Error!";
                        A.Text = b;
                        B.Text = b;
                    }
                    else
                    {
                        A.Text = b;
                        point = true;
                        switch (a)
                        {
                            case "0":
                                num1 = Convert.ToDouble(B.Text);
                                break;
                            case "A":
                                num1 += Convert.ToDouble(B.Text);
                                B.Text = num1.ToString();
                                break;
                            case "B":
                                num1 -= Convert.ToDouble(B.Text);
                                B.Text = num1.ToString();
                                break;
                            case "C":
                                num1 *= Convert.ToDouble(B.Text);
                                B.Text = num1.ToString();
                                break;
                            case "D":
                                num1 /= Convert.ToDouble(B.Text);
                                B.Text = num1.ToString();
                                break;
                        }
                        a = "B";
                    }
                }
            }
            else
                B.Text = "Please clear it.";
            c = false;
        }

        private void Button_ClickC(object sender, RoutedEventArgs e)
        {
            if (b != "Error!")
            {
                if (c == false) { }
                else
                {
                    d = Convert.ToDouble(d).ToString();
                    b = b + d + " × ";
                    d = "";
                    if (b.Contains("÷ 0 "))
                    {
                        b = "Error!";
                        A.Text = b;
                        B.Text = b;
                    }
                    else
                    {
                        A.Text = b;
                        point = true;
                        switch (a)
                        {
                            case "0":
                                num1 = Convert.ToDouble(B.Text);
                                break;
                            case "A":
                                num1 += Convert.ToDouble(B.Text);
                                B.Text = num1.ToString();
                                break;
                            case "B":
                                num1 -= Convert.ToDouble(B.Text);
                                B.Text = num1.ToString();
                                break;
                            case "C":
                                num1 *= Convert.ToDouble(B.Text);
                                B.Text = num1.ToString();
                                break;
                            case "D":
                                num1 /= Convert.ToDouble(B.Text);
                                B.Text = num1.ToString();
                                break;
                        }
                        a = "C";
                    }
                }
            }
            else
                B.Text = "Please clear it.";
            c = false;
        }

        private void Button_ClickD(object sender, RoutedEventArgs e)
        {
            if (b != "Error!")
            {
                if (c == false) { }
                else
                {
                    d = Convert.ToDouble(d).ToString();
                    b = b + d + " ÷ ";
                    d = "";
                    if (b.Contains("÷ 0 "))
                    {
                        b = "Error!";
                        A.Text = b;
                        B.Text = b;
                    }
                    else
                    {
                        A.Text = b;
                        point = true;
                        switch (a)
                        {
                            case "0":
                                num1 = Convert.ToDouble(B.Text);
                                break;
                            case "A":
                                num1 += Convert.ToDouble(B.Text);
                                B.Text = num1.ToString();
                                break;
                            case "B":
                                num1 -= Convert.ToDouble(B.Text);
                                B.Text = num1.ToString();
                                break;
                            case "C":
                                num1 *= Convert.ToDouble(B.Text);
                                B.Text = num1.ToString();
                                break;
                            case "D":
                                num1 /= Convert.ToDouble(B.Text);
                                B.Text = num1.ToString();
                                break;
                        }
                        a = "D";
                    }
                }
            }
            else
                B.Text = "Please clear it.";
            c = false;
        }

        private void Button_ClickE(object sender, RoutedEventArgs e)//等号按钮功能实现
        {
            if (b != "Error!")
            {
                if (c == false) { }
                else
                {
                    if (A.Text.EndsWith("= "))
                    {
                        b = B.Text + " = ";
                    }
                    else
                    {
                        d = Convert.ToDouble(d).ToString();
                        b = b + d + " = ";
                        if (b.Contains("÷ 0 "))
                        {
                            b = "Error!";
                            A.Text = b;
                            B.Text = b;
                        }
                        else
                        {
                            A.Text = "";
                            point = true;
                            switch (a)
                            {
                                case "0":
                                    num1 = Convert.ToDouble(B.Text);
                                    break;
                                case "A":
                                    num1 += Convert.ToDouble(B.Text);
                                    B.Text = num1.ToString();
                                    break;
                                case "B":
                                    num1 -= Convert.ToDouble(B.Text);
                                    B.Text = num1.ToString();
                                    break;
                                case "C":
                                    num1 *= Convert.ToDouble(B.Text);
                                    B.Text = num1.ToString();
                                    break;
                                case "D":
                                    num1 /= Convert.ToDouble(B.Text);
                                    B.Text = num1.ToString();
                                    break;
                            }
                        }
                        a = "0";
                    }
                    if (B.Text != "Error!")//添加历史纪录
                    {
                        his.Insert(0, new His { Head = b, Score = B.Text });
                        records.ItemsSource = his;
                    }
                    b = "";//清空变量，为下一次运算做准备
                    d = "";
                }
            }
            else
                B.Text = "Please clear it.";
            c = false;
        }

        private void Pivot_KeyDown(object sender, KeyRoutedEventArgs e)//启用键盘监听，可以使用键盘对应的键执行按钮功能
        {
            if (e.Key == Windows.System.VirtualKey.Shift) isShiftKeyPressed = true;//判断是否按下Shift键
            else if (isShiftKeyPressed == false)
            {
                if (e.Key == Windows.System.VirtualKey.Number1 || e.Key == Windows.System.VirtualKey.NumberPad1)
                    Button_Click1(sender, e);
                if (e.Key == Windows.System.VirtualKey.Number2 || e.Key == Windows.System.VirtualKey.NumberPad2)
                    Button_Click2(sender, e);
                if (e.Key == Windows.System.VirtualKey.Number3 || e.Key == Windows.System.VirtualKey.NumberPad3)
                    Button_Click3(sender, e);
                if (e.Key == Windows.System.VirtualKey.Number4 || e.Key == Windows.System.VirtualKey.NumberPad4)
                    Button_Click4(sender, e);
                if (e.Key == Windows.System.VirtualKey.Number5 || e.Key == Windows.System.VirtualKey.NumberPad5)
                    Button_Click5(sender, e);
                if (e.Key == Windows.System.VirtualKey.Number6 || e.Key == Windows.System.VirtualKey.NumberPad6)
                    Button_Click6(sender, e);
                if (e.Key == Windows.System.VirtualKey.Number7 || e.Key == Windows.System.VirtualKey.NumberPad7)
                    Button_Click7(sender, e);
                if (e.Key == Windows.System.VirtualKey.Number8 || e.Key == Windows.System.VirtualKey.NumberPad8)
                    Button_Click8(sender, e);
                if (e.Key == Windows.System.VirtualKey.Number9 || e.Key == Windows.System.VirtualKey.NumberPad9)
                    Button_Click9(sender, e);
                if (e.Key == Windows.System.VirtualKey.Number0 || e.Key == Windows.System.VirtualKey.NumberPad0)
                    Button_Click0(sender, e);
                if (e.Key == Windows.System.VirtualKey.Add)
                    Button_ClickA(sender, e);
                if (e.Key == Windows.System.VirtualKey.Subtract || (int)e.Key == 189)
                    Button_ClickB(sender, e);
                if (e.Key == Windows.System.VirtualKey.Multiply)
                    Button_ClickC(sender, e);
                if (e.Key == Windows.System.VirtualKey.Divide || (int)e.Key == 191)
                    Button_ClickD(sender, e);
                if (e.Key == Windows.System.VirtualKey.Decimal || (int)e.Key == 190)
                    Button_Click(sender, e);
                if (e.Key == Windows.System.VirtualKey.Enter || (int)e.Key == 187)
                    Button_ClickE(sender, e);
            }
            else if (isShiftKeyPressed == true)//这个是因为UWP没有具体的VirtualKey，直接用值
            {
                if ((int)e.Key == 187)
                    Button_ClickA(sender, e);
                if (e.Key == Windows.System.VirtualKey.Number8)
                    Button_ClickC(sender, e);
            }
        }

        private void Pivot_KeyUp(object sender, KeyRoutedEventArgs e)//监测是否松开Shift键
        {
            if (e.Key == Windows.System.VirtualKey.Shift) isShiftKeyPressed = false;
        }

        private void AppBarButtonC_Click(object sender, RoutedEventArgs e)//清空数据按钮功能实现
        {
            A.Text = "";
            B.Text = "0";
            a = "0";
            b = "";
            d = "0";
            c = true;
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)//清空历史纪录按钮功能实现
        {
            his.Clear();
            records.ItemsSource = his;
        }

        public class His//历史纪录功能实现
        {
            public string Head { get; set; }
            public string Score { get; set; }
        }

        public ObservableCollection<His> his = new ObservableCollection<His>();

        private void records_ItemClick(object sender, ItemClickEventArgs e)//点击历史纪录返回数值到计算界面功能实现
        {
            A.Text = ((His)e.ClickedItem).Head.Substring(0, ((His)e.ClickedItem).Head.Length - 3);
            B.Text = ((His)e.ClickedItem).Score;
        }
    }
}
