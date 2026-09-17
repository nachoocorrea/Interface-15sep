//------------------------------------------------------------------------------
// <copyright file="Repository.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System;
using System.Collections;

namespace Ucu.Poo.Repositories
{
    /// <summary>
    /// Esta clase representa un repositorio genérico de elementos.
    /// </summary>
    /// <typeparam name="T">El tipo de elementos almacenados.</typeparam>
    public class Repository<T>
    {
        private ArrayList items = new ArrayList();

        /// <summary>
        /// Agrega un elemento al repositorio.
        /// </summary>
        /// <param name="item">El elemento a agregar.</param>
        public void Add(T item)
        {
            if (item != null)
            {
                this.items.Add(item);
            }
        }

        /// <summary>
        /// Elimina un elemento del repositorio.
        /// </summary>
        /// <param name="item">El elemento a eliminar.</param>
        public void Remove(T item)
        {
            this.items.Remove(item);
        }

        /// <summary>
        /// Busca un elemento que cumpla con un criterio específico.
        /// </summary>
        /// <param name="criteria">El criterio por el cual buscar.</param>
        /// <returns>
        /// El elemento encontrado o el valor predeterminado si no se encuentra.
        /// </returns>
        public T Find(Predicate<T> criteria)
        {
            foreach (T item in this.items)
            {
                if (criteria(item))
                {
                    return item;
                }
            }

            return default(T);
        }
    }
}