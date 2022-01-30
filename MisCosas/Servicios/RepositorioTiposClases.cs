using Dapper;
using Microsoft.Data.SqlClient;
using MisCosas.Models;

namespace MisCosas.Servicios
{
    public interface IRepositorioTiposCuentas
    {
        Task Crear(TipoCuenta tipocuenta);
        Task<bool> Existe(string nombre, int usuarioId);
    }
    public class RepositorioTiposCuentas : IRepositorioTiposCuentas
    {
        private readonly string connectionString;
        public RepositorioTiposCuentas(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task Crear(TipoCuenta tipocuenta)
        {
            using var connection = new SqlConnection(connectionString);
            var id = await connection.QuerySingleAsync<int>
                                                            (@"INSERT INTO TipoCuenta (Nombre, UsuarioId, Orden) Values (@Nombre, @UsuarioId, 0);
                                                            SELECT SCOPE_IDENTITY();", tipocuenta);
            tipocuenta.Id = id;
        }

        public async Task<bool> Existe(string nombre, int usuarioId)
        {
            using var connection = new SqlConnection(connectionString);
            var existe = await connection.QueryFirstOrDefaultAsync<int>
                                                            (@"SELECT 1 FROM TipoCuenta WHERE Nombre = @Nombre AND UsuarioId = @UsuarioId;", 
                                                            new {nombre, usuarioId});
            return existe == 1;
        }
    }
}
