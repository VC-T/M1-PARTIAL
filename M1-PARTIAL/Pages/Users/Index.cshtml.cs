using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using M1_PARTIAL.Data;
using M1_PARTIAL.Model;

namespace M1_PARTIAL.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly M1_PARTIAL.Data.M1_PARTIALContext _context;

        public IndexModel(M1_PARTIAL.Data.M1_PARTIALContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.User != null)
            {
                User = await _context.User.ToListAsync();
            }
        }
    }
}
