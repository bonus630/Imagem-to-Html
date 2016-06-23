using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace ImagemToHtml
{
    public partial class Form1 : Form
    {

        Bitmap bitmap;
        string name;
        List<Color> listColor;
        int scala;


        public Form1()
        {
            InitializeComponent();
            scale_ValueChanged(null, null);
            
        }

        private void btn_abrir_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.JPG;*.BMP;*.PNG;*.GIF)|*.JPG;*.BMP;*.PNG;*.GIF";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                name = openFileDialog1.FileName;
                bitmap = new Bitmap(name);
                img_preview.Image = bitmap;
                btn_converter.Enabled = true;
                if ((bitmap.Width * bitmap.Height) > 90000)
                    label1.Text = "Seu html pode ficar lento";
                else
                    label1.Text = "";
            }
        }

        private void btn_converter_Click(object sender, EventArgs e)
        {
            converter();
        }

        private void converter()
        {
            fillListColors();
            
        }

        private string convertColorHexString(Color cor)
        {
            return cor.R.ToString("x2") + cor.G.ToString("x2") + cor.B.ToString("x2");
        }

        private void fillListColors()
        {
            listColor = new List<Color>();
            int width = bitmap.Width;
            int height = bitmap.Height;
            int x = 0; int y = 0;
            FileInfo fi = new FileInfo(name);
            
           string htmlFile = fi.FullName.Replace(fi.Extension,".html");
           
            using (StreamWriter sw = new StreamWriter(htmlFile,false))
            {
                sw.WriteLine("<html xmlns=\"http://www.w3.org/1999/xhtml\">");
                sw.WriteLine("<head>");
                sw.WriteLine("<meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />");
                sw.WriteLine("<title>"+fi.Name+"</title>");
                sw.WriteLine("<style>body{background-color:#"+convertColorHexString(btn_color.BackColor)+"}div{width:"+scala+"px;height:"+scala+"px;display:block;float:left;}#todo{width:"+width*scala+"px;height:"+height*scala+"px;display:block;} </style>");
                sw.WriteLine("</head>");
                sw.WriteLine("<body>");
                sw.WriteLine("<!-- Visite http://bonus630.tk. -->");
                sw.WriteLine("<div id=\"todo\">"); 
                while (y < height)
                {
                   // sw.WriteLine("      <tr>");
                    while (x < width)
                    {
                        Color cor = bitmap.GetPixel(x, y);
                        if(!cor.Equals(btn_color.BackColor))
                            sw.Write("<div style=\"background-color:#" + convertColorHexString(cor) + ";\"></div>");
                        else
                            sw.Write("<div></div>");

                        x++;
                    }
                     
                    x = 0;
                    y++;
                } 
                sw.WriteLine("</div>");
                sw.WriteLine("</body>");
                sw.WriteLine("</html>");
                
            }
            if (cb_navegador.Checked)
                System.Diagnostics.Process.Start(htmlFile);
        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btn_color.BackColor = colorDialog1.Color;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void scale_ValueChanged(object sender, EventArgs e)
        {
            scala = (int)scale.Value;
        }
        
         
               
    }
}
