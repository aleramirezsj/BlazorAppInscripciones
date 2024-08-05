﻿using BlazorAppVSCode.Models.Inscripciones;

namespace BlazorAppVSCode.Interfaces
{
    public interface IDetalleInscripcionService : IGenericService<DetalleInscripcion>
    {
        public Task<List<DetalleInscripcion>?> GetByInscripcionAsync(int? id);
        public Task<bool> CheckDuplicadoDetalleInscripcionAsync(int?idDetalle, int? idInscripcion, int? idMateria);
    }
}
