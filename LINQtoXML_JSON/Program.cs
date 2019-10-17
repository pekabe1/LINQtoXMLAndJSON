using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace LINQtoXMLAndJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library1 = new Library
            {
                AvalibleBooks = XMLData.GetBooksFromFile("BookFile.xml")
            };
            Library library2 = new Library
            {
                AvalibleBooks = JSONData.GetBooksFromFile("BookFile.xml")
            };
            Console.Read();
        }
    }
}


//Zadanie 4:
//Utwórz aplikację konsolową która umożliwia zapis odczyt i edycję zamówień na książki w bibliotece.

//Książka może mieć statusy:
//- dostępna
//- wypożyczona
//- zarezerwowana
//oprócz statusu ma id, nazwę i kategorię.
//Można wypożyczyć książkę jeśli jest dostępna lub zarezerwowana dla nas.
//Status ma:
//- stan
//- userName

//Napisz aplikację która trzyma dane w pliku txt, xml i json.Każdy rodzaj pliku obsługiwany jest przez inną klasę. Każda z tych klas musi mieć takie same metody.
//Każda klasa ma implementować IDisposable
//Każda książka ma kategorię która zaczyna się od nazwy i 4 cyfr.Np.DlaDzieci2345, lub Horrory0987 - ogranicz możliwość wprowadzania kategorii do takiej maski.
//Dobrze jeśli operacje CRUD będą dostępne w klasie generycznej (niekoniecznie).