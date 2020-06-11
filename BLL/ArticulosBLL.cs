using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Parcial1_Ap2_JuanDeDiosFernandezCamilo.Dal;
using Parcial1_Ap2_JuanDeDiosFernandezCamilo.Models;

namespace Parcial1_Ap2_JuanDeDiosFernandezCamilo.BLL
{
    public class ArticulosBLL
    {
        public static bool Existe(int id)
        {
            contexto db = new contexto();
            var encontrado = false;
            
            try
            {
                encontrado = db.Articulos.Any(x => x.ArtiuloId == id);
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return encontrado;
        }
        public static bool Guardar(Articulos articulos)
        {
            if (!Existe(articulos.ArtiuloId))
                return Insertar(articulos);
            else
            {
                return Modificar(articulos);
            }
        }

        public static bool Insertar(Articulos articulos)
        {
            contexto db = new contexto();
            bool paso = false;

            try
            {
                db.Articulos.Add(articulos);
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Modificar(Articulos articulos)
        {
            contexto db = new contexto();
            bool paso = false;

            try
            {
                db.Entry(articulos).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            contexto db = new contexto();
            bool paso = false;

            try
            {
                var articulo = db.Articulos.Find(id);

                if(articulo != null)
                {
                    db.Remove(articulo);
                    paso = db.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }


        public static Articulos Buscar(int id)
        {
            contexto db = new contexto();
            Articulos articulos = new Articulos();

            try
            {
                articulos = db.Articulos.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return articulos;
        }

        public static List<Articulos> GetList(Expression<Func<Articulos, bool>> criterio)
        {
            List<Articulos> lista = new List<Articulos>();
            contexto db = new contexto();
            try
            {
                lista = db.Articulos.Where(criterio).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }
            return lista;
        }
    }
}
