namespace TestDateFormat;

/// <summary>
/// Esta clase implementa la funcionalidad de cambiar el formato de una fecha.
/// </summary>
public class DateFormatter
{

    /// <summary>
    /// Cambia el formato de la fecha que se recibe como argumento. La fecha que se recibe como argumento se asume en
    /// formato "dd/mm/yyyy" y se retorna en formato "yyyy-mm-dd". No se controla que la fecha recibida tenga el formato
    /// asumido.
    /// </summary>
    /// <param name="date">Una fecha en formato "dd/mm/yyyy".</param>
    /// <returns>La fecha convertida al formato "yyyy-mm-dd".</returns>
    public static string ChangeFormat(string date)
    {                                                               //Creo una serie de booleanos que chequeen si:
        bool IsNull = string.IsNullOrEmpty(date);                   //date está vacio
        bool barra = date[2] == '/' && date[5] == '/';              //En la 3ra y 6ta posición haya una /
        bool sub1 = int.TryParse(date.Substring(6, 4), out int n1); //Desde la 6ta posición hayan enteros por 4 lugares
        bool sub2 = int.TryParse(date.Substring(3, 2), out int n2); //Desde la 4ta posición hayan entero por 2 lugares
        bool sub3 = int.TryParse(date.Substring(0, 2), out int n3); //Desde la primer posición hayan entero por 2 lugares
        if (!IsNull && barra && sub1 && sub2 && sub3)               //Si todo esto es correcto, quiere decir que el formato introducido está bien
        {
            return date.Substring(6) + "-" + date.Substring(3, 2) + "-" + date.Substring(0, 2); //Por lo que devuelvo la fecha formateada
        }
        else
        {
            return "Formato Incorrecto"; //Sino devuelvo un string que diga formato incorrecto
        }
    }
}
