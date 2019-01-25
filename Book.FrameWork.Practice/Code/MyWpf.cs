using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Book.FrameWork.Practice.Code
{
    class MyWpf
    {
        public void M1()
        {
            var button = new Button { Content = "确定" };
            button.Click += (a, b) => { button.Content = "取消"; };
            var window = new Window { Title = "我的WPF", Content = button };
            var app = new Application();
            app.Run(window);
        }
    }
}
