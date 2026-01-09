using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;

namespace Class_Gasslivery
{
    public class Printing
    {
        private StreamReader namaFile;
        private Font jenisFont;
        private float marginAtas;
        private float marginBawah;
        private float marginKanan;
        private float marginKiri;

        public StreamReader NamaFile { get => namaFile; set => namaFile = value; }
        public Font JenisFont { get => jenisFont; set => jenisFont = value; }
        public float MarginAtas { get => marginAtas; set => marginAtas = value; }
        public float MarginBawah { get => marginBawah; set => marginBawah = value; }
        public float MarginKanan { get => marginKanan; set => marginKanan = value; }
        public float MarginKiri { get => marginKiri; set => marginKiri = value; }

        public Printing()
        {
            JenisFont = new Font("Courier New", 10);
            NamaFile = new StreamReader("");
            MarginAtas = 30;
            MarginBawah = 30;
            MarginKanan = 30;
            MarginKiri = 30;
        }
        public Printing(Font pFont, string pFile, float pAtas, float pBawah, float pKanan, float pKiri)
        {
            JenisFont = pFont;
            NamaFile = new StreamReader(pFile);
            MarginAtas = pAtas;
            MarginBawah = pBawah;
            MarginKanan = pKanan;
            MarginKiri = pKiri;
        }

        public void Cetak(object sender, PrintPageEventArgs e)
        {
            float tinggiFont = JenisFont.GetHeight(e.Graphics);
            float x = MarginKiri;
            float y;
            int jumBarisSaatIni = 0;
            int maxBaris = (int)((e.MarginBounds.Height - MarginAtas - MarginBawah) / tinggiFont);
            string kalimat = NamaFile.ReadLine();
            while (jumBarisSaatIni < maxBaris && kalimat != null)
            {
                y = MarginAtas + (jumBarisSaatIni * tinggiFont);
                e.Graphics.DrawString(kalimat, JenisFont, Brushes.DarkRed, x, y);

                jumBarisSaatIni++;
                kalimat = NamaFile.ReadLine();
            }
            if (kalimat != null) e.HasMorePages = true;
            else e.HasMorePages = false;
        }

        public void KirimKePrinter()
        {
            PrintDocument p = new PrintDocument();
            p.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            p.PrintPage += new PrintPageEventHandler(Cetak);
            p.Print();
            NamaFile.Close();
        }
    }
}
