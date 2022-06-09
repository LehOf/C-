using System;


namespace System
{
    static class StringExtensions
    {
        public static string Cut(this string thisOBJ, int Count)
        {
            if (thisOBJ.Length < Count) // SE MEU OBJ É DO MESMO TAMANHO OU MENOR QUE O QUE QUERO RECORTAR RETORNO ELE
            {
                return thisOBJ;
            }
            else
            {
                return thisOBJ.Substring(0, Count) + "..."; // RECORTANDO A STRING
            }
        }
    }