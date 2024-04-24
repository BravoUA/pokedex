using Microsoft.AspNetCore.Mvc.RazorPages;

namespace pokedex.Models
{
    public class Page
    {
        public int CurrentPage { get; private set; } 
        public int PageSize { get; private set; } 
        public int TotalItems { get; private set; }
        public int StartPage { get; private set; }
        public int TotalPages { get; private set; }
        public int EndPage { get; private set; }

        public Page() { }

        public Page(int totalItems,int page, int pageSize = 10 ) {

        int totalPages =  (int)Math.Ceiling((decimal)totalItems / pageSize); 
        int currentPage = page;
        int startPage = currentPage - 5;
        int endPage = currentPage + 4;

            if (startPage <= 0)
            {
                endPage = endPage - (startPage - 1);
                startPage = 1;
            }
            if (endPage > totalPages)
            {
                endPage = totalPages;
                CurrentPage = currentPage;
                PageSize = pageSize;
                TotalPages = totalPages;
                StartPage = startPage;
                EndPage = endPage;
            }

        }


    }
}
