        private void addImage()
        {
            Image img = new Image();
            Image img2 = new Image(); 
            img.Source = new SvgImageSource(new Uri("ms-appx:///Assets/test.svg"));
            img2.Source = new SvgImageSource(new Uri("ms-appx:///Assets/test.svg"));

            img.RenderTransformOrigin = new Point(0.5, 0.5);
            RotateTransform myRotateTransform = new RotateTransform();
            myRotateTransform.Angle = 45;

            // Create a transform to scale the size of the button.
            ScaleTransform myScaleTransform = new ScaleTransform();
            myScaleTransform.ScaleY= 1.0;

            TransformGroup myTransformGroup = new TransformGroup();
            myTransformGroup.Children.Add(myScaleTransform);
            myTransformGroup.Children.Add(myRotateTransform);

            img.RenderTransform = myTransformGroup;

            canbas.Children.Add(img);
            canbas.Children.Add(img2);
        }
