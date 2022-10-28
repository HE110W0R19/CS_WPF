using System;
using System.Text;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Class_Work_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool caps_on = true;
        int lvl_num = 2;
        string all_simbols = "QWER TYUI OPASDF GHJKL ZXCVB NMqwer ty uiopasd fghjklzx cvbnm~!@#$%^&* ()_+{}|:\"<>?`12 3456789 0-=[]\\;',./";
        public MainWindow()
        {
            InitializeComponent();
            key_change(caps_on);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void Grid_Key_Down(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.D0:
                    Zero_Click(zero, null);
                    break;
                case Key.D1:
                    One_Click(One, null);
                    break;
                case Key.D2:
                    Two_Click(Two, null);
                    break;
                case Key.D3:
                    Three_Click(Three, null);
                    break;
                case Key.D4:
                    Four_Click(four, null);
                    break;
                case Key.D5:
                    Five_Click(five, null);
                    break;
                case Key.D6:
                    Six_Click(six, null);
                    break;
                case Key.D7:
                    Seven_Click(seven, null);
                    break;
                case Key.D8:
                    Eight_Click(eight, null);
                    break;
                case Key.D9:
                    Nine_Click(nine, null);
                    break;
                case Key.Back:
                    BS_Click(BakcSpace, null);
                    break;
                case Key.Tab:
                    TAB_Click(TAB, null);
                    break;
                case Key.LineFeed:
                    break;
                case Key.Enter:
                    Enter_Click(Enter, null);
                    break;
                case Key.CapsLock:
                    CL_Click(CapsLock, null);
                    break;
                case Key.Space:
                    SPACE_Click(SPACE, null);
                    break;
                case Key.A:
                    A_Click(A, null);
                    break;
                case Key.B:
                    B_Click(B, null);
                    break;
                case Key.C:
                    C_Click(C, null);
                    break;
                case Key.D:
                    D_Click(D, null);
                    break;
                case Key.E:
                    E_Click(E, null);
                    break;
                case Key.F:
                    F_Click(F, null);
                    break;
                case Key.G:
                    G_Click(G, null);
                    break;
                case Key.H:
                    H_Click(H, null);
                    break;
                case Key.I:
                    I_Click(I, null);
                    break;
                case Key.J:
                    J_Click(J, null);
                    break;
                case Key.K:
                    K_Click(K, null);
                    break;
                case Key.L:
                    L_Click(L, null);
                    break;
                case Key.M:
                    M_Click(M, null);
                    break;
                case Key.N:
                    N_Click(N, null);
                    break;
                case Key.O:
                    O_Click(O, null);
                    break;
                case Key.P:
                    P_Click(P, null);
                    break;
                case Key.Q:
                    Q_Click(Q, null);
                    break;
                case Key.R:
                    R_Click(R, null);
                    break;
                case Key.S:
                    S_Click(S, null);
                    break;
                case Key.T:
                    T_Click(T, null);
                    break;
                case Key.U:
                    U_Click(U, null);
                    break;
                case Key.V:
                    V_Click(V, null);
                    break;
                case Key.W:
                    W_Click(W, null);
                    break;
                case Key.X:
                    X_Click(X, null);
                    break;
                case Key.Y:
                    Y_Click(Y, null);
                    break;
                case Key.Z:
                    Z_Click(Z, null);
                    break;
                case Key.LWin:
                    LWIN_Click(LWIN, null);
                    break;
                case Key.RWin:
                    RWin_Click(LWIN, null);
                    break;
                case Key.OemMinus:
                    Minus_Click(minus, null);
                    break;
                case Key.OemPlus:
                    Plus_Click(plus, null);
                    break;
                case Key.OemQuestion:
                    Question_Click(Question, null);
                    break;
                case Key.OemPipe:
                    Vslash_Click(Vslash, null);
                    break;
                case Key.Oem3:
                    UppCom_Click(UppComma, null);
                    break;
                case Key.Oem4:
                    Lparentheses_Click(Left_parentheses, null);
                    break;
                case Key.Oem6:
                    Rparentheses_Click(Right_parentheses, null);
                    break;
                case Key.Oem1:
                    DoubleDot_Click(doubleDot, null);
                    break;
                case Key.Oem7:
                    DoubleComma_Click(DoubleComma, null);
                    break;
                case Key.OemComma:
                    Comma_Click(comma, null);
                    break;
                case Key.OemPeriod:
                    Dot_Click(dot, null);
                    break;
                case Key.LeftShift:
                    LSHIFT_Click(LSHIFT, null);
                    break;
                case Key.RightShift:
                    RS_Click(RShift, null);
                    break;
                case Key.LeftCtrl:
                    LCTRL_Click(LCTRL, null);
                    break;
                case Key.RightCtrl:
                    RCTRL_Click(RCTRL, null);
                    break;
                case Key.LeftAlt:
                    LALT_Click(LALT, null);
                    break;
                case Key.RightAlt:
                    RALT_Click(RALT, null);
                    break;
                default:
                    break;
            }
        }

        private void key_anim(System.Windows.Controls.Button button_click)
        {
            TranslateTransform tran = new TranslateTransform();
            button_click.RenderTransform = tran;
            DoubleAnimation anim1 = new DoubleAnimation(0, 5, TimeSpan.FromSeconds(0.1));
            DoubleAnimation anim2 = new DoubleAnimation(5, 0, TimeSpan.FromSeconds(0.1));
            tran.BeginAnimation(TranslateTransform.YProperty, anim1);
            tran.BeginAnimation(TranslateTransform.YProperty, anim2);
        }

        private void Rand_text(int lvl_value)
        {
            var Rand = new Random();
            string ready_text = "";
            for (int i = 0; i < 70; ++i)
            {
                int r_num = Rand.Next(2, 46);
                ready_text += all_simbols[r_num+lvl_value];
            }
            ContentBlock.Text = ready_text;
        }

        private void key_change(bool stat)
        {
            switch (stat)
            {
                case true:
                    UppComma.Content = "~";
                    One.Content = "!";
                    Two.Content = "@";
                    Three.Content = "#";
                    four.Content = "$";
                    five.Content = "%";
                    six.Content = "^";
                    seven.Content = "&";
                    eight.Content = "*";
                    nine.Content = "(";
                    zero.Content = ")";
                    minus.Content = "_";
                    plus.Content = "+";
                    Left_parentheses.Content = "{";
                    Right_parentheses.Content = "}";
                    Vslash.Content = "|";
                    doubleDot.Content = ":";
                    DoubleComma.Content = "\"";
                    comma.Content = "<";
                    dot.Content = ">";
                    Question.Content = "?";
                    Q.Content = Q.Content.ToString().ToUpper();
                    W.Content = W.Content.ToString().ToUpper();
                    E.Content = E.Content.ToString().ToUpper();
                    R.Content = R.Content.ToString().ToUpper();
                    T.Content = T.Content.ToString().ToUpper();
                    Y.Content = Y.Content.ToString().ToUpper();
                    U.Content = U.Content.ToString().ToUpper();
                    I.Content = I.Content.ToString().ToUpper();
                    O.Content = O.Content.ToString().ToUpper();
                    P.Content = P.Content.ToString().ToUpper();
                    A.Content = A.Content.ToString().ToUpper();
                    S.Content = S.Content.ToString().ToUpper();
                    D.Content = D.Content.ToString().ToUpper();
                    F.Content = F.Content.ToString().ToUpper();
                    G.Content = G.Content.ToString().ToUpper();
                    H.Content = H.Content.ToString().ToUpper();
                    J.Content = J.Content.ToString().ToUpper();
                    K.Content = K.Content.ToString().ToUpper();
                    L.Content = L.Content.ToString().ToUpper();
                    Z.Content = Z.Content.ToString().ToUpper();
                    X.Content = X.Content.ToString().ToUpper();
                    C.Content = C.Content.ToString().ToUpper();
                    V.Content = V.Content.ToString().ToUpper();
                    B.Content = B.Content.ToString().ToUpper();
                    N.Content = N.Content.ToString().ToUpper();
                    M.Content = M.Content.ToString().ToUpper();
                    CapsLockBulb.Background = System.Windows.Media.Brushes.Red;
                    break;
                case false:
                    UppComma.Content = "`";
                    One.Content = "1";
                    Two.Content = "2";
                    Three.Content = "3";
                    four.Content = "4";
                    five.Content = "5";
                    six.Content = "6";
                    seven.Content = "7";
                    eight.Content = "8";
                    nine.Content = "9";
                    zero.Content = "0";
                    minus.Content = "-";
                    plus.Content = "=";
                    Left_parentheses.Content = "[";
                    Right_parentheses.Content = "]";
                    Vslash.Content = "\\";
                    doubleDot.Content = ";";
                    DoubleComma.Content = "\'";
                    comma.Content = ",";
                    dot.Content = ".";
                    Question.Content = "";
                    Q.Content = Q.Content.ToString().ToLower();
                    W.Content = W.Content.ToString().ToLower();
                    E.Content = E.Content.ToString().ToLower();
                    R.Content = R.Content.ToString().ToLower();
                    T.Content = T.Content.ToString().ToLower();
                    Y.Content = Y.Content.ToString().ToLower();
                    U.Content = U.Content.ToString().ToLower();
                    I.Content = I.Content.ToString().ToLower();
                    O.Content = O.Content.ToString().ToLower();
                    P.Content = P.Content.ToString().ToLower();
                    A.Content = A.Content.ToString().ToLower();
                    S.Content = S.Content.ToString().ToLower();
                    D.Content = D.Content.ToString().ToLower();
                    F.Content = F.Content.ToString().ToLower();
                    G.Content = G.Content.ToString().ToLower();
                    H.Content = H.Content.ToString().ToLower();
                    J.Content = J.Content.ToString().ToLower();
                    K.Content = K.Content.ToString().ToLower();
                    L.Content = L.Content.ToString().ToLower();
                    Z.Content = Z.Content.ToString().ToLower();
                    X.Content = X.Content.ToString().ToLower();
                    C.Content = C.Content.ToString().ToLower();
                    V.Content = V.Content.ToString().ToLower();
                    B.Content = B.Content.ToString().ToLower();
                    N.Content = N.Content.ToString().ToLower();
                    M.Content = M.Content.ToString().ToLower();
                    CapsLockBulb.Background = System.Windows.Media.Brushes.Silver;
                    break;
                default:
                    break;
            }
        }

        private void Q_Click(object sender, RoutedEventArgs e)
        {
            key_anim(Q);
            if (caps_on == true)
                this.WriteTextBlock.Text += "Q";
            else
                this.WriteTextBlock.Text += "q";
        }

        private void W_Click(object sender, RoutedEventArgs e)
        {
            key_anim(W);
            if (caps_on == true)
                this.WriteTextBlock.Text += "W";
            else
                this.WriteTextBlock.Text += "w";
        }

        private void E_Click(object sender, RoutedEventArgs e)
        {
            key_anim(E);
            if (caps_on == true)
                this.WriteTextBlock.Text += "E";
            else
                this.WriteTextBlock.Text += "e";
        }

        private void R_Click(object sender, RoutedEventArgs e)
        {
            key_anim(R);
            if (caps_on == true)
                this.WriteTextBlock.Text += "R";
            else
                this.WriteTextBlock.Text += "r";
        }

        private void T_Click(object sender, RoutedEventArgs e)
        {
            key_anim(T);
            if (caps_on == true)
                this.WriteTextBlock.Text += "T";
            else
                this.WriteTextBlock.Text += "t";
        }

        private void Y_Click(object sender, RoutedEventArgs e)
        {
            key_anim(Y);
            if (caps_on == true)
                this.WriteTextBlock.Text += "Y";
            else
                this.WriteTextBlock.Text += "y";
        }

        private void U_Click(object sender, RoutedEventArgs e)
        {
            key_anim(U);
            if (caps_on == true)
                this.WriteTextBlock.Text += "U";
            else
                this.WriteTextBlock.Text += "u";
        }

        private void I_Click(object sender, RoutedEventArgs e)
        {
            key_anim(I);
            if (caps_on == true)
                this.WriteTextBlock.Text += "I";
            else
                this.WriteTextBlock.Text += "i";
        }

        private void O_Click(object sender, RoutedEventArgs e)
        {
            key_anim(O);
            if (caps_on == true)
                this.WriteTextBlock.Text += "O";
            else
                this.WriteTextBlock.Text += "o";
        }

        private void P_Click(object sender, RoutedEventArgs e)
        {
            key_anim(P);
            if (caps_on == true)
                this.WriteTextBlock.Text += "P";
            else
                this.WriteTextBlock.Text += "p";
        }

        private void Lparentheses_Click(object sender, RoutedEventArgs e)
        {
            key_anim(Left_parentheses);
            if (caps_on == true)
                this.WriteTextBlock.Text += "{";
            else
                this.WriteTextBlock.Text += "[";
        }

        private void Rparentheses_Click(object sender, RoutedEventArgs e)
        {
            key_anim(Right_parentheses);
            if (caps_on == true)
                this.WriteTextBlock.Text += "}";
            else
                this.WriteTextBlock.Text += "]";
        }

        private void Vslash_Click(object sender, RoutedEventArgs e)
        {
            key_anim(Vslash);
            if (caps_on == true)
                this.WriteTextBlock.Text += "|";
            else
                this.WriteTextBlock.Text += @"\";
        }

        private void A_Click(object sender, RoutedEventArgs e)
        {
            key_anim(A);
            if (caps_on == true)
                this.WriteTextBlock.Text += "A";
            else
                this.WriteTextBlock.Text += "a";
        }

        private void S_Click(object sender, RoutedEventArgs e)
        {
            key_anim(S);
            if (caps_on == true)
                this.WriteTextBlock.Text += "S";
            else
                this.WriteTextBlock.Text += "s";
        }

        private void D_Click(object sender, RoutedEventArgs e)
        {
            key_anim(D);
            if (caps_on == true)
                this.WriteTextBlock.Text += "D";
            else
                this.WriteTextBlock.Text += "d";
        }

        private void F_Click(object sender, RoutedEventArgs e)
        {
            key_anim(F);
            if (caps_on == true)
                this.WriteTextBlock.Text += "F";
            else
                this.WriteTextBlock.Text += "f";
        }

        private void G_Click(object sender, RoutedEventArgs e)
        {
            key_anim(G);
            if (caps_on == true)
                this.WriteTextBlock.Text += "G";
            else
                this.WriteTextBlock.Text += "g";
        }

        private void H_Click(object sender, RoutedEventArgs e)
        {
            key_anim(H);
            if (caps_on == true)
                this.WriteTextBlock.Text += "H";
            else
                this.WriteTextBlock.Text += "h";
        }

        private void J_Click(object sender, RoutedEventArgs e)
        {
            key_anim(J);
            if (caps_on == true)
                this.WriteTextBlock.Text += "J";
            else
                this.WriteTextBlock.Text += "j";
        }

        private void K_Click(object sender, RoutedEventArgs e)
        {
            key_anim(K);
            if (caps_on == true)
                this.WriteTextBlock.Text += "K";
            else
                this.WriteTextBlock.Text += "k";
        }

        private void L_Click(object sender, RoutedEventArgs e)
        {
            key_anim(L);
            if (caps_on == true)
                this.WriteTextBlock.Text += "L";
            else
                this.WriteTextBlock.Text += "l";
        }

        private void DoubleDot_Click(object sender, RoutedEventArgs e)
        {
            key_anim(doubleDot);
            if (caps_on == true)
                this.WriteTextBlock.Text += ":";
            else
                this.WriteTextBlock.Text += ";";
        }

        private void DoubleComma_Click(object sender, RoutedEventArgs e)
        {
            key_anim(DoubleComma);
            if (caps_on == true)
                this.WriteTextBlock.Text += "\"";
            else
                this.WriteTextBlock.Text += "'";
        }

        private void Z_Click(object sender, RoutedEventArgs e)
        {
            key_anim(Z);
            if (caps_on == true)
                this.WriteTextBlock.Text += "Z";
            else
                this.WriteTextBlock.Text += "z";
        }

        private void X_Click(object sender, RoutedEventArgs e)
        {
            key_anim(X);
            if (caps_on == true)
                this.WriteTextBlock.Text += "X";
            else
                this.WriteTextBlock.Text += "x";
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            key_anim(C);
            if (caps_on == true)
                this.WriteTextBlock.Text += "C";
            else
                this.WriteTextBlock.Text += "c";
        }

        private void V_Click(object sender, RoutedEventArgs e)
        {
            key_anim(V);
            if (caps_on == true)
                this.WriteTextBlock.Text += "V";
            else
                this.WriteTextBlock.Text += "v";
        }

        private void B_Click(object sender, RoutedEventArgs e)
        {
            key_anim(B);
            if (caps_on == true)
                this.WriteTextBlock.Text += "B";
            else
                this.WriteTextBlock.Text += "b";
        }

        private void N_Click(object sender, RoutedEventArgs e)
        {
            key_anim(N);
            if (caps_on == true)
                this.WriteTextBlock.Text += "N";
            else
                this.WriteTextBlock.Text += "n";
        }

        private void M_Click(object sender, RoutedEventArgs e)
        {
            key_anim(M);
            if (caps_on == true)
                this.WriteTextBlock.Text += "M";
            else
                this.WriteTextBlock.Text += "m";
        }

        private void Comma_Click(object sender, RoutedEventArgs e)
        {
            key_anim(comma);
            if (caps_on == true)
                this.WriteTextBlock.Text += "<";
            else
                this.WriteTextBlock.Text += ",";
        }

        private void Dot_Click(object sender, RoutedEventArgs e)
        {
            key_anim(dot);
            if (caps_on == true)
                this.WriteTextBlock.Text += ">";
            else
                this.WriteTextBlock.Text += ".";
        }

        private void Question_Click(object sender, RoutedEventArgs e)
        {
            key_anim(Question);
            if (caps_on == true)
                this.WriteTextBlock.Text += "?";
            else
                this.WriteTextBlock.Text += "/";
        }

        private void BS_Click(object sender, RoutedEventArgs e)
        {
            key_anim(BakcSpace);
            if (this.WriteTextBlock.Text.Length != 0)
                this.WriteTextBlock.Text = this.WriteTextBlock.Text.Remove(WriteTextBlock.Text.Length - 1);
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            key_anim(Enter);
            this.WriteTextBlock.Text += "\n";
        }

        private void RS_Click(object sender, RoutedEventArgs e)
        {
            key_anim(RShift);
        }

        private void RCTRL_Click(object sender, RoutedEventArgs e)
        {
            key_anim(RCTRL);
        }

        private void RWin_Click(object sender, RoutedEventArgs e)
        {
            key_anim(RWin);
        }

        private void RALT_Click(object sender, RoutedEventArgs e)
        {
            key_anim(RALT);
        }

        private void SPACE_Click(object sender, RoutedEventArgs e)
        {
            key_anim(SPACE);
            this.WriteTextBlock.Text += " ";
        }

        private void LALT_Click(object sender, RoutedEventArgs e)
        {
            key_anim(LALT);
        }

        private void LWIN_Click(object sender, RoutedEventArgs e)
        {
            key_anim(LWIN);
        }

        private void LCTRL_Click(object sender, RoutedEventArgs e)
        {
            key_anim(LCTRL);
        }

        private void LSHIFT_Click(object sender, RoutedEventArgs e)
        {
            key_anim(LSHIFT);
        }

        private void CL_Click(object sender, RoutedEventArgs e)
        {
            key_anim(CapsLock);
            key_anim(CapsLockBulb);
            if (caps_on == true)
                caps_on = false;
            else if (caps_on == false)
                caps_on = true;
            key_change(caps_on);
        }

        private void TAB_Click(object sender, RoutedEventArgs e)
        {
            key_anim(TAB);
        }

        private void UppCom_Click(object sender, RoutedEventArgs e)
        {
            key_anim(UppComma);
            UppComma.Background = System.Windows.Media.Brushes.Red;
            if (caps_on == true)
                this.WriteTextBlock.Text += "~";
            else
                this.WriteTextBlock.Text += "`";
            UppComma.Background = System.Windows.Media.Brushes.Crimson;
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            key_anim(One);
            if (caps_on == true)
                this.WriteTextBlock.Text += "!";
            else
                this.WriteTextBlock.Text += "1";
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            key_anim(Two);
            if (caps_on == true)
                this.WriteTextBlock.Text += "@";
            else
                this.WriteTextBlock.Text += "2";
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            key_anim(Three);
            if (caps_on == true)
                this.WriteTextBlock.Text += "#";
            else
                this.WriteTextBlock.Text += "3";
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            key_anim(four);
            if (caps_on == true)
                this.WriteTextBlock.Text += "$";
            else
                this.WriteTextBlock.Text += "4";
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            key_anim(five);
            if (caps_on == true)
                this.WriteTextBlock.Text += "%";
            else
                this.WriteTextBlock.Text += "5";
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            key_anim(six);
            if (caps_on == true)
                this.WriteTextBlock.Text += "^";
            else
                this.WriteTextBlock.Text += "6";
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            key_anim(seven);
            if (caps_on == true)
                this.WriteTextBlock.Text += "&";
            else
                this.WriteTextBlock.Text += "7";
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            key_anim(eight);
            if (caps_on == true)
                this.WriteTextBlock.Text += "*";
            else
                this.WriteTextBlock.Text += "8";
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            key_anim(nine);
            if (caps_on == true)
                this.WriteTextBlock.Text += "(";
            else
                this.WriteTextBlock.Text += "9";
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            key_anim(zero);
            if (caps_on == true)
                this.WriteTextBlock.Text += ")";
            else
                this.WriteTextBlock.Text += "0";
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            key_anim(minus);
            if (caps_on == true)
                this.WriteTextBlock.Text += "_";
            else
                this.WriteTextBlock.Text += "-";
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            key_anim(plus);
            if (caps_on == true)
                this.WriteTextBlock.Text += "+";
            else
                this.WriteTextBlock.Text += "=";
        }

        private void start_button_Click(object sender, RoutedEventArgs e)
        {
            Rand_text(lvl_num);
        }

        private void difficutly_slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lvl_num = Convert.ToInt32(difficutly_slider.Value);
        }
    }
}
