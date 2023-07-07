using System;
using System.Collections.Generic;
using System.Text;

namespace Lab14C.Services
{
    public class AsignamentService
    {
        private readonly AppDbContext _context;

        public AsignamentService() => _context = App.GetContext();
    }
}
