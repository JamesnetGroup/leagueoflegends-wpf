using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Leagueoflegends.LayoutSupport.Controls
{
    public class Icon : Control
    {
        static Icon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Icon), new FrameworkPropertyMetadata(typeof(Icon)));
        }

        public static readonly DependencyProperty DataProperty = DependencyProperty.Register(
            "Data", typeof(Geometry), typeof(Icon), new PropertyMetadata(null));

        public static readonly DependencyProperty FillProperty = DependencyProperty.Register(
            "Fill", typeof(Brush), typeof(Icon), new PropertyMetadata(null));

        public static readonly DependencyProperty StrokeProperty = DependencyProperty.Register(
            "Stroke", typeof(Brush), typeof(Icon), new PropertyMetadata(null));

        public static readonly DependencyProperty StrokeThicknessProperty = DependencyProperty.Register(
            "StrokeThickness", typeof(Thickness), typeof(Icon), new PropertyMetadata(new Thickness(0, 0, 0, 0)));

        public static readonly DependencyProperty StrokeLineJoinProperty = DependencyProperty.Register(
            "StrokeLineJoin", typeof(PenLineJoin), typeof(Icon), new PropertyMetadata(null));

        public static readonly DependencyProperty StrokeDashCapProperty = DependencyProperty.Register(
            "StrokeDashCap", typeof(PenLineCap), typeof(Icon), new PropertyMetadata(null));

        public static readonly DependencyProperty StrokeDashArrayProperty = DependencyProperty.Register(
            "StrokeDashArray", typeof(DoubleCollection), typeof(Icon), new PropertyMetadata(null));

        public static readonly DependencyProperty StrokeMiterLimitProperty = DependencyProperty.Register(
            "StrokeMiterLimit", typeof(double), typeof(Icon), new PropertyMetadata(0.0));

        public static readonly DependencyProperty StretchProperty = DependencyProperty.Register(
            "Stretch", typeof(Stretch), typeof(Icon), new PropertyMetadata(null));

        public static readonly DependencyProperty GeometryWidthProperty = DependencyProperty.Register(
            "GeometryWidth", typeof(double), typeof(Icon), new PropertyMetadata(0.0));

        public static readonly DependencyProperty GeometryHeightProperty = DependencyProperty.Register(
            "GeometryHeight", typeof(double), typeof(Icon), new PropertyMetadata(0.0));

        public Geometry Data
        {
            get { return (Geometry)this.GetValue(DataProperty); }
            set { this.SetValue(DataProperty, value); }
        }

        public Brush Fill
        {
            get { return (Brush)this.GetValue(FillProperty); }
            set { this.SetValue(FillProperty, value); }
        }


        public Brush Stroke
        {
            get { return (Brush)this.GetValue(StrokeProperty); }
            set { this.SetValue(StrokeProperty, value); }
        }

        public Thickness StrokeThickness
        {
            get { return (Thickness)this.GetValue(StrokeThicknessProperty); }
            set { this.SetValue(StrokeThicknessProperty, value); }
        }

        public PenLineJoin StrokeLineJoin
        {
            get { return (PenLineJoin)this.GetValue(StrokeLineJoinProperty); }
            set { this.SetValue(StrokeLineJoinProperty, value); }
        }

        public PenLineCap StrokeDashCap
        {
            get { return (PenLineCap)this.GetValue(StrokeDashCapProperty); }
            set { this.SetValue(StrokeDashCapProperty, value); }
        }

        public DoubleCollection StrokeDashArray
        {
            get { return (DoubleCollection)this.GetValue(StrokeDashArrayProperty); }
            set { this.SetValue(StrokeDashArrayProperty, value); }
        }

        public double StrokeMiterLimit
        {
            get { return (double)this.GetValue(StrokeMiterLimitProperty); }
            set { this.SetValue(StrokeMiterLimitProperty, value); }
        }

        public Stretch Stretch
        {
            get { return (Stretch)this.GetValue(StretchProperty); }
            set { this.SetValue(StretchProperty, value); }
        }

        public double GeometryWidth
        {
            get { return (double)this.GetValue(GeometryWidthProperty); }
            set { this.SetValue(GeometryWidthProperty, value); }
        }

        public double GeometryHeight
        {
            get { return (double)this.GetValue(GeometryHeightProperty); }
            set { this.SetValue(GeometryHeightProperty, value); }
        }
    }
}
