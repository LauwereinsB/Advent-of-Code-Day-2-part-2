using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;

namespace Advent_of_Code_Day_2_v0._2
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

        private void btnRun_Click(object sender, RoutedEventArgs e)
        {
            int forward = 0, depth = 0, aim = 0;
            double result;
            using (StreamReader reader = new StreamReader("D:\\Users\\Benji\\source\\repos\\Advent Of Code 2021\\Advent of Code Day 2 v0.2\\Advent of Code Day 2 v0.2\\Advent of Code Day 2 input.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string oneLine = reader.ReadLine();
                    int n;
                    if (int.TryParse(new string(oneLine.Where(a => Char.IsDigit(a)).ToArray()), out n))
                    {

                    }

                    if (oneLine.Contains("down"))
                    {
                        aim += n;
                    }
                    else if (oneLine.Contains("up"))
                    {
                        aim -= n;
                    }
                    else
                    {
                        forward += n;
                        depth += n * aim;
                    }
                    
                }
            }
            result = forward * depth;
            lblResult.Content = result.ToString();

            
        }
        
    }
}