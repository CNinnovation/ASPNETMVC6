using Microsoft.AspNetCore.Mvc;
using MyFirstMVCApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstMVCApp.ViewComponents
{
    public class MyCoolViewComponent : ViewComponent
    {
        private readonly IBooksRepository _booksRepository;
        public MyCoolViewComponent(IBooksRepository booksRepository)
        {
            _booksRepository = booksRepository;
        }

        public Task<IViewComponentResult> InvokeAsync(string publisher)
        {
            var filteredBooks = _booksRepository.GetBooks().Where(b => b.Publisher == publisher);
            return Task.FromResult<IViewComponentResult>(View(filteredBooks));
        }
    }
}
