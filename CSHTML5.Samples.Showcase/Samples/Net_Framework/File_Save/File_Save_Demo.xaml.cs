﻿using CSHTML5.Extensions.FileSystem;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace CSHTML5.Samples.Showcase
{
    public partial class File_Save_Demo : UserControl
    {
        public File_Save_Demo()
        {
            this.InitializeComponent();
        }

        async void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            await FileSaver.SaveTextToFile("MyTestFile.txt", "Hello World");
        }
    }
}