using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.IO;
using System.Media;
using System.Windows.Controls;

namespace Akasztófa
{
    public class Osztaly
    {
        public static int szamlalo = 0;
        public static int Fuggveny()
        {
            if (szamlalo <= 10)
                szamlalo++;
            return szamlalo - 1;
        }
    }
    public partial class MainWindow : Window
    {
        public static int db = 0;
        public static int pontszam = 0;
        public static int sugopont = 0;
        Thickness aMargoSeged;
        Thickness bMargoSeged;
        Thickness cMargoSeged;
        Thickness dMargoSeged;
        Thickness eeMargoSeged;
        Thickness fMargoSeged;
        Thickness gMargoSeged;
        Thickness hMargoSeged;
        Thickness iiiMargoSeged;
        Thickness jjjMargoSeged;
        Thickness kMargoSeged;
        Thickness lMargoSeged;
        Thickness mMargoSeged;
        Thickness nMargoSeged;
        Thickness oMargoSeged;
        Thickness pMargoSeged;
        SoundPlayer player = new SoundPlayer(@"C:\hangman\forrásfájlok\click.wav");
        SoundPlayer player2 = new SoundPlayer(@"C:\hangman\forrásfájlok\Old victory sound roblox.wav");
        SoundPlayer player3 = new SoundPlayer(@"C:\hangman\forrásfájlok\Sad Trombone - Gaming Sound Effect (HD).wav");
        SoundPlayer player4 = new SoundPlayer(@"C:\hangman\forrásfájlok\African Safari Loop.wav");
        public string beVanEJelentkezve = "";
        public string beolvasottNev = "";
        private void Beolvas()
        {
            string text = " ";
            StreamReader olvas = new StreamReader(@"C:\hangman\forrásfájlok\szavak.txt");
            while (!olvas.EndOfStream)
            {
                text = olvas.ReadLine();
                if (text.Length <= 16)
                {
                    lista.Add(text.ToUpper());
                    db++;
                }
            }
            ran = r.Next(0, db);
            olvas.Close();

            StreamReader olvasBejelentkez = new StreamReader(@"C:\hangman\forrásfájlok\bejelentkezveMarad.txt");
            beVanEJelentkezve = olvasBejelentkez.ReadLine();
            beolvasottNev = olvasBejelentkez.ReadLine();
            if (beVanEJelentkezve == "bejelentkezve")
            {
                ujf.Content = "ÚJ JÁTÉK";
                felhasznalonevIras.Height = 0;
                felhasznalonev.Height = 0;
                jelszo.Height = 0;
                jelszoIras.Height = 0;
                regisztracio.Height = 0;
                bejelentkezveMarad.Height = 0;
                bejelentkezveMaradIras.Height = 0;
            }
            olvasBejelentkez.Close();
        }
        private void Fug()
        {
            int i = 0;
            int[] betuinc = new int[16];

            a.Text = " ";
            b.Text = " ";
            c.Text = " ";
            d.Text = " ";
            ee.Text = " ";
            f.Text = " ";
            g.Text = " ";
            h.Text = " ";
            iii.Text = " ";
            jjj.Text = " ";
            k.Text = " ";
            l.Text = " ";
            m.Text = " ";
            n.Text = " ";
            o.Text = " ";
            p.Text = " ";
            foreach (char item in lista[ran])
            {
                if (i == 0) { a.Text = "_"; betuinc[0]++; }
                if (betuinc[0] == 0) a.Text = " ";
                if (i == 1) { b.Text = "_"; betuinc[1]++; }
                if (betuinc[1] == 0) b.Text = " ";
                if (i == 2) { c.Text = "_"; betuinc[2]++; }
                if (betuinc[2] == 0) c.Text = " ";
                if (i == 3) { d.Text = "_"; betuinc[3]++; }
                if (betuinc[3] == 0) d.Text = " ";
                if (i == 4) { ee.Text = "_"; betuinc[4]++; }
                if (betuinc[4] == 0) ee.Text = " ";
                if (i == 5) { f.Text = "_"; betuinc[5]++; }
                if (betuinc[5] == 0) f.Text = " ";
                if (i == 6) { g.Text = "_"; betuinc[6]++; }
                if (betuinc[6] == 0) g.Text = " ";
                if (i == 7) { h.Text = "_"; betuinc[7]++; }
                if (betuinc[7] == 0) h.Text = " ";
                if (i == 8) { iii.Text = "_"; betuinc[8]++; }
                if (betuinc[8] == 0) iii.Text = " ";
                if (i == 9) { jjj.Text = "_"; betuinc[9]++; }
                if (betuinc[9] == 0) jjj.Text = " ";
                if (i == 10) { k.Text = "_"; betuinc[10]++; }
                if (betuinc[10] == 0) k.Text = " ";
                if (i == 11) { l.Text = "_"; betuinc[11]++; }
                if (betuinc[11] == 0) l.Text = " ";
                if (i == 12) { m.Text = "_"; betuinc[12]++; }
                if (betuinc[12] == 0) m.Text = " ";
                if (i == 13) { n.Text = "_"; betuinc[13]++; }
                if (betuinc[13] == 0) n.Text = " ";
                if (i == 14) { o.Text = "_"; betuinc[14]++; }
                if (betuinc[14] == 0) o.Text = " ";
                if (i == 15) { p.Text = "_"; betuinc[15]++; }
                if (betuinc[15] == 0) p.Text = " ";
                i++;
            }
            KozepreRendez();
        }
        public void KozepreRendez()
        {
            a.Margin = aMargoSeged;
            b.Margin = bMargoSeged;
            c.Margin = cMargoSeged;
            d.Margin = dMargoSeged;
            ee.Margin = eeMargoSeged;
            f.Margin = fMargoSeged;
            g.Margin = gMargoSeged;
            h.Margin = hMargoSeged;
            iii.Margin = iiiMargoSeged;
            jjj.Margin = jjjMargoSeged;
            k.Margin = kMargoSeged;
            l.Margin = lMargoSeged;
            m.Margin = mMargoSeged;
            n.Margin = nMargoSeged;
            o.Margin = oMargoSeged;
            p.Margin = pMargoSeged;

            if (lista[ran].Length == 3)
            {
                a.Margin = h.Margin;
                b.Margin = iii.Margin;
                c.Margin = jjj.Margin;
            }
            if (lista[ran].Length == 4)
            {
                a.Margin = g.Margin;
                b.Margin = h.Margin;
                c.Margin = iii.Margin;
                d.Margin = jjj.Margin;
            }
            if (lista[ran].Length == 5)
            {
                a.Margin = f.Margin;
                b.Margin = g.Margin;
                c.Margin = h.Margin;
                d.Margin = iii.Margin;
                ee.Margin = jjj.Margin;
            }
            if (lista[ran].Length == 6)
            {
                a.Margin = f.Margin;
                b.Margin = g.Margin;
                c.Margin = h.Margin;
                d.Margin = iii.Margin;
                ee.Margin = jjj.Margin;
                f.Margin = k.Margin;
            }
            if (lista[ran].Length == 7)
            {
                a.Margin = f.Margin;
                b.Margin = g.Margin;
                c.Margin = h.Margin;
                d.Margin = iii.Margin;
                ee.Margin = jjj.Margin;
                f.Margin = k.Margin;
                g.Margin = l.Margin;
            }
            if (lista[ran].Length == 8)
            {
                a.Margin = ee.Margin;
                b.Margin = f.Margin;
                c.Margin = g.Margin;
                d.Margin = h.Margin;
                ee.Margin = iii.Margin;
                f.Margin = jjj.Margin;
                g.Margin = k.Margin;
                h.Margin = l.Margin;
            }
            if (lista[ran].Length == 9)
            {
                a.Margin = d.Margin;
                b.Margin = ee.Margin;
                c.Margin = f.Margin;
                d.Margin = g.Margin;
                ee.Margin = h.Margin;
                f.Margin = iii.Margin;
                g.Margin = jjj.Margin;
                h.Margin = k.Margin;
                iii.Margin = l.Margin;
            }
            if (lista[ran].Length == 10)
            {
                a.Margin = d.Margin;
                b.Margin = ee.Margin;
                c.Margin = f.Margin;
                d.Margin = g.Margin;
                ee.Margin = h.Margin;
                f.Margin = iii.Margin;
                g.Margin = jjj.Margin;
                h.Margin = k.Margin;
                iii.Margin = l.Margin;
                jjj.Margin = m.Margin;
            }
            if (lista[ran].Length == 11)
            {
                a.Margin = c.Margin;
                b.Margin = d.Margin;
                c.Margin = ee.Margin;
                d.Margin = f.Margin;
                ee.Margin = g.Margin;
                f.Margin = h.Margin;
                g.Margin = iii.Margin;
                h.Margin = jjj.Margin;
                iii.Margin = k.Margin;
                jjj.Margin = l.Margin;
                k.Margin = m.Margin;
            }
            if (lista[ran].Length == 12)
            {
                a.Margin = c.Margin;
                b.Margin = d.Margin;
                c.Margin = ee.Margin;
                d.Margin = f.Margin;
                ee.Margin = g.Margin;
                f.Margin = h.Margin;
                g.Margin = iii.Margin;
                h.Margin = jjj.Margin;
                iii.Margin = k.Margin;
                jjj.Margin = l.Margin;
                k.Margin = m.Margin;
                l.Margin = n.Margin;
            }
            if (lista[ran].Length == 13)
            {
                a.Margin = b.Margin;
                b.Margin = c.Margin;
                c.Margin = d.Margin;
                d.Margin = ee.Margin;
                ee.Margin = f.Margin;
                f.Margin = g.Margin;
                g.Margin = h.Margin;
                h.Margin = iii.Margin;
                iii.Margin = jjj.Margin;
                jjj.Margin = k.Margin;
                k.Margin = l.Margin;
                l.Margin = m.Margin;
                m.Margin = n.Margin;
            }
            if (lista[ran].Length == 14)
            {
                a.Margin = b.Margin;
                b.Margin = c.Margin;
                c.Margin = d.Margin;
                d.Margin = ee.Margin;
                ee.Margin = f.Margin;
                f.Margin = g.Margin;
                g.Margin = h.Margin;
                h.Margin = iii.Margin;
                iii.Margin = jjj.Margin;
                jjj.Margin = k.Margin;
                k.Margin = l.Margin;
                l.Margin = m.Margin;
                m.Margin = n.Margin;
                n.Margin = o.Margin;
            }
            if (lista[ran].Length == 15)
            {
                a.Margin = b.Margin;
                b.Margin = c.Margin;
                c.Margin = d.Margin;
                d.Margin = ee.Margin;
                ee.Margin = f.Margin;
                f.Margin = g.Margin;
                g.Margin = h.Margin;
                h.Margin = iii.Margin;
                iii.Margin = jjj.Margin;
                jjj.Margin = k.Margin;
                k.Margin = l.Margin;
                l.Margin = m.Margin;
                m.Margin = n.Margin;
                n.Margin = o.Margin;
                o.Margin = p.Margin;
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            aMargoSeged = a.Margin;
            bMargoSeged = b.Margin;
            cMargoSeged = c.Margin;
            dMargoSeged = d.Margin;
            eeMargoSeged = ee.Margin;
            fMargoSeged = f.Margin;
            gMargoSeged = g.Margin;
            hMargoSeged = h.Margin;
            iiiMargoSeged = iii.Margin;
            jjjMargoSeged = jjj.Margin;
            kMargoSeged = k.Margin;
            lMargoSeged = l.Margin;
            mMargoSeged = m.Margin;
            nMargoSeged = n.Margin;
            oMargoSeged = o.Margin;
            pMargoSeged = p.Margin;
            Beolvas();
            Fug();
            KozepreRendez();
            player4.Play();
            textbox.Focus();
        }
        public static List<string> lista = new List<string>();
        public static Random r = new Random();
        public static int ran;
        public int szamlal = 0;
        private void Gomb_Click(object sender, RoutedEventArgs e)
        {
            int continueabble = 0;
            string becenev2 = "";
            if (beVanEJelentkezve == "nincs bejelentkezve")
            {
                continueabble = 0;
                StreamReader olvas = new StreamReader(@"C:\hangman\forrásfájlok\bejelentkezes.txt");
                while (!olvas.EndOfStream)
                {
                    string felh = olvas.ReadLine();
                    string jelsz = olvas.ReadLine();
                    becenev2 = olvas.ReadLine();
                    olvas.ReadLine();
                    if (felh == felhasznalonev.Text && jelsz == jelszo.Password)
                    {
                        nev.Text = becenev2;
                        continueabble = 1;
                    }
                }
                olvas.Close();
                if (continueabble == 0)
                {
                    MessageBox.Show("A felhasználónév vagy a jelszó helytelen!");
                    felhasznalonev.Text = "";
                    jelszo.Password = "";
                }
                if (continueabble == 1)
                {
                    StreamReader olvas2 = new StreamReader(@"C:\hangman\felhasználók\" + nev.Text + ".txt");
                    pontszam = Convert.ToInt32(olvas2.ReadLine());
                    sugopont = Convert.ToInt32(olvas2.ReadLine());
                    olvas2.Close();
                }
            }
            if (bejelentkezveMarad.IsChecked == true)
            {
                StreamWriter iras = new StreamWriter(@"C:\hangman\forrásfájlok\bejelentkezveMarad.txt");
                iras.WriteLine("bejelentkezve");
                iras.WriteLine(nev.Text);
                iras.Flush();
                iras.Close();
            }
            if (continueabble == 1 || beVanEJelentkezve == "bejelentkezve")
            {

                if (beVanEJelentkezve == "bejelentkezve")
                {
                    nev.Text = beolvasottNev;
                    StreamReader olvas2 = new StreamReader(@"C:\hangman\felhasználók\" + nev.Text + ".txt");
                    pontszam = Convert.ToInt32(olvas2.ReadLine());
                    sugopont = Convert.ToInt32(olvas2.ReadLine());
                    olvas2.Close();
                }
                bejelentkezveMaradIras.Height = 0;
                bejelentkezveMarad.Height = 0;
                felhasznalonevIras.Height = 0;
                felhasznalonev.Height = 0;
                jelszoIras.Height = 0;
                jelszo.Height = 0;
                regisztracio.Height = 0;
                sugopontdarab.Content = sugopont;
                korte.Height = 53;
                sugopontdarab.Height = 40;
                korte2.Height = 53;
                pont.Text = pontszam + " p";
                KozepreRendez();
                player4.Play();
                panel.Height = 0;
                box.Height = 40;
                plus.Height = 40;
                vasarlas.Height = 50;
                hangman.Height = 0;
                ujf.Height = 0;
                play.Height = 50;
                fooldal.Height = 50;
                player.Play();
                ran = r.Next(0, db);
                aa = 0;
                áá = 0;
                bb = 0;
                cc = 0;
                dd = 0;
                eee = 0;
                éé = 0;
                ff = 0;
                gg = 0;
                hh = 0;
                ii = 0;
                íí = 0;
                jj = 0;
                kk = 0;
                ll = 0;
                mm = 0;
                nn = 0;
                oo = 0;
                óó = 0;
                öö = 0;
                őő = 0;
                pp = 0;
                qq = 0;
                rr = 0;
                ss = 0;
                tt = 0;
                uu = 0;
                úú = 0;
                üü = 0;
                űű = 0;
                vv = 0;
                ww = 0;
                xx = 0;
                yy = 0;
                zz = 0;
                Fug();
                Osztaly.szamlalo = 0;
                BitmapImage myBitmapImage = new BitmapImage();
                myBitmapImage.BeginInit();
                myBitmapImage.UriSource = new Uri(@"C:\hangman\forrásfájlok\sorozat.jpg");
                kep.Source = myBitmapImage;
                myBitmapImage.EndInit();
                A.IsEnabled = true;
                Á.IsEnabled = true;
                B.IsEnabled = true;
                C.IsEnabled = true;
                D.IsEnabled = true;
                E.IsEnabled = true;
                É.IsEnabled = true;
                F.IsEnabled = true;
                Gé.IsEnabled = true;
                H.IsEnabled = true;
                I.IsEnabled = true;
                Í.IsEnabled = true;
                J.IsEnabled = true;
                Ká.IsEnabled = true;
                L.IsEnabled = true;
                M.IsEnabled = true;
                N.IsEnabled = true;
                O.IsEnabled = true;
                Ó.IsEnabled = true;
                Ö.IsEnabled = true;
                Ő.IsEnabled = true;
                P.IsEnabled = true;
                Q.IsEnabled = true;
                R.IsEnabled = true;
                S.IsEnabled = true;
                T.IsEnabled = true;
                U.IsEnabled = true;
                Ú.IsEnabled = true;
                Ü.IsEnabled = true;
                Ű.IsEnabled = true;
                V.IsEnabled = true;
                W.IsEnabled = true;
                X.IsEnabled = true;
                Y.IsEnabled = true;
                Z.IsEnabled = true;
                A.Foreground = Brushes.White;
                Á.Foreground = Brushes.White;
                B.Foreground = Brushes.White;
                C.Foreground = Brushes.White;
                D.Foreground = Brushes.White;
                E.Foreground = Brushes.White;
                É.Foreground = Brushes.White;
                F.Foreground = Brushes.White;
                Gé.Foreground = Brushes.White;
                H.Foreground = Brushes.White;
                I.Foreground = Brushes.White;
                Í.Foreground = Brushes.White;
                J.Foreground = Brushes.White;
                Ká.Foreground = Brushes.White;
                L.Foreground = Brushes.White;
                M.Foreground = Brushes.White;
                N.Foreground = Brushes.White;
                O.Foreground = Brushes.White;
                Ó.Foreground = Brushes.White;
                Ö.Foreground = Brushes.White;
                Ő.Foreground = Brushes.White;
                P.Foreground = Brushes.White;
                Q.Foreground = Brushes.White;
                R.Foreground = Brushes.White;
                S.Foreground = Brushes.White;
                T.Foreground = Brushes.White;
                U.Foreground = Brushes.White;
                Ú.Foreground = Brushes.White;
                Ü.Foreground = Brushes.White;
                Ű.Foreground = Brushes.White;
                V.Foreground = Brushes.White;
                W.Foreground = Brushes.White;
                X.Foreground = Brushes.White;
                Y.Foreground = Brushes.White;
                Z.Foreground = Brushes.White;
                if (box.Text != "")
                {
                    box.Text = "";
                    box.Text = string.Empty;
                }
                textbox.Focus();
            }
        }
        private void Gomb_Click2(object sender, RoutedEventArgs e)
        {
            KozepreRendez();
            korte2.Height = 53;
            player4.Stop();
            panel.Height = 0;
            box.Height = 40;
            plus.Height = 40;
            hangman.Height = 0;
            ujf.Height = 0;
            play.Height = 50;
            fooldal.Height = 50;
            player.Play();
            ran = r.Next(0, db);
            aa = 0;
            áá = 0;
            bb = 0;
            cc = 0;
            dd = 0;
            eee = 0;
            éé = 0;
            ff = 0;
            gg = 0;
            hh = 0;
            ii = 0;
            íí = 0;
            jj = 0;
            kk = 0;
            ll = 0;
            mm = 0;
            nn = 0;
            oo = 0;
            óó = 0;
            öö = 0;
            őő = 0;
            pp = 0;
            qq = 0;
            rr = 0;
            ss = 0;
            tt = 0;
            uu = 0;
            úú = 0;
            üü = 0;
            űű = 0;
            vv = 0;
            ww = 0;
            xx = 0;
            yy = 0;
            zz = 0;
            Fug();
            Osztaly.szamlalo = 0;
            BitmapImage myBitmapImage = new BitmapImage();
            myBitmapImage.BeginInit();
            myBitmapImage.UriSource = new Uri(@"C:\hangman\forrásfájlok\sorozat.jpg");
            kep.Source = myBitmapImage;
            myBitmapImage.EndInit();
            A.IsEnabled = true;
            Á.IsEnabled = true;
            B.IsEnabled = true;
            C.IsEnabled = true;
            D.IsEnabled = true;
            E.IsEnabled = true;
            É.IsEnabled = true;
            F.IsEnabled = true;
            Gé.IsEnabled = true;
            H.IsEnabled = true;
            I.IsEnabled = true;
            Í.IsEnabled = true;
            J.IsEnabled = true;
            Ká.IsEnabled = true;
            L.IsEnabled = true;
            M.IsEnabled = true;
            N.IsEnabled = true;
            O.IsEnabled = true;
            Ó.IsEnabled = true;
            Ö.IsEnabled = true;
            Ő.IsEnabled = true;
            P.IsEnabled = true;
            Q.IsEnabled = true;
            R.IsEnabled = true;
            S.IsEnabled = true;
            T.IsEnabled = true;
            U.IsEnabled = true;
            Ú.IsEnabled = true;
            Ü.IsEnabled = true;
            Ű.IsEnabled = true;
            V.IsEnabled = true;
            W.IsEnabled = true;
            X.IsEnabled = true;
            Y.IsEnabled = true;
            Z.IsEnabled = true;
            A.Foreground = Brushes.White;
            Á.Foreground = Brushes.White;
            B.Foreground = Brushes.White;
            C.Foreground = Brushes.White;
            D.Foreground = Brushes.White;
            E.Foreground = Brushes.White;
            É.Foreground = Brushes.White;
            F.Foreground = Brushes.White;
            Gé.Foreground = Brushes.White;
            H.Foreground = Brushes.White;
            I.Foreground = Brushes.White;
            Í.Foreground = Brushes.White;
            J.Foreground = Brushes.White;
            Ká.Foreground = Brushes.White;
            L.Foreground = Brushes.White;
            M.Foreground = Brushes.White;
            N.Foreground = Brushes.White;
            O.Foreground = Brushes.White;
            Ó.Foreground = Brushes.White;
            Ö.Foreground = Brushes.White;
            Ő.Foreground = Brushes.White;
            P.Foreground = Brushes.White;
            Q.Foreground = Brushes.White;
            R.Foreground = Brushes.White;
            S.Foreground = Brushes.White;
            T.Foreground = Brushes.White;
            U.Foreground = Brushes.White;
            Ú.Foreground = Brushes.White;
            Ü.Foreground = Brushes.White;
            Ű.Foreground = Brushes.White;
            V.Foreground = Brushes.White;
            W.Foreground = Brushes.White;
            X.Foreground = Brushes.White;
            Y.Foreground = Brushes.White;
            Z.Foreground = Brushes.White;
            if (box.Text != "")
            {
                box.Text = "";
                box.Text = string.Empty;
            }
            textbox.Focus();
        }
        public int marErtesitett = 0;
        public int megTart = 0;
        public void FoFuggveny(string s)
        {
            int x = 0;
            megTart = 0;
            if (!(a.Text != "_" && b.Text != "_" && c.Text != "_" && d.Text != "_" && ee.Text != "_" && f.Text != "_" && g.Text != "_" && h.Text != "_" && iii.Text != "_" && jjj.Text != "_" && k.Text != "_" && l.Text != "_" && m.Text != "_" && n.Text != "_" && o.Text != "_" && p.Text != "_" && x < 11) && (!(a.Text != "_" && b.Text != "_" && c.Text != "_" && d.Text != "_" && ee.Text != "_" && f.Text != "_" && g.Text != "_" && h.Text != "_" && iii.Text != "_" && jjj.Text != "_" && k.Text != "_" && l.Text != "_" && m.Text != "_" && n.Text != "_" && o.Text != "_" && p.Text != "_" && x == 11)))
            {
                megTart = 1;
                player.Play();
                int i = 0;
                int y = 0;
                foreach (char item in lista[ran])
                {
                    if (item == Convert.ToChar(s))
                    {
                        if (i == 0) a.Text = s;
                        if (i == 1) b.Text = s;
                        if (i == 2) c.Text = s;
                        if (i == 3) d.Text = s;
                        if (i == 4) ee.Text = s;
                        if (i == 5) f.Text = s;
                        if (i == 6) g.Text = s;
                        if (i == 7) h.Text = s;
                        if (i == 8) iii.Text = s;
                        if (i == 9) jjj.Text = s;
                        if (i == 10) k.Text = s;
                        if (i == 11) l.Text = s;
                        if (i == 12) m.Text = s;
                        if (i == 13) n.Text = s;
                        if (i == 14) o.Text = s;
                        if (i == 15) p.Text = s;
                        pontszam++;
                        pont.Text = pontszam + " p";
                        y++;
                    }
                    i++;
                }

                if (y == 0)
                {
                    BitmapImage myBitmapImage = new BitmapImage();
                    myBitmapImage.BeginInit();
                    myBitmapImage.UriSource = new Uri(@"C:\hangman\forrásfájlok\sorozat" + Osztaly.Fuggveny() + ".jpg");
                    kep.Source = myBitmapImage;
                    x = Osztaly.szamlalo;
                    myBitmapImage.EndInit();
                }
                int j = 0;
                //súgópont (villanykörte) világít, mikor a pálcikaembernek már csak egy lába hiányzik
                if (x == 10 && sugopont > 0)
                {
                    korte2.Height = 0;

                }
                //a szó megoldása (felakasztást követően)
                if (x == 11)
                {
                    foreach (char item in lista[ran])
                    {
                        if (j == 0) a.Text = item.ToString();
                        if (j == 1) b.Text = item.ToString();
                        if (j == 2) c.Text = item.ToString();
                        if (j == 3) d.Text = item.ToString();
                        if (j == 4) ee.Text = item.ToString();
                        if (j == 5) f.Text = item.ToString();
                        if (j == 6) g.Text = item.ToString();
                        if (j == 7) h.Text = item.ToString();
                        if (j == 8) iii.Text = item.ToString();
                        if (j == 9) jjj.Text = item.ToString();
                        if (j == 10) k.Text = item.ToString();
                        if (j == 11) l.Text = item.ToString();
                        if (j == 12) m.Text = item.ToString();
                        if (j == 13) n.Text = item.ToString();
                        if (j == 14) o.Text = item.ToString();
                        if (j == 15) p.Text = item.ToString();
                        j++;
                    }
                }
                if (a.Text != "_" && b.Text != "_" && c.Text != "_" && d.Text != "_" && ee.Text != "_" && f.Text != "_" && g.Text != "_" && h.Text != "_" && iii.Text != "_" && jjj.Text != "_" && k.Text != "_" && l.Text != "_" && m.Text != "_" && n.Text != "_" && o.Text != "_" && p.Text != "_" && x < 11)
                {
                    player2.Play();
                    pontszam += 9;
                    pont.Text = pontszam + " p";
                    gif.Height = 700;
                    MessageBox.Show("Gratulálok, kitaláltad!", "Üzenet");
                    gif.Height = 0;
                }
                if (a.Text != "_" && b.Text != "_" && c.Text != "_" && d.Text != "_" && ee.Text != "_" && f.Text != "_" && g.Text != "_" && h.Text != "_" && iii.Text != "_" && jjj.Text != "_" && k.Text != "_" && l.Text != "_" && m.Text != "_" && n.Text != "_" && o.Text != "_" && p.Text != "_" && x == 11)
                {
                    player3.Play();
                    MessageBox.Show("Sajnálom, próbáld meg újra!", "Üzenet");
                }
                textbox.Focus();
                deleteBorders();
            }
        }
        int aa = 0; int áá = 0; int bb = 0; int cc = 0; int dd = 0; int eee = 0; int éé = 0; int ff = 0; int gg = 0; int hh = 0; int ii = 0; int íí = 0; int jj = 0; int kk = 0; int ll = 0; int mm = 0; int nn = 0; int oo = 0; int óó = 0; int öö = 0; int őő = 0; int pp = 0; int qq = 0; int rr = 0; int ss = 0; int tt = 0; int uu = 0; int úú = 0; int üü = 0; int űű = 0; int vv = 0; int ww = 0; int xx = 0; int yy = 0; int zz = 0;
        private void A_Click(object sender, RoutedEventArgs e)
        {
            string s = "A";
            if (aa == 0)
                FoFuggveny(s);
            if (megTart == 1)
            {
                A.IsEnabled = false;
                A.Foreground = Brushes.Green;
            }
            aa++;
        }
        private void Á_Click(object sender, RoutedEventArgs e)
        {
            string s = "Á";
            if (áá == 0)
                FoFuggveny(s);
            if (megTart == 1)
            {
                Á.Foreground = Brushes.Green;
                Á.IsEnabled = false;
            }
            áá++;
        }
        private void B_Click(object sender, RoutedEventArgs e)
        {
            string s = "B";
            if (bb == 0)
                FoFuggveny(s);
            if (megTart == 1)
            {
                B.Foreground = Brushes.Green;
                B.IsEnabled = false;
            }
            bb++;
        }
        private void C_Click(object sender, RoutedEventArgs e)
        {
            string s = "C";
            if (cc == 0)
                FoFuggveny(s);
            if (megTart == 1)
            {
                C.Foreground = Brushes.Green;
                C.IsEnabled = false;
            }
            cc++;
        }
        private void D_Click(object sender, RoutedEventArgs e)
        {
            string s = "D";
            if (dd == 0)
                FoFuggveny(s);
            if (megTart == 1)
            {
                D.Foreground = Brushes.Green;
                D.IsEnabled = false;
            }
            dd++;
        }
        private void E_Click(object sender, RoutedEventArgs e)
        {
            string s = "E";
            if (eee == 0)
                FoFuggveny(s);
            if (megTart == 1)
            {
                E.Foreground = Brushes.Green;
                E.IsEnabled = false;
            }
            eee++;
        }
        private void É_Click(object sender, RoutedEventArgs e)
        {
            string s = "É";
            if (éé == 0)
                FoFuggveny(s);
            if (megTart == 1)
            {
                É.Foreground = Brushes.Green;
                É.IsEnabled = false;
            }
            éé++;
        }
        private void F_Click(object sender, RoutedEventArgs e)
        {
            string s = "F";
            if (ff == 0)
                FoFuggveny(s);
            if (megTart == 1)
            {
                F.Foreground = Brushes.Green;
                F.IsEnabled = false;
            }
            ff++;
        }
        private void Gé_Click(object sender, RoutedEventArgs e)
        {
            string s = "G";
            if (gg == 0)
                FoFuggveny(s);
            if (megTart == 1)
            {
                Gé.Foreground = Brushes.Green;
                Gé.IsEnabled = false;
            }
            gg++;
        }
        private void H_Click(object sender, RoutedEventArgs e)
        {
            string s = "H";
            if (hh == 0)
                FoFuggveny(s);
            if (megTart == 1)
            {
                H.Foreground = Brushes.Green;
                H.IsEnabled = false;
            }
            hh++;
        }
        private void I_Click(object sender, RoutedEventArgs e)
        {
            string s = "I";
            if (ii == 0)
                FoFuggveny(s);
            if (megTart == 1)
            {
                I.Foreground = Brushes.Green;
                I.IsEnabled = false;
            }
            ii++;
        }
        private void Í_Click(object sender, RoutedEventArgs e)
        {
            string s = "Í";
            if (íí == 0)
                FoFuggveny(s);
            if (megTart == 1)
            {
                Í.Foreground = Brushes.Green;
                Í.IsEnabled = false;
            }
            íí++;
        }
        private void J_Click(object sender, RoutedEventArgs e)
        {
            string s = "J";
            if (jj == 0)
                FoFuggveny(s);
            if (megTart == 1)
            {
                J.Foreground = Brushes.Green;
                J.IsEnabled = false;
            }
            jj++;
        }
        private void Ká_Click(object sender, RoutedEventArgs e)
        {
            string s = "K";
            if (kk == 0)
                FoFuggveny(s);
            if (megTart == 1)
            {
                Ká.Foreground = Brushes.Green;
                Ká.IsEnabled = false;
            }
            kk++;
        }
        private void L_Click(object sender, RoutedEventArgs e)
        {
            string s = "L";
            if (ll == 0)
                FoFuggveny(s);
            if (megTart == 1)
            {
                L.Foreground = Brushes.Green;
                L.IsEnabled = false;
            }
            ll++;
        }
        private void M_Click(object sender, RoutedEventArgs e)
        {
            string s = "M";
            if (mm == 0)
                FoFuggveny(s);
            if (megTart == 1)
            {
                M.Foreground = Brushes.Green;
                M.IsEnabled = false;
            }
            mm++;
        }
        private void N_Click(object sender, RoutedEventArgs e)
        {
            string s = "N";
            if (nn == 0)
                FoFuggveny(s);
            if (megTart == 1)
            {
                N.Foreground = Brushes.Green;
                N.IsEnabled = false;
            }
            nn++;
        }
        private void O_Click(object sender, RoutedEventArgs e)
        {
            string s = "O";
            if (oo == 0)
                FoFuggveny(s);
            if (megTart == 1)
            {
                O.Foreground = Brushes.Green;
                O.IsEnabled = false;
            }
            oo++;
        }
        private void Ó_Click(object sender, RoutedEventArgs e)
        {
            string s = "Ó";

            if (óó == 0)
                FoFuggveny(s);
            if (megTart == 1)
            {
                Ó.Foreground = Brushes.Green;
                Ó.IsEnabled = false;
            }
            óó++;
        }
        private void Ö_Click(object sender, RoutedEventArgs e)
        {
            string s = "Ö";
            if (öö == 0)
                FoFuggveny(s);
            if (megTart == 1)
            {
                Ö.Foreground = Brushes.Green;
                Ö.IsEnabled = false;
            }
            öö++;
        }
        private void Ő_Click(object sender, RoutedEventArgs e)
        {
            string s = "Ő";

            if (őő == 0)
                FoFuggveny(s);
            if (megTart == 1)
            {
                Ő.Foreground = Brushes.Green;
                Ő.IsEnabled = false;
            }
            őő++;
        }
        private void P_Click(object sender, RoutedEventArgs e)
        {
            string s = "P";
            if (pp == 0)
                FoFuggveny(s);
            if (megTart == 1)
            {
                P.Foreground = Brushes.Green;
                P.IsEnabled = false;
            }
            pp++;
        }
        private void Q_Click(object sender, RoutedEventArgs e)
        {
            string s = "Q";
            if (qq == 0)
                FoFuggveny(s);
            if (megTart == 1)
            {
                Q.Foreground = Brushes.Green;
                Q.IsEnabled = false;
            }
            qq++;
        }
        private void R_Click(object sender, RoutedEventArgs e)
        {
            string s = "R";
            if (rr == 0)
                FoFuggveny(s);
            if (megTart == 1)
            {
                R.Foreground = Brushes.Green;
                R.IsEnabled = false;
            }
            rr++;
        }
        private void S_Click(object sender, RoutedEventArgs e)
        {
            string s = "S";
            if (ss == 0)
                FoFuggveny(s);
            if (megTart == 1)
            {
                S.Foreground = Brushes.Green;
                S.IsEnabled = false;
            }
            ss++;
        }
        private void T_Click(object sender, RoutedEventArgs e)
        {
            string s = "T";
            if (tt == 0)
                FoFuggveny(s);
            if (megTart == 1)
            {
                T.Foreground = Brushes.Green;
                T.IsEnabled = false;
            }
            tt++;
        }
        private void U_Click(object sender, RoutedEventArgs e)
        {
            string s = "U";
            if (uu == 0)
                FoFuggveny(s);
            if (megTart == 1)
            {
                U.Foreground = Brushes.Green;
                U.IsEnabled = false;
            }
            uu++;
        }
        private void Ú_Click(object sender, RoutedEventArgs e)
        {
            string s = "Ú";
            if (úú == 0)
                FoFuggveny(s);
            if (megTart == 1)
            {
                Ú.Foreground = Brushes.Green;
                Ú.IsEnabled = false;
            }
            úú++;
        }
        private void Ü_Click(object sender, RoutedEventArgs e)
        {
            string s = "Ü";
            if (üü == 0)
                FoFuggveny(s);
            if (megTart == 1)
            {
                Ü.Foreground = Brushes.Green;
                Ü.IsEnabled = false;
            }
            üü++;
        }
        private void Ű_Click(object sender, RoutedEventArgs e)
        {
            string s = "Ű";
            if (űű == 0)
                FoFuggveny(s);
            if (megTart == 1)
            {
                Ű.Foreground = Brushes.Green;
                Ű.IsEnabled = false;
            }
            űű++;
        }
        private void V_Click(object sender, RoutedEventArgs e)
        {
            string s = "V";
            if (vv == 0)
                FoFuggveny(s);
            if (megTart == 1)
            {
                V.Foreground = Brushes.Green;
                V.IsEnabled = false;
            }
            vv++;
        }
        private void W_Click(object sender, RoutedEventArgs e)
        {
            string s = "W";
            if (ww == 0)
                FoFuggveny(s);
            if (megTart == 1)
            {
                W.Foreground = Brushes.Green;
                W.IsEnabled = false;
            }
            ww++;
        }
        private void X_Click(object sender, RoutedEventArgs e)
        {
            string s = "X";
            if (xx == 0)
                FoFuggveny(s);
            if (megTart == 1)
            {
                X.Foreground = Brushes.Green;
                X.IsEnabled = false;
            }
            xx++;
        }
        private void Y_Click(object sender, RoutedEventArgs e)
        {
            string s = "Y";
            if (yy == 0)
                FoFuggveny(s);
            if (megTart == 1)
            {
                Y.Foreground = Brushes.Green;
                Y.IsEnabled = false;
            }
            yy++;
        }
        private void Z_Click(object sender, RoutedEventArgs e)
        {
            string s = "Z";
            if (zz == 0)
                FoFuggveny(s);
            if (megTart == 1)
            {
                Z.Foreground = Brushes.Green;
                Z.IsEnabled = false;
            }
            zz++;
        }
        private void Button_Click(object sender, RoutedEventArgs e) //új szó felvétele
        {
            int y = 0;
            box.Height = 40;
            player.Play();
            if (box.Text.Length <= 16 && box.Text.Length >= 3)
            {
                for (int i = 0; i < db; i++)
                {
                    if (box.Text.ToUpper() == lista[i])
                    {
                        y = 1;
                    }
                }
                if (y == 0)
                {
                    StreamWriter iras = File.AppendText(@"C:\hangman\forrásfájlok\szavak.txt");
                    iras.WriteLine(box.Text.ToUpper());
                    iras.Flush();
                    iras.Close();
                    StreamReader olvas = new StreamReader(@"C:\hangman\forrásfájlok\szavak.txt");
                    while (olvas.EndOfStream == false)
                    {
                        lista.Add(olvas.ReadLine());
                        db++;
                    }
                    olvas.Close();
                    MessageBox.Show("Sikeres felvétel!", "Üzenet");
                }
                if (y == 1)
                {
                    MessageBox.Show("Ez a szó már szerepel a listában!", "Hiba");
                }
            }
            if (box.Text.Length > 16)
            {
                MessageBox.Show("Túl hosszú a karakterek száma! (max. 16)", "Hiba!");
            }
            if (box.Text.Length < 3)
            {
                MessageBox.Show("Túl rövid a karakterek száma! (min. 3)", "Hiba!");
            }

            box.Text = string.Empty;
            textbox.Focus();
        }
        private void textbox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            if (textbox.Text == "a")
            {
                string s = "A";
                if (aa == 0)
                    FoFuggveny(s);
                if (megTart == 1)
                {
                    A.Foreground = Brushes.Green;
                    A.IsEnabled = false;
                }
                aa++;
            }
            if (textbox.Text == "á")
            {
                string s = "Á";
                if (áá == 0)
                    FoFuggveny(s);
                if (megTart == 1)
                {
                    Á.Foreground = Brushes.Green;
                    Á.IsEnabled = false;
                }
                áá++;
            }
            if (textbox.Text == "b")
            {
                string s = "B";
                if (bb == 0)
                    FoFuggveny(s);
                if (megTart == 1)
                {
                    B.Foreground = Brushes.Green;
                    B.IsEnabled = false;
                }
                bb++;
            }
            if (textbox.Text == "c")
            {
                string s = "C";
                if (cc == 0)
                    FoFuggveny(s);
                if (megTart == 1)
                {
                    C.Foreground = Brushes.Green;
                    C.IsEnabled = false;
                }
                cc++;
            }
            if (textbox.Text == "d")
            {
                string s = "D";
                if (dd == 0)
                    FoFuggveny(s);
                if (megTart == 1)
                {
                    D.Foreground = Brushes.Green;
                    D.IsEnabled = false;
                }
                dd++;
            }
            if (textbox.Text == "e")
            {
                string s = "E";
                if (eee == 0)
                    FoFuggveny(s);
                if (megTart == 1)
                {
                    E.Foreground = Brushes.Green;
                    E.IsEnabled = false;
                }
                eee++;
            }
            if (textbox.Text == "é")
            {
                string s = "É";
                if (éé == 0)
                    FoFuggveny(s);
                if (megTart == 1)
                {
                    É.Foreground = Brushes.Green;
                    É.IsEnabled = false;
                }
                éé++;
            }
            if (textbox.Text == "f")
            {
                string s = "F";
                if (ff == 0)
                    FoFuggveny(s);
                if (megTart == 1)
                {
                    F.Foreground = Brushes.Green;
                    F.IsEnabled = false;
                }
                ff++;
            }
            if (textbox.Text == "g")
            {
                string s = "G";
                if (gg == 0)
                    FoFuggveny(s);
                if (megTart == 1)
                {
                    Gé.Foreground = Brushes.Green;
                    Gé.IsEnabled = false;
                }
                gg++;
            }
            if (textbox.Text == "h")
            {
                string s = "H";
                if (hh == 0)
                    FoFuggveny(s);
                if (megTart == 1)
                {
                    H.Foreground = Brushes.Green;
                    H.IsEnabled = false;
                }
                hh++;
            }
            if (textbox.Text == "i")
            {
                string s = "I";
                if (ii == 0)
                    FoFuggveny(s);
                if (megTart == 1)
                {
                    I.Foreground = Brushes.Green;
                    I.IsEnabled = false;
                }
                ii++;
            }
            if (textbox.Text == "í")
            {
                string s = "Í";
                if (íí == 0)
                    FoFuggveny(s);
                if (megTart == 1)
                {
                    Í.Foreground = Brushes.Green;
                    Í.IsEnabled = false;
                }
                íí++;
            }
            if (textbox.Text == "j")
            {
                string s = "J";
                if (jj == 0)
                    FoFuggveny(s);
                if (megTart == 1)
                {
                    J.Foreground = Brushes.Green;
                    J.IsEnabled = false;
                }
                jj++;
            }
            if (textbox.Text == "k")
            {
                string s = "K";
                if (kk == 0)
                    FoFuggveny(s);
                if (megTart == 1)
                {
                    Ká.Foreground = Brushes.Green;
                    Ká.IsEnabled = false;
                }
                kk++;
            }
            if (textbox.Text == "l")
            {
                string s = "L";
                if (ll == 0)
                    FoFuggveny(s);
                if (megTart == 1)
                {
                    L.Foreground = Brushes.Green;
                    L.IsEnabled = false;
                }
                ll++;
            }
            if (textbox.Text == "m")
            {
                string s = "M";
                if (mm == 0)
                    FoFuggveny(s);
                if (megTart == 1)
                {
                    M.Foreground = Brushes.Green;
                    M.IsEnabled = false;
                }
                mm++;
            }
            if (textbox.Text == "n")
            {
                string s = "N";
                if (nn == 0)
                    FoFuggveny(s);
                if (megTart == 1)
                {
                    N.Foreground = Brushes.Green;
                    N.IsEnabled = false;
                }
                nn++;
            }
            if (textbox.Text == "o")
            {
                string s = "O";
                if (oo == 0)
                    FoFuggveny(s);
                if (megTart == 1)
                {
                    O.Foreground = Brushes.Green;
                    O.IsEnabled = false;
                }
                oo++;
            }
            if (textbox.Text == "ó")
            {
                string s = "Ó";
                if (óó == 0)
                    FoFuggveny(s);
                if (megTart == 1)
                {
                    Ó.Foreground = Brushes.Green;
                    Ó.IsEnabled = false;
                }
                óó++;
            }
            if (textbox.Text == "ö")
            {
                string s = "Ö";
                if (öö == 0)
                    FoFuggveny(s);
                if (megTart == 1)
                {
                    Ö.Foreground = Brushes.Green;
                    Ö.IsEnabled = false;
                }
                öö++;
            }
            if (textbox.Text == "ő")
            {
                string s = "Ő";
                if (őő == 0)
                    FoFuggveny(s);
                if (megTart == 1)
                {
                    Ő.Foreground = Brushes.Green;
                    Ő.IsEnabled = false;
                }
                őő++;
            }
            if (textbox.Text == "p")
            {
                string s = "P";
                if (pp == 0)
                    FoFuggveny(s);
                if (megTart == 1)
                {
                    P.Foreground = Brushes.Green;
                    P.IsEnabled = false;
                }
                pp++;
            }
            if (textbox.Text == "q")
            {
                string s = "q";
                if (qq == 0)
                    FoFuggveny(s);
                if (megTart == 1)
                {
                    Q.Foreground = Brushes.Green;
                    Q.IsEnabled = false;
                }
                qq++;
            }
            if (textbox.Text == "r")
            {
                string s = "R";
                if (rr == 0)
                    FoFuggveny(s);
                if (megTart == 1)
                {
                    R.Foreground = Brushes.Green;
                    R.IsEnabled = false;
                }
                rr++;
            }
            if (textbox.Text == "s")
            {
                string s = "S";
                if (ss == 0)
                    FoFuggveny(s);
                if (megTart == 1)
                {
                    S.Foreground = Brushes.Green;
                    S.IsEnabled = false;
                }
                ss++;
            }
            if (textbox.Text == "t")
            {
                string s = "T";
                if (tt == 0)
                    FoFuggveny(s);
                if (megTart == 1)
                {
                    T.Foreground = Brushes.Green;
                    T.IsEnabled = false;
                }
                tt++;
            }
            if (textbox.Text == "u")
            {
                string s = "U";
                if (uu == 0)
                    FoFuggveny(s);
                if (megTart == 1)
                {
                    U.Foreground = Brushes.Green;
                    U.IsEnabled = false;
                }
                uu++;
            }
            if (textbox.Text == "ú")
            {
                string s = "Ú";
                if (uu == 0)
                    FoFuggveny(s);
                if (megTart == 1)
                {
                    Ú.Foreground = Brushes.Green;
                    Ú.IsEnabled = false;
                }
                úú++;
            }
            if (textbox.Text == "ü")
            {
                string s = "Ü";
                if (üü == 0)
                    FoFuggveny(s);
                if (megTart == 1)
                {
                    Ü.Foreground = Brushes.Green;
                    Ü.IsEnabled = false;
                }
                üü++;
            }
            if (textbox.Text == "ű")
            {
                string s = "Ű";
                if (űű == 0)
                    FoFuggveny(s);
                if (megTart == 1)
                {
                    Ű.Foreground = Brushes.Green;
                    Ű.IsEnabled = false;
                }
                űű++;
            }
            if (textbox.Text == "v")
            {
                string s = "V";
                if (vv == 0)
                    FoFuggveny(s);
                if (megTart == 1)
                {
                    V.Foreground = Brushes.Green;
                    V.IsEnabled = false;
                }
                vv++;
            }
            if (textbox.Text == "w")
            {
                string s = "W";
                if (ww == 0)
                    FoFuggveny(s);
                if (megTart == 1)
                {
                    W.Foreground = Brushes.Green;
                    W.IsEnabled = false;
                }
                ww++;
            }
            if (textbox.Text == "x")
            {
                string s = "X";
                if (xx == 0)
                    FoFuggveny(s);
                if (megTart == 1)
                {
                    X.Foreground = Brushes.Green;
                    X.IsEnabled = false;
                }
                xx++;
            }
            if (textbox.Text == "y")
            {
                string s = "Y";
                if (yy == 0)
                    FoFuggveny(s);
                if (megTart == 1)
                {
                    Y.Foreground = Brushes.Green;
                    Y.IsEnabled = false;
                }
                yy++;
            }
            if (textbox.Text == "z")
            {
                string s = "Z";
                if (zz == 0)
                    FoFuggveny(s);
                if (megTart == 1)
                {
                    Z.Foreground = Brushes.Green;
                    Z.IsEnabled = false;
                }
                zz++;
            }
            textbox.Text = "";
        }
        public int x = 0;
        private void fooldal_Click(object sender, RoutedEventArgs e)
        {
            ujf.Content = "ÚJ JÁTÉK";
            player.Play();
            korte.Height = 0;
            sugopontdarab.Height = 0;
            korte2.Height = 0;
            ujf.Height = 0;
            play.Height = 0;
            panel.Height = 700;
            box.Height = 0;
            plus.Height = 0;
            vasarlas.Height = 0;
            hangman.Height = 200;
            ujf.Height = 50;
            fooldal.Height = 0;
            player4.Play();
            StreamWriter iras = new StreamWriter(@"C:\hangman\felhasználók\" + nev.Text + ".txt");
            iras.WriteLine(pontszam);
            iras.WriteLine(sugopont);
            iras.Flush();
            iras.Close();
        }
        //ablak bezárása
        private void Button_Click_3(object sender, EventArgs e)
        {
            StreamWriter iras = new StreamWriter(@"C:\hangman\felhasználók\" + nev.Text + ".txt");
            iras.WriteLine(pontszam);
            iras.WriteLine(sugopont);
            iras.Flush();
            iras.Close();
            this.Close();
        }
        private void korte_Click(object sender, RoutedEventArgs e)
        {

            korte2.Height = 53;
            sugopont--;
            sugopontdarab.Content = sugopont;
            int i = 0;
            int j = 0;

            foreach (char item in lista[ran])
            {
                if (i == 0 && item == 'A')
                {
                    if (sugoPontSegedFuggveny('A') == 1)
                    {
                        Aborder.Height = 53;
                        i++;
                    }
                }
                if (i == 0 && item == 'Á')
                {
                    if (sugoPontSegedFuggveny('Á') == 1)
                    {
                        Áborder.Height = 53;
                        i++;
                    }
                }
                if (i == 0 && item == 'B')
                {
                    if (sugoPontSegedFuggveny('B') == 1)
                    {
                        Bborder.Height = 53;
                        i++;
                    }
                }
                if (i == 0 && item == 'C')
                {
                    if (sugoPontSegedFuggveny('C') == 1)
                    {
                        Cborder.Height = 53;
                        i++;
                    }
                }
                if (i == 0 && item == 'D')
                {
                    if (sugoPontSegedFuggveny('D') == 1)
                    {
                        Dborder.Height = 53;
                        i++;
                    }
                }
                if (i == 0 && item == 'E')
                {
                    if (sugoPontSegedFuggveny('E') == 1)
                    {
                        Eborder.Height = 53;
                        i++;
                    }
                }
                if (i == 0 && item == 'É')
                {
                    if (sugoPontSegedFuggveny('É') == 1)
                    {
                        Éborder.Height = 53;
                        i++;
                    }
                }
                if (i == 0 && item == 'F')
                {
                    if (sugoPontSegedFuggveny('F') == 1)
                    {
                        Fborder.Height = 53;
                        i++;
                    }
                }
                if (i == 0 && item == 'G')
                {
                    if (sugoPontSegedFuggveny('G') == 1)
                    {
                        Gborder.Height = 53;
                        i++;
                    }
                }
                if (i == 0 && item == 'H')
                {
                    if (sugoPontSegedFuggveny('H') == 1)
                    {
                        Hborder.Height = 53;
                        i++;
                    }
                }
                if (i == 0 && item == 'I')
                {
                    if (sugoPontSegedFuggveny('I') == 1)
                    {
                        Iborder.Height = 53;
                        i++;
                    }
                }
                if (i == 0 && item == 'Í')
                {
                    if (sugoPontSegedFuggveny('Í') == 1)
                    {
                        Íborder.Height = 53;
                        i++;
                    }
                }
                if (i == 0 && item == 'J')
                {
                    if (sugoPontSegedFuggveny('J') == 1)
                    {
                        Jborder.Height = 53;
                        i++;
                    }
                }
                if (i == 0 && item == 'K')
                {
                    if (sugoPontSegedFuggveny('K') == 1)
                    {
                        Kborder.Height = 53;
                        i++;
                    }
                }
                if (i == 0 && item == 'L')
                {
                    if (sugoPontSegedFuggveny('L') == 1)
                    {
                        Lborder.Height = 53;
                        i++;
                    }
                }
                if (i == 0 && item == 'M')
                {
                    if (sugoPontSegedFuggveny('M') == 1)
                    {
                        Mborder.Height = 53;
                        i++;
                    }
                }
                if (i == 0 && item == 'N')
                {
                    if (sugoPontSegedFuggveny('N') == 1)
                    {
                        Nborder.Height = 53;
                        i++;
                    }
                }
                if (i == 0 && item == 'O')
                {
                    if (sugoPontSegedFuggveny('O') == 1)
                    {
                        Oborder.Height = 53;
                        i++;
                    }
                }
                if (i == 0 && item == 'Ó')
                {
                    if (sugoPontSegedFuggveny('Ó') == 1)
                    {
                        Óborder.Height = 53;
                        i++;
                    }
                }
                if (i == 0 && item == 'Ö')
                {
                    if (sugoPontSegedFuggveny('Ö') == 1)
                    {
                        Öborder.Height = 53;
                        i++;
                    }
                }
                if (i == 0 && item == 'Ő')
                {
                    if (sugoPontSegedFuggveny('Ő') == 1)
                    {
                        Őborder.Height = 53;
                        i++;
                    }
                }
                if (i == 0 && item == 'P')
                {
                    if (sugoPontSegedFuggveny('P') == 1)
                    {
                        Pborder.Height = 53;
                        i++;
                    }
                }
                if (i == 0 && item == 'Q')
                {
                    if (sugoPontSegedFuggveny('Q') == 1)
                    {
                        Qborder.Height = 53;
                        i++;
                    }
                }
                if (i == 0 && item == 'R')
                {
                    if (sugoPontSegedFuggveny('R') == 1)
                    {
                        Rborder.Height = 53;
                        i++;
                    }
                }
                if (i == 0 && item == 'S')
                {
                    if (sugoPontSegedFuggveny('S') == 1)
                    {
                        Sborder.Height = 53;
                        i++;
                    }
                }
                if (i == 0 && item == 'T')
                {
                    if (sugoPontSegedFuggveny('T') == 1)
                    {
                        Tborder.Height = 53;
                        i++;
                    }
                }
                if (i == 0 && item == 'U')
                {
                    if (sugoPontSegedFuggveny('U') == 1)
                    {
                        Uborder.Height = 53;
                        i++;
                    }
                }
                if (i == 0 && item == 'Ú')
                {
                    if (sugoPontSegedFuggveny('Ú') == 1)
                    {
                        Úborder.Height = 53;
                        i++;
                    }
                }
                if (i == 0 && item == 'Ü')
                {
                    if (sugoPontSegedFuggveny('Ü') == 1)
                    {
                        Üborder.Height = 53;
                        i++;
                    }
                }
                if (i == 0 && item == 'Ű')
                {
                    if (sugoPontSegedFuggveny('Ű') == 1)
                    {
                        Űborder.Height = 53;
                        i++;
                    }
                }
                if (i == 0 && item == 'V')
                {
                    if (sugoPontSegedFuggveny('V') == 1)
                    {
                        Vborder.Height = 53;
                        i++;
                    }
                }
                if (i == 0 && item == 'W')
                {
                    if (sugoPontSegedFuggveny('W') == 1)
                    {
                        Wborder.Height = 53;
                        i++;
                    }
                }
                if (i == 0 && item == 'X')
                {
                    if (sugoPontSegedFuggveny('X') == 1)
                    {
                        Xborder.Height = 53;
                        i++;
                    }
                }
                if (i == 0 && item == 'Y')
                {
                    if (sugoPontSegedFuggveny('Y') == 1)
                    {
                        Yborder.Height = 53;
                        i++;
                    }
                }
                if (i == 0 && item == 'Z')
                {
                    if (sugoPontSegedFuggveny('Z') == 1)
                    {
                        Zborder.Height = 53;
                        i++;
                    }
                }
                j++;
            }
        }
        public int sugoPontSegedFuggveny(char betuErtek)
        {
            if (a.Text != betuErtek.ToString() && b.Text != betuErtek.ToString() && c.Text != betuErtek.ToString() && d.Text != betuErtek.ToString()
                && ee.Text != betuErtek.ToString() && f.Text != betuErtek.ToString() && g.Text != betuErtek.ToString() && h.Text != betuErtek.ToString()
                && iii.Text != betuErtek.ToString() && jjj.Text != betuErtek.ToString() && k.Text != betuErtek.ToString() && l.Text != betuErtek.ToString()
                && m.Text != betuErtek.ToString() && n.Text != betuErtek.ToString() && n.Text != betuErtek.ToString() && p.Text != betuErtek.ToString()
               )
            {
                return 1;
            }
            else return 0;
        }
        public void deleteBorders()
        {
            Aborder.Height = 0;
            Áborder.Height = 0;
            Bborder.Height = 0;
            Cborder.Height = 0;
            Dborder.Height = 0;
            Eborder.Height = 0;
            Éborder.Height = 0;
            Fborder.Height = 0;
            Gborder.Height = 0;
            Hborder.Height = 0;
            Iborder.Height = 0;
            Íborder.Height = 0;
            Jborder.Height = 0;
            Kborder.Height = 0;
            Lborder.Height = 0;
            Mborder.Height = 0;
            Nborder.Height = 0;
            Oborder.Height = 0;
            Óborder.Height = 0;
            Öborder.Height = 0;
            Őborder.Height = 0;
            Pborder.Height = 0;
            Qborder.Height = 0;
            Rborder.Height = 0;
            Sborder.Height = 0;
            Tborder.Height = 0;
            Uborder.Height = 0;
            Úborder.Height = 0;
            Üborder.Height = 0;
            Űborder.Height = 0;
            Vborder.Height = 0;
            Wborder.Height = 0;
            Xborder.Height = 0;
            Yborder.Height = 0;
            Zborder.Height = 0;
        }
        //vásárlás
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (pontszam < 100) MessageBox.Show("Nincs elég pontod! (min.:100 p", "Info");
            if (sugopont > 98) MessageBox.Show("Legfeljebb 99 súgópontod lehet!", "Info");
            if (pontszam > 100 && sugopont < 99)
            {
                pontszam -= 100;
                pont.Text = pontszam.ToString() + " p";
                sugopont++;
                sugopontdarab.Content = sugopont.ToString();
            }
        }
        public int paritas = 0;
        private void regisztracio_Click(object sender, RoutedEventArgs e)
        {
            if (paritas % 2 == 0)
                regisztraciosPanel.Height = 330;
            vissza.Height = 50;
            if (paritas % 2 == 1)
            {
                if (ujfelhasznaloNev.Text != "" && ujJelszo.Password != "" && becenev.Text != "" && becenev.Text.Length < 9)
                {
                    regisztraciosPanel.Height = 0;
                    StreamWriter iras = File.AppendText(@"C:\hangman\forrásfájlok\bejelentkezes.txt");
                    iras.WriteLine(ujfelhasznaloNev.Text);
                    iras.WriteLine(ujJelszo.Password);
                    iras.WriteLine(becenev.Text);
                    iras.WriteLine();
                    iras.Flush();
                    iras.Close();
                    vissza.Height = 0;
                    MessageBox.Show("Sikeres regisztráció!");
                    StreamWriter iras2 = new StreamWriter(@"C:\hangman\felhasználók\" + becenev.Text + ".txt");
                    iras2.WriteLine("0");
                    iras2.WriteLine("0");
                    iras2.Flush();
                    iras2.Close();
                }
                if (ujfelhasznaloNev.Text == "" && ujJelszo.Password == "") { MessageBox.Show("Minden mezőt ki kell tölteni!"); ujfelhasznaloNev.Text = ""; ujJelszo.Password = ""; becenev.Text = ""; }
                if (becenev.Text.Length >= 9) { MessageBox.Show("A becenév legfeljebb 8 karakter hosszú lehet!"); ujfelhasznaloNev.Text = ""; ujJelszo.Password = ""; becenev.Text = ""; }
                ujfelhasznaloNev.Text = "";
                ujJelszo.Password = "";
                becenev.Text = "";
            }
            paritas++;
        }
        private void kijelentkezes_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter iras = new StreamWriter(@"C:\hangman\forrásfájlok\bejelentkezveMarad.txt");
            iras.WriteLine("nincs bejelentkezve");
            iras.WriteLine();
            iras.Flush();
            iras.Close();
            StreamWriter iras2 = new StreamWriter(@"C:\hangman\felhasználók\" + nev.Text + ".txt");
            iras2.WriteLine(pontszam);
            iras2.WriteLine(sugopont);
            iras2.Flush();
            iras2.Close();
            bejelentkezveMarad.IsChecked = false;
            felhasznalonevIras.Height = 20;
            felhasznalonev.Height = 50;
            jelszoIras.Height = 20;
            jelszo.Height = 50;
            regisztracio.Height = 50;
            felhasznalonev.Text = "";
            jelszo.Password = "";
            nev.Text = "";
            beVanEJelentkezve = "nincs bejelentkezve";
            bejelentkezveMarad.Height = 30;
            bejelentkezveMaradIras.Height = 60;
            ujf.Content = "BEJELENTKEZÉS";
            player.Play();
            korte.Height = 0;
            sugopontdarab.Height = 0;
            korte2.Height = 0;
            ujf.Height = 0;
            play.Height = 0;
            panel.Height = 700;
            box.Height = 0;
            plus.Height = 0;
            vasarlas.Height = 0;
            hangman.Height = 200;
            ujf.Height = 50;
            fooldal.Height = 0;
            player4.Play();
        }
        private void vissza_Click(object sender, RoutedEventArgs e)
        {
            regisztraciosPanel.Height = 0;
            vissza.Height = 0;
            ujfelhasznaloNev.Text = "";
            ujJelszo.Password = "";
            becenev.Text = "";
            paritas--;
        }
    }
}