using FirstCoreApp.Common;
using FirstCoreApp.IRepostory;
using FirstCoreModelApi.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreApp.Repository
{
    public class BookRepository:IBookRepository
    {
        private  CommonRepository _commonRepostory;
        public BookRepository(CommonRepository commonRepository)
        {
            _commonRepostory = commonRepository;
        }

        public string BookInsert(BooksInsert bookinsert)
        {
            var _book = new Books();
            string result = string.Empty;
            try
            {
                _book = new Books()
                {
                    Title = bookinsert.Title,
                    Description = bookinsert.Description,
                    Rate = bookinsert.Rate,
                    DateRead = bookinsert.DateRead ?? null,
                    CoverUrl = bookinsert.CoverUrl,
                    General = bookinsert.General,
                    IsRead= bookinsert.IsRead


                };
                _commonRepostory.books.Add(_book);
                _commonRepostory.SaveChanges();
            }
            catch (Exception ex)
            {
                result = ex.ToString();
                return result;
            }
            return result;
        }
       
        public List<Books>GetBooks()=> _commonRepostory.books.ToList();
        public Books  GetBooksId(Int32? Id)
        {     
               var  result = _commonRepostory.books.FirstOrDefault(x => x.Id == Id);
               return result;
        }
        public string BookUpdate(BooksUpdate bookupdate)
        {
            string result = string.Empty;
            Int32? id = bookupdate.Id;
            var books = _commonRepostory.books.FirstOrDefault(x => x.Id == id);
            if (books != null)
            {
                books.Title = bookupdate.Title;
                books.Description = bookupdate.Description;
                books.Rate = bookupdate.Rate;
                books.DateRead = bookupdate.DateRead;
                books.CoverUrl = bookupdate.CoverUrl;
                books.General = bookupdate.General;
                books.IsRead = bookupdate.IsRead;
                _commonRepostory.SaveChanges();
            }
            return result;
        }
        public string BookDelete(Int32? Id)
        {
            string result = string.Empty;
            var _books = _commonRepostory.books.FirstOrDefault(x => x.Id == Id);
            if (_books != null)
            {
                _commonRepostory.books.Remove(_books);
                _commonRepostory.SaveChanges();
                result = "Delete SuccessFully";
            }

            return result;

        }
    }
    
}
