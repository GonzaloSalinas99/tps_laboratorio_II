using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Formularios
{
    public class Reloj
    {

        int hora;
        int minuto;
        int segundo;

        public delegate void NotificadorCambioTiempo(Reloj reloj);
        public event NotificadorCambioTiempo SegundoCambiado;

        public void Iniciar()
        {
            Task.Run(() =>
            {

                while (true)
                {

                    DateTime dt = DateTime.Now;
                    Thread.Sleep(10);


                    if (dt.Second != segundo)
                    {

                        if (SegundoCambiado is not null)
                        {
                            SegundoCambiado(this);
                        }
                    }
                    hora = dt.Hour;
                    minuto = dt.Minute;
                    segundo = dt.Second;
                }

            });



        }
        public override string ToString()
        {
            return $"{hora} : {minuto} : {segundo}";
        }

    }
}
