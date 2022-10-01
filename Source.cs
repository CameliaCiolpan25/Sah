using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

abstract class Piesa
{
    protected int x, y, w, h;
    protected Image img;



    public int X
    {
        get { return x; }
        set { this.x = value; }
    }
    public int Y
    {
        get { return y; }
        set { this.y = value; }
    }
    public int W
    {
        get { return w; }
        set { this.w = value; }
    }
    public int H
    {
        get { return h; }
        set { this.h = value; }
    }
    public bool este_deasupra(int x, int y)
    {
        if (x < this.x) return false;
        if (x > this.x + w) return false;
        if (y < this.y) return false;
        if (y > this.y + h) return false;
        return true;
    }
    public void deseneaza(Graphics g)
    {
        g.DrawImage(img, x, y, w, h);
    }
}

class PionA : Piesa
{
    public PionA(int x, int y, int w, int h)
    {
        this.x = x;
        this.y = y;
        this.w = w;
        this.h = h;
        this.img = Image.FromFile("pion.gif");
    }
}

class PionN : Piesa
{
    public PionN(int x, int y, int w, int h)
    {
        this.x = x;
        this.y = y;
        this.w = w;
        this.h = h;
        this.img = Image.FromFile("pionN.gif");
    }
}

class RegeA : Piesa
{
    public RegeA(int x, int y, int w, int h)
    {
        this.x = x;
        this.y = y;
        this.w = w;
        this.h = h;
        this.img = Image.FromFile("regeA.png");
    }
}

class JocSah
{
    int w, h, l;
    Graphics g;
    List<Piesa> piese;
    public JocSah(int w,int h,Graphics g)
    {
        this.w = w;
        this.h = h;
        this.g = g;
        l = w / 10;
        piese = new List<Piesa>();
        for(int i=0;i<8;i++)
        {
            piese.Add(new PionA(0, 0, l / 2, l * 2 / 3));
           

        }
        for (int i = 0; i < 8; i++)
        {
            piese.Add(new PionN(0, 0, l / 2, l * 2 / 3));
        }
        piese.Add(new RegeA(0, 0, l * 2 / 3, l * 2 / 3));
    }
    public void aseaza_piesa(Piesa p,int x,int y)
    {
        int lin = y / l;
        int col = x / l;
        p.X = col * l + l / 2 - p.W / 2;
        p.Y = lin * l + l / 2 - p.H / 2;

    }
    public void aseaza_piese()
    {
        for(int i=0;i<8;i++)
        {
            aseaza_piesa(piese[i], l + i * l, 2 * l+l/2);
        }
        for(int i=0;i<8;i++)
        {
            aseaza_piesa(piese[8 + i], l + l * i, 7 * l+l/2);
        }
        aseaza_piesa(piese[16], l + 4 * l, l + l / 2);
    }
    public void deseneaza_tabla_sah()
    {
        g.Clear(Color.White);
        Pen Creion = new Pen(Color.Black, 1);
        Brush col1 = Brushes.Orange, col2 = Brushes.Azure;
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                g.FillRectangle((i + j) % 2 == 0 ? col1 : col2, l + i * l, l + j * l, l, l);
            }
        }
        for (int i = 0; i < 9; i++)
        {
            g.DrawLine(Creion, l, l + i * l, 9 * l, l + i * l);
            g.DrawLine(Creion, l + i * l, l, l + i * l, 9 * l);
        }
        /* for(int i=0;i<8;i++)
         {
             Font drawFont = new Font("Arial", 16);
             SolidBrush drawBrush = new SolidBrush(Color.Black);
             g.DrawString((Convert.ToChar(97 + i)).ToString(), drawFont, drawBrush, l + i * l+l/3 ,9*l+l/8) ;
             g.DrawString((i+1).ToString(), drawFont, drawBrush,  l/3, l + i * l + l / 3);
         }*/
        Font f = new Font("Times New Roman", 12);
        StringFormat sf = new StringFormat();
        sf.Alignment = StringAlignment.Center;
        sf.LineAlignment = StringAlignment.Center;
        for (int i = 0; i < 8; i++)
        {
            g.DrawString((i + 1).ToString(), f, Brushes.Black, new RectangleF(l / 2, l + i * l, l / 2, l), sf);
            g.DrawString(Convert.ToChar((97 + i)).ToString(), f, Brushes.Black, new RectangleF(l + i * l, 9 * l, l, l / 2), sf);
        }
       
    }
    public void deseneaza()
    {
        deseneaza_tabla_sah();
        foreach(Piesa p in piese)
        {
            p.deseneaza(g);
        }
    }
    public void jocNou()
    {
        aseaza_piese();
        deseneaza();
    }
    public Piesa daPiesa(int x,int y)
    {
        foreach(Piesa p in piese)
        {
            if (p.este_deasupra(x, y))
                return p;
        }
        return null;
    }
}
