using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Adquisiciones.Business
{
    /// <summary>
    /// Descripción breve de aletras.
    /// </summary>
    public class Aletras
    {
        public Aletras()
        {
            //
            // TODO: agregar aquí la lógica del constructor
            //
        }

        public string Letras(string numero)
        {
            //********Declara variables de tipo cadena************
            string palabras = string.Empty, entero = string.Empty, dec = string.Empty, flag = string.Empty, strComparacion = string.Empty;


            //**********Valida cuando es cero*************
            if (numero == "0")
                return "CERO PESOS 00/100 M.N";


            //********Declara variables de tipo entero***********
            int num = 0, x = 0, y = 0;

            flag = "N";

            //**********Número Negativo***********
            if (numero.Substring(0, 1) == "-")
            {

                numero = numero.Substring(1, numero.Length - 1).ToString();
                palabras = "menos ";
            }

            //**********Si tiene ceros a la izquierda*************
            for (x = 1; x <= numero.Length; x++)
            {
                if (numero.Substring(0, 1) == "0")
                {
                    numero = numero.Substring(1, numero.Length - 1).ToString();
                    if (numero.Length == 0)
                        palabras = string.Empty;
                }
                else
                {
                    break;
                }
            }

            //*********Dividir parte entera y decimal************
            for (y = 0; y <= numero.Length - 1; y++)
            {

                if (numero.Substring(y, 1) == ".")
                {
                    flag = "S";
                }
                else
                {
                    if (flag == "N")
                        entero = entero + numero.Substring(y, 1);
                    else
                        dec = dec + numero.Substring(y, 1);
                }
            }

            if (dec.Length == 1)
                dec = dec + "0";

            //**********proceso de conversión***********
            flag = "N";

            if (Convert.ToDouble(numero) <= 999999999)
            { //Inicio del if principal
                for (y = entero.Length; y >= 1; y--)
                {	//Inicio de For
                    num = entero.Length - (y);
                    switch (y)
                    {
                        case 3:
                            strComparacion = "A";
                            break;
                        case 6:
                            strComparacion = "A";
                            break;
                        case 9:
                            strComparacion = "A";
                            break;
                        case 2:
                            strComparacion = "B";
                            break;
                        case 5:
                            strComparacion = "B";
                            break;
                        case 8:
                            strComparacion = "B";
                            break;
                        case 1:
                            strComparacion = "C";
                            break;
                        case 4:
                            strComparacion = "C";
                            break;
                        case 7:
                            strComparacion = "C";
                            break;
                    }

                    switch (strComparacion)
                    {
                        case "A":
                            {
                                //**********Asigna las palabras para las centenas***********
                                switch (entero.Substring(num, 1))
                                {
                                    case "1":
                                        if (entero.Substring(num + 1, 1) == "0" && entero.Substring(num + 2, 1) == "0")
                                            palabras = palabras + "CIEN ";
                                        else
                                            palabras = palabras + "CIENTO ";
                                        break;
                                    case "2":
                                        palabras = palabras + "DOSCIENTOS ";
                                        break;
                                    case "3":
                                        palabras = palabras + "TRESCIENTOS ";
                                        break;
                                    case "4":
                                        palabras = palabras + "CUATROCIENTOS ";
                                        break;
                                    case "5":
                                        palabras = palabras + "QUINIENTOS ";
                                        break;
                                    case "6":
                                        palabras = palabras + "SEISCIENTOS ";
                                        break;
                                    case "7":
                                        palabras = palabras + "SETECIENTOS ";
                                        break;
                                    case "8":
                                        palabras = palabras + "OCHOCIENTOS ";
                                        break;
                                    case "9":
                                        palabras = palabras + "NOVECIENTOS ";
                                        break;
                                }// Se cierra el Switch del caso 3
                                break;
                            }// Fin del caso 3

                        case "B":
                            {
                                //*********Asigna las palabras para las decenas************
                                switch (entero.Substring(num, 1))
                                {
                                    case "1":
                                        if (entero.Substring(num + 1, 1) == "0")
                                        {
                                            flag = "S";
                                            palabras = palabras + "DIEZ ";
                                        }
                                        if (entero.Substring(num + 1, 1) == "1")
                                        {
                                            flag = "S";
                                            palabras = palabras + "ONCE ";
                                        }
                                        if (entero.Substring(num + 1, 1) == "2")
                                        {
                                            flag = "S";
                                            palabras = palabras + "DOCE ";
                                        }
                                        if (entero.Substring(num + 1, 1) == "3")
                                        {
                                            flag = "S";
                                            palabras = palabras + "TRECE ";
                                        }
                                        if (entero.Substring(num + 1, 1) == "4")
                                        {
                                            flag = "S";
                                            palabras = palabras + "CATORCE ";
                                        }
                                        if (entero.Substring(num + 1, 1) == "5")
                                        {
                                            flag = "S";
                                            palabras = palabras + "QUINCE ";
                                        }
                                        if (Convert.ToInt32(entero.Substring(num + 1, 1)) > 5)
                                        {
                                            flag = "N";
                                            palabras = palabras + "DIEZ Y ";
                                        }
                                        break;
                                    case "2":
                                        if (entero.Substring(num + 1, 1) == "0")
                                        {
                                            palabras = palabras + "VEINTE ";
                                            flag = "S";
                                        }
                                        else
                                        {
                                            palabras = palabras + "VEINTI";
                                            flag = "N";
                                        }
                                        break;
                                    case "3":
                                        if (entero.Substring(num + 1, 1) == "0")
                                        {
                                            palabras = palabras + "TREINTA ";
                                            flag = "S";
                                        }
                                        else
                                        {
                                            palabras = palabras + "TREINTA Y ";
                                            flag = "N";
                                        }
                                        break;
                                    case "4":
                                        if (entero.Substring(num + 1, 1) == "0")
                                        {
                                            palabras = palabras + "CUARENTA ";
                                            flag = "S";
                                        }
                                        else
                                        {
                                            palabras = palabras + "CUARENTA Y ";
                                            flag = "N";
                                        }
                                        break;
                                    case "5":
                                        if (entero.Substring(num + 1, 1) == "0")
                                        {
                                            palabras = palabras + "CINCUENTA ";
                                            flag = "S";
                                        }
                                        else
                                        {
                                            palabras = palabras + "CINCUENTA Y ";
                                            flag = "N";
                                        }
                                        break;
                                    case "6":
                                        if (entero.Substring(num + 1, 1) == "0")
                                        {
                                            palabras = palabras + "SESENTA ";
                                            flag = "S";
                                        }
                                        else
                                        {
                                            palabras = palabras + "SESENTA Y ";
                                            flag = "N";
                                        }
                                        break;
                                    case "7":
                                        if (entero.Substring(num + 1, 1) == "0")
                                        {
                                            palabras = palabras + "SETENTA ";
                                            flag = "S";
                                        }
                                        else
                                        {
                                            palabras = palabras + "SETENTA Y ";
                                            flag = "N";
                                        }
                                        break;
                                    case "8":
                                        if (entero.Substring(num + 1, 1) == "0")
                                        {
                                            palabras = palabras + "OCHENTA ";
                                            flag = "S";
                                        }
                                        else
                                        {
                                            palabras = palabras + "OCHENTA Y ";
                                            flag = "N";
                                        }
                                        break;
                                    case "9":
                                        if (entero.Substring(num + 1, 1) == "0")
                                        {
                                            palabras = palabras + "NOVENTA ";
                                            flag = "S";
                                        }
                                        else
                                        {
                                            palabras = palabras + "NOVENTA Y ";
                                            flag = "N";
                                        }
                                        break;
                                }//Fin del switch
                                break;

                            }//FIN Case 2

                        case "C":
                            {
                                //*********Asigna las palabras para las unidades*********
                                switch (entero.Substring(num, 1))
                                {
                                    case "1":
                                        if (flag == "N")
                                        {
                                            //if (y == 1)
                                            palabras = palabras + "UN ";
                                        }
                                        else
                                        {
                                            if (entero.Substring(entero.Length - 2, 2) != "11")
                                                palabras = palabras + "UN ";
                                        }
                                        break;
                                    case "2":
                                        if (flag == "N")
                                            palabras = palabras + "DOS ";
                                        break;
                                    case "3":
                                        if (flag == "N")
                                            palabras = palabras + "TRES ";
                                        break;
                                    case "4":
                                        if (flag == "N")
                                            palabras = palabras + "CUATRO ";
                                        break;
                                    case "5":
                                        if (flag == "N")
                                            palabras = palabras + "CINCO ";
                                        break;
                                    case "6":
                                        if (flag == "N")
                                            palabras = palabras + "SEIS ";
                                        break;
                                    case "7":
                                        if (flag == "N")
                                            palabras = palabras + "SIETE ";
                                        break;
                                    case "8":
                                        if (flag == "N")
                                            palabras = palabras + "OCHO ";
                                        break;
                                    case "9":
                                        if (flag == "N")
                                            palabras = palabras + "NUEVE ";
                                        break;
                                }//Fin del switch caso 1
                                break;
                            }//Fin del Case 1
                    }//Fin switch principal y
                    //***********Asigna la palabra mil***************
                    if (y == 4)
                    {
                        ////							if (entero.Substring(5, 1) != "0" || entero.Substring(4, 1) != "0" || entero.Substring(3, 1) != "0" || (entero.Substring(5, 1) == "0" && entero.Substring(4, 1) == "0" && entero.Substring(3, 1) == "0" && entero.Length  <= 5))
                        if (entero.Substring(3, 1) != "0" || (entero.Substring(3, 1) == "0" && entero.Length <= 5))
                        {

                            if (entero.Substring(0, 1) == "1" && entero.Substring(1, 1) == "0" && entero.Substring(2, 1) == "0" && entero.Substring(3, 1) == "0")
                            {
                                // Se asigna para cuando es 1000
                                palabras = palabras + "UN MIL ";
                            }
                            else
                            {
                                palabras = palabras + "MIL ";
                            }
                        }


                    }

                    //**********Asigna la palabra millón*************
                    if (y == 7)
                    {
                        if (entero.Length == 7 && entero.Substring(0, 1) == "1")
                            palabras = palabras + " UN MILLÓN ";
                        else
                            palabras = palabras + "MILLONES ";
                    }
                }//Fin del For
                //**********Une la parte entera y la parte decimal*************
                if (dec != string.Empty)
                    return palabras + " PESOS " +  (dec.Length > 2?dec.Substring(0,2):dec) + " /100 M.N.";
                else
                    return palabras + " PESOS 00/100 M.N";
            }//Fin del if principal
            else
                return "";
        } // Fin del funcion
    }

    
}
