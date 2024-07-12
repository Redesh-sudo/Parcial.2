// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization.Formatters;

class Parcial
{
    static void Main(string[] args)
    {

        Console.WriteLine("lista de partidos:Panama 2024");
        Console.WriteLine("");

        // PARTIDOS DE PANAMÄ
        List<string> partidos = new List<string>();

        partidos.Add("PRD");
        partidos.Add("Partido Popular");
        partidos.Add("Morilena");
        partidos.Add("Partido Panameñista");
        partidos.Add("Cambio Democratico");
        partidos.Add("FAD");
        partidos.Add("Partido Alianza");
        partidos.Add("Libre Postulación Color Celeste ");
        partidos.Add("Libre Postulación Color Verde ");

        // VOTOS POR PARTIDO
        List<double> votos = new List<double>();
        votos.Add(41000);
        votos.Add(4000);
        votos.Add(7000);
        votos.Add(12000);
        votos.Add(30000);
        votos.Add(4000);
        votos.Add(3000);
        votos.Add(30000);
        votos.Add(9000);

        var combine = partidos.Zip(votos, (partido, votos) => new { Partido = partido, Votos = votos });

        foreach (var item in combine)
        {
            Console.WriteLine("{0}: {1:F2}", item.Partido, "N° de votos:" + item.Votos);
        }

        Console.WriteLine("");
        Console.WriteLine("");


        Console.WriteLine("Cociente:20000");
        Console.WriteLine("");
        // CREAR LISTA PARA ALMACENAR EL VALOR DE COCIENTE 
        List<double> cocientes = new();

        // LISTA PARA ALMACENAR EL VALOR DEL COCIENTE POR PARTIDO 
        List<double> cocientes_partido = new List<double>();

        // OBTENIENDO EL VALOR DE 20000 DE VOTOS ENTRE LA CANTIDAD DE DIPUTADOS
        double resultado = 140000 / 7;
        cocientes.Add(resultado);



        foreach (var cd in cocientes_partido)
        {
            Console.WriteLine(cd);
        }
        // DIVIDIENDO LOS VOTOS DE LOS PARTIDOS POR EL COCIENTE VOTOS/ 200000
        for (int i = 0; i < votos.Count; i++)
             {
            double votos_i = (double)(int)votos[i];
            votos[i] = votos_i / resultado;
            cocientes_partido.Add(votos_i / resultado);
             }


        // IMPRIMIR LOS PARTIDOS CON EL COCIENTE
        foreach (var ite in combine)
               {
                   Console.WriteLine("{0}: {1:F2}", ite.Partido, ite.Votos);

                }

        Console.WriteLine("");
        Console.WriteLine("Partidos que presentan diputados por cociente ");
        // IMPRIMIR LOS PARTIDOS QUE PRESENTAN DIPUTADOS 
       
        // Lista para almacenar los partidos que participan por el medio cociente 
        List<double> part_cociente = new List<double>();

        // Lista  para partidos con diputados 
        List<double> coci = new List<double>();

        foreach ( var  co in cocientes_partido )
        {
            if (co < 1.0) {

                part_cociente.Add(co);

        } 
                    else
                        {
                         coci.Add(co);
                        }
            
        }

        // Los nuevos datos de la lista de partidos con cociente para diputados
        List<string> list = new List<string>();
        List<string> list2= new List<string>();
        foreach (var nombre in partidos )  
        {
                  if (nombre == "PRD") 
                  {
             
                      list.Add(nombre);

                   }
                      else if (nombre =="Cambio Democratico")
                      {
                                list.Add(nombre);
                      }
                            else if (nombre == "Libre Postulación Color Celeste ")
                            {
                                list.Add(nombre);
                            }
                                    else
                                    {
                                             list2.Add(nombre);
                                    }
        }

        var combin =list.Zip(coci, (list, coci) => new { list= list, coci=coci });

        foreach ( var comb in combin )
        {
                         Console.WriteLine("{0}: {1:F2}",comb.list, comb.coci);
        }

        
                         Console.WriteLine("");
                         Console.WriteLine("");


        // LA CANTIDAD DE MEDIO COCIENTE= COCIENTE / 2 
                                     List<string> list3 = new List<string>();
                                     List<string> list4 = new List<string>();
                                     List<int> mediocociente = new List<int>();
        int medio = 20000 / 2;
        Console.WriteLine("Medio Cociente:" + medio);


        foreach (var con in list2 )
        {
               if (con == "Partido Panameñista")
                 {

                  list3.Add(con);

                  }
                   else
                      {
                        list4.Add(con);

                      }
        }

        List<double> coci2 = new List<double>();
        List<double> coci3 = new List<double>();
        foreach ( var coni in part_cociente )
        {
            if (coni >= 0.6)
               {
                coci2.Add(coni);
                }
                 else
                {

                  coci3.Add(coni);
                 }
           
        }


        var combinee = list2.Zip(part_cociente, (list2, part_cociente) => new { list2 = list2, part_cociente = part_cociente });

        foreach ( var con in combinee )
                   {

                     Console.WriteLine("{0}: {1:F2}", con.list2, con.part_cociente);

                    }
                     Console.WriteLine("");

                     Console.WriteLine("Partidos que presentan diputados por mediocociente: ");

        var medi = list3.Zip(coci2, (list3, coci2) => new { list3 = list3, coci2 = coci2 });


        foreach (var con in medi)
                   {

                      Console.WriteLine("{0}: {1:F2}", con.list3, con.coci2);

                    }

                      Console.WriteLine("");

                      Console.WriteLine("Residuo");

                      Console.WriteLine("Partidos que presentan diputados por residuo:");

        List<string> list5 = new List<string>();
        List<double> coci4 = new List<double>();
        foreach ( var con in coci3 )
        {

          if (con >0.21)
            {
               coci4.Add(con);
            }

        }
        
        foreach ( var con in list4)

        {
            if (con == " Morilena")
            {
                list5.Add(con);
            }
               else if (con == "Libre Postulación Color Verde")
               {

                list5.Add(con);

                }
        }

        var residuo = list4.Zip(coci4, (list5, coci4) => new { list5 = list5, coci4 = coci4 });

        foreach (var con in residuo)
           {

            Console.WriteLine("{0}: {1:F2}", con.list5, con.coci4);
           }
    }

}
















 