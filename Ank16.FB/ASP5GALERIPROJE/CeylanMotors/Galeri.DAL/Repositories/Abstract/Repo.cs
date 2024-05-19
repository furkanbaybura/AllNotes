using Galeri.DAL.Data;
using Galeri.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri.DAL.Repositories.Abstract
{
    public class Repo<TEntity> : IRepo<TEntity> where TEntity : BaseEntity
    {
        protected GaleriDbContext _galeriDbContext;
        protected DbSet<TEntity> entities;

        public Repo(GaleriDbContext context)
        {
            _galeriDbContext = context;
            entities = _galeriDbContext.Set<TEntity>();
        }
        
    }
}
