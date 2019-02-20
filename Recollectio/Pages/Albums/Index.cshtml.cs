using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Recollectio.Models;

namespace Recollectio.Pages.Albums
{
    public class IndexModel : PageModel
    {
        private readonly Recollectio.Models.AlbumContext _context;

        public IndexModel(Recollectio.Models.AlbumContext context)
        {
            _context = context;
        }

        public IList<Album> Album { get;set; }

        public async Task OnGetAsync()
        {
            Album = await _context.Album.ToListAsync();
        }
    }
}
