using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlightPlanLib
{
    public class ListaFlightPlan
    {

        List<FlightPlan> FPList = new List<FlightPlan>();

        public void Pon(FlightPlan fp)
        {
            FPList.Add(fp);
        }

        double dist;
        double tiempo;

        public void SetDistSeg(double dist)
        {
            this.dist = dist;
        }
        public void SetTiempo(double tiempo)
        {
            this.tiempo = tiempo;
        }
        public double GetDistSeg()
        {
            return this.dist;
        }
        public double GetTiempo()
        {
            return this.tiempo;
        }

        public FlightPlan GetFP(int i)
        {
            return FPList[i];
        }

        public int DameNum()
        {
            return FPList.Count;
        }

        public void MoverVuelo(double tiempo)
        // Mueve el vuelo a la posición correspondiente a viajar durante el tiempo que se recibe como parámetro
        {
            for (int i = 0; i < this.DameNum(); i++)
            {
                //Calculamos la distancia recorrida en el tiempo dado
                double D = tiempo * this.FPList[i].GetVelocidad() / 60;

                //Comprobar que no me paso

                //Calculamos las razones trigonométricas
                double H = Math.Sqrt((this.FPList[i].GetFX() - this.FPList[i].GetIX()) * (this.FPList[i].GetFX() - this.FPList[i].GetIX()) + (this.FPList[i].GetFY() - this.FPList[i].GetIY()) * (this.FPList[i].GetFY() - this.FPList[i].GetIY()));
                if (H < D)
                {
                    //Me paso
                    this.FPList[i].SetIX(this.FPList[i].GetFX());
                    this.FPList[i].SetIY(this.FPList[i].GetFY());
                }
                else
                {
                    double C = (this.FPList[i].GetFX() - this.FPList[i].GetIX()) / H;
                    double S = (this.FPList[i].GetFY() - this.FPList[i].GetIY()) / H;

                    //Caculamos la nueva posición del vuelo
                    this.FPList[i].SetIX(this.FPList[i].GetIX() + D * C);
                    this.FPList[i].SetIY(this.FPList[i].GetIY() + D * S);
                }
            }
        }

        public FlightPlan Dame(int i)
        {
            return this.FPList[i];
        }


        public bool hayconflicto2()
        {
            bool conflict = false;
            int cont = 0;
            while (conflict==false && cont<FPList.Count)
            {
                
                while (cont < FPList.Count && conflict == false)
                {
                    int cont2 = cont + 1;
                    while (cont2 < FPList.Count && conflict == false)
                    {
                        conflict = FPList[cont].HayConflicto(FPList[cont], FPList[cont2], this.dist);
                        
                        cont2 += 1;

                    }
                    cont += 1;
                }
                
            }
            
            return (conflict);
            

        }

        public int willbeinconflict(double dist)   //Hacemos la derivada para anticipar el conflicto!! 
        {

            if (this.FPList.Count > 1)
            {

                int cont = 0;
                int firstconflict = -1;
                bool conflicto = false;
                while (cont < this.FPList.Count && conflicto == false)
                {
                    int cont2 = 0;
                    while (cont2 < cont && conflicto == false)
                    {
                        double a = 2 * this.FPList[cont2].GetIX() * this.FPList[cont2].GetVelocidad() * this.FPList[cont2].getcos();
                        double b = (-2) * this.FPList[cont2].GetIX() * this.FPList[cont].GetVelocidad() * this.FPList[cont].getcos();
                        double c = (-2) * this.FPList[cont].GetIX() * this.FPList[cont2].GetVelocidad() * this.FPList[cont2].getcos();
                        double d = 2 * this.FPList[cont].GetIX() * this.FPList[cont].GetVelocidad() * this.FPList[cont].getcos();
                        double e = 2 * this.FPList[cont2].GetIY() * this.FPList[cont2].GetVelocidad() * this.FPList[cont2].getsin();
                        double f = (-2) * this.FPList[cont].GetIY() * this.FPList[cont2].GetVelocidad() * this.FPList[cont2].getsin();
                        double g = 2 * this.FPList[cont].GetIY() * this.FPList[cont].GetVelocidad() * this.FPList[cont].getsin();
                        double h = (-2) * this.FPList[cont2].GetIY() * this.FPList[cont].GetVelocidad() * this.FPList[cont].getsin();
                        double i = 2 * (this.FPList[cont2].GetVelocidad()) * (this.FPList[cont2].GetVelocidad());
                        double j = 2 * (this.FPList[cont].GetVelocidad()) * (this.FPList[cont].GetVelocidad());
                        double k = (-4) * this.FPList[cont].GetVelocidad() * this.FPList[cont2].GetVelocidad() * this.FPList[cont].getcos() * this.FPList[cont2].getcos();
                        double l = (-4) * this.FPList[cont].GetVelocidad() * this.FPList[cont2].GetVelocidad() * this.FPList[cont].getsin() * this.FPList[cont2].getsin();

                        double a1 = this.FPList[cont2].GetIX() * this.FPList[cont2].GetIX();
                        double a2 = this.FPList[cont].GetIX() * this.FPList[cont].GetIX();
                        double a3 = this.FPList[cont2].GetIY() * this.FPList[cont2].GetIY();
                        double a4 = this.FPList[cont].GetIY() * this.FPList[cont].GetIY();
                        double a5 = -2 * this.FPList[cont2].GetIY() * this.FPList[cont].GetIY();
                        double a6 = -2 * this.FPList[cont2].GetIX() * this.FPList[cont].GetIX();

                        double tiempo = (-1) * ((a + b + c + d + e + f + g + h) / (i + j + k + l));
                        

                        double dis2 = tiempo * (a + b + c + d + e + f + g + h) + ((tiempo * tiempo) / 2) * (i + j + k + l) + a1 + a2 + a3 + a4 + a5 + a6;

                        double dis = Math.Sqrt(Convert.ToDouble(dis2));
                        if (dist > dis)
                        {
                            firstconflict = cont2;
                            conflicto = true;
                        }

                        cont2++;
                    }
                    cont2 = cont + 1;
                    while (cont2 < this.FPList.Count && conflicto == false)
                    {
                        double a = 2 * this.FPList[cont2].GetIX() * this.FPList[cont2].GetVelocidad() * this.FPList[cont2].getcos();
                        double b = (-2) * this.FPList[cont2].GetIX() * this.FPList[cont].GetVelocidad() * this.FPList[cont].getcos();
                        double c = (-2) * this.FPList[cont].GetIX() * this.FPList[cont2].GetVelocidad() * this.FPList[cont2].getcos();
                        double d = 2 * this.FPList[cont].GetIX() * this.FPList[cont].GetVelocidad() * this.FPList[cont].getcos();
                        double e = 2 * this.FPList[cont2].GetIY() * this.FPList[cont2].GetVelocidad() * this.FPList[cont2].getsin();
                        double f = (-2) * this.FPList[cont].GetIY() * this.FPList[cont2].GetVelocidad() * this.FPList[cont2].getsin();
                        double g = 2 * this.FPList[cont].GetIY() * this.FPList[cont].GetVelocidad() * this.FPList[cont].getsin();
                        double h = (-2) * this.FPList[cont2].GetIY() * this.FPList[cont].GetVelocidad() * this.FPList[cont].getsin();
                        double i = 2 * (this.FPList[cont2].GetVelocidad()) * (this.FPList[cont2].GetVelocidad());
                        double j = 2 * (this.FPList[cont].GetVelocidad()) * (this.FPList[cont].GetVelocidad());
                        double k = (-4) * this.FPList[cont].GetVelocidad() * this.FPList[cont2].GetVelocidad() * this.FPList[cont].getcos() * this.FPList[cont2].getcos();
                        double l = (-4) * this.FPList[cont].GetVelocidad() * this.FPList[cont2].GetVelocidad() * this.FPList[cont].getsin() * this.FPList[cont2].getsin();

                        double a1 = this.FPList[cont2].GetIX() * this.FPList[cont2].GetIX();
                        double a2 = this.FPList[cont].GetIX() * this.FPList[cont].GetIX();
                        double a3 = this.FPList[cont2].GetIY() * this.FPList[cont2].GetIY();
                        double a4 = this.FPList[cont].GetIY() * this.FPList[cont].GetIY();
                        double a5 = -2 * this.FPList[cont2].GetIY() * this.FPList[cont].GetIY();
                        double a6 = -2 * this.FPList[cont2].GetIX() * this.FPList[cont].GetIX();

                        double tiempo = (-1) * ((a + b + c + d + e + f + g + h) / (i + j + k + l));
                        

                        double dis2 = tiempo * (a + b + c + d + e + f + g + h) + ((tiempo * tiempo) / 2) * (i + j + k + l) + a1 + a2 + a3 + a4 + a5 + a6;

                        double dis = Math.Sqrt(Convert.ToDouble(dis2));
                        if (dist > dis)
                        {
                            firstconflict = cont2;
                            conflicto = true;
                        }

                        cont2++;
                    }

                    cont++;
                }
                return firstconflict;


            }
            else
                return -1;
        }
    }
}
