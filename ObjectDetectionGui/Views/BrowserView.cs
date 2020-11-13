using System;
using Models;
using DeepLearning;
using ObjectDetectionGui.Base;
using System.Collections.Generic;
using System.IO;
using System.Drawing;

namespace ObjectDetectionGui.Views
{
    public partial class BrowserView
    {

        #region Fields

        private ResultViewModel m_ResultViewModel = ResultViewModel.Instance;
        public List<DetectedItemInfo> DetectedItemInfoList { get; set; }

        #endregion

        #region Initializing

        public BrowserView()
        {
        }


        #endregion

        #region Commands



        public void Detect()
        {
            if (ImagePath !=null)
            {
                WrapperModel model = WrapperModel.Instance;
                model.FilePath = ImagePath;
                items = model.Detect();

                SetDetectedItemsToBindableItems();
            }
            else
            {
            }
        }

        #endregion
        
        #region Utilitis

        private void SetDetectedItemsToBindableItems()
        {
            m_ResultViewModel.ResultModelList.Clear();
            foreach (DetectedItemInfo item in items)
            {
                ResultInfoModel resultModel = new ResultInfoModel();
                resultModel.DetectionLabel = item.Type;
                resultModel.Confidence = item.Confidence;
                resultModel.DetectedBoxLeftTopX = item.X;
                resultModel.DetectedBoxLeftTopY = item.Y;
                resultModel.DetectedBoxWidth = item.Width;
                resultModel.DetectedBoxHeight = item.Height;
                m_ResultViewModel.ResultModelList.Add(resultModel);
            }
            DrawBoundingBox();
        }
        #endregion
        #region Drawing BoundingBox

        public void DrawBoundingBox()
        {
            Image img = Image.FromFile(ImagePath);//建立Image对象
            Graphics g = Graphics.FromImage(img);//创建Graphics对象
            Pen pen;
            Font font = new Font("Arial", 16);
            foreach (DetectedItemInfo item in items)
            {
                pen = new Pen(Brushes.Blue, 2);
                g.DrawRectangle( pen, new Rectangle(item.X, item.Y, item.Width, item.Height)); 
                g.DrawString(item.Type, font, Brushes.Red, item.X, item.Y);
                //ImageFormat iformat=new ImageFormat(new Guid(Bmp));
            }
            img.Save(@"image.png");
            
        }

        #endregion

        #region Changed Value


        #endregion

        public string ImagePath { get; set; }
        public List<DetectedItemInfo> items { get; set; }
    }
}
