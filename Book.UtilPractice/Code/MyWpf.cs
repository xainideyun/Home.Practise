using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Book.UtilPractice.Code
{
    class MyWpf
    {
        public void M1()
        {
            var button = new Button { Content = "确定" };
            button.Click += (a, b) => { };
        }
    }
}
