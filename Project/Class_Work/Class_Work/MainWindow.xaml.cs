using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Class_Work
{
    class HockeyPuck
    {
        bool LeftMove; bool RightMove;
        int X_PuckPos = 0;
        int Y_PuckPos = 0;
        public Border PuckBorder = new Border();
        public void InitPuck()
        {
            this.PuckBorder.Height = 50;
            this.PuckBorder.Width = 50;
            this.PuckBorder.BorderBrush = Brushes.Black;
            this.PuckBorder.CornerRadius = new CornerRadius(100);
            this.PuckBorder.BorderThickness = new Thickness(1);
            this.PuckBorder.VerticalAlignment = VerticalAlignment.Center;
            RadialGradientBrush myRadialGradientBrush = new RadialGradientBrush();
            myRadialGradientBrush.GradientStops.Add(
                new GradientStop(Colors.GreenYellow, 0.1));
            myRadialGradientBrush.GradientStops.Add(
                new GradientStop(Colors.LimeGreen, 0.70));
            PuckBorder.Background = myRadialGradientBrush;
        }
        public void MovePuck()
        {
            
        }
        public bool CheckPos(int XPos, int YPos)
        {
            return true;
        }
    }

    abstract class AbstractPlayer
    {
        protected int GoalPointer = 0;
        protected string PlayerName = null;
        public abstract void InitPlayer(string Name);
        public abstract void MoveBat();
    }

    class MousePlayer : AbstractPlayer
    {
        int X_MouseCord = 0;
        int Y_MouseCord = 0;
        public Border PlayerBorder = new Border();
        public void SetMouseCord(int x, int y)
        {
            if (x >= -170 && x <= 170 && y >= 40 && y <= 247)
            {
                this.X_MouseCord = x;
                this.Y_MouseCord = y;
            }
        }
        public override void InitPlayer(string Name)
        {
            this.PlayerName = Name;
            PlayerBorder.Height = 72;
            PlayerBorder.Width = 72;
            PlayerBorder.BorderBrush = Brushes.Black;
            PlayerBorder.BorderThickness = new Thickness(2);
            PlayerBorder.CornerRadius = new CornerRadius(100);
        }
        public override void MoveBat()
        {
            PlayerBorder.RenderTransform = new TranslateTransform { X = X_MouseCord, Y = Y_MouseCord };
        }
    }

    class Bot : AbstractPlayer
    {
        int X_RandCord = 0;
        int Y_RandCord = -250;
        public Border BotBorder = new Border();
        public void GetRandCord(ref int X, ref int Y)
        {
            Random rand = new Random();

        }
        public override void InitPlayer(string Name)
        {
            this.PlayerName = Name;
            BotBorder.Height = 72;
            BotBorder.Width = 72;
            BotBorder.BorderBrush = Brushes.Black;
            BotBorder.BorderThickness = new Thickness(2);
            BotBorder.CornerRadius = new CornerRadius(100);
        }
        public override void MoveBat()
        {
            BotBorder.RenderTransform = new TranslateTransform { X = X_RandCord, Y = Y_RandCord };
        }
    }

    public partial class MainWindow : Window
    {
        MousePlayer player1 = new MousePlayer();
        Bot bot = new Bot();
        HockeyPuck puck = new HockeyPuck();
        public MainWindow()
        {
            //new MenuWindow().ShowDialog();
            InitializeComponent();
            player1.InitPlayer("ppp");
            bot.InitPlayer("bbb");
            puck.InitPuck();
            Game.Children.Add(player1.PlayerBorder);
            Game.Children.Add(bot.BotBorder);
            Game.Children.Add(puck.PuckBorder);
        }

        private void MouseMoveClick(object sender, MouseEventArgs e)
        {
            int x = Convert.ToInt32(e.GetPosition(null).X) - 220;
            int y = Convert.ToInt32(e.GetPosition(null).Y) - 330;
            player1.SetMouseCord(x, y);
            player1.MoveBat();
            bot.MoveBat();
            this.cords.Content = $"x:{x}y:{y}";
        }
    }
}
