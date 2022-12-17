using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlightPlanLib
{
    public class FlightPlan
    {
            string ID; // identificador de vuelo
            string compañia;
            double velocidad; // En nudos (millas nauticas por hora)
            double IX; // Coordenadas del punto inicial en un espacio cartesiano. El punto (0,0) es la coordenada NordOeste
            double IY; // Aumentar X corresponde a moverse hacia el Este y aumentar Y es moverse al Sur
            // cada unidad es una milla nautica
            double FX; // Coordenadas del punto de destino
            double FY;
            double Xorigen;
            double Yorigen;
            double sin;
            double cos;

            public FlightPlan()
            {

            }

            public FlightPlan(string ID, string compañia, double velocidad, double IX, double IY, double FX, double FY)
            {
                this.ID = ID;
                this.compañia = compañia;
                this.velocidad = velocidad;
                this.IX = IX;
                this.IY = IY;
                this.FX = FX;
                this.FY = FY;
                this.Xorigen = IX;
                this.Yorigen = IY;
                double Hip = Math.Sqrt(Convert.ToDouble((FX - IX) * (FX - IX) + (FY - IY) * (FY - IY)));
                this.sin = (FY - IY) / Hip;
                this.cos = (FX - IX) / Hip;
            }


            //Sets y Gets
            public void SetID(string ID)
            {
                this.ID = ID;
            }

            public string GetID()
            {
                return this.ID;
            }

            public void SetCompañia(string compañia)
            {
                this.compañia = compañia;
            }

            public string GetCompañia()
            {
                return this.compañia;
            }

            public void SetVelocidad(double velocidad)
            {
                this.velocidad = velocidad;
            }

            public double GetVelocidad()
            {
                return this.velocidad;
            }

            public void SetIX(double IX)
            {
                this.IX = IX;
            }

            public double GetIX()
            {
                return this.IX;
            }

            public void SetFX(double FX)
            {
                this.FX = FX;
            }

            public double GetFX()
            {
                return this.FX;
            }

            public void SetIY(double IY)
            {
                this.IY = IY;
            }

            public double GetIY()
            {
                return this.IY;
            }

            public void SetFY(double FY)
            {
                this.FY = FY;
            }

            public double GetFY()
            {
                return this.FY;
            }

            public void SetXorigen(double Xorigen)
            {
                this.Xorigen = Xorigen;
            }
            
            public double GetXorigen()
            {
                return this.Xorigen;
            }
            public void SetYorigen(double Yorigen)
            {
                this.Yorigen = Yorigen;
            }
            public double GetYorigen()
            {
                return this.Yorigen;
            }

            public double getsin() {
                return this.sin;
            }
            public double getcos() {
                return this.cos;
            }


            public void CambiarVel(double vel)
            {
                this.velocidad = vel / 1000;
            }


            public bool HayConflicto(FlightPlan a, FlightPlan b, double seguridad)
            {

                if (a.distancia(b) < seguridad)
                {
                    return (true);
                }

                else
                {
                    return (false);
                }

            }
           


            public double distancia( FlightPlan b)
            // retorna la distancia entre los dos planes de vuelo
            {
                return Math.Sqrt((this.IX - b.IX) * (this.IX - b.IX) + (this.IY - b.IY) * (this.IY - b.IY));

            }


            public void MoverVuelo(FlightPlan plan, double tiempo)
            // Mueve el vuelo a la posición correspondiente a viajar durante el tiempo que se recibe como parámetro
            {
                //Calculamos la distancia recorrida en el tiempo dado
                double D = tiempo * plan.velocidad / 60;

                //Calculamos las razones trigonométricas
                double H = Math.Sqrt((plan.FX - plan.IX) * (plan.FX - plan.IX) + (plan.FY - plan.IY) * (plan.FY - plan.IY));

                if (H < D) 
                {
                    //me paso
                    plan.IX = plan.FX;
                    plan.IY = plan.FY;


                    double C = (plan.FX - plan.IX) / H;
                    double S = (plan.FY - plan.IY) / H;

                    //Caculamos la nueva posición del vuelo
                    plan.IX = plan.IX + D * C;
                    plan.IY = plan.IY + D * S;
                }
            }

            

        }
    }
