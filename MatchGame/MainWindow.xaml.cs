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

namespace MatchGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetUpGame();
        }

        private void SetUpGame()
        {
            List<string> animalsEmoji = new List<string>()
            {
                ":)",":(",
                "xD","xP",
                ":s",":<",
                ":p",":P",
                ":d",":S",
                ":e",":X",
                ":w",":D",
                ":q",":Q",
            };

            Random random = new Random();
               
            foreach(TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                int index = random.Next(animalsEmoji.Count);
                string nextEmoji = animalsEmoji[index];
                textBlock.Text = nextEmoji;
                animalsEmoji.RemoveAt(index);
            }
        }
    }
}
