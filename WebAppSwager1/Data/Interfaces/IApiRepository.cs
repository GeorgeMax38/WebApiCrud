﻿using WebAppSwager1.Models;

namespace WebAppSwager1.Data.Interfaces
{
    public interface IApiRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T: class;
        Task<bool> SaveAll();
        Task<IEnumerable<Usuario>> GetUsuariosAsync();
        Task<Usuario> GetUsuariosByIdAsync(int id);
        Task<Usuario> GetUsuariosByNombreAsync(string nombre);
        Task<IEnumerable<Producto>> GetProductosAsync();
        Task<Producto> GetProductosByIdAsync(int id);
        Task<Producto> GetProductosByNombreAsync(string nombre);
    }
}
