using Microsoft.EntityFrameworkCore;
using RegistroBlazor.DAL;
using RegistroBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroBlazor.BLL
{
    public class NotasBLL
    {
        public static bool Guardar(Notas notas)
        {
            if (!Existe(notas.notasId))//si no existe insertamos

                return Insertar(notas);
            else
                return Modificar(notas);

        }

        private static bool Insertar(Notas notas)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Notas.Add(notas);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;

            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }


        private static bool Modificar(Notas notas)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {

                contexto.Entry(notas).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var auxNotas = contexto.Notas.Find(id);
                if (auxNotas != null)
                {
                    contexto.Notas.Remove(auxNotas);//remueve la entidad
                    paso = contexto.SaveChanges() > 0;

                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static Notas Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Notas notas;

            try
            {
                notas = contexto.Notas.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return notas;

        }

        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Notas.Any(n => n.notasId == id);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return encontrado;

        }
    }
}
