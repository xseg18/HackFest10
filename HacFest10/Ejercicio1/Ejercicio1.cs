using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HacFest10.Ejercicio1
{
    internal class Ejercicio1
    {
        List<Coordenada> coordenadas;
        List<Rectangulo> Rectangles;

        public Ejercicio1()
        {

        }

        private void LeerArchivo()
        {
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("~/data.txt");
                //Read the first line of text
                string line = sr.ReadLine();
                //Continue to read until you reach end of file
                List<int[]> format = new List<int[]>();
                while (line != null)
                {
                    List<int> listconvert = new List<int>();
                    line.Split(',').ToList().ForEach(x => listconvert.Add(Convert.ToInt32(x)));
                    format.Add(listconvert.ToArray());
                }
                //close the file
                sr.Close();
                foreach (int[] figure in format)
                {
                    if (Rectangles == null)
                    {
                        if (!figure.Any(x => x < 0))
                        {
                            Rectangles = new List<Rectangulo>
                            {
                                new Rectangulo(new Coordenada(figure[0], figure[1]), new Coordenada(figure[1], figure[2]))
                            };
                        }
                        else
                        {
                            Console.WriteLine("Archivo con número negativo");
                            break;
                        }
                    }
                    else
                    {
                        //primera coordenada
                        if (Rectangles.Any(x => figure[0] >= x.coordenada1.cX && figure[0] <= x.coordenada2.cX))
                        {
                            var rects = Rectangles.Where(x => figure[0] >= x.coordenada1.cX && figure[0] <= x.coordenada2.cX);
                            foreach (var rect in rects)
                            {
                                if (Rectangles.Any(x => figure[3] >= x.coordenada1.cY && figure[3] <= x.coordenada2.cY))
                                {

                                }
                            }
                        }

                    }
                }
            } catch (Exception ex)
            {
                Console.WriteLine("Archivo incorrecto " + ex.Message);
            }
        }
        private List<int> Areas(List<int[]> rectangles)
        {
            List<int> areas = new List<int>();
            foreach (int[] rectangle in rectangles)
            {
                if (rectangle[0] >= 0 && rectangle[2] >= 0)
                {
                    int arista1 = rectangle[2] - rectangle[0];
                    if (rectangle[1] >= 0 && rectangle[3] >= 0)
                    {
                        int arista2 = rectangle[3] - rectangle[1];
                        int area = arista1 * arista2;
                        areas.Add(area);
                    }
                }

            }
            return areas;
        }
    
    }
}
