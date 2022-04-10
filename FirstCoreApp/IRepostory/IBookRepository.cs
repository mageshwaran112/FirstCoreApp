using FirstCoreModelApi.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreApp.IRepostory
{
    interface IBookRepository
    {
        string BookInsert(BooksInsert bookinsert);
        List<Books> GetBooks();
        Books GetBooksId(Int32? Id);
        string BookUpdate(BooksUpdate bookupdate);
        string BookDelete(Int32? Id);
    }

}
