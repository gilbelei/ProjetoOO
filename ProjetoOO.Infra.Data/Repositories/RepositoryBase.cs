using ProjetoOO.Domain.Interface.Repositories;
using ProjetoOO.Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;


namespace ProjetoOO.Infra.Data.Repositories
{
    /// <summary>
    /// Classe que é herdada de forma poliformica
    /// </summary>
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected ProjetoOoContext Db = new ProjetoOoContext();

        public void Add(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);
            Db.SaveChanges();
        }

        public TEntity GetById(int id)
        {
            return Db.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Db.Set<TEntity>().ToList();
        }

        public void Update(TEntity obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }

        /// <summary>
        /// Método em sobrecarga para exclusão de um registro
        /// </summary>
        /// <param name="obj">Objeto a ser excluído</param>
        public void Remove(TEntity obj)
        {
            Db.Set<TEntity>().Remove(obj);
            Db.SaveChanges();
        }

        /// <summary>
        /// Método em sobrecarga para exclusão de vários registros
        /// </summary>
        /// <param name="obj">Lista de objetos a serem excluídos</param>
        public void Remove(List<TEntity> obj)
        {
            foreach (TEntity item in obj)
            {
                Db.Set<TEntity>().Remove(item);
            }
            
            Db.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
