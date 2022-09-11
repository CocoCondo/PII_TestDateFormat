using TestDateFormat;
namespace Library.Tests;

[TestFixture]
public class DataFormatterTests
{
    [Test]
    public void IsDateEmpty() //Testeo que no esté vacío
    {
        const string date = "25/12/1955"; 
        string coso = DateFormatter.ChangeFormat(date);
        Assert.IsNotNull(coso);
    }

    [Test]
    public void IsDateFormatCorrect() //Testeo con un valor correcto
    {
        const string date = "25/12/1999";
        string coso = DateFormatter.ChangeFormat(date);
        const string expected = "1999-12-25";
        Assert.AreEqual(expected, coso);
    }

    [Test]
    public void IsDateFormatIncorrect() //Testeo con un valor incorrecto
    {
        const string date = "25-12/1999";
        string coso = DateFormatter.ChangeFormat(date);
        const string expected = "1999-12-25";
        Assert.AreEqual(expected, coso); //Me devuelve lo que puse que en la clase DateFormatter devolviera si el formato introducido está mal
    }
}