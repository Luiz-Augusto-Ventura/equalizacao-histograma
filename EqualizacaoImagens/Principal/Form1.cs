using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap img, imgEq, novaImg;
        Color pixel;
        int red, green, blue;
        int[] histogramaR, histogramaG, histogramaB;
        float[] histAcumuladoR, histAcumuladoG, histAcumuladoB;
        int[] mapaCoresR, mapaCoresG, mapaCoresB;
        int tomR, tomG, tomB, novoTomR, novoTomG, novoTomB;
        
        private void cmdAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog imgOriginal = new OpenFileDialog();
            imgOriginal.Filter = "JPEG|*.JPG|PNG|*.PNG|GIF|*.GIF|BMP|*.BMP|All files (*.*)|*.*";
            if (imgOriginal.ShowDialog() == DialogResult.OK)
            {
                img = new Bitmap(imgOriginal.FileName);
                imagemOriginal.Image = img;

                
                //Limpando os gráficos e PictureBox
                chart_R_Original.Series[0].Points.Clear();
                chart_G_Original.Series[0].Points.Clear();
                chart_B_Original.Series[0].Points.Clear();
                chart_P_Original.Series[0].Points.Clear();

                chart_R_Equalizado.Series[0].Points.Clear();
                chart_G_Equalizado.Series[0].Points.Clear();
                chart_B_Equalizado.Series[0].Points.Clear();
                chart_P_Equalizado.Series[0].Points.Clear();

                imagemEqualizada.Image = null;
            }
            cmdEqualizar.Enabled = true;
            cmdEqualizarCores.Enabled = true;
        }

        private void cmdSalvar_Click(object sender, EventArgs e)
        {
            SaveFileDialog imgEqualizada = new SaveFileDialog();
            imgEqualizada.Filter = "JPEG|*.JPG|PNG|*.PNG|GIF|*.GIF|BMP|*.BMP|All files (*.*)|*.*";
            if (imgEqualizada.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (Bitmap imgEq = new Bitmap(imagemEqualizada.Image))
                    {
                        imgEq.Save(imgEqualizada.FileName, ImageFormat.Jpeg);
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }

        private void cmdEqualizar_Click(object sender, EventArgs e)
        {
            imgEq = equalizarImagem(img);
            imagemEqualizada.Image = imgEq;
            histogramaR = new int[256];

            calcularHistograma(imgEq, "P");
            gerarGraficoHistogramaEq("P");

            cmdSalvar.Enabled = true;
        }

        private void cmdEqualizarCores_Click(object sender, EventArgs e)
        {
            imgEq = equalizarImagemCores(img);
            imagemEqualizada.Image = imgEq;       
            histogramaR = new int[256];
            histogramaG = new int[256];
            histogramaB = new int[256];
            
            calcularHistograma(imgEq, "RGB");
            gerarGraficoHistogramaEq("RGB");

            cmdSalvar.Enabled = true;
        }

        private void calcularHistograma(Bitmap img, string canal)
        {
            if (img != null)
            {
                canal.ToUpper();
                switch (canal)
                {
                    case "P":
                        for (int x = 0; x < img.Width; x++)
                        {
                            for (int y = 0; y < img.Height; y++)
                            {
                                pixel = img.GetPixel(x, y);
                                red = pixel.R;
                                histogramaR[red]++;
                            }
                        }
                        break;
                    case "RGB":
                        for (int x = 0; x < img.Width; x++)
                        {
                            for (int y = 0; y < img.Height; y++)
                            {
                                pixel = img.GetPixel(x, y);
                                red = pixel.R;
                                green = pixel.G;
                                blue = pixel.B;
                                histogramaR[red]++;
                                histogramaG[green]++;
                                histogramaB[blue]++;
                            }
                        }
                        break;
                }
            }
        }

        private void gerarGraficoHistograma(string canal)
        {
            canal.ToUpper();
            switch (canal)
            {
                case "P":
                    for (int i = 0; i < 256; i++)
                    {
                        chart_P_Original.Series[0].Points.AddXY(i + 1, histogramaR[i]);
                    }
                    break;
                case "RGB":
                    for (int i = 0; i < 256; i++)
                    {
                        chart_R_Original.Series[0].Points.AddXY(i + 1, histogramaR[i]);
                        chart_G_Original.Series[0].Points.AddXY(i + 1, histogramaG[i]);
                        chart_B_Original.Series[0].Points.AddXY(i + 1, histogramaB[i]);
                    }
                    break;
            }
        }

        private void gerarGraficoHistogramaEq(string canal)
        {
            canal.ToUpper();
            switch (canal)
            {
                case "P":
                    for (int i = 0; i < 256; i++)
                    {
                        chart_P_Equalizado.Series[0].Points.AddXY(i + 1, histogramaR[i]);
                    }
                    break;
                case "RGB":
                    for (int i = 0; i < 256; i++)
                    {
                        chart_R_Equalizado.Series[0].Points.AddXY(i + 1, histogramaR[i]);
                        chart_G_Equalizado.Series[0].Points.AddXY(i + 1, histogramaG[i]);
                        chart_B_Equalizado.Series[0].Points.AddXY(i + 1, histogramaB[i]);
                    }
                    break;
            }
        }

        private int maiorValor(int[] hist)
        {
            for (int i = (hist.Length - 1); i >= 0; i--)
            {
                if (hist[i] != 0)
                    return i;
            }
            return 0;
        }

        private Bitmap equalizarImagem(Bitmap imagem)
        {
            histogramaR = new int[256];
            histAcumuladoR = new float[256];

            //Calcula histograma
            calcularHistograma(imagem, "P");
            //Cria o gráfico do histograma
            gerarGraficoHistograma("P");
 
            //Calcula histograma acumulado
            float aux = histAcumuladoR[0];
            for (int i = 1; i < histogramaR.Length; i++)
            {
                if (histogramaR[i] != 0)
                {
                    histAcumuladoR[i] = aux + ((float)histogramaR[i] / (imagem.Width * imagem.Height));
                    aux = histAcumuladoR[i];
                }
            }
  
            //Calcula mapa de cores
            int[] mapaCores = new int[256];
            int maior = maiorValor(histogramaR);
            for (int i = 0; i < histogramaR.Length; i++)
                mapaCores[i] = (int)(Math.Round(histAcumuladoR[i] * maior));



            //Equalizando imagem
            novaImg = new Bitmap(imagem.Width, imagem.Height);
            for (int m = 0; m < imagem.Width; m++)
            {
                for (int n = 0; n < imagem.Height; n++)
                {
                    pixel = imagem.GetPixel(m, n);
                    tomR = pixel.R;
                    novoTomR = mapaCores[tomR];
                    novaImg.SetPixel(m, n, Color.FromArgb(novoTomR, novoTomR, novoTomR));
                }
            }
            return novaImg;
        }

        private Bitmap equalizarImagemCores(Bitmap imagem)
        {
            histogramaR = new int[256];
            histogramaG = new int[256];
            histogramaB = new int[256];
            histAcumuladoR = new float[256];
            histAcumuladoG = new float[256];
            histAcumuladoB = new float[256];

            //Calcula histograma
            calcularHistograma(imagem, "RGB");
            //Define histogramas
            gerarGraficoHistograma("RGB");
  
            //Calcula histograma acumulado
            histAcumuladoR[0] = (float)histogramaR[0] / (imagem.Width * imagem.Height);
            histAcumuladoG[0] = (float)histogramaG[0] / (imagem.Width * imagem.Height);
            histAcumuladoB[0] = (float)histogramaB[0] / (imagem.Width * imagem.Height);
            float auxR = histAcumuladoR[0];
            float auxG = histAcumuladoG[0];
            float auxB = histAcumuladoB[0];
            for (int i = 1; i < 256; i++)
            {
                if (histogramaR[i] != 0)
                {
                    histAcumuladoR[i] = auxR + ((float)histogramaR[i] / (imagem.Width * imagem.Height));
                    auxR = histAcumuladoR[i];
                }
                if (histogramaG[i] != 0)
                {
                    histAcumuladoG[i] = auxG + ((float)histogramaG[i] / (imagem.Width * imagem.Height));
                    auxG = histAcumuladoG[i];
                }
                if (histogramaB[i] != 0)
                {
                    histAcumuladoB[i] = auxB + ((float)histogramaB[i] / (imagem.Width * imagem.Height));
                    auxB = histAcumuladoB[i];
                }
            }

            //Calcula mapa de cores
            mapaCoresR = new int[256];
            mapaCoresG = new int[256];
            mapaCoresB = new int[256];
            int maiorR = maiorValor(histogramaR);
            int maiorG = maiorValor(histogramaG);
            int maiorB = maiorValor(histogramaB);
            for (int i = 0; i < 256; i++)
            {
                mapaCoresR[i] = (int)(Math.Round(histAcumuladoR[i] * maiorR));
                mapaCoresG[i] = (int)(Math.Round(histAcumuladoG[i] * maiorG));
                mapaCoresB[i] = (int)(Math.Round(histAcumuladoB[i] * maiorB));
            }


            //Equalizando imagem
            novaImg = new Bitmap(imagem.Width, imagem.Height);
            for (int m = 0; m < imagem.Width; m++)
            {
                for (int n = 0; n < imagem.Height; n++)
                {
                    pixel = imagem.GetPixel(m, n);
                    tomR = pixel.R;
                    tomG = pixel.G;
                    tomB = pixel.B;
                    novoTomR = mapaCoresR[tomR];
                    novoTomG = mapaCoresG[tomG];
                    novoTomB = mapaCoresB[tomB];
                    novaImg.SetPixel(m, n, Color.FromArgb(novoTomR, novoTomG, novoTomB));
                }
            }
            return novaImg;
        }    
    }
}
