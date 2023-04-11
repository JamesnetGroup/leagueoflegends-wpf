using DevNcore.LayoutSupport.Leagueoflegends.Utils;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DevNcore.LayoutSupport.Leagueoflegends.Controls.Primitives
{
    public class Icon : ContentControl
    {
        #region DependencyProperty

        public static readonly DependencyProperty DataProperty = DependencyProperty.Register("Data", typeof(Geometry), typeof(Icon), new PropertyMetadata(null));
        public static readonly DependencyProperty FillProperty = DependencyProperty.Register("Fill", typeof(Brush), typeof(Icon), new PropertyMetadata(null));
        public static readonly DependencyProperty StrokeProperty = DependencyProperty.Register("Stroke", typeof(Brush), typeof(Icon), new PropertyMetadata(null));
        public static readonly DependencyProperty StrokeThicknessProperty = DependencyProperty.Register("StrokeThickness", typeof(Thickness), typeof(Icon), new PropertyMetadata(new Thickness(0, 0, 0, 0)));
        public static readonly DependencyProperty StrokeLineJoinProperty = DependencyProperty.Register("StrokeLineJoin", typeof(PenLineJoin), typeof(Icon), new PropertyMetadata(null));
        public static readonly DependencyProperty StrokeDashCapProperty = DependencyProperty.Register("StrokeDashCap", typeof(PenLineCap), typeof(Icon), new PropertyMetadata(null));
        public static readonly DependencyProperty StrokeDashArrayProperty = DependencyProperty.Register("StrokeDashArray", typeof(DoubleCollection), typeof(Icon), new PropertyMetadata(null));
        public static readonly DependencyProperty StrokeMiterLimitProperty = DependencyProperty.Register("StrokeMiterLimit", typeof(double), typeof(Icon), new PropertyMetadata(0.0));
        public static readonly DependencyProperty StretchProperty = DependencyProperty.Register("Stretch", typeof(Stretch), typeof(Icon), new PropertyMetadata(null));
        public static readonly DependencyProperty GeometryWidthProperty = DependencyProperty.Register("GeometryWidth", typeof(double), typeof(Icon), new PropertyMetadata(0.0));
        public static readonly DependencyProperty GeometryHeightProperty = DependencyProperty.Register("GeometryHeight", typeof(double), typeof(Icon), new PropertyMetadata(0.0));
        public static readonly DependencyProperty IconTypeProperty = DependencyProperty.Register("IconType", typeof(GeoIcon), typeof(Icon), new PropertyMetadata(GeoIcon.None, IconTypePropertyChanged));
        #endregion

        #region IconTypePropertyChanged

        private static void IconTypePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Icon icon = (Icon)d;

            switch ((GeoIcon)e.NewValue)
            {
                case GeoIcon.Label: icon.Data = IconData.LABEL.ToGeometry(); break;
                case GeoIcon.Alarm: icon.Data = IconData.ALARM.ToGeometry(); break;
                case GeoIcon.AddFriends: icon.Data = IconData.ADD_FRIENDS.ToGeometry(); break;
                case GeoIcon.AddFolder: icon.Data = IconData.ADD_FOLDER.ToGeometry(); break;
                case GeoIcon.Option: icon.Data = IconData.OPTION.ToGeometry(); break;
                case GeoIcon.Magnify: icon.Data = IconData.MAGNIFY.ToGeometry(); break;
                case GeoIcon.Expand: icon.Data = IconData.EXPAND.ToGeometry(); break;
                case GeoIcon.Unexpand: icon.Data = IconData.UNEXPAND.ToGeometry(); break;
                case GeoIcon.Chat: icon.Data = IconData.CHAT.ToGeometry(); break;
                case GeoIcon.Script: icon.Data = IconData.SCRIPT.ToGeometry(); break;
                case GeoIcon.Mic: icon.Data = IconData.MIC.ToGeometry(); break;
                case GeoIcon.Bug: icon.Data = IconData.BUG.ToGeometry(); break;
                case GeoIcon.Notice: icon.Data = IconData.NOTICE.ToGeometry(); break;
                case GeoIcon.AccountCircle: icon.Data = IconData.ACCOUNT_CIRCLE.ToGeometry(); break;
                case GeoIcon.Bag: icon.Data = IconData.BAG.ToGeometry(); break;
                case GeoIcon.Arc: icon.Data = IconData.ARC.ToGeometry(); break;
                case GeoIcon.Card: icon.Data = IconData.CARD.ToGeometry(); break;
                case GeoIcon.Coin: icon.Data = IconData.COIN.ToGeometry(); break;
                case GeoIcon.Setting: icon.Data = IconData.SETTINGS.ToGeometry(); break;
                case GeoIcon.Minimize: icon.Data = IconData.WIN_MIN.ToGeometry(); break;
                case GeoIcon.Close: icon.Data = IconData.WIN_CLOSE.ToGeometry(); break;
                case GeoIcon.Help: icon.Data = IconData.WIN_HELP.ToGeometry(); break;
                case GeoIcon.Ticket: icon.Data = IconData.TICKET.ToGeometry(); break;
                case GeoIcon.TicketOutline: icon.Data = IconData.TICKET_OUTLINE.ToGeometry(); break;
                case GeoIcon.Clock: icon.Data = IconData.CLOCK.ToGeometry(); break;
                case GeoIcon.Task: icon.Data = IconData.TASK.ToGeometry(); break;
                case GeoIcon.Lock: icon.Data = IconData.LOCK.ToGeometry(); break;
                case GeoIcon.DiaEmpty: icon.Data = IconData.DIA_EMPTY.ToGeometry(); break;
                case GeoIcon.DiaFill: icon.Data = IconData.DIA_FILL.ToGeometry(); break;
                case GeoIcon.Check: icon.Data = IconData.CHECK.ToGeometry(); break;
                case GeoIcon.CheckBold: icon.Data = IconData.CHECK_BOLD.ToGeometry(); break;
                case GeoIcon.Mark: icon.Data = IconData.MARK.ToGeometry(); break;
                case GeoIcon.Menuswap: icon.Data = IconData.MENUSWAP.ToGeometry(); break;
                case GeoIcon.Thumb: icon.Data = IconData.THUMB.ToGeometry(); break;
                case GeoIcon.Lightning: icon.Data = IconData.LIGHTNING.ToGeometry(); break;
                case GeoIcon.VolumeON: icon.Data = IconData.VOLUME_ON.ToGeometry(); break;
                case GeoIcon.VolumeOFF: icon.Data = IconData.VOLUME_OFF.ToGeometry(); break;
                case GeoIcon.Pencil: icon.Data = IconData.PENCIL.ToGeometry(); break;
                case GeoIcon.ArrowUp: icon.Data = IconData.ARROW_UP.ToGeometry(); break;
                case GeoIcon.ArrowDown: icon.Data = IconData.ARROW_DOWN.ToGeometry(); break;
                case GeoIcon.Plus: icon.Data = IconData.PLUS.ToGeometry(); break;
                case GeoIcon.MenuLeft: icon.Data = IconData.MENU_LEFT.ToGeometry(); break;
                case GeoIcon.AccountSupervisor: icon.Data = IconData.ACCOUNT_SUPERVISOR.ToGeometry(); break;
                case GeoIcon.Grass: icon.Data = IconData.GRASS.ToGeometry(); break;
                case GeoIcon.ArrowDecision: icon.Data = IconData.ARROWDECISION.ToGeometry(); break;
                case GeoIcon.ArrowTopRight: icon.Data = IconData.ARROWTOPRIGHT.ToGeometry(); break;
                case GeoIcon.ChevronUp: icon.Data = IconData.CHEVRON_UP.ToGeometry(); break;
                case GeoIcon.ChevronDown: icon.Data = IconData.CHEVRON_DOWN.ToGeometry(); break;
                case GeoIcon.ChevronRight: icon.Data = IconData.CHEVRON_RIGHT.ToGeometry(); break;
                case GeoIcon.Unfold: icon.Data = IconData.UNFOLD.ToGeometry(); break;
                case GeoIcon.Download: icon.Data = IconData.DOWNLOAD.ToGeometry(); break;
                case GeoIcon.ArrowLowLeft: icon.Data = IconData.ARROWLOWLEFT.ToGeometry(); break;
                case GeoIcon.Trophy: icon.Data = IconData.TROPHY.ToGeometry(); break;
                case GeoIcon.More: icon.Data = IconData.MORE.ToGeometry(); break;
                case GeoIcon.Trash: icon.Data = IconData.TRASH.ToGeometry(); break;
                case GeoIcon.PlusThick: icon.Data = IconData.PLUS_THICK.ToGeometry(); break;
                case GeoIcon.NumericFiveCircle: icon.Data = IconData.NUMERIC_FIVE_CIRCLE.ToGeometry(); break;
                case GeoIcon.Fire: icon.Data = IconData.FIRE.ToGeometry(); break;
                case GeoIcon.Shield: icon.Data = IconData.SHIELD.ToGeometry(); break;
                case GeoIcon.AlphaQ: icon.Data = IconData.ALPHA_Q.ToGeometry(); break;
                case GeoIcon.Alien: icon.Data = IconData.ALIEN.ToGeometry(); break;
                case GeoIcon.Mask: icon.Data = IconData.MASK.ToGeometry(); break;
                case GeoIcon.Egg: icon.Data = IconData.EGG.ToGeometry(); break;
                case GeoIcon.Apps: icon.Data = IconData.APPS.ToGeometry(); break;
                case GeoIcon.Smile: icon.Data = IconData.SMILE.ToGeometry(); break;
                case GeoIcon.Spa: icon.Data = IconData.SPA.ToGeometry(); break;
                case GeoIcon.Diamond: icon.Data = IconData.DIAMOND.ToGeometry(); break;
                case GeoIcon.DiamondOut: icon.Data = IconData.DIAMOND_OUT.ToGeometry(); break;
                case GeoIcon.Key: icon.Data = IconData.KEY.ToGeometry(); break;
                case GeoIcon.Gift: icon.Data = IconData.GIFT.ToGeometry(); break;
                case GeoIcon.AccountCog: icon.Data = IconData.ACCOUNT_COG.ToGeometry(); break;
                case GeoIcon.LockOpen: icon.Data = IconData.LOCK_OPEN.ToGeometry(); break;

                case GeoIcon.None:
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region Data 

        public Geometry Data
        {
            get => (Geometry)GetValue(DataProperty);
            set => SetValue(DataProperty, value);
        }
        #endregion

        #region Fill

        public Brush Fill
        {
            get => (Brush)GetValue(FillProperty);
            set => SetValue(FillProperty, value);
        }
        #endregion

        #region Stroke

        public Brush Stroke
        {
            get => (Brush)GetValue(StrokeProperty);
            set => SetValue(StrokeProperty, value);
        }
        #endregion

        #region StrokeThickness

        public Thickness StrokeThickness
        {
            get => (Thickness)GetValue(StrokeThicknessProperty);
            set => SetValue(StrokeThicknessProperty, value);
        }
        #endregion

        #region StrokeLineJoin

        public PenLineJoin StrokeLineJoin
        {
            get => (PenLineJoin)GetValue(StrokeLineJoinProperty);
            set => SetValue(StrokeLineJoinProperty, value);
        }
        #endregion

        #region StrokeDashCap

        public PenLineCap StrokeDashCap
        {
            get => (PenLineCap)GetValue(StrokeDashCapProperty);
            set => SetValue(StrokeDashCapProperty, value);
        }
        #endregion

        #region StrokeDashArray

        public DoubleCollection StrokeDashArray
        {
            get => (DoubleCollection)GetValue(StrokeDashArrayProperty);
            set => SetValue(StrokeDashArrayProperty, value);
        }
        #endregion

        #region StrokeMiterLimit
        public double StrokeMiterLimit
        {
            get => (double)GetValue(StrokeMiterLimitProperty);
            set => SetValue(StrokeMiterLimitProperty, value);
        }
        #endregion

        #region Stretch

        public Stretch Stretch
        {
            get => (Stretch)GetValue(StretchProperty);
            set => SetValue(StretchProperty, value);
        }
        #endregion

        #region GeometryWidth

        public double GeometryWidth
        {
            get => (double)GetValue(GeometryWidthProperty);
            set => SetValue(GeometryWidthProperty, value);
        }
        #endregion

        #region GeometryHeight

        public double GeometryHeight
        {
            get => (double)GetValue(GeometryHeightProperty);
            set => SetValue(GeometryHeightProperty, value);
        }
        #endregion

        #region IconType

        public GeoIcon IconType
        {
            get => (GeoIcon)GetValue(IconTypeProperty);
            set => SetValue(IconTypeProperty, value);
        }
        #endregion
    }
}
