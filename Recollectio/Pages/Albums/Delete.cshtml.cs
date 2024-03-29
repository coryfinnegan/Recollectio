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
    public class DeleteModel : PageModel
    {
        private readonly Recollectio.Models.AlbumContext _context;

        public DeleteModel(Recollectio.Models.AlbumContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Album Album { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Album = await _context.Album.FirstOrDefaultAsync(m => m.Id == id);

            if (Album == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Album = await _context.Album.FindAsync(id);

            if (Album != null)
            {
                _context.Album.Remove(Album);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
