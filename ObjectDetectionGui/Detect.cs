using System;
using Models;
using ObjectDetectionGui.Views;
using DeepLearning;

namespace ObjectDetectionGui
{
    public class Detect
    {
        static void Main(string[] args)
        {
            WrapperModel model = WrapperModel.Instance;
            if (model.IsDetectionEnable)
            {
                BrowserView browserview = new BrowserView();
                //检测的图片路径
                browserview.ImagePath = "1.jpg";
                //检测
                browserview.Detect();
                //检测到的类别名称
                foreach (DetectedItemInfo item in browserview.items)
                {
                    var label = item.Type;
                    Console.WriteLine(label);
                }
            }
        }
    }
}
